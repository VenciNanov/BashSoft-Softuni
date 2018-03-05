using Bashsoft.IO.Commands;
using BashSoft.Exceptions;

namespace BashSoft
{
    internal class ChangePathAbsoluteCommand : Command
    {
        public ChangePathAbsoluteCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (Data.Length!=2)
            {
                throw new InvalidCommandException(this.Input);
            }

            var absPath = this.Data[1];
            this.InputOutPutManager.ChangeCurrentDirectoryAbsolute(absPath);
        }
    }
}