using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoRedoWithCommand.Commands
{
    public class InvokerEditText
    {

        
        List<Command> commands = new List<Command>();
        int current = 0;
        private Command _command;
        public InvokerEditText(Command command)
        {
            _command = command;
        }
        public string ExecuteCommand(string input)
        {
           
            string result = _command.Execute(input);

            commands.Add(_command);
            current++;

            return result;
        }
        public string Undo()
        {
            Command command = commands[--current];
            return command.UnExecute(command.CurrentInput);
        }
        public string Redo()
        {
            Command command = commands[current++];
            return command.Execute(command.CurrentInput);
        }
    }
}
