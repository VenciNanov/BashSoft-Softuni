using Bashsoft.IO.Commands;
using BashSoft.Exceptions;

namespace BashSoft
{
    internal class MakeDirectoryCommand : Command
    {
        public MakeDirectoryCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }
            string folderName = this.Data[1];
            this.InputOutPutManager.CreateDirectoryInCurrentFolder(folderName);
        }
    }
}