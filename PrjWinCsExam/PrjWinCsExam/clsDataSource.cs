using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace PrjWinCsExam
{
    class clsDataSource
    {
        public static clsListStudent getAllStudent()
        {
            clsListStudent allClients = new clsListStudent();
            OleDbConnection mycon = new OleDbConnection();
            mycon.ConnectionString =@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ravi patel\source\repos\PrjWinCsExam\PrjWinCsExam\Database\College.accdb";
            mycon.Open();

            OleDbCommand mycmd = new OleDbCommand();
            mycmd.CommandText = "SELECT SNumber, SName, SBirthdate, SAverage FROM Students";
            mycmd.Connection = mycon;

            OleDbDataReader myRder = mycmd.ExecuteReader();
            while (myRder.Read())
            {
                string num = myRder["SNumber"].ToString();
                string name = myRder["SName"].ToString();
                string date = myRder["SBirthdate"].ToString();
                string avg = myRder["SAverage"].ToString();
                clsStudent aStudent = new clsStudent(num, name, date, Single.Parse(avg));
                allClients.Add(aStudent);
            }

            return allClients;
        }

    }
}
