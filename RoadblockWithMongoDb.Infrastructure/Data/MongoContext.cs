using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RoadblockWithMongoDb.Contracts.Config;

namespace RoadblockWithMongoDb.Infrastructure.Data
{
    public class MongoContext
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;

        public MongoContext(IOptions<DatabaseSettings> dbOptions)
        {
            var settings = dbOptions.Value;
            _client = new MongoClient(settings.ConnectionString);
            _database = _client.GetDatabase(settings.DatabaseName);
        }

        public IMongoClient Client => _client;
        public IMongoDatabase Database => _database;
    }
}
