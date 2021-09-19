using System.Collections.Generic;
using CVPorject1.Models;

namespace CVPorject1.Data
{
    class PlatformRepo : IPlatformRepo
    {
        private readonly ModelContext dbContext;

        public PlatformRepo(ModelContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void AddPlatform(Platform platform)
        {
            throw new System.NotImplementedException();
        }

        public Platform GetCommandById(int platformId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Platform> GetCommands()
        {
            throw new System.NotImplementedException();
        }

        public Platform RemovePlatform(int platformId)
        {
            throw new System.NotImplementedException();
        }
    }
}