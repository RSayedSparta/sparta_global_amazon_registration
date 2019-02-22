using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AmazonRegistration
{
    class User
    {
        public User()
        {

        }

        public User(string n, string p, int a, string rp, string pn, string pic)
        {
            name = n;
            password = p;
            repassword = rp;
            age = a;
            phoneNumber = pn;
            picturePath = pic;
            

        }

        string name;
        string password;
        int age;
        string repassword;
        string phoneNumber;
        string picturePath;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string PicturePath { get => picturePath; set => picturePath = value; }
        public int Age { get => age; set => age = value; }
        public string Repassword { get => repassword; set => repassword = value; }

        public void saveData()
        {
            using (StreamWriter sw = File.AppendText("UserData.txt"))
            {
                sw.WriteLine(name+ "," + password + "," + repassword + "," + age + "," + phoneNumber + "," + picturePath );
            }
        }
    }
    
}
