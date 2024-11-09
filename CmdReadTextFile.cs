// Ninjazz
using System; 
using MCGalaxy;
public class CmdReadFromTextFile : Command 
	{ 
		public override string name { get { return "ReadFromTextFile";}}
		public override string shortcut { get { return "";}}
		public override string type { get { return "other";}}
		public override bool museumUsable { get { return true;}}

		public override void Use(Player p, string message)
		public static PlayerList credits;
		{
			PlayerList.Load("text/readthis.txt");
		}

		public override void Help(Player p) 
		{
			p.Message("Example command to make a command read data from a text file.");
		}
}