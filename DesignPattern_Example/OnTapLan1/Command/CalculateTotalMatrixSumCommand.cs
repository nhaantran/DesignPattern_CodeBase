namespace DesignPattern_Example.OnTapLan1.Command
{
    public class CalculateTotalMatrixSumCommand : ICommand
    {
        private readonly MatrixOperator _matrixOperator;

        public CalculateTotalMatrixSumCommand(MatrixOperator matrixOperator)
        {
            _matrixOperator = matrixOperator;
        }

        public void Execute()
        {
            var sum = _matrixOperator.CalculateTotalMatrixSum();
            Console.WriteLine($"Total sun if _matrix: {sum}");
        }
    }
}
