public abstract class Person
{
    private string pronound;
    private string name;
    private string surname;
    private string age;
    private string religion;
    private string allergicreactions;

    public Person(string pronound,string name,string surname,string age,string religion,string allergicreactions)
    {
        this.pronound = pronound;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.religion = religion;
        this.allergicreactions = allergicreactions;
    }
    public string GetName()
    {
        return this.name;
    }
    public string Getsurname()
    {
        return this.surname;
    }
    public string Getage()
    {
        return this.age;
    }
    public string Getreligion()
    {
        return this.religion;
    }
    public string Getallergicreactions()
    {
        return this.allergicreactions;
    }
    public string Getpronound()
    {
        return this.pronound;
    }
}