using BashSoft;
using BashSoft.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bashsoft.IO.Commands
{
    public abstract class Command
    {
        private string input;
        private string[] data;

        private Tester judge;
        private StudentsRepository repository;
        private IOManager inputOutputManager;

        public Command(string input,string[] data,Tester judge,StudentsRepository repository,IOManager inputOutputManager)
        {
            this.Input = input;
            this.Data = data;
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }

        public IOManager InputOutPutManager
        {
            get { return inputOutputManager; }
        }

        public StudentsRepository Repository
        {
            get { return repository; }
        }

        public Tester Judge
        {
            get { return this.judge; }
        }

        public string[] Data
        {
            get { return data; }
            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new NullReferenceException();
                }
                data = value;
            }
        }


        public string Input
        {
            get { return input; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }

                input = value;
            }
        }

        public abstract void Execute();
    }
}
