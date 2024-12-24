using Python.Runtime;

namespace Testing;

internal class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstname, string lastname)
    {
        FirstName = firstname;
        LastName = lastname;
    }

    public string GetFullName() => FirstName + " " + LastName;
}

public static class Program
{
    public static void Main(string[] argv)
    {
        Runtime.PythonDLL = @"C:\Users\lavap\AppData\Local\Programs\Python\Python312\python312.dll";
        PythonEngine.Initialize();

        using (Py.GIL())
        {
            using (var scope = Py.CreateScope())
            {
                scope.Set("Person", PyType.Get(typeof(Person)));

                scope.Exec("print(Person('Lilith', 'Winterlight').GetFullName())");
            }
        }
    }
}
