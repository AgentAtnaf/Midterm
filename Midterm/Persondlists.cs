using System.Collections.Generic;
using System;

public class Persondlist
{
    private List<Person>personList;

    public Persondlist()
    {
        this.personList = new List<Person>();
    }
    public void AddNewPerson(Person person)
    {
        this.personList.Add(person);
    }
    public void FetchCollege()
    {
        Console.WriteLine("List College student");
        Console.WriteLine("***********");
        foreach(Person persons in this.personList)
        {
            if (persons is College)
            {
                Console.WriteLine("{0} Name {1} surname {2}",persons.Getpronound(),persons.GetName(),persons.Getsurname());
            }
        }
    }
    public void Fetchstudent()
    {
        Console.Clear();
        Console.WriteLine("List Student");
        Console.WriteLine("***********");
        foreach(Person person in this.personList)
        {
            if (person is Student)
            {
                Console.WriteLine("{0} Name {1} surname {2} ",person.Getpronound(),person.GetName(),person.Getsurname());
            }
        }
    }
    public void Fetchteacher()
    {
        Console.Clear();
        Console.WriteLine("List Teacher");
        Console.WriteLine("***********");
        foreach(Person person in personList)
        {
            if (person is Teacher)
            {
                Console.WriteLine("{0} Name {1} surname {2} ",person.Getpronound(),person.GetName(),person.Getsurname());
            }
        }
    }
    public string checkname(string pronound,string name,string surname)
    {
        string checker = "0";
        string Pronounds = pronound;
        string Names = name;
        string Surnames = surname;
        foreach (Person persons in personList) 
        {
            if (Pronounds != persons.Getpronound() && Names != persons.GetName() && Surnames != persons.Getsurname()) 
            {
                return checker = "passed";
            }
            if (Pronounds == persons.Getpronound() && Names == persons.GetName() && Surnames == persons.Getsurname())
            {
                return checker = "Alreadytaken";
            }
        }
        return checker;
    }
}