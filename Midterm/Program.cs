enum Menu
{
    Registermenu = 1,
    gettotal = 2,
    login = 3
}
enum Register
{
    Collegestudent = 1,
    Student = 2,
    teacher = 3
}
enum Pronoun
{
    Mr = 1, Mrs = 2 , Miss = 3
}
enum Level
{
    M4 = 1, M5 = 2 , M6 = 3
}
enum Rankofteacher
{
    Dean = 1,Headofdepartment = 2,fulltimeteacher=3
}
enum Religion
{
    Buddhist = 1,Christ = 2,Islam = 3,etc = 4
}
enum Loginlist
{
    registrater = 1,showcollegename = 2, showstudentname = 3 , showteachername = 4,exit = 5
}
public class Program
{
    public static int collegecounter = 0;
    public static int studentcounter = 0;
    public static int teachercounter = 0;
    public static int M4counter = 0;
    public static int M5counter = 0;
    public static int M6counter = 0;
    static Persondlist persondList;
     static void PrepareEmailListWhenProgramisloaded()
    {
            Program.emaillist = new Emaillist();
    }
    static Emaillist emaillist;
    static void PreparePersonListWhenProgramisloaded()
    {
            Program.persondList = new Persondlist();
    }
    static void ToMainnologin()
    {
        Mainmenu();
        InputmenuFromkeyboard();
    }
    static void Main(string[] args)
    {
        PrepareEmailListWhenProgramisloaded();
        PreparePersonListWhenProgramisloaded();
        ToMainnologin();
    }
    static void Mainmenu()
    {   
        Console.Clear();
        Console.WriteLine("Welcome to registration of Idia camp 2022 application");
        Console.WriteLine("---------------------------------------------------------");     
        Console.WriteLine("1. Registermenu ");
        Console.WriteLine("2. gettotal");
        Console.WriteLine("3. Login");
        Console.WriteLine("---------------------------------------------------------");
    }
    static void InputmenuFromkeyboard()
    {
        Console.Write("Please input Menu:");
        Menu menu = (Menu)int.Parse(Console.ReadLine());
        
        getmenulist(menu);
    }
    static void getmenulist(Menu menu)
    {
        switch (menu) 
        {
            case Menu.Registermenu:
                ShowRegistermenuScreen();
                    break;
            case Menu.gettotal:
                 gettotal(teachercounter,studentcounter,collegecounter,M4counter,M5counter,M6counter);
                    break;
            case Menu.login:
                loginprocess();
                    break;
                default:
                    break;
        }
    }
    static void InputmenuloginFromkeyboard()
    {
        Console.Write("please input Menu:");
        Loginlist loginlist = (Loginlist)int.Parse(Console.ReadLine());

        inputloginlist(loginlist);
    }
    static void inputloginlist(Loginlist loginlist)
    {
        switch (loginlist) 
        {
            case Loginlist.registrater:
                ShowRegistermenuScreen();
                    break;
            case Loginlist.showcollegename:
                Collegename();
                    break;
            case Loginlist.showstudentname:
                studentename();
                    break;
            case Loginlist.showteachername:
                teachername();
                    break;
            case Loginlist.exit:
                ToMainnologin();
                    break;
                default:
                    break;
        }
    }
    static void Collegename()
    {
        Program.persondList.FetchCollege();
        Console.ReadLine();
        ToMainnologin();
    }
    static void studentename()
    {
        Program.persondList.Fetchstudent();
        Console.ReadLine();
        ToMainnologin();
    }
    static void teachername()
    {
        Program.persondList.Fetchteacher();
        Console.ReadLine();
        ToMainnologin();
    }
    
    static void gettotal(int teachercounter,int studentcounter,int collegecounter,int M4counter,int M5counter,int M6counter)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("Amount of teacher: {0} ",teachercounter);
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("Amount of student: {0} ",studentcounter);
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("Amount of College student: {0} ",collegecounter);
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("Amount of M.4 Student: {0} ",M4counter);
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("Amount of M.5 Student: {0} ",M5counter);
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("Amount of M.6 Student: {0} ",M6counter);
        Console.WriteLine("---------------------------------------------------------");
        Console.ReadLine();
        ToMainnologin();

    }
    static void ShowRegistermenuScreen()
    {
        Registermenu();
        InputregisterFromkeyboard();
    }
    static void Registermenu()
    {
        Console.Clear();
        Console.WriteLine("Registeration menu");
        Console.WriteLine("---------------------------------------------------------");     
        Console.WriteLine("1. College student ");
        Console.WriteLine("2. Student");
        Console.WriteLine("3. Teacher");
        Console.WriteLine("---------------------------------------------------------");
    }
    static void InputregisterFromkeyboard()
    {
        Console.Write("please input Menu:");
        Register register = (Register)int.Parse(Console.ReadLine());

        inputmenuRegister(register);
    }
    static void inputmenuRegister(Register register)
    {
        switch (register) 
        {
            case Register.Collegestudent:
                CollegeRegister();
                    break;
            case Register.Student:
                StudentRegister();
                    break;
            case Register.teacher:
                teacherRegister();
                    break;
                default:
                    break;
        }
    }
    static void HeaderCollegeRegister()
    {
        Console.Clear();
        Console.WriteLine("Register new Colleage student");
        Console.WriteLine("Please type your info correctly");
        Console.WriteLine("-----------------------");
    }
    static void HeaderStudentRegister()
    {
        Console.Clear();
        Console.WriteLine("Register new Student");
        Console.WriteLine("Please type your info correctly");
        Console.WriteLine("-----------------------");
    }
    static void HeaderteacherRegister()
    {
        Console.Clear();
        Console.WriteLine("Register new Teacher");
        Console.WriteLine("Please type your info correctly");
        Console.WriteLine("-----------------------");
    }
    static void CollegeRegister()
    {
        HeaderCollegeRegister();
        string checker = "0";
        College college = new College(inputPronound(),InputName(),InputSurname(),InputAge(),InputCollegeid(),Inputreligion(),Inputallergicreactions());
        checker = Program.persondList.checkname(college.Getpronound(),college.GetName(),college.Getsurname());
        if(checker == "passed" || checker == "0" )
         {
        string admin = "0";
        Console.WriteLine("Are you admin ?");
        Console.WriteLine("---------------");
        Console.WriteLine("Yes type 1,No type 2");
        admin = Console.ReadLine();
        if (admin == "1")
        {
            string ticket = "0";
            Email email = new Email(inputemail(),inpassword());
            ticket = Program.emaillist.checkmail(email.GetEmail());
            if(ticket == "passed")
            {
                Console.WriteLine(ticket);
                System.Threading.Thread.Sleep(3000);
                Program.emaillist.AddNewEmail(email);
                Program.persondList.AddNewPerson(college);
                collegecounter++;
                ToMainnologin();
            }
            else
            {
            Console.WriteLine("Invalid email");
            System.Threading.Thread.Sleep(5000);
            ToMainnologin();
            }
        }
        else if (admin == "2")
        {
            Program.persondList.AddNewPerson(college);
            collegecounter++;
            ToMainnologin();
        }
    }
        if(checker == "Alreadytaken")
        {
            Console.WriteLine("Invalid name");
            System.Threading.Thread.Sleep(5000);
            ToMainnologin();
        }
    }
    static void StudentRegister()
    {
        string checker = "0";
        HeaderStudentRegister();
        Student student = new Student(inputPronound(),InputName(),InputSurname(),InputAge(),Inputlevelofeducation(),Inputreligion(),Inputallergicreactions(),InputSchoolname());
        checker = Program.persondList.checkname(student.Getpronound(),student.GetName(),student.Getsurname());
        if(checker == "passed" || checker == "0" )
         {
            Program.persondList.AddNewPerson(student);
            studentcounter++;
            ToMainnologin();
         }
        if(checker == "Alreadytaken")
        {
            Console.WriteLine("Invalid name");
            if(student.Getlevelofeducation() == "M.4")
            {
                M4counter--;
            }
            else if(student.Getlevelofeducation() == "M.5")
            {
                M5counter--;
            }
            else if(student.Getlevelofeducation() == "M.6")
            {
                M6counter--;
            }
            System.Threading.Thread.Sleep(5000);
            ToMainnologin();
        }
    }
    static void teacherRegister()
    {
        string checker = "0";
        HeaderteacherRegister();
        Teacher teacher = new Teacher(inputPronound(),InputName(),InputSurname(),InputAge(),Inputrank(),Inputreligion(),Inputallergicreactions(),Inputcar());
        checker = Program.persondList.checkname(teacher.Getpronound(),teacher.GetName(),teacher.Getsurname());
        if(checker == "passed" || checker == "0" )
         {
        string admin = "0";
        Console.WriteLine("Are you admin ?");
        Console.WriteLine("---------------");
        Console.WriteLine("Yes type 1,No type 2");
        admin = Console.ReadLine();
        if (admin == "1")
        {
            string ticket = "0";
            Email email = new Email(inputemail(),inpassword());
            ticket = Program.emaillist.checkmail(email.GetEmail());
            if(ticket == "passed")
            {
                Console.WriteLine(ticket);
                System.Threading.Thread.Sleep(3000);
                Program.emaillist.AddNewEmail(email);
                Program.persondList.AddNewPerson(teacher);
                ToMainnologin();
            }
            else
            {
            Console.WriteLine("Invalid email");
            System.Threading.Thread.Sleep(5000);
            ToMainnologin();
            }
        }
        else if (admin == "2")
        {
            Program.persondList.AddNewPerson(teacher);
            ToMainnologin();
        }
    }
        if(checker == "Alreadytaken")
        {
            Console.WriteLine("Invalid name");
            System.Threading.Thread.Sleep(5000);
            ToMainnologin();
        }
    }
    static void Pronoundlist()
    {
        Console.Clear();
        Console.WriteLine("Please choose your pronound correctly from this list.");
        Console.WriteLine("-----------------------");
        Console.WriteLine("1.MR.");
        Console.WriteLine("2.Mrs.");
        Console.WriteLine("3.Miss.");
        Console.WriteLine("-----------------------");
    }
    static string inputPronound()
    {
        Pronoundlist();
        Console.Write(":");
        Pronoun pronound = (Pronoun)int.Parse(Console.ReadLine());
        
        return Pronouncase(pronound);
    }
    static string Pronouncase(Pronoun pronound)
    {
        switch (pronound) 
        {
            case Pronoun.Mr:
                return "Mr.";
                    break;
            case Pronoun.Mrs:
                return "Mrs.";
                    break;
            case Pronoun.Miss:
                return "Miss";
                    break;
            default:
                return "";
                    break;
        }
    }
    static string InputName()
    {
        Console.Write("Name :");
        return Console.ReadLine();
    }
    static string InputSurname()
    {
        Console.Write("Surname :");
        return Console.ReadLine();
    }
    static string InputAge()
    {
        Console.Write("Age :");
        return Console.ReadLine();
    }
    static string InputCollegeid()
    {
        Console.Write("Collegeid :");
        return Console.ReadLine();
    }
    static string Inputreligion()
    {
        Console.Clear();
        Console.WriteLine("Please choose your religion correctly from this list.");
        Console.WriteLine("-----------------------");
        Console.WriteLine("1.Buddhist");
        Console.WriteLine("2.Chirst");
        Console.WriteLine("3.Islam");
        Console.WriteLine("4.Etc...");
        Console.WriteLine("-----------------------");
        Console.Write(":");
        Religion religion = (Religion)int.Parse(Console.ReadLine());
        return Religioncase(religion);
    }
    static string Religioncase(Religion religion)
    {
        switch (religion) 
        {
            case Religion.Buddhist:
                return "Buddhist";
                    break;
            case Religion.Christ:
                return "Christian";
                    break;
            case Religion.Islam:
                return "Islam";
                    break;
            case Religion.etc:
                return "Etc...";
                    break;
            default:
                return "";
                    break;
        }
    }
    static string Inputallergicreactions()
    {
        Console.Write("Allergic reactions :");
        return Console.ReadLine();
    }
    static string Inputlevelofeducation()
    {
       Console.Clear();
       Console.WriteLine("Please choose your level correctly from this list.");
        Console.WriteLine("-----------------------");
        Console.WriteLine("1.M.4");
        Console.WriteLine("2.M.5");
        Console.WriteLine("3.M.6");
        Console.WriteLine("-----------------------");
        Console.Write(":");
        Level level = (Level)int.Parse(Console.ReadLine());
        return Levelcase(level);
    }
    static string Levelcase(Level level)
    {
        switch (level) 
        {
            case Level.M4:
            M4counter++;
            return "M.4";
                    break;
            case Level.M5:
            M5counter++;
                return "M.5";
                    break;
            case Level.M6:
            M6counter++;
                return "M.6";
                    break;
            default:
                return "";
                    break;
        }
    }
    static string Inputrank()
    {
        Console.Clear();
        Console.WriteLine("Please choose your rank correctly from this list.");
        Console.WriteLine("-----------------------");
        Console.WriteLine("1.Dean");
        Console.WriteLine("2.Head of department");
        Console.WriteLine("3.Full-time teacher");
        Console.WriteLine("-----------------------");
        Console.Write(":");
        Rankofteacher rank = (Rankofteacher)int.Parse(Console.ReadLine());
        return Teacherrank(rank);
    }
    static string Teacherrank(Rankofteacher rank)
    {
        switch (rank) 
        {
            case Rankofteacher.Dean:
                return "Dean";
                    break;
            case Rankofteacher.Headofdepartment:
                return "Headofdepartment";
                    break;
            case Rankofteacher.fulltimeteacher:
                return "Fulltimeteacher";
                    break;
            default:
                return "";
                    break;
        }
    }
    static string InputSchoolname()
    {
        Console.Write("Schoolname :");
        return Console.ReadLine();
    }
    static string Inputcar()
    {
        int car = 0; 
        Console.Write("Do you have car :");
        Console.WriteLine("Yes type 1");
        Console.WriteLine("No type 2");
        car = int.Parse(Console.ReadLine());
        if(car == 1)
        {   
            Console.WriteLine("Type your car number:");
            return Console.ReadLine();
        }
        else return "";
    }
    static string inputemail()
    {
        Console.Write("Input your email :");
        return Console.ReadLine();
    }
    static string inpassword()
    {
        Console.Write("Input your password :");
        return Console.ReadLine();
    }
    static void showloginlist()
    {
        Console.Clear();
        Console.WriteLine("Information menu");
        Console.WriteLine("---------------------------------------------------------");    
        Console.WriteLine("1. Registermenu"); 
        Console.WriteLine("2. College student ");
        Console.WriteLine("3. Student");
        Console.WriteLine("4. Teacher");
        Console.WriteLine("5. Exit");
        Console.WriteLine("---------------------------------------------------------");
        Loginlist loginlist = (Loginlist)int.Parse(Console.ReadLine());;
        inputloginlist(loginlist);
    }
    static void loginprocess()
    {
        Console.Clear();
        string key = "0";
        key = Program.emaillist.login(inputemail(),inpassword());
        if(key == "Passed")
        {
            showloginlist();
            InputmenuloginFromkeyboard();
        }
        else if (key == "e")
        {
            ToMainnologin();
        }
        else if (key == "Deninded")
        {
            Console.WriteLine("Incorrect email or password. Please try again.");
            System.Threading.Thread.Sleep(5000);
            loginprocess();
        }
    }
}