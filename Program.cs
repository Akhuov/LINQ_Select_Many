using LINQ_002;

namespace DemoConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        // HomeTask
        // With Select
        Console.WriteLine("\n   With Select \n");

        var employees = Employee.GetEmployees().Select(x => new
        {
            Id = x.Id,
            FirstName = x.FirstName,
            LastName = x.LastName,
            Age = x.Age,
            Salary = x.Salary,
            Languages = string.Join(", ", x.ProgrammingLanguages),
            CreditCards = string.Join(", ", x.CreditCards),
            Emails = string.Join(", ", x.Emails)
        });

        foreach (var emp in employees)
        {
            Console.WriteLine("FirstName: {0}", emp.FirstName);
            Console.WriteLine("Programming Languages: {0}", emp.Languages);
            Console.WriteLine("Emails: {0}", emp.Emails);
            Console.WriteLine("Credit Cards: {0}", emp.CreditCards);
            Console.WriteLine();
        }

        Console.WriteLine("\n   With Select Many \n");

        // With Select Many
        var emps = Employee.GetEmployees()
                .SelectMany(x => x.ProgrammingLanguages, (emp, lang) => new
                {
                    emp.Id,
                    emp.FirstName,
                    emp.LastName,
                    emp.Age,
                    emp.Salary,
                    Language = lang,
                    CreditCards = emp.CreditCards,
                    Emails = emp.Emails
                })
                .SelectMany(x => x.CreditCards, (emp, card) => new
                {
                    emp.Id,
                    emp.FirstName,
                    emp.LastName,
                    emp.Age,
                    emp.Salary,
                    emp.Language,
                    CreditCard = card,
                    emp.Emails
                })
                .SelectMany(x => x.Emails, (emp, email) => new
                {
                    emp.Id,
                    emp.FirstName,
                    emp.LastName,
                    emp.Age,
                    emp.Salary,
                    emp.Language,
                    emp.CreditCard,
                    Email = email
                });

        foreach (var emp in emps)
        {
            Console.WriteLine("FirstName: {0}", emp.FirstName);
            Console.WriteLine("Programming Language: {0}", emp.Language);
            Console.WriteLine("Email: {0}", emp.Email);
            Console.WriteLine("Credit Card: {0}", emp.CreditCard);
            Console.WriteLine();
        }

         var query2 = Employee.GetEmployees().Select(x => new
                {
                    EmployeeName = string.Join("", x.FirstName),
                    Programm = string.Join(",", x.ProgrammingLanguages),
                    Email = string.Join(",", x.Emails)
                }).ToList();


            foreach ( var employee in query2 )
            {
                Console.WriteLine(employee.EmployeeName + " => " + employee.Programm + " => " + employee.Email);
            }



    }
}