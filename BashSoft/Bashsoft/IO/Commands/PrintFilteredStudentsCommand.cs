using Bashsoft.IO.Commands;
using BashSoft.Exceptions;

namespace BashSoft
{
    internal class PrintFilteredStudentsCommand : Command
    {
        public PrintFilteredStudentsCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 5)
            {
                throw new InvalidCommandException(this.Input);
            }

            string courseName = this.Data[1];
            string filter = this.Data[2].ToLower();
            string command = this.Data[3].ToLower();
            string quantity = this.Data[5].ToLower();

            TryParseParametersFromFilterAndTak(courseName, filter, command, quantity);
        }

        private void TryParseParametersFromFilterAndTak(string courseName, string filter, string command, string quantity)
        {
            if (command == "take")
            {
                if (quantity == "all")
                {
                    this.Repository.FilterAndTake(courseName, filter);
                }
                else
                {
                    int studentsToTake;
                    bool hasParsed = int.TryParse(quantity, out studentsToTake);
                    if (hasParsed)
                    {
                        this.Repository.FilterAndTake(courseName, filter, studentsToTake);
                    }
                    else
                    {
                        throw new InvalidTakeQueryParamterException();
                    }
                }
            }
            else
            {
                throw new InvalidCommandException(command);
            }
        }
    }
}