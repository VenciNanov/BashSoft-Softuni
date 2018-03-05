using System;
using System.Collections.Generic;
using System.Text;
using BashSoft;

namespace Bashsoft.IO.Commands
{
    internal class CloseConsoleCommand : Command
    {
        public CloseConsoleCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}
