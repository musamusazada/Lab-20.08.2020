using System;

namespace Employee_Info_Sys
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting the program env
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Centering our text
            Console.SetCursorPosition((Console.WindowWidth - "Employee Information System".Length) / 2, Console.CursorTop + 3);
            Console.WriteLine("Employee Information System");


            byte choice = 0;
            bool input_success;
            Employee[] employees = new Employee[0];


            //This Array is for all our operations: FIND , UPDATE , DELETE
            Employee[] tempArr = new Employee[0];


            //Setting up our Department Objects
            Department it_dep = new Department();
            it_dep.depName = "IT";
            
            Department sales_dep = new Department();
            it_dep.depName = "SALES";

            Department design_dep = new Department();
            it_dep.depName = "DESIGN";

            //Variables for Update option
            string updateSurname;
            byte updateAge;
            int updateNumber;
            string updateDepartment;



            //Starting our program loop

            do
            {
                //Presenting Navigation
                Console.WriteLine();
                centerTxt("1: List | 2: Find | 3: Create | 4: Update | 5: Delete | 0: Exit");
                Console.WriteLine("1: List | 2: Find | 3: Create | 4: Update | 5: Delete | 0: Exit");

                centerTxt("1: ");
                //Error Handling for invalid user input
                bool success = byte.TryParse(Console.ReadLine(), out choice);
                if (!success)
                {

                    choice = 255;
                }

                switch (choice)
                {
                    //List Options
                    case 1:
                        if (employees.Length > 0)
                        {
                            foreach (var item in employees)
                            {
                                centerTxt("__________________________________________________");
                                Console.WriteLine("__________________________________________________");
                                centerTxt($"ID: {item.id } | NAME: {item.name} | SURNAME: {item.surName} | DEPARTMENT: {item.depName} | Age: {item.age} | Phone Number: {item.phoneNumber.ToString("(000) 000-00-00")}");
                                Console.WriteLine($"ID: {item.id } | NAME: {item.name} | SURNAME: {item.surName} | DEPARTMENT: {item.depName} | Age: {item.age} | Phone Number: {item.phoneNumber.ToString("(000) 000-00-00")}");
                            }
                            centerTxt("__________________________________________________");
                            Console.WriteLine("__________________________________________________");
                            Console.WriteLine();
                            centerTxt($"Total Employees: {employees.Length}");
                            Console.WriteLine($"Total Employees: {employees.Length}");
                            //IT DEPARTMENT EMPLOYEE COUNT
                            tempArr = Array.FindAll(employees, e => e.depName == "IT");
                            it_dep.employeeCount = tempArr.Length;
                            if(it_dep.employeeCount>0)
                            {
                                centerTxt($"IT Department Employees: {it_dep.employeeCount}");
                                Console.WriteLine($"IT Department Employees: {it_dep.employeeCount}");
                            }    
                            tempArr = Array.Empty<Employee>();
                            //SALES DEPARTMENT EMPLOYEE COUNT
                            tempArr = Array.FindAll(employees, e => e.depName == "SALES");
                            sales_dep.employeeCount = tempArr.Length;
                            if (sales_dep.employeeCount > 0)
                            {
                                centerTxt($"SALES Department Employees: {sales_dep.employeeCount}");
                                Console.WriteLine($"SALES Department Employees: {sales_dep.employeeCount}");
                            }
                            tempArr = Array.Empty<Employee>();
                            //DESIGN DEPARTMENT EMPLOYEE COUNT
                            tempArr = Array.FindAll(employees, e => e.depName == "DESIGN");
                            design_dep.employeeCount = tempArr.Length;
                            if (design_dep.employeeCount > 0)
                            {
                                centerTxt($"DESIGN Department Employees: {design_dep.employeeCount}");
                                Console.WriteLine($"DESIGN Department Employees: {design_dep.employeeCount}");
                            }
                            tempArr = Array.Empty<Employee>();
                            centerTxt("****************************************************************");
                            Console.WriteLine("****************************************************************");
                        }
                        else
                        {
                            Console.WriteLine();
                            centerTxt("0 Employee");
                            Console.WriteLine("0 Employee");
                            centerTxt("****************************************************************");
                            Console.WriteLine("****************************************************************");
                        }
                        break;
                        //Find Option
                    case 2:
                        centerTxt("Search Name: ");
                        Console.Write("Search Name: ");
                        string findName = Console.ReadLine();
                        tempArr = Array.FindAll(employees, e => e.name.ToLower() == findName.ToLower());
                        if (tempArr.Length > 0)
                        {
                            foreach (var item in tempArr)
                            {
                               
                                centerTxt("__________________________________________________");
                                Console.WriteLine("__________________________________________________");
                                centerTxt($"ID: {item.id } | NAME: {item.name} | SURNAME: {item.surName} | DEPARTMENT: {item.depName} | Age: {item.age} | Phone Number: {item.phoneNumber.ToString("(000) 000-00-00")}");
                                Console.WriteLine($"ID: {item.id } | NAME: {item.name} | SURNAME: {item.surName} | DEPARTMENT: {item.depName} | Age: {item.age} | Phone Number: {item.phoneNumber.ToString("(000) 000-00-00")}");
                            }
                            Console.WriteLine();
                            centerTxt("__________________________________________________");
                            Console.WriteLine("__________________________________________________");
                            centerTxt("****************************************************************");
                            Console.WriteLine("****************************************************************");
                        }
                        else
                        {
                            centerTxt("No Such Employee Found!");
                            Console.WriteLine("No Such Employee Found!");
                            centerTxt("****************************************************************");
                            Console.WriteLine("****************************************************************");
                        }
                        tempArr = Array.Empty<Employee>();
                        break;


                        //Create option
                    case 3:
                        //TAKING NECESSARY INPUT
                        centerTxt("Enter Name:     ");
                        Console.Write("Enter Name: ");
                        string newName = Console.ReadLine();
                        centerTxt("Enter Surname:     ");
                        Console.Write("Enter Surname: ");
                        string newSurName = Console.ReadLine();
                        centerTxt("Enter Age:    ");
                        Console.Write("Enter Age: ");
                        byte newAge;
                        input_success = byte.TryParse(Console.ReadLine(), out newAge);
                        if(!input_success)
                        {
                            centerTxt("Invalid Age. Please Update Employee later");
                            Console.WriteLine("Invalid Age. Please Update Employee later");
                            newAge = 0;
                        }
                        centerTxt("Enter Phone Number:  ");
                        Console.Write("Enter Phone Number: ");
                        int newPhoneNumber;
                        input_success = Int32.TryParse(Console.ReadLine(), out newPhoneNumber);
                        if(!input_success)
                        {
                            centerTxt("Invalid Phone Number. Please Update Employee later");
                            Console.WriteLine("Invalid Phone Number. Please Update Employee later");
                            newPhoneNumber = 0;
                        }
                        centerTxt("Enter Department(IT, SALES, DESIGN): ");
                        Console.Write("Enter Department(IT, SALES, DESIGN): ");
                        string newDepartment = Console.ReadLine();
                        centerTxt("****************************************************************");
                        Console.WriteLine("****************************************************************");
                        //INPUT END

                        //CREATING NEW OBJECT AND ADDING IT TO ARRAY
                        Array.Resize(ref employees, employees.Length + 1);
                        Employee newEmployee = new Employee();
                        newEmployee.name = newName;
                        newEmployee.surName = newSurName;
                        newEmployee.age = newAge;
                        newEmployee.phoneNumber = newPhoneNumber;
                        newEmployee.depName = newDepartment.ToUpper();
                        newEmployee.id = Convert.ToByte(employees.Length - 1);

                        employees[employees.Length - 1] = newEmployee;
                        break;


                        //Update Option
                    case 4:
                        Console.WriteLine();
                        centerTxt("Name: ");
                        Console.Write("Name: ");
                        string updateName = Console.ReadLine();
                        tempArr = Array.FindAll(employees, e => e.name.ToLower() == updateName.ToLower());
                        if (tempArr.Length > 0)
                        {
                            centerTxt("Select the ID of the user you want to update: ");
                            Console.WriteLine("Select the ID of the user you want to update: ");
                            Console.WriteLine();
                            foreach (var item in tempArr)
                            {
                                centerTxt("__________________________________________________");
                                Console.WriteLine("__________________________________________________");
                                centerTxt($"ID: {item.id } | NAME: {item.name} | SURNAME: {item.surName} | DEPARTMENT: {item.depName} | Age: {item.age} | Phone Number: {item.phoneNumber.ToString("(000) 000-00-00")}");
                                Console.WriteLine($"ID: {item.id } | NAME: {item.name} | SURNAME: {item.surName} | DEPARTMENT: {item.depName} | Age: {item.age} | Phone Number: {item.phoneNumber.ToString("(000) 000-00-00")}");
                            }
                            Console.WriteLine();
                            centerTxt("ID : ");
                            Console.Write("ID : ");
                            byte updateID = Convert.ToByte(Console.ReadLine());
                            if (updateID >= 0 && updateID < employees.Length)
                            {
                                Console.WriteLine();
                                centerTxt("Update Name: ");
                                Console.Write("Update Name: ");
                                updateName = Console.ReadLine();
                                if(!String.IsNullOrWhiteSpace(updateName))
                                {
                                    employees[updateID].name = updateName;
                                }
                                centerTxt("Update Surname: ");
                                Console.Write("Update Surname: ");
                                updateSurname = Console.ReadLine();
                                if (!String.IsNullOrWhiteSpace(updateSurname))
                                {
                                    employees[updateID].surName = updateSurname;
                                }
                                centerTxt("Update Age: ");
                                Console.Write("Update Age: ");                            
                                success = byte.TryParse(Console.ReadLine(), out updateAge);
                                if (!success)
                                {
                                    centerTxt("Invalid Number Format.Change did not affect previous data");
                                    Console.WriteLine("Invalid Number Format. Change did not affect previous data");
                                }
                                else
                                {
                                    employees[updateID].age = updateAge;
                                }
                                centerTxt("Update Phone Number: ");
                                Console.Write("Update Phone Number: ");
                                success = int.TryParse(Console.ReadLine(), out updateNumber);
                                if(!success)
                                {
                                    centerTxt("Invalid Number Format.Change did not affect previous data");
                                    Console.WriteLine("Invalid Number Format. Change did not affect previous data");
                                }
                                else
                                {
                                    employees[updateID].phoneNumber = updateNumber;
                                }
                                centerTxt("Update Department: ");
                                Console.Write("Update Department: ");
                                updateDepartment = Console.ReadLine();
                                if (!String.IsNullOrWhiteSpace(updateDepartment))
                                {
                                    employees[updateID].depName = updateDepartment;
                                }

                                Console.WriteLine();
                            }
                            else
                            {
                                centerTxt("Select Valid ID!");
                                Console.WriteLine("Select Valid ID!");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            centerTxt("No Such Employee");
                            Console.WriteLine("No Such Employee");
                            Console.WriteLine();
                        }
                        tempArr = Array.Empty<Employee>();
                        break;
                        //Delete Option
                    case 5:
                        Console.WriteLine();
                        centerTxt("Name: ");
                        Console.Write("Name: ");
                        string delName = Console.ReadLine();
                        tempArr = Array.FindAll(employees, e => e.name.ToLower() == delName.ToLower());
                        if (tempArr.Length > 0)
                        {
                            centerTxt("Select the ID of the user you want to delete");
                            Console.WriteLine("Select the ID of the user you want to delete");
                            Console.WriteLine();
                            foreach (var item in tempArr)
                            {
                                centerTxt("__________________________________________________");
                                Console.WriteLine("__________________________________________________");
                                centerTxt($"ID: {item.id } | NAME: {item.name} | SURNAME: {item.surName} | DEPARTMENT: {item.depName} | Age: {item.age} | Phone Number: {item.phoneNumber.ToString("(000) 000-00-00")}");
                                Console.WriteLine($"ID: {item.id } | NAME: {item.name} | SURNAME: {item.surName} | DEPARTMENT: {item.depName} | Age: {item.age} | Phone Number: {item.phoneNumber.ToString("(000) 000-00-00")}");
                            }
                            centerTxt("__________________________________________________");
                            Console.WriteLine("__________________________________________________");
                            Console.WriteLine();
                            centerTxt("ID : ");
                            Console.Write("ID : ");
                            byte delID = Convert.ToByte(Console.ReadLine());
                            if (delID >= 0 && delID < employees.Length)
                            {
                                for (int i = delID; i < employees.Length - 1; i++)
                                {
                                    employees[delID] = employees[delID + 1];
                                    employees[delID].id = delID;
                                }
                                Array.Resize(ref employees, employees.Length - 1);
                               
                                Console.WriteLine();
                                centerTxt("****************************************************************");
                                Console.WriteLine("****************************************************************");
                            }
                            else
                            {
                                centerTxt("Invalid ID");
                                Console.WriteLine("Invalid ID");
                                centerTxt("****************************************************************");
                                Console.WriteLine("****************************************************************");
                            }
                        }
                        tempArr = Array.Empty<Employee>();
                        break;
                    case 0:                       
                        break;
                    default:
                        centerTxt("Please enter valid option");
                        Console.WriteLine("Please enter valid option");
                        break;
                }

            } while (choice != 0);
            Console.Clear();
            centerTxt("Program Terminated :)");
            Console.WriteLine("Program Terminated :)");
            Console.Read();
        }

        //This is a function to center any text in Console Window
        static void centerTxt(string s = "asd ad asd asd as das as das das")
        {
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop + 1);
        }
    }
}
