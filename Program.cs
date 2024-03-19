using TobetoTask.GenericTypes;
using TobetoTask.Inheritance;
using TobetoTask.Encapsulation;
using TobetoTask.Polymorfizm;
using System.Drawing;
namespace TobetoTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inheritance
            //Employee employee = new Employee();
            //employee.Id = 1;
            //employee.FirstName = "Ali";
            //employee.LastName = "Seven";


            //Manager manager = new Manager();
            //manager.Section = "IT";


            //Generic Types
            //String tipinde veri deposu oluşturma
            //DataRepository<string> stringRepo = new DataRepository<string>(3);
            //stringRepo.AddToEmployee("Ahmet");
            //stringRepo.AddToEmployee("Ayşe");
            //stringRepo.AddToEmployee("Mehmet");
            //stringRepo.Write();


            //User user = new User("user123","123456");
            //user.SetToUserName("newUser1456");
            //user.SetToPassword("564897");

            //Console.WriteLine("Kullanıcı Adı: " + user.GetToUserName());
            //Console.WriteLine("Password: " + user.GetToPassword());

            Shape[] shapes = new Shape[2];
            shapes[0] = new Regtangle(5,4);
            shapes[1] = new Circle(6);

            foreach (var shape in shapes)
            {
                Console.WriteLine("Area: " + shape.CalculateArea());
            }
        }
    }
}
