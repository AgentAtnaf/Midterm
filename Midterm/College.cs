class College: Person
{
    private string Collegeid;
    public College(string pronound,string name,string surname,string age,string Collegeid,string religion,string allergicreactions) :base(pronound,name,surname,age,religion,allergicreactions)
    {
        this.Collegeid = Collegeid;
    }
}