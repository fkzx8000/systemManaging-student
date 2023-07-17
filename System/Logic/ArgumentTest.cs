using System;
using System.Text.RegularExpressions;
using TDD_work.Exeptions;

namespace TDD_work
{
    class ArgumentTest
    {
        public static void testPhone(string Phone)
        {
            if (Phone.Length == 11)
            {
                var isPhone = Regex.IsMatch(Phone, @"^\d{3}[-]\d{7}$");

                if (!isPhone)
                {
                    throw new PhoneNumberException();
                }
            }

            bool isNumeric = int.TryParse(Phone, out _);

            if (!isNumeric && Phone.Length != 11)
            {
                throw new NumericalExpression("Phone");
            }

            if (Phone.Length < 10 || Phone.Length > 11)
            {
                throw new ArgumentOutOfRangeException("The length of Phone is out of range");
            }



        }

        public static void testEmail(string Email)
        {
            var isEmail = Regex.IsMatch(Email, @"^\w+([.-]?\w+)*@\w+([.-]?\w+)*(\.\w{2,3})+$");

            if (!isEmail)
            {
                throw new EmailException();
            }
        }

        public static void testID(string ID)
        {
            bool isNumeric = int.TryParse(ID, out _);

            if (!isNumeric)
            {
                throw new NumericalExpression("ID");
            }

            if (ID.Length != 9)
            {
                throw new ArgumentOutOfRangeException("The length of ID mast be 9 digits");
            }
        }

        public static void testGrade(string grade, string name)
        {
            if (grade.Length == 0)
            {
                throw new ArgumentEmptyException(name);
            }

            bool isNumeric = int.TryParse(grade, out int number);

            if (isNumeric)
            {
                if (number < 0 ||
                    (number > 100 && number != 777))
                {
                    throw new ArgumentOutOfRangeException(name + " is out of range");
                }
            }
            else
            {
                throw new NumericalExpression(name);
            }
        }

        public static void testName(string name)
        {

            bool isAlpha = Regex.IsMatch(name, @"^[a-zA-Z]+$");

            if (!isAlpha)
            {
                throw new ArgumentAlphaException();
            }
        }
    }
}
