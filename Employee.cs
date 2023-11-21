using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_002
{
        public class Employee
        {
            public int Id { get; set; }

            public string? FirstName { get; set; }

            public string? LastName { get; set; }

            public int Age { get; set; }

            public float Salary { get; set; }

            public List<string> ProgrammingLanguages { get; set; }

            public List<string> CreditCards { get; set; }

            public List<string> Emails { get; set; }

            public static List<Employee> GetEmployees()
            {
                return new List<Employee>
        {
            new Employee
            {
                Id = 1,
                FirstName = "Salohiddin",
                LastName = "Sunnatov",
                Age = 19,
                Salary = 1000,
                ProgrammingLanguages = new List<string>
                {
                    "C#",
                    "C",
                    "C++"
                },
                CreditCards = new List<string>
                {
                    "123123123",
                    "563643534",
                },
                Emails = new List<string>
                {
                    "iddiunna@gmail.com",
                    "ankabut571@gmail.com",
                    "SalohiddinSunnatov@gmail.com"
                }
            },

            new Employee
            {
                Id = 2,
                FirstName = "Bahrom",
                LastName = "Bahromov",
                Age = 18,
                Salary = 1200,
                ProgrammingLanguages = new List<string>
                {
                    "C#",
                    "C",
                    "C++"
                },
                CreditCards = new List<string>
                {
                    "47352698743564",
                    "2495640985",
                    "4837640574232"
                },
                Emails = new List<string>
                {
                    "BahromBahromov@gmail.com",
                }
            },

            new Employee
            {
                Id = 3,
                FirstName = "Islom",
                LastName = "Karimov",
                Age = 20,
                Salary = 434,
                ProgrammingLanguages = new List<string>
                {
                    "C#",
                    "C",
                    "C++"
                },
                CreditCards = new List<string>
                {
                    "21123131233",
                },
                Emails = new List<string>
                {
                    "IslomKarimov@gmail.com",
                }
            },
            new Employee
            {
                Id = 4,
                FirstName = "Akrom",
                LastName = "Fozilov",
                Age = 54,
                Salary = 777,
                ProgrammingLanguages = new List<string>
                {
                    "Python",
                    "Javascript",
                    "Java"
                },
                CreditCards = new List<string>
                {
                    "4385603894",
                },
                Emails = new List<string>
                {
                    "AkromFozilov@gmail.com",
                    "FozilovAkrom@gmail.com",
                }
            },
            new Employee
            {
                Id = 5,
                FirstName = "Vali",
                LastName = "Aliyev",
                Age = 24,
                Salary = 455,
                ProgrammingLanguages = new List<string>
                {
                    "Paskal",
                    "Rust",
                    "Ruby"
                },
                CreditCards = new List<string>
                {
                    "1231234132",
                    "8999676454",
                    "3242343243"
                },
                Emails = new List<string>
                {
                    "ValiAliyev@gmail.com",
                    "AliyevVali@gmail.com"
                }
            }
        };
            }
        }
}
