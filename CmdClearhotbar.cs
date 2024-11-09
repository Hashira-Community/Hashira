//Made by Ninjazz & Goldberg

using System;
using MCGalaxy;
using MCGalaxy.Network;

public sealed class CmdClearHotbar : Command {
        public override string name { get { return "ClearHotbar";}}
        public override string shortcut { get { return "CH";}}
        public override string type { get { return "other";}}
        public override bool museumUsable { get { return false;}}
        
        public override void Use(Player p, string message)
        {
            for (byte i = 0; i < 9; i++)
            {
                p.Session.Send(Packet.SetHotbar(0, i, false));
                //Command.Find("Hold").Use(p, "blockID") <- You can use this to make player hold a specific block from inventory.
            }
        }
        
        public override void Help(Player p)
        {
            p.Message("Clears Hotbar.");
        }
}   

//Yet to do - Run automatically when player connects, for now the map can have a air message block with command /CH or /clearhotbar. (I am too lazy :p)