//reference System.Core.dll
//Made by Ninjazz
using System;
using System.Linq;
using System.IO;
using MCGalaxy; 
using MCGalaxy.Commands; 

public sealed class CmdScramble : Command {
    
    public override string name { get { return "Scramble";}}

	public override string shortcut { get { return "";}}

	public override string type { get { return "other";}}
    
    public override void Use(Player p, string message) { 
        
        	string[] args = message.SplitSpaces();
        
        	string filePath = "scrambledwords.txt";
            string[] lines = File.ReadAllLines(filePath);
            Random random = new Random();
            int index = random.Next(lines.Length); 
        	string randomLine = lines[index];
        
        	string filePath2 = "unscrambledwords.txt";
            string[] lines2 = File.ReadAllLines(filePath2);
            Random random2 = new Random();
            int index2 = random2.Next(lines2.Length); 
        	string randomLine2 = lines2[index2];
        
        	if (args[0] == "") {
				p.Message("Your word is : %a" + randomLine);
            }
        
        	else if (lines2.Contains(args[0])) 
                {
                    p.Message("%aYou UnScrambled the word! :D");
				}
        
            else 
            	{
                	p.Message("%cThe word '" + args[0] + "' is not the UnScrambled word. Please try again.");
            	}
    	}
    	public override void Help(Player p)
    	{
       		p.Message("/Scramble to get a scrambled word.");
            p.Message("%a/Scramble <Your guess> %7to see if you unscrambled the word correctly or not.");
    	}
}
/* To make this command work, make 2 text files, scrambledwords.txt and unscrambledwords.txt in home/container/ 
Now type 1 scrambled words on each line do same with unscrambeled words.
Now compile the command using "/Compile scramble"
Load the command using "/CmdLoad scramble"
Now its ready to use! 
If any error occurs or for any queries, contact _ninjazzhere_ on discord. 
*/ 

