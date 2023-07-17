using System;

namespace TDD_work
{
    [Serializable]

    public class UserData
    {
        // Set the csv file attributes
        public string FirstName { get; set;}

        public string LastName { get; set; }

        public string ID { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Physics { get; set; }

        public string Calculus { get; set; }

        public string ComputerScience { get; set; }

        public string History { get; set; }

        public string IndustrialEngineering { get; set; }

        public string AverageGrade { get; set; }
    }
}
