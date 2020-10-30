using Caliburn.Micro;
using SQLite;
using System.IO;
using Windows.Storage;
using IMDBConsumer.Utilities.Extensions;
using IMDBConsumer.Services.Repositories;
using IMDBConsumer.Utilities.Constants;

namespace IMDBConsumer.Uwp
{
    /// <summary>
    /// Use this class to register internal services
    /// </summary>
    public static class RegisterInternalServices
    {
        public static void RegisterViewModels(ref WinRTContainer container)
        {
            container
               //Base Screen View Model
               .PerRequest<BaseViewModel>()
               .PerRequest<DrawboardProjectListItemsViewModel>()
               .Singleton<CommonHttpClientConsumer>();  //HttpClient

            RegisterWebServices.InitializeClientFactory(); //Register the HttpClientFactory 
        }

        public static void RegisterSqliteEncryption(ref WinRTContainer container)
        {
            //Initialize the Db directory, including access  
            string directoryPath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "CryptoCoinLocalData");
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            string dbPath = Path.Combine(directoryPath, $"{AppInformation.AppName}.db3");
            if (!File.Exists(dbPath))
                File.Create(dbPath);

            SQLitePCL.Batteries_V2.Init(); //This is to enforce encryption of the database

            var options = new SQLiteConnectionString(dbPath, false,
key: SecurityConstants.SQLCipherKey.HashPassword(),
preKeyAction: db => db.Execute("PRAGMA cipher_default_use_hmac = OFF;PRAGMA hexkey=\"0x0102030405060708090a0b0c0d0e0f10\""),
postKeyAction: db => db.Execute("PRAGMA kdf_iter = 128000;"));

            try { container.Instance<IDatabase>(new Database(new SQLiteConnection(options))); } catch { } //Register the Sqlite dependency into the iOC Container for dependency injection
        }
    }
}
