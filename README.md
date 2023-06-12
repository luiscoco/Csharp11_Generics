# Csharp2_Generics

Generics in C# allow you to create classes, interfaces, and methods that can work with various data types without sacrificing type safety. They provide a way to define placeholders for types that are determined at compile time, enabling code reuse and ensuring type safety at the same time.

Here's an example to illustrate how generics work in C#:

```csharp
// Example of a generic class
public class MyGenericClass<T>
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

// Example of a generic method
public T GenericMethod<T>(T argument)
{
    Console.WriteLine("Generic method called with argument: " + argument);
    return argument;
}
```

In the above code, we have a generic class called MyGenericClass that has a type parameter T. The constructor and GenericMethod both use this type parameter. The MyGenericClass can be instantiated with any type, and the type safety is maintained because the actual type is determined when creating an instance of the class.

Here's an example of how you can use the generic class and method:

```csharp
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
```

In this example, we create instances of MyGenericClass with different type arguments (int and string) and call the GenericMethod with different arguments and return types. The generic method is also invoked with specific type arguments (int and string).

Generics in C# provide flexibility and code reuse by allowing you to write classes and methods that can work with multiple types, promoting type safety and reducing code duplication.

