using System.Collections.Generic;
using CVPorject1.Models;

namespace CVPorject1.Data
{
    interface IPlatformRepo
    {
        IEnumerable<Platform> GetCommands();
        Platform GetCommandById(int platformId);

        void AddPlatform(Platform platform);

        Platform RemovePlatform(int platformId);
    }
}