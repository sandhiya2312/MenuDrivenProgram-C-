using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employee
{
    class Employee
    {
        private int id;
        private string name;
        private string role;
        private int age;
        private int salary;

        public Employee(int id, string name, string role, int age, int salary)
        {
            this.id = id;
            this.name = name;
            this.role = role;
            this.age = age;
            this.salary = salary;
        }
       
        public int getId() { return id; }

        public string getName() { return name; }

        public string getRole() { return role; }

        public int getAge() { return age; } 

        public int getSalary() { return salary; }
            
        public int Id { set  { id = value; } }

        public string Name { set { name = value; } }    

        public string Role { set { role = value; } }

        public int Age {  set { age = value; } }
        
        public int Salary {  set { salary = value; } }



    }
}
