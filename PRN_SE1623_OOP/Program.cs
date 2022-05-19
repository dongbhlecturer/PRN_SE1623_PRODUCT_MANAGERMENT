namespace PRN.SE1623;
using static System.Console;
using System.Collections;
public class Program
{
    public static void Main(string[] args)
    {
        /*1. create a Employee object*/
        /*
        Employee e = new Employee { Salary = 1253d, Name = "Dong" };
        Employee b = new Employee(1,"Tran Van Meo",1524d);
        WriteLine(b.Name);
        WriteLine(e);
        */
        /*2. Define a collection Employees*/
        /*
        ArrayList lstEmps = new ArrayList();
        lstEmps.Add(new Employee(1,"Dong",123d,new DateOnly(),new Address(493,"CMT8","Phuong 13","Quan 10","HCMC")));
        lstEmps.Add(new Employee(2, "An", 1223d));
        lstEmps.Add(new Employee(3, "Hue", 143d));
        lstEmps.Add(new Employee(4, "Lan", 12003d));
        lstEmps.Add(new Employee(5, "Huu", 12300d));
        lstEmps.Add(new Employee(6, "Van", 12003d));
        
        //display
        Display(lstEmps);
      

        Employee e = new Employee { Salary = 1253d, Name = "Dong" };

        Person p = new Employee();//polymorphis

        Employee k = (Employee)p; //down-casting
        

        
        Print(e);
        Print(p);
          */

        /*----------abstract---------------*/
        WriteLine("-===========================================");
        Shape s = new Circle(100);//polymorphis
        s.display();

        /*----------Interfaces---------------*/

        IShape ac = new Rectangle();


        double area = s.Perimetter();
        WriteLine(area);

        ReadLine();

    }

    private static void Print(Person p)
    {
        WriteLine(p);
    }

    private static void Display(ArrayList lstData)
    {
        /*
        foreach (Employee e in lstData)
        {
            WriteLine(e);
        }
        */

        for(int i = 0; i < lstData.Count; i++)
        {
            WriteLine(lstData[i]);
        }
    }
}