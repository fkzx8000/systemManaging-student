using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace TDD_work
{
    public class ControlCSV
    {
        public static string AverageGradeOfFive(
            string first, string second, string third, string firth, string five)
        {
            var list = new List<int>
            {
                int.Parse(first),
                int.Parse(second),
                int.Parse(third),
                int.Parse(firth),
                int.Parse(five)
            };

            list.RemoveAll(element => element == 777);

            int sum = 0;

            foreach (var element in list)
            {
                sum += element;
            }

            if (list.Count == 0)
            {
                return 0.ToString();
            }

            return (sum / list.Count).ToString();
        }

        public static List<UserData> getUser()
        {
            string fileName = System.Environment.CurrentDirectory + "/UserData.csv";

            List<UserData> array = new List<UserData>();
            var i = 0;

            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {

                var records = csv.GetRecords<UserData>();

                foreach(var record in records)
                {
                    array.Add(record);
                }

                return array;
            }
        }

        // Add user list to CSV file
        public static void AdduserList(List<UserData> data)
        {
            string fileName = System.Environment.CurrentDirectory + "/UserData.csv";

            if (File.Exists(fileName))
            {
                // Append to the file.
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    // Don't write the header again.
                    HasHeaderRecord = false,
                };
                using (var stream = File.Open(fileName, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(data);
                }
            }
            else
            {
                // Write to a file.

                using (var writer = new StreamWriter(fileName))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(data);
                }
            }


        }

        // Add one user defind person in to CSV file
        public static void AddUser(
            string firstName,
            string lastName,
            string id,
            string email,
            string phone,
            string phisics,
            string calculus,
            string computerScience,
            string history,
            string industrialEngineering)
        {
            string fileName = System.Environment.CurrentDirectory + "/UserData.csv";

            var data = new List<UserData>
            {
                new UserData 
                { 
                    FirstName = firstName,
                    LastName = lastName,
                    ID = id,
                    Email = email,
                    PhoneNumber = phone,
                    Physics = phisics,
                    Calculus = calculus,
                    ComputerScience = computerScience,
                    History = history,
                    IndustrialEngineering = industrialEngineering,
                    AverageGrade = AverageGradeOfFive(phisics, calculus, computerScience, history, industrialEngineering)
                }
            };

            if (File.Exists(fileName))
            {
                // Append to the file.
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    // Don't write the header again.
                    HasHeaderRecord = false,
                };
                using (var stream = File.Open(fileName, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(data);
                }
            }
            else
            {
                // Write to a file.

                using (var writer = new StreamWriter(fileName))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(data);
                }
            }

        }
    }
}
