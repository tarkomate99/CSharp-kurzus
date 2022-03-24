using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaShell.Commands
{
    [Loadable]
    internal class LsCommand : ICommand
    {
        public void Execute(IConsole console)
        {
            string mappa = Environment.CurrentDirectory;
            foreach (var file in Directory.GetFiles(mappa))
            {
                console.WriteLine(file);
            }
        }
    }
}
