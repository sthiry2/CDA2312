using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppControleDeSaisieSurface.MyValidatesRules
{
    public class ValidateDateRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            DateTime result;
            if (!DateTime.TryParseExact((string)value,"dd/MM/yyyy",CultureInfo.CurrentCulture,DateTimeStyles.None,out result))
            {
                return new ValidationResult(false,"La Date doit avoir le format DD/MM/YYYY");
            }
            else 
            {
                return ValidationResult.ValidResult;
            }


        }
    }
}
