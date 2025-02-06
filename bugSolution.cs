public class ExampleClass{
    public int MyProperty {get;set;}

    public void MyMethod(){
        // Initialize MyProperty before accessing it.
        MyProperty = 0; 
        int value = MyProperty; 
        Console.WriteLine(value); //This will now print 0
    }
}