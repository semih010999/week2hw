using week1hw;

partial class Program
{
    public static void Main()
    {
        Employee employee = new Employee(1,"semih","eseroglu");
        Employee employee2 = new Employee(2, "hunkar", "acar");

        Console.WriteLine(employee);
        AddRemove addremove = new AddRemove();

        addremove.AddEmp(employee);
        addremove.AddEmp(employee2);


        Console.WriteLine(addremove.ReadId(1));

        Console.WriteLine(addremove);

    }
}