using System;
using static CourseManagementApplication.Group;

namespace CourseManagementApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Yeni qrup yarat");
            Console.WriteLine("2.Qruplarin siyahisini goster");
            Console.WriteLine("3.Qrup uzerinde duzelish etmek");
            Console.WriteLine("4.Qrupdaki telebelerin siyahisini goster");
            Console.WriteLine("5.Butun telebelerin siyahisini goster");
            Console.WriteLine("6.Telebe yarat\n");


            Console.Write("Menyudan secim edin : ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (userInput == 1) // 1.Yeni qrup yarat
                {
                    Console.Write("Category : 1.Programming  2.Design  3.System Adminstration\n\nChoose your category : "); //Category
                    Category category = (Category)Convert.ToInt32(Console.ReadLine());

                    Console.Write("Is online : "); //isOnline
                    bool isOnline = Convert.ToBoolean(Console.ReadLine());

                    Group newGroup = new Group(category, isOnline);
                    groupsList.Add(newGroup);
                    userInput = 111;
                    Console.Write("\nMenyudan secim edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }

                else if(userInput == 2) //2.Qruplarin siyahisini goster
                {
                    foreach (var item in groupsList)
                    {
                        int StuCount;
                        if(item.category == Category.Programming)
                        {
                            StuCount = programmingStudentsList.Count;
                            item.Limit = StuCount;
                        }
                        if (item.category == Category.Design)
                        {
                            StuCount = designStudentsList.Count;
                            item.Limit = StuCount;
                        }
                        if (item.category == Category.SysAdmin)
                        {
                            StuCount = sysadminStudentsList.Count;
                            item.Limit = StuCount;
                        }
                        Console.WriteLine($"No : {item.No}, Category : {item.category}, Is online : {item.isOnline}, Student count : {item.Limit}");
                    }
                    userInput = 111;
                    Console.Write("\nMenyudan secim edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }

                else if (userInput == 3) //3.Qrup uzerinde duzelish etmek
                {
                    Console.Write("Category : 1.Programming  2.Design  3.System Adminstration\n\nChoose your category : "); //Category
                    Category category = (Category)Convert.ToInt32(Console.ReadLine());

                    switch (category)
                    {
                        case Category.Programming:
                            Console.Write("Hansi qrupun nomresin deyiwmek isteyirsiniz : ");
                            string noInput = Console.ReadLine();
                            bool isExist = false;
                            bool isExist2 = false;
                            foreach (var item in groupsList)
                            {
                                if(item.No == noInput)
                                {
                                    Console.Write("Qrupun yeni nomresi : ");
                                    Bp = Convert.ToInt32(Console.ReadLine());
                            
                                    foreach (var group in groupsList)
                                    {
                                        if(group.No == $"BP{Bp}")
                                        {
                                            isExist2 = true; 
                                        }
                                    }
                                    if(isExist2 == true)
                                    {
                                        Console.WriteLine("bele bir qrup artiq var");
                                        break;
                                    }
                                    else
                                    {
                                        item.No = $"BP{Bp}";
                                    }
                                    
                                    isExist = true;
                                    break;
                                }
                            }
                            if (isExist2 == true)
                            {
                                break;
                            }
                            if (isExist == false)
                            {
                                Console.WriteLine("daxil etdiyiniz input qrup listinde yoxdur ");
                            }
                            break;

                        case Category.Design:
                            Console.Write("Qrupun yeni nomresi : ");
                            Dn = Convert.ToInt32(Console.ReadLine());
                            break;
                        case Category.SysAdmin:
                            Console.Write("Qrupun yeni nomresi : ");
                            Sys = Convert.ToInt32(Console.ReadLine());
                            break;
                        default:
                            break;
                    }
                    userInput = 111;
                    Console.Write("\nMenyudan secim edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }

                else if(userInput == 4) //4.Qrupdaki telebelerin siyahisini goster
                {
                    Console.Write("1.Programming  2.Design  3.System Adminstration\nChoose group : ");
                    Category categoryInput = (Category)Convert.ToInt32(Console.ReadLine());

                    switch (categoryInput)
                    {
                        case Category.Programming:
                            foreach (var item in programmingStudentsList)
                            {
                                Console.WriteLine($"Fullname : {item.FullName}, Group No : {item.GroupNo}, Type : {item.Type}\n");
                            }
                            break;
                        case Category.Design:
                            foreach (var item in designStudentsList)
                            {
                                Console.WriteLine($"Fullname : {item.FullName}, Group No : {item.GroupNo}, Type : {item.Type}\n");
                            }
                            break;
                        case Category.SysAdmin:
                            foreach (var item in sysadminStudentsList)
                            {
                                Console.WriteLine($"Fullname : {item.FullName}, Group No : {item.GroupNo}, Type : {item.Type}\n");
                            }
                            break;
                        default:
                            Console.WriteLine("Daxil etdiyiniz nomreli qrup yoxdur");
                            break;          
                    }

                    userInput = 111;
                    Console.Write("\nMenyudan secim edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }

                else if (userInput == 5) //5.Butun telebelerin siyahisini goster
                {
                    foreach (var item in studentsList)
                    {
                        Console.WriteLine($"Fullname : {item.FullName}, Group No : {item.GroupNo}, Type : {item.Type}\n");
                    }
                    userInput = 111;
                    Console.Write("\nMenyudan secim edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else if (userInput == 6) //6.Telebe yarat
                {
                    Console.Write("\nFullname : "); //FullName
                    string userFullName = Console.ReadLine();

                    Console.Write("1.Programming  2.Design  3.System Adminstration\n\nGroup No : "); //Group No
                    Category userGroupNo = (Category)Convert.ToInt32(Console.ReadLine());


                    Console.Write("Type : "); //Type
                    bool userType = Convert.ToBoolean(Console.ReadLine());

                    
                    Student newStudent = new Student(userFullName, userGroupNo, userType);
                    studentsList.Add(newStudent);

                    switch (userGroupNo)
                    {
                        case Category.Programming:
                            programmingStudentsList.Add(newStudent);
                            break;
                        case Category.Design:
                            designStudentsList.Add(newStudent);
                            break;
                        case Category.SysAdmin:
                            sysadminStudentsList.Add(newStudent);
                            break;
                        default:
                            break;
                    }


                    userInput = 111;
                    Console.Write("\nMenyudan secim edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write("\nSeciminiz menyuda tapilmadi, bir daha cehd edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
            }
           

            
        }
    }
}
