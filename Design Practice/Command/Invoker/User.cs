using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Command.ConcreteCommand;
using Command.Receiver;

namespace Command.Invoker
{
    class User
    {
        private Calculator _calculator = new Calculator();
        private List<Commands.Command> _commands = new List<Commands.Command>();
        private int _current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);

            //perform redo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count-1)
                {
                    Commands.Command command = _commands[_current++];
                    command.Execute();
                }
                
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    Commands.Command command = _commands[--_current] as Commands.Command;
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            Commands.Command command = new CalculatorCommand(_calculator, @operator, operand);
            command.Execute();

            // Add command to undo list
            _commands.Add(command);
            _current++;
        }
    }
}
