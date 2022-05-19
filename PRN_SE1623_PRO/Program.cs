namespace fptedu.se1623;//.NET 6 (same as package in java)

public class Programming
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Hello, World...");
        //primitive (nguyen thuy) <> prime (nguyen to)
        int x = 10, y = 20;
        string name;
        name = "abc";
        
        var salary = 10.5;//goi toi APIs (xml/json)
       
        
        dynamic fullName = 10;
        fullName = true;

        var a= true;

        int age = int.Parse("30"); 
   
        Console.WriteLine(salary.GetType()); 

        Console.WriteLine("{0},{1}",1,4);
        Console.WriteLine($"Sum of a = {x} and b = {y} is: { Sum(x,y)}");
        Console.ReadLine();
    }

    //sum for int a, int b: parameters vs argruments
    public static int Sum(int a, int b) 
    { 
        return a + b; 
    }
}
