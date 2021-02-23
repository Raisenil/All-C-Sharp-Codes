using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th5
{
    class Teacher 
    {
        string hr;
        public string Hr
        {
            set { hr = value; }
            get { return hr; }
        }
        private int salary;
        public inr Salary
        {
            get { return salary; }
            set { id = value; }
        }
        private string dob;
        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        private string bg;
        public string Bg
        {
            get { return bg; }
            set { bg = value; }
        }
        public Person()
        {
            Console.WriteLine("Person Default");
        }
        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("Person 1 parameter");
        }
        public Person(string name,string id)
        {
            this.name = name;
            this.id = id;
            Console.WriteLine("Person 2 parameter");
        }
        
    }
}
