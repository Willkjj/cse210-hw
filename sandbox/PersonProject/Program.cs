class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "boberts", 23, 23);
        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPoliceMan = new Police("gun", "robert", "rob", 43, 43);
        Console.WriteLine(myPoliceMan.GetPersonInformation());

        Doctor myDoctor = new Doctor("PhD","Phill","Phillips",43,82);
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}