using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagementApplication
{
    partial class Group
    {
        //Fields
        public string No;
        public Category category;
        public bool isOnline;
        public int Limit;
        public static List<Group> groupsList = new List<Group>();
        public static List<Student> studentsList = new List<Student>();
        
        public static List<Student> programmingStudentsList = new List<Student>();
        public static List<Student> designStudentsList = new List<Student>();
        public static List<Student> sysadminStudentsList = new List<Student>();

        public static int Bp = 100;
        public static int Dn = 100;
        public static int Sys = 100;


        //Constructor
        public Group(Category categoryPar, bool isonline)
        {
            category = categoryPar;
            isOnline = isonline;

            switch (category)
            {
                case Category.Programming:
                    No = $"BP{Bp}";
                    Bp++;
                    break;
                case Category.Design:
                    No = $"DN{Dn}";
                    Dn++;
                    break;
                case Category.SysAdmin:
                    No = $"Sys{Sys}";
                    Sys++;
                    break;
                default:
                    Console.WriteLine("daxil etdiyiniz input secimlerde yoxdur");
                    break;
            }

            //Limit
            if(isOnline == true)
            {
                Limit = 15;
            }
            else
            {
                Limit = 10;
            }
        }

    }
}
