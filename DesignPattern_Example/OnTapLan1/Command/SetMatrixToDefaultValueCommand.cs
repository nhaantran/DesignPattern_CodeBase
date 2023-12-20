namespace DesignPattern_Example.OnTapLan1.Command
{
    public class SetMatrixToDefaultValueCommand : ICommand
    {
        private readonly double _defaultValue;
        private readonly MatrixOperator _matrixOperator;

        public SetMatrixToDefaultValueCommand(MatrixOperator matrixOperator, double defaultValue)
        {
            _matrixOperator = matrixOperator;
            _defaultValue = defaultValue;
        }

        public void Execute()
        {
           _matrixOperator.SetMatrixToDefaultValue(_defaultValue);  
            Console.WriteLine($"Finish set all value of _matrix to given default value: {_defaultValue}");
        }
    }
}
