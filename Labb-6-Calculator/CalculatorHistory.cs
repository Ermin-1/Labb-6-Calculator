using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_Calculator
{
    public class CalculatorHistory
    {
        private List<string> history = new List<string>();

        public void AddCalculation(string calculation)
        {
            history.Add(calculation);
        }

        public List<string> GetHistory()
        {
            return history;
        }
    }
}
