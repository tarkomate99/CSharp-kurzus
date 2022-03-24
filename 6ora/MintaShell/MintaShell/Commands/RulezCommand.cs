using System;

namespace MintaShell.Commands
{
    internal class RulezCommand : ICommand
    {
        public void Execute(IConsole console)
        {
            console.WriteLine("Reflection rulez!4!");
        }
    }
}
