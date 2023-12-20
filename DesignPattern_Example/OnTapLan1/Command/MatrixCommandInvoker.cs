
namespace DesignPattern_Example.OnTapLan1.Command
{
    public class MatrixCommandInvoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
