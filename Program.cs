namespace Global
{
    namespace System
    {
        public class MyClass
        {
            public void SomeMethod()
            {
                Console.WriteLine("Hello from Global::System.MyClass");
            }
        }
    }
}

namespace MyNamespace
{
    using Global::System;

    public class Program
    {
        public static void Main()
        {
            MyClass myObject = new MyClass();
            myObject.SomeMethod(); // Accessing Global::System.MyClass
        }
    }
}
