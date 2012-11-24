using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEB.Utils.WinKeys.Model
{
    abstract class CommandInitialiser
    {
        public static Command[] LoadCommands()
        {
            return new Command[] {new Command() {Action = "Desktop", Key = 'D'}, new Command {Action = "Explorer", Key = 'E'}};
        }
    }
}
