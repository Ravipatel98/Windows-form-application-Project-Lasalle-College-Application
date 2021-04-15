using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWinCsExam
{
    public class clsListStudent
    {
        private List<clsStudent> studentList;

        public clsListStudent()
        {
            studentList = new List<clsStudent>();
        }


        public List<clsStudent> getElement()
        {
            return studentList;
        }


        public void Add(clsStudent student)
        {

            this.studentList.Add(student);
        }

        public void Edit(int position, clsStudent student)
        {
            studentList[position] = student;
        }

        public bool Delete(int position)
        {

            studentList.RemoveAt(position);
            return true;
        }
        public clsStudent MoveTo(int position)
        {
            return studentList[position];
        }
    }
}

