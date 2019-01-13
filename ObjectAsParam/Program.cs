using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAsParam
{
    class Validator
    {
        private Credential cr;
        public Validator(Credential cr)
        {
            this.cr = cr;

        }

        public bool isValid()
        {
            if (cr.userName.Length >= 6 && cr.passWord.Length ==3)
            {
                return true;
            }
            return false;
        }
    }

    class Credential
    {
        public string userName { set; get; }
        public string passWord { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Credential cr= new Credential();
            cr.userName = "porosh";
            cr.passWord = "123";
            Validator val = new Validator(cr);

            if (val.isValid())
            {
                Console.WriteLine("Performing Login");
            }
            else
            {
                Console.WriteLine("You Cant Login Fool!");
            }

            Console.ReadKey();
        }
    }
}
