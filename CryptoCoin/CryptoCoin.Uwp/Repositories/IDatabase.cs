using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Drawboard.Domain.Repositories
{
    public interface IDatabase
    {
        SQLiteConnection _connection { get; set; }
        string _databasePath { get; set; }

        void CloseDatabase();

        //DELETE
        void Delete(object objectToDelete);
        void Delete<T>(Guid id);
        void Delete<T>(IEnumerable<Guid> ids);
        void DeleteAll<T>();

        //GET
        IEnumerable<PersistentType> Get<PersistentType>(string queryStatement, params object[] queryParameter);
        IEnumerable<PersistentType> GetAll<PersistentType>() where PersistentType : class, new();

        //Transaction Management
        void BeginTransaction();
        void Commit();

        void Rollback();
        void RunInTransaction(Action action);

        //Insert
        void Insert<T>(T objectToInsert);
        void InsertOrReplace<T>(T objectToInsert);
        void InsertOrUpdate<T>(T obj);
        void CreateTable<T>();
        void DropTable<T>();
        void Update<T>(T objectToUpdate) where T : class, new();

        void Execute(string query, params object[] args);

        T GetSingleItem<T>(Func<T, bool> condition) where T : class, new();
        IEnumerable<T> GetItems<T>(Func<T, bool> condition) where T : class, new();
        int InsertItems<T>(IEnumerable<T> items);
        int UpdateItems<T>(IEnumerable<T> models);

        Task<IEnumerable<PersistentType>> GetAsync<PersistentType>(string query);
        ScalarType GetScalar<ScalarType>(string query) where ScalarType : new();

        Task<ScalarType> GetScalarAsync<ScalarType>(string query) where ScalarType : new();
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
