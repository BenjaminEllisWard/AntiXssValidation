using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexValidation
{
    class AntiXssValidation
    {
        /// <summary>
        /// Determines if a string consists solely of alphabetic characters.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="length">Length of a valid string</param>
        /// <param name="allowNull">Determines whether the method returns true or false if input is null.</param>
        /// <returns></returns>
        static public bool IsAlphabetic(string input, ushort length, bool allowNull)
        {
            if (input != null)
            {
                return Regex.IsMatch(input.Trim(), $"^[a-zA-Z]{{{length}}}$");
            }
            else
            {
                return allowNull;
            }
        }

        /// <summary>
        /// Determines if a string consists solely of alphabetic characters and is a certain length.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="minLength">Minimum length of a valid string</param>
        /// <param name="maxLength">Maximum length of a valid string</param>
        /// <param name="allowNull">Determines whether method returns true or false if input is null.</param>
        /// <returns></returns>
        static public bool IsAlphabetic(string input, ushort minLength, ushort maxLength, bool allowNull)
        {
            if (input != null)
            {
                return Regex.IsMatch(input.Trim(), $"^[a-zA-Z]{{{minLength},{maxLength}}}$");
            }
            else
            {
                return allowNull;
            }
        }
    }
}
