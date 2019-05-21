using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexValidation
{
    /// <summary>
    /// Class with methods that validate input for XSS prevention.
    /// </summary>
    public class AntiXssValidation
    {
        /// <summary>
        /// Determines whether a string consists solely of alphabetic characters.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="length">Length of a valid string. Length of 0 will match input of any length.</param>
        /// <param name="allowNull">Determines whether method returns true or false when input is null.</param>
        /// <returns></returns>
        static public bool IsAlphabetic(string input, ushort length, bool allowNull)
        {
            if (input != null)
            {
                return Regex.IsMatch(input.Trim(), length > 0 ? $"^[a-zA-Z]{{{length}}}" : "^[a-zA-Z]+$");
            }
            else
            {
                return allowNull;
            }
        }

        /// <summary>
        /// Determines whether a string consists solely of alphabetic characters.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="length">Length of a valid string. Length of 0 will match input of any length.</param>
        /// <param name="allowNull">Determines whether method returns true or false when input is null.</param>
        /// <param name="allowFail">Determines whether an ArgumentException is thrown when input is invalid.</param>
        /// <returns></returns>
        static public bool IsAlphabetic(string input, ushort length, bool allowNull, bool allowFail)
        {
            if (!allowFail && !IsAlphabetic(input, length, allowNull))
            {
                throw new ArgumentException("Input is invalid.");
            }
            else
            {
                return IsAlphabetic(input, length, allowNull);
            }
        }

        /// <summary>
        /// Determines whether a string consists solely of alphabetic characters and is a certain length.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="minLength">Minimum length of a valid string</param>
        /// <param name="maxLength">Maximum length of a valid string</param>
        /// <param name="allowNull">Determines whether the method will return true or false when input is null.</param>
        /// <returns></returns>
        static public bool IsAlphabetic(string input, ushort minLength, ushort maxLength, bool allowNull) =>
            input != null ? Regex.IsMatch(input.Trim(), $"^[a-zA-Z]{{{minLength},{maxLength}}}$") : allowNull;

        /// <summary>
        /// Determines whether a string consists solely of alphabetic characters and is a certain length.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="minLength">Minimum length of a valid string</param>
        /// <param name="maxLength">Maximum length of a valid string</param>
        /// <param name="allowNull">Determines whether method returns true or false when input is null.</param>
        /// <param name="allowFail">Determines whether an ArgumentException is thrown when input is invalid.</param>
        /// <returns></returns>
        static public bool IsAlphabetic(string input, ushort minLength, ushort maxLength, bool allowNull, bool allowFail)
        {
            if (!allowFail && !IsAlphabetic(input, minLength, maxLength, allowNull))
            {
                throw new ArgumentException("Input is invalid.");
            }
            else
            {
                return IsAlphabetic(input, minLength, maxLength, allowNull);
            }
        }

        /// <summary>
        /// Determines whether a string consists solely of numeric characters.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="length">Length of a valid string. Length of 0 will match input of any length.</param>
        /// <param name="allowNull">Determines whether the method will return true or false when input is null.</param>
        /// <returns></returns>
        static public bool IsNumeric(string input, ushort length, bool allowNull)
        {
            if (input != null)
            {
                return Regex.IsMatch(input.Trim(), length > 0 ? $"^[0-9]{{{length}}}" : "^[0-9]+$");
            }
            else
            {
                return allowNull;
            }
        }

        /// <summary>
        /// Determines whether a string consists solely of numeric characters.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="length">Length of a valid string. Length of 0 will match input of any length.</param>
        /// <param name="allowNull">Determines whether method returns true or false when input is null.</param>
        /// <param name="allowFail">Determines whether an ArgumentException is thrown when input is invalid.</param>
        /// <returns></returns>
        static public bool IsNumeric(string input, ushort length, bool allowNull, bool allowFail)
        {
            if (!allowFail && !IsNumeric(input, length, allowNull))
            {
                throw new ArgumentException("Input is invalid.");
            }
            else
            {
                return IsNumeric(input, length, allowNull);
            }
        }

        /// <summary>
        /// Determines whether a string consists solely of numeric characters and is a certain length.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="minLength">Minimum length of a valid string</param>
        /// <param name="maxLength">Maximum length of a valid string</param>
        /// <param name="allowNull">Determines whether the method will return true or false when input is null.</param>
        /// <returns></returns>
        static public bool IsNumeric(string input, ushort minLength, ushort maxLength, bool allowNull) =>
            input != null ? Regex.IsMatch(input.Trim(), $"^[0-9]{{{minLength},{maxLength}}}$") : allowNull;

        /// <summary>
        /// Determines whether a string consists solely of numeric characters and is a certain length.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="minLength">Minimum length of a valid string</param>
        /// <param name="maxLength">Maximum length of a valid string</param>
        /// <param name="allowNull">Determines whether the method will return true or false when input is null.</param>
        /// <param name="allowFail">Determines whether an ArgumentException is thrown when input is invalid.</param>
        /// <returns></returns>
        static public bool IsNumeric(string input, ushort minLength, ushort maxLength, bool allowNull, bool allowFail)
        {
            if (!allowFail && !IsNumeric(input, minLength, maxLength, allowNull))
            {
                throw new ArgumentException("Input is invalid.");
            }
            else
            {
                return IsNumeric(input, minLength, maxLength, allowNull);
            }
        }

        /// <summary>
        /// Determines whether a string consists solely of alphanumeric characters.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="length">Length of a valid string. Length of 0 will match input of any length.</param>
        /// <param name="allowNull">Determines whether the method returns true or false when input is null.</param>
        /// <returns></returns>
        static public bool IsAlphaNumeric(string input, ushort length, bool allowNull)
        {
            if (input != null)
            {
                return Regex.IsMatch(input.Trim(), length > 0 ? $"^[a-zA-Z0-9]{{{length}}}" : "^[a-zA-Z0-9]+$");
            }
            else
            {
                return allowNull;
            }
        }

        /// <summary>
        /// Determines whether a string consists solely of alphanumeric characters.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="length">Length of a valid string. Length of 0 will match input of any length.</param>
        /// <param name="allowNull">Determines whether method returns true or false when input is null.</param>
        /// <param name="allowFail">Determines whether an ArgumentException is thrown when input is invalid.</param>
        /// <returns></returns>
        static public bool IsAlphaNumeric(string input, ushort length, bool allowNull, bool allowFail)
        {
            if (!allowFail && !IsAlphaNumeric(input, length, allowNull))
            {
                throw new ArgumentException("Input is invalid.");
            }
            else
            {
                return IsAlphaNumeric(input, length, allowNull);
            }
        }

        /// <summary>
        /// Determines whether a string consists solely of alphanumeric characters and is a certain length.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="minLength">Minimum length of a valid string</param>
        /// <param name="maxLength">Maximum length of a valid string</param>
        /// <param name="allowNull">Determines whether the method will return true or false when input is null.</param>
        /// <returns></returns>
        static public bool IsAlphaNumeric(string input, ushort minLength, ushort maxLength, bool allowNull) =>
            input != null ? Regex.IsMatch(input.Trim(), $"^[a-zA-Z0-9]{{{minLength},{maxLength}}}$") : allowNull;

        /// <summary>
        /// Determines whether a string consists solely of alphanumeric characters and is a certain length.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="minLength">Minimum length of a valid string</param>
        /// <param name="maxLength">Maximum length of a valid string</param>
        /// <param name="allowNull">Determines whether the method will return true or false when input is null.</param>
        /// <param name="allowFail">Determines whether an ArgumentException is thrown when input is invalid.</param>
        /// <returns></returns>
        static public bool IsAlphaNumeric(string input, ushort minLength, ushort maxLength, bool allowNull, bool allowFail)
        {
            if (!allowFail && !IsAlphaNumeric(input, minLength, maxLength, allowNull))
            {
                throw new ArgumentException("Input is invalid.");
            }
            else
            {
                return IsAlphaNumeric(input, minLength, maxLength, allowNull);
            }
        }

        /// <summary>
        /// Determines whether a string consists solely of alphanumeric characters according to a specified pattern.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="alphaLength">Length of alphabetic segment of a valid string</param>
        /// <param name="numLength">Length of numeric segment of a valid string</param>
        /// <param name="alphaBeforeNum">Determines whether alphabetic or numeric segment leads on a valid string.</param>
        /// <param name="allowNull">Determines whether the method returns true or false when input is null.</param>
        /// <returns></returns>
        static public bool IsValidAlphanumeric(string input, ushort alphaLength, ushort numLength, bool alphaBeforeNum, bool allowNull)
        {
            if (input != null)
            {
                if (alphaBeforeNum)
                {
                    if (numLength > 0)
                    {
                        return Regex.IsMatch(input.Trim(), $"^[a-zA-Z]{{{alphaLength}}}[0-9]{{{numLength}}}$");
                    }
                    else
                    {
                        return Regex.IsMatch(input.Trim(), $"^[a-zA-Z]{{{alphaLength}}}[0-9]+$");
                    }
                }
                else
                {
                    if (alphaLength > 0)
                    {
                        return Regex.IsMatch(input.Trim(), $"^[0-9]{{{numLength}}}[a-zA-Z]{{{alphaLength}}}$");
                    }
                    else
                    {
                        return Regex.IsMatch(input.Trim(), $"^[0-9]{{{numLength}}}[a-zA-z]+$");
                    }
                }
            }
            else
            {
                return allowNull;
            }
        }

        /// <summary>
        /// Determines whether a string consists solely of alphanumeric characters according to a specified pattern.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="alphaLength">Length of alphabetic segment of a valid string</param>
        /// <param name="numLength">Length of numeric segment of a valid string</param>
        /// <param name="alphaBeforeNum">Determines whether alphabetic or numeric segment leads on a valid string.</param>
        /// <param name="allowNull">Determines whether the method returns true or false when input is null.</param>
        /// <param name="allowFail">Determines whether an ArgumentException is thrown when input is invalid.</param>
        /// <returns></returns>
        static public bool IsValidAlphanumeric(string input, ushort alphaLength, ushort numLength, bool alphaBeforeNum, bool allowNull, bool allowFail)
        {
            if (!allowFail && !IsValidAlphanumeric(input, alphaLength, numLength, alphaBeforeNum, allowNull))
            {
                throw new ArgumentException("Input is invalid.");
            }
            else
            {
                return IsValidAlphanumeric(input, alphaLength, numLength, alphaBeforeNum, allowNull);
            }
        }

        /// <summary>
        /// Validates a string input against an argument-provided regular expression.
        /// </summary>
        /// <param name="input">String to be matched against a regular expression</param>
        /// <param name="regex">Regular expression used to validate input</param>
        /// <param name="allowNull">Determines whether method returns true or false when input is null</param>
        /// <returns></returns>
        static public bool IsValid(string input, string regex, bool allowNull) => input != null ? Regex.IsMatch(input, regex) : allowNull;

        /// <summary>
        /// Validates a string input against an argument-provided regular expression.
        /// </summary>
        /// <param name="input">String to be matched against a regular expression</param>
        /// <param name="regex">Regular expression used to validate input</param>
        /// <param name="allowNull">Determines whether method returns true or false when input is null.</param>
        /// <param name="allowFail">Determines whether an ArgumentException is thrown when input is invalid.</param>
        /// <returns></returns>
        static public bool IsValid(string input, string regex, bool allowNull, bool allowFail)
        {
            if (!allowFail && !IsValid(input, regex, allowNull))
            {
                throw new ArgumentException("Input is invalid.");
            }
            else
            {
                return IsValid(input, regex, allowNull);
            }
        }
    }
}