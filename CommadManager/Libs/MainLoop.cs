using CommandManager.Models;

namespace CommandManager.Libs;

static class MainLoop
{
    static CommandsController _commandsController = new CommandsController();
    public static void Run()
    {
        var isStoped = false;

        AddAllCommandsToPool();
        _commandsController.AddCommand(new Command("bb", "Exit from programm", () =>
        {
            isStoped = true;
        }));
        Console.WriteLine("Enter \"help\" for get commands");
        while (!isStoped)
        {
            Console.Write("> ");
            string command = Console.ReadLine() ?? "";
            _commandsController.FindAndExecute(command);
        }
    }

    private static List<Command> GetListCommands()
    {
        return new List<Command>()
        {
            new Command("test","Command for test", () => Console.WriteLine("Hello, Test! XD")),
            new Command("add","Adding number", CalculationMethods.AddHandle),
            new Command("substract","Substracting numbers", CalculationMethods.SubstractHandle),
            new Command("divide","Dividing numbers", CalculationMethods.DivideHandle),
            new Command("multiply","Multiply numbers", CalculationMethods.MultiplyHandle),
            
        };
    }

    private static void AddAllCommandsToPool()
    {
        GetListCommands().ForEach(el =>
        {
            _commandsController.AddCommand(el);
        });
    }

}