﻿using Newtonsoft.Json.Linq;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
    //When Written: when selling a module in outfitting
    //Parameters:
    //•	Slot
    //•	SellItem
    //•	SellPrice
    //•	Ship
    public class JournalModuleSellRemote : JournalEntry
    {
        public JournalModuleSellRemote(JObject evt) : base(evt, JournalTypeEnum.ModuleSellRemote)
        {
            Slot = Tools.GetStringDef(evt["StorageSlot"]);
            SellItem = Tools.GetStringDef(evt["SellItem"]);
            SellPrice = Tools.GetInt(evt["SellPrice"]);
            Ship = Tools.GetStringDef(evt["Ship"]);
            ShipId = Tools.GetInt(evt["ShipID"]);
            ServerId = Tools.GetInt(evt["ServerId"]);
        }
        public string Slot { get; set; }
        public string SellItem { get; set; }
        public int SellPrice { get; set; }
        public string Ship { get; set; }
        public int ShipId { get; set; }
        public int ServerId { get; set; }
        public override string DefaultRemoveItems()
        {
            return base.DefaultRemoveItems() + ";ShipID;ServerID";
        }
        public static System.Drawing.Bitmap Icon { get { return EDDiscovery.Properties.Resources.modulesell; } }

    }
}