using System;

namespace MessageBoxExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MessageBoxWrapper.ShowMessageBox("Hello World 3.0", "Hello", MessageBoxType.CancelTryContinue, MessageBoxIcon.Information);
        }
    }
}
