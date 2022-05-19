/*
    base (superclass/parrent class)
    derived(subclass/childclass)
 
 */
public class Person
{
    public string Name { get; set; }
    public DateOnly Dob { get; set; }
    public Address Address { get; set; } //Has-A

    protected string License { get; set; }

    public Person()
    {

    }

    public Person(string name, DateOnly dob, Address address)
    {
        Name = name;
        Dob = dob;
        Address = address;
    }

    public override string? ToString()
    {
        return $"[Name={Name}, Dob = {Dob}, Address = {Address}]";
    }
}