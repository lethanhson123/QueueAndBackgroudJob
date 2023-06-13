using BusinessServices.Constants;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Utilities.MPlusSyncOrderUtility;
using static Utilities.MPlusSyncOrderUtility.EnumExtensions;

namespace BusinessServices.Models.MPlusSyncOrder.Validation
{
    public class WLBPaymentRangeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var dataEnum = Enum.GetValues(typeof(PaymentTypeOfWLB)).Cast<PaymentTypeOfWLB>().Select(s => s.GetDisplayName()).ToList();
            if (dataEnum.Any(a => Regex.IsMatch(a, value.ToString(), RegexOptions.IgnoreCase)))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Payment method is incorrect");
        }
    }

    public class WLBOrderStatusRangeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var dataEnum = Enum.GetValues(typeof(OrderStatusOfWLB)).Cast<OrderStatusOfWLB>().Select(s => s.GetDisplayName()).ToList();

            if (Regex.IsMatch(OrderStatusOfWLB.Processing.GetDisplayName(), value.ToString(), RegexOptions.IgnoreCase))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Please choose orders status processing ");
        }
    }

    public class CurrencyRangeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var enumDatas = Enum.GetValues(typeof(Currencies)).Cast<Currencies>().Select(s => s.GetDisplayName()).ToList();

            if (enumDatas.Any(a => Regex.IsMatch(a, value.ToString(), RegexOptions.IgnoreCase)))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Please enter a correct value of currency");
        }
    }
}
