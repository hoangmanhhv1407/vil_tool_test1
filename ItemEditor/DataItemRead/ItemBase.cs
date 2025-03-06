using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ItemEditor
{
    enum FameValues
    {

        [Display(Name = "None")]
        NONE = 0,
        [Display(Name = "Brave Heart")]
        GK_TITLE1,
        [Display(Name = "Noble Soul")]
        GK_TITLE2,
        [Display(Name = "Peaceful Warrior")]
        GK_TITLE3,
        [Display(Name = "Awakened Soul")]
        GK_TITLE4,
        [Display(Name = "Hero of The Land")]
        GK_TITLE5,
        [Display(Name = "Selfless One")]
        GK_TITLE6,
        [Display(Name = "Blessed by Fate")]
        GK_TITLE7,
        [Display(Name = "Destiny's Hand")]
        GK_TITLE8,
        [Display(Name = "Dweller on The Threshold")]
        GK_TITLE9,
        [Display(Name = "Seeker of Atonement")]
        GK_TITLE10,
        [Display(Name = "Good Karma")]
        GOOD_KARMA = 99,
        [Display(Name = "Dark Heart")]
        BK_TITLE1 = 101,
        [Display(Name = "Ignoble Soul")]
        BK_TITLE2,
        [Display(Name = "Savage Warrior")]
        BK_TITLE3,
        [Display(Name = "Captive Soul")]
        BK_TITLE4,
        [Display(Name = "Scar of The Land")]
        BK_TITLE5,
        [Display(Name = "Selfish Fiend")]
        BK_TITLE6,
        [Display(Name = "Cursed by Fate")]
        BK_TITLE7,
        [Display(Name = "Hell’s Pawn")]
        BK_TITLE8,
        [Display(Name = "Demon on The Threshold")]
        BK_TITLE9,
        [Display(Name = "Minion of The Damned")]
        BK_TITLE10,
        [Display(Name = "Bad Karma")]
        BAD_KARMA = 199
    }

    public abstract class ItemBase : IItem
    {
        public abstract void Load(Stream s);
        public abstract void Save(Stream s);
        public void AddToItemRankMap()
        {
            if (!ItemParser.ItemRanks.ContainsKey(ItemRank)) ItemParser.ItemRanks[ItemRank] = new List<ItemBase>();
            if (ItemParser.ItemRanks[ItemRank] == null) ItemParser.ItemRanks[ItemRank] = new List<ItemBase>(); //shouldn't happen though
            ItemParser.ItemRanks[ItemRank].Add(this);
        }

        public static void SaveMap(Map<IItem> map, Type type, ItemType itemType, Stream s)
        {

        }

        /// <summary>
        /// Contains all the objects of its type
        /// </summary>

        public static Map<ItemBase> Items { get; set; }
        public string FullName
        {
            get
            { 
                return string.Format("({0})\t{1}", ID, Name);
            }
        }
        public sbyte Type { get; set; }
        public sbyte SecondType { get; set; }
        public short ID { get; set; }
        public short ModelIndex { get; set; }
        public short IconIndex { get; set; }
        public ushort ItemRank { get; set; }
        public byte Grade { get; set; }
        public byte Quality { get; set; }
        public byte Quality2 { get; set; }
        public uint Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool BlockDrop { get; set; }
        public bool BlockStorage { get; set; }
        public bool CanNPC {get{return !BlockNpcSell;}}
        public bool CanTrade {get{return !Convert.ToBoolean(BlockTrade);}}
        public sbyte CashCheck { get; set; }
        public short Time { get; set; }
        public sbyte ApplyClan { get; set; }
        public int ClanPoint1 { get; set; }
        public int ClanPoint2 { get; set; }
        public byte Fame { get; set; }
        public uint XsdName { get; set; }
        public uint XsdItemInfo { get; set; }

        public List<byte> unknownBytes = new List<byte>();

        #region Fields

        //protected sbyte Type;
        //protected sbyte SecondType;
        //protected short ID;
        //protected short ModelIndex;
        //protected short IconIndex;
        //protected ushort ItemRank;
        //protected sbyte ApplyClan;
        //protected int ClanPoint1; //
        //protected int ClanPoint2; //other clans
        //protected byte Grade;
        //protected byte Quality;
        //protected byte Quality2;
        //protected uint Price;
        //protected string Name = "";
        //protected string Description;
        //protected bool BlockDrop;
       public byte BlockTrade;
      public bool BlockNpcSell;
        //protected bool BlockStorage;
        //protected sbyte CashCheck; //wtf
        //protected short Time;
        //protected byte Fame;
        #endregion

    }
}
