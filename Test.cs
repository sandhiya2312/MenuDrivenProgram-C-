using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Employee
{
    class Test
    {
        static List<Employee> employees = new List<Employee>();
        static void AddMemeber()
        {
            Console.WriteLine("Enter the Employee id,name,department,age and salary");
            Employee e1 = new Employee(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            employees.Add(e1);
            Console.WriteLine("Employee Added");
        }

        static void ViewEmployees()
        {
            if (employees.Count > 0)
            {
                foreach (Employee e in employees)
                {
                    Console.WriteLine("Id= "+e.getId()+",Name= "+e.getName()+ ",Role= " + e.getRole()+",Age= "+e.getAge()+",Salary= "+e.getSalary());
                }
            }
            else
            {
                Console.WriteLine("There is no Employee");
            }
        }

        static void UpdateEmployee(int id)
        {
            int flag = 0;
            foreach (Employee e in employees)
            {
                if(e.getId()==id)
                {
                    flag = 1;
                    Console.WriteLine("1--UpdateId\n2--UpadteName\n3--UpdateRole\n4--UpdateAge\n5--UpdateSalary\nEnter your choice to Update--");
                    int n= Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Enter Id--");
                            e.Id = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Enter Name--");
                            e.Name = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter Role--");
                            e.Role = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter Age--");
                            e.Age= Convert.ToInt32(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Enter Salary--");
                            e.Salary= Convert.ToInt32(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Enter from 1 to 5!!");
                            break;
                    }
                    
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Employee Updated Successfully");
            }
            else
            {
                Console.WriteLine("There is no employee with this id!!!!!");
            }
        }


        static void DeleteEmployee(int id)
        {
            int flag = 0;
            foreach (Employee e in employees)
            {
                if (e.getId() == id)
                {
                    flag = 1;
                    employees.Remove(e);
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Employee with id " + id + " was deleted");
            }
            else
            {
                Console.WriteLine("There is no employee with this id!!!!!");
            }
        }


        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\n1--InsertEmployee\n2--ViewEmployees\n3--UpdateEmployee\n4--DeleteEmployee\nPlease Enter Your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddMemeber();
                        break;
                    case 2:
                        ViewEmployees();
                        break;
                    case 3:
                        Console.WriteLine("Please Enter the id of the employee to be Updated:");
                        int id1= Convert.ToInt32(Console.ReadLine());
                        UpdateEmployee(id1);
                        break;
                    case 4:
                        Console.WriteLine("Please Enter the id of the employee to be Deleted:");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        DeleteEmployee(id2);
                        break;

                }
            } while (true);
        }

                
    }
}
