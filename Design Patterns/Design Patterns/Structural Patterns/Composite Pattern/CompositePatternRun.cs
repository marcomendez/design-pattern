﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Composite_Pattern
{
    public class CompositePatternRun
    {
        public void run()
        {
            Console.WriteLine("************************** Composite Pattern **********************************");
            Employee CEO = new Employee("John", "CEO", 30000);
            Employee headSales = new Employee("Robert", "Head Sales", 20000);

            Employee headMarketing = new Employee("Michel", "Head Marketing", 20000); Employee clerk1 = new Employee("Laura", "Marketing", 10000);
            Employee clerk2 = new Employee("Bob", "Marketing", 10000);

            Employee salesExecutive1 = new Employee("Richard", "Sales", 10000);
            Employee salesExecutive2 = new Employee("Rob", "Sales", 10000);


  

        

            CEO.add(headSales);
            CEO.add(headMarketing);

            headSales.add(salesExecutive1);
            headSales.add(salesExecutive2);

            headMarketing.add(clerk1);
            headMarketing.add(clerk2);

            //print all employees of the organization
            Console.WriteLine(CEO.name + " : " + CEO.dept);

            foreach (Employee headEmployee in CEO.getSubordinates())
            {
                Console.WriteLine(headEmployee.name + " : " + headEmployee.dept);

                foreach (Employee employee in headEmployee.getSubordinates())
                {
                    Console.WriteLine(employee.name + " : " + employee.dept);
                }
            }
            Console.WriteLine("******************************************************************************");
        }
    }
    }

