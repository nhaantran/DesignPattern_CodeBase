using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.OnTapLan1.Command
{
    public class FindMinValueInMatrixCommand : ICommand
    {
        private readonly MatrixOperator _matrixOperator;

        public FindMinValueInMatrixCommand(MatrixOperator matrixOperator)
        {
            _matrixOperator = matrixOperator;
        }


        public void Execute()
        {
            var min = _matrixOperator.FindMinValueInMatrix();
            Console.WriteLine($"Min value in _matrix: {min}");
        }
    }
}
