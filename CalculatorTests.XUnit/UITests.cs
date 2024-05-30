using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTests.XUnit
{
    public class UITests
    {
        private readonly UserInterface _ui = new UserInterface();

        [Fact]
        public void GetMenuChoice_ValidInput_ReturnsChoice()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (var sr = new StringReader("2"))
                {
                    Console.SetIn(sr);
                    var result = _ui.GetMenuChoice(1, 2);
                    Assert.Equal(2, result);
                }
            }
        }


        [Fact]
        public void PrintResult_PrintsCorrectOutput()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _ui.PrintResult(10);

                var result = sw.ToString().Trim();
                Assert.Equal("Resultatet är: 10", result);
            }
        }



    }
}
