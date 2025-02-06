public class ExampleClass{
    public int MyProperty {get;set;}

    public void MyMethod(){
        // Accessing a property that hasn't been initialized will lead to an error.
        int value = MyProperty; 
        // The below code is unreachable since the above line throws an exception.
        Console.WriteLine("This line will not be reached.");
    }
}