using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWinCsExam
{
  public  class clsCourse
    {
        private string cNumber;
        private string cTitle;
        private clsListStudent cStudents;



        public clsCourse()
        {
            cNumber = "Not Defined";
            cTitle = "Not Defined";
            cStudents = new clsListStudent();


        }

        public clsCourse(string number, string title, clsListStudent students)
        {
            cNumber = number;
            cTitle = title;
            cStudents = students;

        }

        public string Number
        {
            
            get
            {
                return cNumber; 
            }
           
            set 
            { 
                cNumber = value;
            }
        }
        public string Title
        {
            
            get 
            { 
                return cTitle; 
            }
           
            set { 
                cTitle = value; 
            }
        }

        public clsListStudent Students
        {
            
            get {
                return cStudents;
            }
            
            set 
            { 
                cStudents = value;
            }
        }
    }
}
