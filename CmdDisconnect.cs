// Made by Ninjazz

using System;
using MCGalaxy;
using MCGalaxy.Commands;

namespace MCGalaxy 
{
	public class Disconnect : Command {
		public override string name { get { return "Disconnect";}}
		public override string shortcut { get { return "dc";}}
		public override string type { get { return "fun";}}
		public override bool museumUsable { get { return true;}}
		
		public override void Use(Player p, string message) 
		{
			
			string[] args = message.SplitSpaces();
			string fullname = p.color + p.truename;
			
			if (args[0] == "") Command.Find("quit");
			
			if (args[0] == "rage") {
				p.Leave(fullname + "%3 did the classic ragequit!");
				return;
			}
			
			if (args[0] == "bored") {
				p.Leave(fullname + "%3 was so bored they decided to disconnect...");
				return;
			}
			
			if (args[0] == "fancy") {
				p.Leave(fullname + "%3 disconnected in a fancy way ~~~");
				return;
			}
			
			if (args[0] == "dramatic") {
				p.Leave(fullname + "%3 did the dramatic disconnect...");
				return;
			}
			
			else { p.Leave(fullname + "%3 bro couldn't even disconnect properly what a loser."); }
		}
		public override void Help(Player p)
		{
			p.Message("%aDisconnect <Type> : %3Custom disconnect message.");
			p.Message("%3Valid Types are %arage%3, %abored%3, %afancy%3, %adramatic%3.");
			p.Message("%3If you leave %a<Types> %3empty it will show default disconnect message.");
			p.Message("%3But if you mispelled the %a<type> %3then...");
		}
	}
}