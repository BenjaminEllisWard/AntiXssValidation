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

        /// <summary>
        /// Determines if a string consists solely of numeric characters.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="length">Length of a valid string</param>
        /// <param name="allowNull">Determines whether the method returns true or false if input is null.</param>
        /// <returns></returns>
        static public bool IsNumeric(string input, ushort length, bool allowNull)
        {
            if (input != null)
            {
                return Regex.IsMatch(input.Trim(), $"^[0-9]{{{length}}}$");
            }
            else
            {
                return allowNull;
            }
        }

        /// <summary>
        /// Determines if a string consists solely of numeric characters and is a certain length.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="minLength">Minimum length of a valid string</param>
        /// <param name="maxLength">Maximum length of a valid string</param>
        /// <param name="allowNull">Determines whether method returns true or false if input is null.</param>
        /// <returns></returns>
        static public bool IsNumeric(string input, ushort minLength, ushort maxLength, bool allowNull)
        {
            if (input != null)
            {
                return Regex.IsMatch(input.Trim(), $"^[0-9]{{{minLength},{maxLength}}}$");
            }
            else
            {
                return allowNull;
            }
        }

        /// <summary>
        /// Determines if a string consists solely of alphanumeric characters.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="length">Length of a valid string</param>
        /// <param name="allowNull">Determines whether the method returns true or false if input is null.</param>
        /// <returns></returns>
        static public bool IsAlphanumeric(string input, ushort length, bool allowNull)
        {
            if (input != null)
            {
                return Regex.IsMatch(input.Trim(), $"^[a-zA-Z0-9]{{{length}}}$");
            }
            else
            {
                return allowNull;
            }
        }

        /// <summary>
        /// Determines if a string consists solely of alphanumeric characters and is a certain length.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="minLength">Minimum length of a valid string</param>
        /// <param name="maxLength">Maximum length of a valid string</param>
        /// <param name="allowNull">Determines whether method returns true or false if input is null.</param>
        /// <returns></returns>
        static public bool IsAlphanumeric(string input, ushort minLength, ushort maxLength, bool allowNull)
        {
            if (input != null)
            {
                return Regex.IsMatch(input.Trim(), $"^[a-zA-Z0-9]{{{minLength},{maxLength}}}$");
            }
            else
            {
                return allowNull;
            }
        }

        /// <summary>
        /// Determines if a string is a valid alphanumeric string according to a pattern.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="alphaLength">Length of a valid string's alphabetic segment</param>
        /// <param name="numLength">Length of a valid string's numeric segment</param>
        /// <param name="alphaBeforeNum">Determines if alphabetic or numeric portion leads on a valid string.</param>
        /// <param name="allowNull">Determines whether the method returns true or false when input is null.</param>
        /// <returns></returns>
        static public bool IsValidAlphanumeric(string input, ushort alphaLength, ushort numLength, bool alphaBeforeNum, bool allowNull)
        {
            if (input != null)
            {
                return Regex.IsMatch(input.Trim(), alphaBeforeNum ? $"^[a-zA-Z]{{{alphaLength}}}[0-9]{{{numLength}}}$" : $"^[0-9]{{{numLength}}}[a-zA-Z]{{{alphaLength}}}$");
            }
            else
            {
                return allowNull;
            }
        }

        /// <summary>
        /// Validates input against a regular expression.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="regex">Regular expression against which the input is validated</param>
        /// <param name="allowNull">Determines whether the method returns true or false when input is null.</param>
        /// <returns></returns>
        static public bool IsValid(string input, string regex, bool allowNull) => input != null ? Regex.IsMatch(input.Trim(), regex) : allowNull;
    }
}
