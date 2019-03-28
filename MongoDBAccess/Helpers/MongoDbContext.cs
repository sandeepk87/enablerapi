using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
namespace MongoDBAccess.Helpers
{
   public class MongoDbContext: IMongoDBContext
    {
        // "mongodb": "//service.DEV_grpsdevmdb1:OtWQwNYkHqGBih2gxbXz@grpsuatmdb1.caqhgrps.local:27017,grpsuatmdb2.caqhgrps.local:27017,grpsuatmdb3.caqhgrps.local:27017/grpsdevmdb1"

        private IMongoClient mongoClient;
        private readonly IMongoDatabase _database = null;
        public MongoDbContext(Setting<Settings> setting)
        {
            MongoClientSettings mongoClientSettings = MongoClientSettings.FromConnectionString(setting.Value.ConnectionString);
            mongoClient = new MongoClient(mongoClientSettings);
            _database = mongoClient.GetDatabase(setting.Value.DatabaseName);
        }



        public IMongoCollection<TDocument> GetCollection<TDocument>(string collection)
        {
            return _database.GetCollection<TDocument>(collection);
        }

    }
}
