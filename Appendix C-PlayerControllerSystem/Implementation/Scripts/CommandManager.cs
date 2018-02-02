using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerControllerSystem
{
    class CommandManager
    {
        private static CommandManager instance;

        public static CommandManager Instance()
        {
            if (instance==null)
            {
                instance = new CommandManager();
            }

            return instance;
        }

        List<ICommand> commandList = new List<ICommand>();

        public void AddNewCommand(ICommand newCommand)
        {
            commandList.Add(newCommand);
        }

        public void ExecuteCommand(KeyCodes key)
        {
            foreach (var temp in commandList)
            {
                Command tempCommand = (Command)temp;

                if (tempCommand.Key==key)
                {
                    temp.Execute();
                }
            }
        }
    }
}
