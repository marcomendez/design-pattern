using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Composite_Pattern
{
    public class Employee
    {
        public string name;
        public string dept;private
         int salary;
        private List<Employee> subordinates;

        // constructor
        public Employee(string name, string dept, int salary)
        {
            this.name = name;
            this.dept = dept;
            this.salary = salary;
            subordinates = new List<Employee>();
        }

        public void add(Employee e)
        {
            subordinates.Add(e);
        }

        public void remove(Employee e)
        {
            subordinates.Remove(e);
        }

        public List<Employee> getSubordinates()
        {
            return subordinates;
        }

        public string toString()
        {
            return ("Employee :[ Name : " + name + ", dept : " + dept + ", salary :" + salary + " ]");
        }
    }
}
