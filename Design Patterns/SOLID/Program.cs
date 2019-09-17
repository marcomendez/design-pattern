using SOLID.DependencyInversionPrinciple;
using SOLID.LiskovSubstitutionPrinciple;
using SOLID.OpenClose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //************ Open Close ***********
            Login login = new Login();
            login.MakeLogin(new Admin());
            login.MakeLogin(new User());


            //************* Liskov **************
            Robot robot1 = new Robot2017();
            robot1.Attack(); // Daña 150
            
            Console.WriteLine("Robot 2017 : Attrack =" + robot1.Attack());

            Robot robot2 = new Robot2018();
            robot2.Attack(); // Daña 175
            Console.WriteLine("Robot 2018 : Attrack =" + robot2.Attack());

            Robot robot3 = new Robot2019();
            robot3.Attack(); // Daña 200
            Console.WriteLine("Robot 2019 : Attrack =" + robot3.Attack());


            //************* Dependency Inversion ************** 
            Whatsaap whatsaap = new Whatsaap();
            new Notification().Send(whatsaap);

            Email mail = new Email();
            new Notification().Send(mail);

            SMS sms = new SMS();
            new Notification().Send(sms);

            Console.ReadLine();
        }
    }
}
