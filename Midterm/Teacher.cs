class Teacher: Person
{
    private string rank;
    private string privatecar;

    public Teacher(string pronound,string name,string surname,string age,string rank,string religion,string allergicreactions,string privatecar) :base(pronound,name,surname,age,religion,allergicreactions)
    {
        this.rank = rank;
        this.privatecar = privatecar;
    }
}