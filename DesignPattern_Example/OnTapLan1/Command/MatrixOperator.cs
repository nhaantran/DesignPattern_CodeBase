namespace DesignPattern_Example.OnTapLan1.Command
{
    public class MatrixOperator
    {
        private readonly double[,] _matrix;

        public MatrixOperator(double[,] matrix)
        {
            _matrix = matrix;
        }

        public double FindMaxVolumnInMatrix()
        {
            double max = _matrix[0, 0];
            foreach (var item in _matrix)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public double FindMinValueInMatrix()
        {
            double min = _matrix[0, 0];
            foreach (var item in _matrix)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        public void SetMatrixToDefaultValue(double defaultValue)
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    _matrix[i, j] = defaultValue;
                }
            }
        }
        public double CalculateTotalMatrixSum()
        {
            double sum = 0;
            foreach (var item in _matrix)
            {
                sum += item;
            }
            return sum;
        }

    }
}
