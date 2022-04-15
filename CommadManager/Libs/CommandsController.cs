using CommandManager.Models;

namespace CommandManager.Libs;

public class CommandsController
{
    private List<Command> _commands;

    public CommandsController()
    {
        _commands = new List<Command>();
        _commands.Add(new Command("help", "Show all commnds", GetHelpHandle));
    }

    private void GetHelpHandle()
    {
        Console.WriteLine("Commands:");
        _commands.ForEach((el) =>
        {
            Console.WriteLine(el);
        });
        
    }

    public void AddCommand(Command command)
    {
        _commands.Add(command);
    }

    public void FindAndExecute(string command)
    {
        _commands.ForEach((el) =>
        {
            if(el.GetCommand().ToLower() == command.ToLower()) el.Execute();
        });
    }
}