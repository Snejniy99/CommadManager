namespace CommandManager.Models;

public class Command
{
    public delegate void Callback();
    private string _command;
    private string _description;
    private Callback _callback;

    public Command(string command, string description, Callback callback)
    {
        _callback = callback;
        _description = description;
        _command = command;
    }
    
    public void Execute()
    {
        _callback();
    }

    public override string ToString()
    {
        return $"{_command} - {_description}";
    }

    public string GetCommand()
    {
        return _command;
    }
}