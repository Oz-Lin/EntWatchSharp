﻿namespace EntWatchSharp.Items
{
    public class ItemConfig
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Color { get; set; }
        public int HammerID { get; set; }
        public int[] GlowColor { get; set; }
		public int FilterID { get; set; } //-hammerid of filter_*
		public string FilterValue { get; set; } //-activatorname or Context:1
		public bool BlockPickup { get; set; }
        public bool AllowTransfer { get; set; }
		public bool ForceDrop { get; set; }
		public bool Chat { get; set; }
		public bool Hud { get; set; }
		public int TriggerID { get; set; }
		public bool UsePriority { get; set; }

		public List<Ability> AbilityList { get; set; }

        public bool thisItemConfig(int iHammerID)
        {
            if (iHammerID == HammerID) return true;
            return false;
        }

        public ItemConfig()
        {
            Name = "";
            ShortName = "";
            Color = "{white}";
            HammerID = 0;
            GlowColor = [255, 255, 255, 255];
            FilterID = 0;
			FilterValue = "";
			BlockPickup = false;
			AllowTransfer = false;
			ForceDrop = false;
			Chat = false;
            Hud = false;
            TriggerID = 0;
			UsePriority = false;
			AbilityList = new List<Ability>();
        }
	}
}
