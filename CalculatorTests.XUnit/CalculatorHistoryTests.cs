using Labb_6_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTests.XUnit
{
    public class CalculatorHistoryTests
    {
        private readonly CalculatorHistory _history = new CalculatorHistory();

        [Fact]
        public void AddCalculation_AddsToHistory()
        {
            _history.AddCalculation("5 + 3 = 8");
            var result = _history.GetHistory();
            Assert.Contains("5 + 3 = 8", result);
        }

        [Fact]
        public void GetHistory_ReturnsAllCalculations()
        {
            _history.AddCalculation("5 + 3 = 8");
            _history.AddCalculation("10 - 2 = 8");
            var result = _history.GetHistory();
            Assert.Equal(2, result.Count);
        }

    }
}
