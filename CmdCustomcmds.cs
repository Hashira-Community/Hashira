//Made by Ninjazz
//reference System.Core.dll
using System;
using MCGalaxy;
using MCGalaxy.Commands;
using System.IO;
using System.Collections.Generic;

namespace MCGalaxy 
{
    public sealed class CmdCustomCommands : Command 
    {
        public override string name { get { return "CustomCommands";}}
        public override string shortcut { get { return "ccmds";}}
        public override string type { get { return "information";}}
        public override CommandAlias[] Aliases {
            get { return new CommandAlias[] { new CommandAlias("Commands"), new CommandAlias("cmds") }; }
		}
        public override void Use(Player p, string message) 
        {
        	string path = "./text/ccmds.txt";
            string[] args = message.SplitSpaces();
            if (message.Length == 0)
            {
                string[] ccmds = File.ReadAllLines(path); 
                foreach (string ccmd in ccmds) {
                p.Message(ccmd);
                }

                if (ccmds.Length == 0)
                {
                    p.Message("There are no Custom Commands in the Ccmds list.");
                    return;
                }
            }    
        }
        public override void Help(Player p)
        {
            p.Message("%b/Commands : %3Shows a list of Commands..");
            p.Message("Shortcut: /cmds");
        }
    }
}
/*
To make this work you need to goto " file > properties > server.properties > disabled-commands = " and type commands " disabled-commands = commands  "
Then compile and load this, restart the server.
Also you have to make a text file which lists every commands you want player to show, this is basically to decorate the server a bit if you are making a minigame server.
*/