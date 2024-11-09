//Made by Ninjazz 

using System;
using MCGalaxy;
namespace MCGalaxy
{
	public sealed class CmdMaths : Command
	{
		public override string name { get { return "Maths";}}
		public override string shortcut { get { return "";}}
		public override string type { get { return "information";}}
		public override bool museumUsable { get { return true;}}
		
		public override void Use(Player p, string message)
		{
			string[] args = message.SplitSpaces();
			if (args[0] == "add"){
				int num1, num2;
				int.TryParse(args[1], out num1);
				int.TryParse(args[2], out num2);
				int result = num1 + num2;
				p.Message("Answer: " + result);
			}
			if (args[0] == "subtract"){
				int num1, num2;
				int.TryParse(args[1], out num1);
				int.TryParse(args[2], out num2);
				int result = num1 - num2;
				p.Message("Answer: " + result);
			}
			if (args[0] == "multiply"){
				int num1, num2;
				int.TryParse(args[1], out num1);
				int.TryParse(args[2], out num2);
				int result = num1 * num2;
				p.Message("Answer: " + result);
			}
			if (args[0] == "divide"){
				int num1, num2;
				int.TryParse(args[1], out num1);
				int.TryParse(args[2], out num2);
				double result = num1 / num2;
				p.Message("Answer: " + result);
			}
     	}       
		public override void Help(Player p)
		{
			p.Message("/Maths <Digit or Number> <1st Digit or Number> <2nd Digit or Number>");
            p.Message("Mode can be add, subtract, multiply, divide.");
		}
	}
}