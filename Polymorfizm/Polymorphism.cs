using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobetoTask.Polymorfizm
{
    public class Polymorphism
    {
        /* Polymorphism(Çok Biçimlilik) => Bir nesnenin farklı şekillerde davranabilme yeteneğidir.Bu, farklı nesne türlerinin aynı yöntem veya özellikle kullanılarak 
         * farklı davranışlar sergilemesine olaranak tanır.Genellikle miras almayı ve sanal yöntemleri içerir
         * 
         * --Compile-time Polymorphism(Derleme Zamanı Çok Biçimlilik): Bu tür, işlemci derleme zamanında hangi yöntemin çağrılacağını belirler.
         * --Reun-time Polymorphism (Çalışma Zamanı Çok Biçimlilik): Bu tür, işlemcinin çalışma zamanında hangi yöntemin çağıralacağını belirler.         
         */
    }

    //Örnek1
    //base class
   //class Vehicle
   //{
   //     //virtual ile metodu alt sınıflar tarafundan ezilmeye uygun hale getirdik 

   //     //base.Move() kullanımı ile ana sınıftan metot çağırılır.
   //     public virtual void Move()
   //     {
   //         Console.WriteLine("Vehicle is moving");
   //     }
   //}

   // class Car : Vehicle
   // {
   //     //override ile metotun önceki halini geçersiz kılmış olduk
   //     public override void Move()
   //     {
            
   //         Console.WriteLine("Car is driving on the road");
   //     }
   // }

   // class  Truck : Vehicle
   // {
   //     public override void Move()
   //     {
   //         Console.WriteLine("Truct is transporting goods");
   //     }
   // }

    //Örnek 2

    //base class
    public  abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Regtangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Regtangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double CalculateArea ()
        {
            return Width * Height;
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea ()
        {
           return Math.PI * Radius * Radius;
        }
    }
}
