namespace DesignPattern_Example.Command___COR___Homework;

public interface ICommand
{
    public int Execute(int a, int b);
}
public class PlusCommand : ICommand
{
    
    public int Execute(int a, int b)
    {
        return a + b;
    }
}

public class SubtractCommand : ICommand
{
    public int Execute(int a, int b)
    {
        return a - b;
    }
}

public class DivideCommand : ICommand
{
    public int Execute(int a, int b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            return a;
        }
    }
}
public class MultiplyCommand : ICommand
{
    public int Execute(int a, int b)
    {
        return a * b;
    }
}
public class Calculator
{
    public ICommand command;
    public Calculator(ICommand command)
    {
        this.command = command;
    }
    public Calculator()
    {

    }
    public void SetCommand(ICommand command)
    {
        this.command = command;
    }
    public void Calculate(int a, int b)
    {
        command.Execute(a, b);
    }
}

