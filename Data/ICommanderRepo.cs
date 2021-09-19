using System.Collections.Generic;
using CVPorject1.Models;

namespace CVPorject1.Data
{
    interface ICommanderRepo
    {
        IEnumerable<Command> GetCommands();
        Command GetCommandById(int commandId);

        void AddCommand(Command command);

        Command RemoveCommand(int commandId);
    }
}