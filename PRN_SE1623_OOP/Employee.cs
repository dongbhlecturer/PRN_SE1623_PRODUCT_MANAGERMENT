public class Employee:Person //IS-A
{
    /*Fields/data*/
    private int _id;
   
    /*Properties/Attributes*/
    //init-only properties
    public double Salary { get; init; } //.NET Core
    public int Id { get => _id; set => _id = value; }
    public string Level { get; set; }//"Senior, Leader"
   
    //Auto-properties
    public string NameOfCompany { get; } = "FPT Education";

    /*Constructor*/
    public Employee()
    {
   
    }

    public Employee(int id, string name, double salary)
    {
        Salary = salary;
        Id = id;
        Name = name;
    }

    public Employee(int id, string name, double salary, DateOnly dob, Address address, string license):base(name,dob,address)
    {
        Salary = salary;
        Id = id;
        License = license;
    }


    //display to console

    //Overrding

    public override string? ToString()
    {
        return $"[Id = {this._id}, Name = {Name}, Salary = {Salary}], Dob = {Dob}, Address = {Address}";
    }

    //manual methods here
    public double GetSalaryByLevel()
    {
        if (this.Level == "Senior")
        {
            return this.Salary * 0.1;
        }
        else
        {
            return this.Salary;
        }
    }
    //Overloading
    public double GetSalaryByLevel(double commitment)
    {
        return this.GetSalaryByLevel() + commitment;
    }
}