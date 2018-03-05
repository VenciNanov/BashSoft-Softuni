using Bashsoft.IO.Commands;
using BashSoft.Exceptions;

namespace BashSoft
{
    internal class ChangePathRelativelyCommand : Command
    {
        public ChangePathRelativelyCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }
            string relPath = Data[1];
            this.InputOutPutManager.ChangeCurrentDirectoryRelative(relPath);
        }
    }
}