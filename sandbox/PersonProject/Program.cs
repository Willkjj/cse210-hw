class Program
{

    public static void PersonInfo(Person person)
    {
        // if (person is Doctor doctor)
        //     doctor.GetPersonInformation();
        // else if (person is Police police)
        // {
        //     police.GetPersonInformation();
        // }
        Console.WriteLine(person.GetPersonInformation());

    }
    public static void Main(string[] args)
    {
        // Person myPerson = new Person("Bob", "boberts", 23, 23);
        // Console.WriteLine(myPerson.GetPersonInformation());
    

        Police myPoliceMan = new Police("gun", "robert", "rob", 43, 43);
        // Console.WriteLine(myPoliceMan.GetPersonInformation());

        Doctor myDoctor = new Doctor("PhD","Phill","Phillips",43,82);
        // Console.WriteLine(myDoctor.GetPersonInformation());


        List<Person> people = new List<Person>();
        people.Add(myDoctor);
        people.Add(myPoliceMan);
        // people.Add(myPerson);
        foreach(Person person in people)
        {
            // person.GetPersonInformation();
            PersonInfo(person);
        }

    }
}