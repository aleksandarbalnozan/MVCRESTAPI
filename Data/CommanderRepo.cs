using System.Collections.Generic;
using CVPorject1.Models;

namespace CVPorject1.Data
{
    class CommanderRepo : ICommanderRepo
    {
        private readonly ModelContext dbContext;

        public CommanderRepo(ModelContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void AddCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public Command GetCommandById(int commandId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetCommands()
        {
            throw new System.NotImplementedException();
        }

        public Command RemoveCommand(int commandId)
        {
            throw new System.NotImplementedException();
        }
    }
}