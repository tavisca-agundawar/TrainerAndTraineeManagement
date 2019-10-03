using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CRUD_API.Service
{
    public static class ValidationHelper
    {
        public static bool ContainsNumbers(this string value)
        {
            return value.Any(char.IsDigit);
        }

        public static bool IsBlankOrWhiteSpace(this string value)
        {
            return value == null || value.All(char.IsWhiteSpace) || value == "";
        }

        public static bool IsEmail(this string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        public static bool IsPhoneNumber(this string phoneNumber)
        {
            bool valid = true;
            if(phoneNumber.Length != 10)
            {
                valid = false;
            }
            if (phoneNumber.Any(char.IsLetter))
            {
                valid = false;
            }
            return valid;
        }

        public static bool IsPositiveNumber(this int number)
        {
            if(number>0)
                return true;
            else
                return false;
        }
    }
}
