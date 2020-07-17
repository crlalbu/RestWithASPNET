using System.Collections.Generic;
using RestWithASPNet.Models;

namespace RestWithASPNet.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command getCommandById(int id);
    }
}