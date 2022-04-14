using System;
using System.Collections.Generic;
using System.Text;
using static CourseManagementApplication.Group;

namespace CourseManagementApplication
{
    class Student
    {
        //Fields
        public string FullName;
        public string GroupNo;
        public bool Type;
        public Category category;

        public static int Bp = 100;
        public static int Dn = 100;
        public static int Sys = 100;
        


        //Constructor
        public Student(string fullname, Category categoryPar, bool type)
        {
            
            FullName = fullname;
            Type = type;
            category = categoryPar;
            

            switch (category)
            {
                case Category.Programming:
                    GroupNo = $"BP{Bp}";
                    Bp++;
                    break;
                case Category.Design:
                    GroupNo = $"DN{Dn}";
                    Dn++;
                    break;
                case Category.SysAdmin:
                    GroupNo = $"Sys{Sys}";
                    Sys++;
                    break;
                default:
                    Console.WriteLine("daxil etdiyiniz input secimlerde yoxdur");
                    break;
            }
        }

        

    }
}
