using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Console;

namespace RestWithASPNETErudio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        
        public IActionResult Sum(string firstNumber,string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal dacimalValue;
            if (decimal.TryParse(strNumber, out dacimalValue))
            {
                return dacimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
            
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]

        public IActionResult Sub(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("multi/{firstNumber}/{secondNumber}")]

        public IActionResult Multi(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sub = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]

        public IActionResult Div(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sub = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("med/{firstNumber}/{secondNumber}/{terNumber}/{quadNumber}")]

        public IActionResult Med(string firstNumber, string secondNumber, string terNumber, string quadNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber) && IsNumeric(terNumber) && IsNumeric(quadNumber))
            {
                var med = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber) + ConvertToDecimal(terNumber) + ConvertToDecimal(quadNumber)) / 4;
                return Ok(med.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("raiz/{firstNumber}")]

        public IActionResult Raiz(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var raiz = Math.Sqrt((double)ConvertToDecimal(firstNumber));
                return Ok(raiz.ToString());
            }

            return BadRequest("Invalid Input");
        }


    }
}
