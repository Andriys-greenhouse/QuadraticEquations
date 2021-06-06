using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquations
{
    public class EquationsSolver
    {
        static void Main(string[] args)
        {
        }

        public QuadraticResult QuadraticEquationSolver(decimal a, decimal b, decimal c)
        {

        }
    }

    public class QuadraticResult
    {
        public bool Solved { get; set; }
        public decimal[] Results { get; set; }

        public QuadraticResult(bool aSolved, decimal[] aResults)
        {
            Solved = aSolved;
            Results = aResults;
        }
    }
}
