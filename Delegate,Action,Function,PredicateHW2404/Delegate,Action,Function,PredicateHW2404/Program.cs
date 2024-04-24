using Delegate_Action_Function_PredicateHW2404.Models;

namespace Delegate_Action_Function_PredicateHW2404
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Person> people = new List<Person>();
            //people.Add(new Person { Name = "Anar",Surname="Qasimzada",Age=20 });
            //people.Add(new Person { Name = "Nurlan",Surname="Abbasov",Age=20 });
            //people.FindAll(s=>s.Name==Console.ReadLine()).ForEach(s=> Console.Write(s.Name));
            //people.FindAll(s=> s.Surname.Contains("ov")||s.Surname.Contains("ova)")).ForEach(s=>Console.Write(s.Surname));
            //people.FindAll(s=>s.Age>20).ForEach(s=> Console.WriteLine(s.Age));
            List<Exam> exams = new List<Exam>();
            
            exams.Add(new Exam { Subject="task1",ExamDuration=3,StartDate=DateTime.Now });
            exams.FindAll(s=>s.StartDate<=DateTime.Now.AddDays(7)).ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));
            exams.FindAll(s => s.ExamDuration > 2).ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));
            exams.FindAll(s=> DateTime.Now>= s.StartDate&& DateTime.Now<s.EndDate).ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));
        }
    }
}
