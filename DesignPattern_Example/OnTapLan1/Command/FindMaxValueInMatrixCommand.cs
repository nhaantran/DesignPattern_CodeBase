namespace DesignPattern_Example.OnTapLan1.Command
{
    public class FindMaxValueInMatrixCommand : ICommand
    {
        private readonly MatrixOperator _matrixOperator;

        public FindMaxValueInMatrixCommand(MatrixOperator matrixOperator)
        {
            _matrixOperator = matrixOperator;
        }

        public void Execute()
        {
            var max = _matrixOperator.FindMaxVolumnInMatrix();
            Console.WriteLine($"Max value in _matrix: {max}");
        }
    }
}   
