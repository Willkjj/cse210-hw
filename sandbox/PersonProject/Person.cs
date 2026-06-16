abstract class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _weight = weight;
    }
    
    public virtual string GetPersonInformation()
    {
        return $"Name: {_firstName} {_lastName}, age: {_age}, weight: {_weight}";
    }

    public void ChangeWeight(int update)
    {
        _weight += update;
    }

    public abstract double GetSalary();
    // class must also be declared as abstract as well
}