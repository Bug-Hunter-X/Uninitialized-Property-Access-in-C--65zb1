public class ExampleClass{
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Initialize the property before use.
        this.MyProperty = 0; // Initialize MyProperty
        int value = this.MyProperty * 2; 
    }

    public ExampleClass() { // Constructor to initialize the property
        MyProperty = 10; 
    }
}