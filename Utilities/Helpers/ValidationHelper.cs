using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Utilities.Helpers
{
    public static class ValidationHelper
    {
        /// <summary>
        /// Throws an <seealso cref="JimmyBoh.Common.Exceptions.InvalidModelException">InvalidModelException</seealso> if invalid. 
        /// </summary>
        /// <param name="instance">The object instance to validate.</param>
        public static void Validate(object instance)
        {
            List<ValidationResult> results;
            var isValid = IsValid(instance, out results);

            if (!isValid)
                throw new InvalidModelException(results);
        }

        public static bool IsValid(object instance)
        {
            var vc = new ValidationContext(instance, null, null);

            return Validator.TryValidateObject(instance, vc, null, true);
        }

        public static bool IsValid(object instance, out List<ValidationResult> results)
        {
            var vc = new ValidationContext(instance, null, null);
            results = new List<ValidationResult>();
            return Validator.TryValidateObject(instance, vc, results, true);
        }
        public static bool IsValidEmail(string email)
        {
            Regex rx = new Regex(@"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            return rx.IsMatch(email);
        }
    }
    public class InvalidModelException : Exception
    {
        public ValidationResult[] ValidationResults { get; set; }

        public InvalidModelException(IEnumerable<ValidationResult> results)
        {
            ValidationResults = results.ToArray();
        }
        public InvalidModelException(string message) : base(message) { }

        public InvalidModelException(string message, IEnumerable<ValidationResult> results) : base(message, null)
        {
            ValidationResults = results.ToArray();
        }

        // This constructor is needed for serialization.
        protected InvalidModelException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
