// Using the generic class
MyGenericClass<int> intInstance = new MyGenericClass<int>(42);
int result = intInstance.GenericMethod(10);
Console.WriteLine("Returned value: " + result);

MyGenericClass<string> stringInstance = new MyGenericClass<string>("Hello");
string result2 = stringInstance.GenericMethod("World");
Console.WriteLine("Returned value: " + result2);

// Using the generic method
int intResult = GenericMethod<int>(5);
Console.WriteLine("Returned value: " + intResult);

string stringResult = GenericMethod<string>("Hello");
Console.WriteLine("Returned value: " + stringResult);

// Example of a generic method
T GenericMethod<T>(T argument)
{
    Console.WriteLine("Generic method called with argument: " + argument);
    return argument;
}


// Example of a generic class
class MyGenericClass<T>
{
    private T genericField;

    public MyGenericClass(T value)
    {
        genericField = value;
    }

    public T GenericMethod(T argument)
    {
        Console.WriteLine("Generic method called with argument: " + argument);
        return genericField;
    }
}




