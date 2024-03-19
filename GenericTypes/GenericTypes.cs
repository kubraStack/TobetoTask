using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobetoTask.GenericTypes
{
    
      
       
     //Geçici sınıf
    //Buarada <T> ile class'ın herhangi bir veri tipiyle çalışabileceğini belirtmiş oluyoruz.
    // Generic Type kullanarak : 
    // ----Tip Güvenliği (Type Safety)
    // ----Kodun Daha Az Tekrarı (Less Code Duplication)
    // ----Daha Genel ve Esnek Kod Yazma (Writing More General and Flexible Code)
    public class DataRepository<T>
    {
        private T[] data;
        private int indeks = 0;

        //Constructor
        public DataRepository(int size)
        {
            data = new T[size];
        }

        //Eleman ekleme 
        public void AddToEmployee(T employee)
        {
            if (indeks < data.Length)
            {
                data[indeks] = employee;
                indeks++;   
            }
            else
            {
                Console.WriteLine("Veri deposu dolu, eleman eklenemedi!");
            }
        }

        //Elemanları ekrana yazdırma metodu
        public void Write()
        {
            Console.WriteLine("Depodaki Elemanlar: ");
            foreach (T employee in data)
            {
                Console.WriteLine(employee);
            }
        }
    }


   

    
}
