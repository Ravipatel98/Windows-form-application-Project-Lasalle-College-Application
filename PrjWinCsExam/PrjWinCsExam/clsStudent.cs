using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWinCsExam
{
  public  class  clsStudent
    {
        private string vNumber; 
        private string vName;
        private string vAge;
        private DateTime vBirthdate;
        private Single vAverage;
        private string num;
        private string date;
        private float v;

        public clsStudent()
        {
            vNumber =  vName = "Not Defined";
            vBirthdate = new DateTime();
            vAverage = -1;

        }

        public clsStudent(string num, string name, string date, float v)
        {
            this.num = num;
            Name = name;
            this.date = date;
            this.v = v;
        }

        public clsStudent(string number, string name, DateTime birthdate, int age, Single average)
        {
            vName = name;
            vBirthdate = birthdate;
            vAverage = average;



        }
        public string Number
        {
            // access for reading 
            get { return vNumber; }
            // access for writing 
            set { vNumber = value; }
        }

        public string Name
        {
            // access for reading 
            get { return vName; }
            // access for writing 
            set { vName = value; }
        }

        public DateTime Birthdate
        {
            // access for reading 
            get
            { return vBirthdate; }
            // access for writing 
            set { vBirthdate = value; }
        }

        public Single Average // Read-Only property
        {
            // access for reading 
            get { return vAverage; }
            // Set is deleted because access for writing is NOT allowed
        }

        public int Age  // ReadOnly
        {
            // access for reading 
            get
            {
                return (DateTime.Today.Year - vBirthdate.Year);
            }
        }


    }
}
