using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeCommissionCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string restart;
            do
            {
                Console.WriteLine("**********Employee Commission Program**********");
                bool validationloop1 = false;
                while (validationloop1 == false) // while loop used for validation
                {
                    Console.WriteLine("\ninput number of employees");
                    string employeeNumber = Console.ReadLine();
                    byte numberOfEmployees;
                    if (!byte.TryParse(employeeNumber, out numberOfEmployees)) // user input validation, if the user inputs anything other than an integar, program will show an error message and loop to the question below.
                    {
                        Console.WriteLine("\nTry again, please input number of employees as an integer");
                    }
                    else
                    {
                        int i;
                        validationloop1 = true;
                        string employeeName;
                        string[] employeeNameArray = new string[numberOfEmployees];
                        int[] employeeIdArray = new int[numberOfEmployees];
                        double[] employeePropertiesArray = new double[numberOfEmployees];
                        for (i = 0; i < numberOfEmployees; i++)
                        {
                            bool validationloop2 = false;
                            while (validationloop2 == false)
                            {
                                Console.WriteLine("\nPlease input employee name {0} ", (i + 1));

                                employeeName = Console.ReadLine();
                                if (employeeName == "")
                                {
                                    Console.WriteLine("\nTry again, Please input employee name using characters");
                                }
                                else
                                {
                                    validationloop2 = true;
                                    employeeNameArray[i] = employeeName;
                                    bool validationLoop3 = false;
                                    while (validationLoop3 == false)
                                    {
                                        Console.WriteLine("\nInput employee ID {0}", (i + 1));
                                        string employeeId = Console.ReadLine();
                                        int employeeIdValid;
                                        if (!int.TryParse(employeeId, out employeeIdValid)) // data valdiation using TryParse
                                        {

                                            Console.WriteLine("\nTry again, input employee ID as an integer");
                                        }
                                        else
                                        {
                                            validationLoop3 = true;
                                            employeeIdArray[i] = employeeIdValid;
                                            bool validationLoop4 = false;
                                            while (validationLoop4 == false)
                                            {
                                                Console.WriteLine("\nInput number of properties sold ");
                                                string employeeProperties = Console.ReadLine();
                                                int employeePropertiesValid;
                                                if (!int.TryParse(employeeProperties, out employeePropertiesValid))
                                                {
                                                    Console.WriteLine("\nTry again, input number of properties sold as an integer ");
                                                }
                                                else
                                                {
                                                    validationLoop4 = true;
                                                    employeePropertiesArray[i] = employeePropertiesValid;
                                                    employeePropertiesArray[i] *= 500; //this was on line 93, which made the program crash. (IndexOutOfRangeException)
                                                }

                                            }


                                        }
                                    }
                                }
                            }

                        }
                        Array.Sort(employeePropertiesArray);
                        Array.Reverse(employeePropertiesArray);
                        Console.WriteLine("\nemployees properties sales from highest to lowest: ");
                        for (i = 0; i < numberOfEmployees; i++) // this for loop display the employees properties sales * £500 from highest to lowest.
                        {
                            Console.WriteLine("£ " + employeePropertiesArray[i]);

                        }
                    }
                }



                        Console.WriteLine("\npress Y to restart. \npress any key to exit.");
                        restart = Console.ReadLine().ToUpper();
            } while (restart == "Y") ; // a Do While loop to restart or exit the application
        }   
    }
}
