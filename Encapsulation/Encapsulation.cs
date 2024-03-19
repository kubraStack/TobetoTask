using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobetoTask.Encapsulation
{
    public class Programs
    {

        /* Encapsulation(Kapsülleme) => Nesne yönelimli programlamada önemli bir prensiptir ve bir sınıfıniçindeki
         * verileri(alanları) ve bu verilere erişim yöntemlerini(metotları) bir aradagruplama sürecidir.Bu, verilerin dış etkilerden korunmasını ve
         * sınıf iç yapısının gizlenmesini sağlar.Encapsulation, bir sınıfın içindeki detayların dış dünyaya gizlenmesini ve yalnızca gerekli olanlarının dışarıya açılmasını sağlar,
         * böylece sınıfın iç yapısı değiştiğinde diğer kodlara minimal etki yapar.
         * 
  
         ENCAPSULATION'ın TEMEL AVANTAJLARI : 
           * Gizlilik(Privacy)
           * Esneklik ve Kolaylık(Flexibility and Ease of Maintance)
           * Kod Düzeni ve Anlaşırlık(Code Organization and Readability)
         */
    }


    public class User
    {
        //private erişim belirleyici ile sınıf içinde gizlenmiş alanlar
        private string UserName;
        private string Password;

        //constructor

        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }



        //Getter ve setter metotları

        //Kullanıcı adını dışarıya okumak için get metodu
        public string GetToUserName()
        {
            return UserName;
        }

        //Şifreyi dışarıya okumak
        public string GetToPassword()
        {
            return Password;
        }

        //Kullanıcı adını değiştirme set metodu
        public void SetToUserName(string NewUserName)
        {
            UserName = NewUserName;
        }


        //Şifreyi değiştime set metodu
        public void SetToPassword(string NewPassword)
        {
            Password = NewPassword;
        }


    }

}
