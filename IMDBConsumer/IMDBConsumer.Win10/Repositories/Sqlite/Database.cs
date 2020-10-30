using IMDBConsumer.Services.Repositories;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBConsumer.Win10.Repositories.Sqlite
{
    public class Database : IDatabase
    {
        public Database(SQLiteConnection connection)
        {
            _connection = connection;
        }
        public SQLiteConnection _connection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string _databasePath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void CloseDatabase()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void CreateTable<T>()
        {
            throw new NotImplementedException();
        }

        public void Delete(object objectToDelete)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(IEnumerable<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll<T>()
        {
            throw new NotImplementedException();
        }

        public void DropTable<T>()
        {
            throw new NotImplementedException();
        }

        public void Execute(string query, params object[] args)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersistentType> Get<PersistentType>(string queryStatement, params object[] queryParameter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersistentType> GetAll<PersistentType>() where PersistentType : class, new()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PersistentType>> GetAsync<PersistentType>(string query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetItems<T>(Func<T, bool> condition) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public ScalarType GetScalar<ScalarType>(string query) where ScalarType : new()
        {
            throw new NotImplementedException();
        }

        public Task<ScalarType> GetScalarAsync<ScalarType>(string query) where ScalarType : new()
        {
            throw new NotImplementedException();
        }

        public T GetSingleItem<T>(Func<T, bool> condition) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public void Insert<T>(T objectToInsert)
        {
            throw new NotImplementedException();
        }

        public int InsertItems<T>(IEnumerable<T> items)
        {
            throw new NotImplementedException();
        }

        public void InsertOrReplace<T>(T objectToInsert)
        {
            throw new NotImplementedException();
        }

        public void InsertOrUpdate<T>(T obj)
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void RunInTransaction(Action action)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T objectToUpdate) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public int UpdateItems<T>(IEnumerable<T> models)
        {
            throw new NotImplementedException();
        }
    }
}
