using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace people
{
    class Person
    {

        public string fname { get; set; }
        public string lname { get; set; }
        public string mname { get; set; }
        public string sname { get; set; }
        public string month { get; set; }
        public string day { get; set; }
        public string year { get; set; }
        

        public void lastname ()
        {
            this.lname = Console.ReadLine();
        }
        public void firstname ()
        {
            this.fname = Console.ReadLine();
        }
        public void Suffixname()
        {
            this.sname = Console.ReadLine();
            if (sname == null)
            {
                this.sname = " ";
            }

        }
        public void Month()
        {
            this.month = Console.ReadLine();
        }
        public void Day()
        {
            this.day = Console.ReadLine();
        }
        public void Year()
        {
            
            this.year = Console.ReadLine();
            
           

        }
             
        }
        
            
    }

