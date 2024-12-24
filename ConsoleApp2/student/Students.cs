using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2.student
{
    public class Students
    {
        public string Name;
        public string Major;
        public string GPA;

        public string GetInfo(string Name, string Major, string GPA)
        {
            return Name + " " + Major + " " + GPA;
            
        }
    
      }
}
