class Student: Person
{
    private string Schoolname;
    private string levelofeducation;

    public Student(string pronound,string name,string surname,string age,string levelofeducation,string religion,string allergicreactions,string Schoolname) :base(pronound,name,surname,age,religion,allergicreactions)
    {
        this.levelofeducation = levelofeducation;
        this.Schoolname = Schoolname;
    }
    public string Getlevelofeducation()
    {
        return this.levelofeducation;
    }
}