using Demo.UserDefiendDataTypes;
using Demo.Enums;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum => Enumeration

            #region EX1
            //Person person = new Person();
            //person.Id = 1;
            //person.Name = "Nour";
            //person.gender = Gender.Male;

            //Console.WriteLine(person.gender);

            //Grade G = Grade.A;
            //if(G == Grade.A)
            //    Console.WriteLine("Excelent");
            //else
            //    Console.WriteLine(" ");

            //G = (Grade)5; // exciplicit casting


            //Grade grade2 = new Grade();
            //Console.WriteLine(grade2);


            #endregion

            #region EX2
            // Student student = new Student();
            // bool isParsed;
            // Console.WriteLine("Enter Student Data : ");
            // Console.Write("id => ");
            // int id;
            // do { 
            //     isParsed = int.TryParse(Console.ReadLine(), out id);
            //     if (isParsed == false)
            //     {
            //         Console.WriteLine("invalid input");
            //     }
            // } while (!isParsed);
             
            // student.id = id;
             
            // Console.Write("Name => ");
            // student.name = Console.ReadLine();
             
            // object gender;
            // do {
            //     Console.Write("Gander => ");
            //     isParsed = Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out gender);
            //     if (!isParsed)
            //     {
            //         Console.WriteLine("invalid input");
            //     }
            // }while (!isParsed);
            // // parse
            // // student.gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);
            // // student.gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            // student.gender = (Gender)gender;
             
            // object grade;
            // do
            // {
            //     Console.Write("Grade => ");
            //     isParsed = Enum.TryParse(typeof(Grade), Console.ReadLine(), true, out grade);
            //     if (isParsed == false)
            //     {
            //         Console.WriteLine("invalid input");
            //     }
            // } while (!isParsed);
            // student.grade = (Grade)grade;
             
            // object branch;
            // do
            // {
            //     Console.Write("Branch => ");
            //     isParsed = Enum.TryParse(typeof(Branch), Console.ReadLine(), true, out branch);
            //     if (!isParsed)
            //     {
            //         Console.WriteLine("invalid input");
            //     }
            // } while (!isParsed);
            // student.branch = (Branch)branch;
             
            // Console.WriteLine($"your id = {student.id} , your name is {student.name}," +
            //     $" your gender is {student.gender}," +
            //     $"your grade is {student.grade} , your branch is {student.branch}");
            #endregion

            #region EX3
            User user1 = new User();
            user1.Id = 10;
            // user1.permession = (Permession) 5;
            user1.permession = (Permession) 10;
            Console.WriteLine(user1.permession);
            
            user1.permession = user1.permession ^ Permession.Read; // if the [read] found => remove ,  if the [read] not found => add
            Console.WriteLine(user1.permession);
            //user1.permession = Permession.Read | Permession.Write; 
            #endregion

            #endregion

        }
    }
}
