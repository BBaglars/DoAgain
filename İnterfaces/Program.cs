//IntarfacesIntro();


using İnterfaces;

CustomerManager customerManager = new CustomerManager();
customerManager.Add(new OracleCustomerDal());


Console.ReadLine();

static void IntarfacesIntro()
{
    PersonManager manager = new PersonManager();
    Customer customer2 = new Customer
    {
        Id = 1,
        FirstName = "Engin",
        LastName = "Demiroğ",
        Address = "Ankara"
    };

    Student student = new Student
    {
        Id = 1,
        FirstName = "Derin",
        LastName = "Demiroğ",
        Departmant = "Computer Sciences"
    };


    manager.Add(student);
    manager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" });
    manager.Add(customer2);
    manager.Add(new Worker
    {
        Id = 1,
        FirstName = "Derin",
        LastName = "Demiroğ",
        Departmant = "Computer Sciences"
    });
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }

    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}