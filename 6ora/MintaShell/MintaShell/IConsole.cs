namespace MintaShell
{
    internal interface IConsole
    {
        //Write("hello");
        //Write("Hello {0}", valami);
        void Write(string format, params object[] args);
        void WriteLine(string format, params object[] args);
        string ReadLine();
    }
}
