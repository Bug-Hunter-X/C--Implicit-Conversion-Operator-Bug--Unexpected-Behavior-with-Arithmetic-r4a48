public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 10; // Implicit conversion from int to MyClass
        int value1 = obj1; // Implicit conversion from MyClass to int

        MyClass obj2 = new MyClass(20);
        MyClass obj3 = obj2 + 5; // Implicit conversion from int to MyClass, then addition, resulting in a new MyClass object

        Console.WriteLine(obj1); // Output: 10
        Console.WriteLine(value1); // Output: 10
        Console.WriteLine(obj3); // Output: 25
    }
}