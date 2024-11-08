using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace projekt
{
    [Serializable]
    public class Student : IENTITY
    {
        //IENTITY attributes
        public string Id { get; set; } 
        public string Name { get; set; } 
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }

        //Other
        public double GPA { get; set; }
        public double DRL { get; set; }
        public string SchoolYear { get; set; }
        
        //Class
        public string ClassID { get; set; }
        public string DepartmentID { get; set; }

        public List<string> CourseIDs = new List<string>();

        public Dictionary<string, string> DisplayInfo()
        {
            //// Cá nhân
            //Console.WriteLine($"ID: {Id}");
            //Console.WriteLine($"Name: {Name}");
            //Console.WriteLine($"Gender: {Gender}");
            //Console.WriteLine($"Bday: {Bday}");
            //Console.WriteLine($"CourseID: {string.Join(", ", CourseIDs)}");
            //Console.WriteLine($"DepartmentID: {DepartmentID}");

            //// Học tập
            //Console.WriteLine($"SchoolYear: {SchoolYear}");
            //Console.WriteLine($"GPA: {GPA}");
            //Console.WriteLine($"ĐRL: {ĐRL}");

            //// Liên lạc
            //Console.WriteLine($"Email: {Email}");
            //Console.WriteLine($"Phone: {PhoneNumber}");
            return new Dictionary<string, string>
            {
                ["ID"] = Id,
                ["Name"] = Name,
                ["Gender"] = Gender,
                ["Birthday"] = Birthday,
                ["CourseIDs"] = string.Join(", ", CourseIDs),
                ["DepartmentID"] = DepartmentID,
                ["SchoolYear"] = SchoolYear,
                ["GPA"] = GPA.ToString(),
                ["DRL"] = DRL.ToString(),
                ["Email"] = Email,
                ["Phone"] = PhoneNumber
            };
        }
    }
}


