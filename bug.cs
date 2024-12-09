public class ExampleClass{
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property before it's initialized leads to unpredictable behavior.
        int value = this.MyProperty * 2; // Bug: potential use of uninitialized property
    }
}