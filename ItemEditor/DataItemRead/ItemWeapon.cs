using ItemEditor.XStringDatabase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemEditor
{
    #region Weapon Types enums
    enum WeaponSecondType
    {
        SHORT = 0,           
        LONG,                
        SOFT,                
        HIDDEN,              
        MUSICAL,             
        SPECIAL
    }

    enum ThirdTypeWeaponShort
    {
        SWORD = 0,           
        SABER,               
        STAFF,                
        HIT,
        GLOVES,                
        DAGGER,              
        AXE,
        WHEELS
    }

    enum ThirdTypeWeaponLong
    {
        GLAIVE = 0,          
        SPEAR,
        POLEARM,				
    }

    enum ThirdTypeWeaponSoft
    {
        STEELWHIP = 0,       
        HAMMER,              
        CHAIN                
    }

    enum ThirdTypeWeaponHidden
    {
        DART = 0,            
        DAGGER,              
        JAVELIN,             
        NEEDLE,              
        ARROWLAUNCHER,       
        MINE                 
    }

    enum ThirdTypeWeaponMusical
    {
        RYUNG = 0,           
        GO,                  
        SO,                  
        KUEM,                
        JUCK                 
    }

    enum ThirdTypeWeaponSpecial
    {
        BRACERS = 0               
    }
    #endregion

    class Effect
    {
        public Effect()
        {

        }
        public Effect(Effect e)
        {
            /*
            this.id = e.id;
            this.value = e.value;
            this.prob = e.prob;
            this.type = e.type;
            this.per = e.per;
            this.name = e.name;*/
            MemberwiseClone();
        }

        public void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            ID = br.ReadUInt16();
            Value = br.ReadUInt16();
            Prob = br.ReadByte();
            Type = br.ReadByte();
            Per = br.ReadUInt16();
            Name = XsdManager.GetInfoFrom("EffectsName", ID);
            Desc = XsdManager.GetInfoFrom("EffectsInfo", ID);
        }

        public void Save(Stream s)
        {
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(ID);
            bw.Write(Value);
            bw.Write(Prob);
            bw.Write(Type);
            bw.Write(Per);
        }

        public ushort ID { get; set; }

        public ushort Value { get; set; }
        
        public string Description
        {
            get
            {
                if (ID == 0 || string.IsNullOrWhiteSpace(Desc)) return "";
                string s = "";
                s = Desc.Replace("%d", "{0}").Replace("%%", "%");

                return string.Format(s, Value);
            }
        }

        public string Name { get; set; }

        //internal ushort ID;
        //internal ushort Value;
        public byte Prob { get; set; } 
        public byte Type { get; set; }
        public ushort Per { get; set; }
        public string Desc;

        
    }

    class Special
    {
        public Special()
        {

        }
        public Special(Special s)
        {
            MemberwiseClone();
        }

        public ushort ID
        {
            get { return id; }
            set { id = value; }
        }
        public byte Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public ushort Time
        {
            get { return time; }
            set { this.time = value; }
        }
        public byte Type
        {
            get { return type; }
            set { this.type = value; }
        }
        public ushort Prob
        {
            get { return prob; }
            set { prob = value; }
        }

        internal ushort id;
        internal ushort time;
        internal byte value;
        internal byte type;
        internal ushort prob;

        public void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            id = br.ReadUInt16();
            time = br.ReadUInt16();
            value = br.ReadByte();
            type = br.ReadByte();
            prob = br.ReadUInt16();
        }

        public void Save(Stream s)
        {
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(id);
            bw.Write(time);
            bw.Write(value);
            bw.Write(type);
            bw.Write(prob);
            //bw.Close(); //?
        }
    }

    class VectorPos
    {
        public VectorPos()
        {

        }
        public VectorPos(VectorPos v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        internal float x;
        internal float y;
        internal float z;
        public void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            x = br.ReadSingle();
            y = br.ReadSingle();
            z = br.ReadSingle();
        }

        public void Save(Stream s)
        {
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(x);
            bw.Write(y);
            bw.Write(z);
        }
    }

    class ItemWeapon : ItemBase
    {
        public ItemWeapon()
        {
            
        }
        public ItemWeapon(ItemWeapon w)
        {
            Type = w.Type;
            SecondType = w.SecondType;
            //XSD stuff
            xsdNick = w.xsdNick;
            xsdAddTo = w.xsdAddTo;
            xsdName = w.xsdName;
            xsdItemInfo = w.xsdItemInfo;
            //
            thirdType = w.thirdType;
            //stats
            minDmg = w.minDmg;
            maxDmg = w.maxDmg;
            durabiliy = w.durabiliy;
            balance = w.balance;
            attackRate = w.attackRate;
            critRate = w.critRate;
            hardness = w.hardness;
            ApplyClan = w.ApplyClan;
            ClanPoint1 = w.ClanPoint1;
            ClanPoint2 = w.ClanPoint2;
            level = w.level;
            mainStat = w.mainStat;
            secondaryStat = w.secondaryStat;
            Price = w.Price;
            rank = w.rank;
            hiddenID = w.hiddenID;
            sockets = w.sockets;
            CashCheck = w.CashCheck;
            Time = w.Time;
            ModelIndex = w.ModelIndex;
            IconIndex = w.IconIndex;
        vecItemPosition = new VectorPos[4];
            for (int i = 0; i < 4; i++) vecItemPosition[i] = new VectorPos(w.vecItemPosition[i]);
        effects = new Effect[5];
            for (int i = 0; i < 5; i++) effects[i] = new Effect(w.effects[i]);
        specials = new Special[4];
            for (int i = 0; i < 4; i++) specials[i] = new Special(w.specials[i]);
            reduceLevel = w.reduceLevel;
            BlockNpcSell = w.BlockNpcSell;
            BlockTrade = w.BlockTrade;
            BlockStorage = w.BlockStorage;
            maxSlots = w.maxSlots;
            statTrade = w.statTrade;
            unknownBytes = w.unknownBytes.ToList();

            switch (Type)
            {
                case (int)ItemType.WEAPON:
                    {
                        ID = ItemWeapon.mapWeapons.Keys.Max();
                        ItemWeapon.mapWeapons.Add(++ID, this);
                        break;
                    }
                case (int)ItemType.WEAPON2:
                    {
                        ID = ItemWeapon.mapWeapons2.Keys.Max();
                        ItemWeapon.mapWeapons2.Add(++ID, this);
                        break;
                    }
                case (int)ItemType.WEAPON3:
                    {
                        ID = ItemWeapon.mapWeapons3.Keys.Max();
                        ItemWeapon.mapWeapons3.Add(++ID, this);
                        break;
                    }
            }
        }


        #region XSD Stuff

        #endregion

        public static uint Size 
        {
            get
            {
                return 226;
            }
        }
        //public static uint Size {get{return 0xe2;}}
        public static Map<ItemWeapon> Weapons {get{return mapWeapons;}}
        public static Map<ItemWeapon> Weapons2 {get{return mapWeapons2;}}
        public static Map<ItemWeapon> Weapons3 {get{return mapWeapons3;}}

        static Map<ItemWeapon> mapWeapons = new Map<ItemWeapon>();
        static Map<ItemWeapon> mapWeapons2 = new Map<ItemWeapon>();
        static Map<ItemWeapon> mapWeapons3 = new Map<ItemWeapon>();


        public override void Load(Stream s)
        {
            if (XsdManager.WeaponInfo.Count == 0) XsdManager.GetDataTo(XsdManager.WeaponInfo, "ItemTable_SeedInfoWeapon");
            if (XsdManager.WeaponNames.Count == 0) XsdManager.GetDataTo(XsdManager.WeaponNames, "ItemTable_SeedWeapon");
            if (XsdManager.AddTos.Count == 0) XsdManager.GetDataTo(XsdManager.AddTos, "ItemTable_AddTo");
            if (XsdManager.Nicknames.Count == 0) XsdManager.GetDataTo(XsdManager.Nicknames, "ItemTable_Nickname");
            if (XsdManager.EffectsName.Count == 0) XsdManager.GetDataTo(XsdManager.EffectsName, "CharacterState_name");
            if (XsdManager.EffectsInfo.Count == 0) XsdManager.GetDataTo(XsdManager.EffectsInfo, "CharacterState_info");

            BinaryReader br = new BinaryReader(s);
            Type = br.ReadSByte();
            SecondType = br.ReadSByte();
            ID = br.ReadInt16();
            xsdNick = br.ReadUInt16();
            xsdAddTo = br.ReadUInt16();
            xsdName = br.ReadUInt32();
            
            thirdType = br.ReadSByte();
            xsdItemInfo = br.ReadUInt32();

            //set weapon info
            if (XsdManager.WeaponNames.ContainsKey((int)xsdName))
                Name = XsdManager.WeaponNames[(int)xsdName];

            if (XsdManager.WeaponInfo.ContainsKey((int)xsdItemInfo))
                Description = XsdManager.WeaponInfo[(int)xsdItemInfo];

            if (XsdManager.AddTos.ContainsKey((int)xsdAddTo))
               AddTos = XsdManager.AddTos[(int)xsdAddTo];

            if (XsdManager.Nicknames.ContainsKey((int)xsdNick))
                Nicknames = XsdManager.Nicknames[(int)xsdNick];
            //

            minDmg = br.ReadInt16();
            maxDmg = br.ReadInt16();
            durabiliy = br.ReadUInt16();
            balance = br.ReadSByte();
            attackRate = br.ReadSByte();
            critRate = br.ReadInt16();

            unknownBytes.AddRange(br.ReadBytes(3)); //3
            //unknown1 = br.ReadSByte();
            //tears = br.ReadSByte();
            //unknown2 = br.ReadSByte();
            hardness = br.ReadSByte();
            level = br.ReadInt16();
            mainStat = br.ReadInt16();
            secondaryStat = br.ReadInt16();
            unknownBytes.AddRange(br.ReadBytes(6)); //9
            ApplyClan = br.ReadSByte();
            ClanPoint1 = br.ReadInt32();
            ClanPoint2 = br.ReadInt32();
            Price = br.ReadUInt32();
            
            unknownBytes.AddRange(br.ReadBytes(4)); //13
            rank = br.ReadSByte();
            hiddenID = br.ReadInt16();
            unknownBytes.AddRange(br.ReadBytes(2)); //15
            sockets = br.ReadByte();
            unknownBytes.Add(br.ReadByte()); //16
            ModelIndex = br.ReadInt16();
            IconIndex = br.ReadInt16();
            unknownBytes.AddRange(br.ReadBytes(6)); //22
            Grade = br.ReadByte();
            unknownBytes.AddRange(br.ReadBytes(2)); //25
            
            for(int i=0; i<4; ++i)
            {
                vecItemPosition[i] = new VectorPos();
                vecItemPosition[i].Load(new MemoryStream(br.ReadBytes(12)));
            }
            for (int i = 0; i < 5; ++i)
            {
                effects[i] = new Effect();
                effects[i].Load(new MemoryStream(br.ReadBytes(8)));

            }
            for (int i = 0; i < 4; i++)
            {
                specials[i] = new Special();
                specials[i].Load(new MemoryStream(br.ReadBytes(8)));
            }
            unknownBytes.AddRange(br.ReadBytes(2)); //28
            BlockDrop = br.ReadBoolean();
            BlockTrade = br.ReadByte();
            BlockNpcSell = br.ReadBoolean();
            unknownBytes.AddRange(br.ReadBytes(7)); //35
            CashCheck = br.ReadSByte();
            Time = br.ReadInt16();
            BlockStorage = br.ReadBoolean();
            unknownBytes.AddRange(br.ReadBytes(4)); //39
            maxSlots = br.ReadByte();
            unknownBytes.Add(br.ReadByte());        //40
            reduceLevel = br.ReadByte();
            unknownBytes.AddRange(br.ReadBytes(3)); //43
         }

        public override void Save(Stream s)
        {
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(Type);
            bw.Write(SecondType);
            bw.Write(ID);
            bw.Write(xsdNick);
            bw.Write(xsdAddTo);
            bw.Write(xsdName);
            bw.Write(thirdType);
            bw.Write(xsdItemInfo);
            bw.Write(minDmg);
            bw.Write(maxDmg);
            bw.Write(durabiliy);
            bw.Write(balance);
            bw.Write(attackRate);
            bw.Write(critRate);

            int currIdx = 0;
            bw.Write(unknownBytes.ToArray(), currIdx, 3);
            currIdx += 3;
            bw.Write(hardness);
            bw.Write(level);
            bw.Write(mainStat);
            bw.Write(secondaryStat);
            bw.Write(unknownBytes.ToArray(), currIdx, 6);
            currIdx += 6;
            bw.Write(ApplyClan);
            bw.Write(ClanPoint1);
            bw.Write(ClanPoint2);
            bw.Write(Price);
            bw.Write(unknownBytes.ToArray(), currIdx, 4);
            currIdx += 4;
            bw.Write(rank);
            bw.Write(hiddenID);
            bw.Write(unknownBytes.ToArray(), currIdx, 2);
            currIdx += 2;
            bw.Write(sockets);
            bw.Write(unknownBytes.ToArray(), currIdx, 1);
            currIdx += 1;
            bw.Write(ModelIndex);
            bw.Write(IconIndex);
            bw.Write(unknownBytes.ToArray(), currIdx, 6);
            currIdx += 6;
            bw.Write(Grade);
            bw.Write(unknownBytes.ToArray(), currIdx, 2);
            currIdx += 2;

            for (int i = 0; i < 4; ++i)
            {
                vecItemPosition[i].Save(s);
            }
            for (int i = 0; i < 5; ++i)
            {
                effects[i].Save(s);

            }
            for (int i = 0; i < 4; i++)
            {
                specials[i].Save(s);
            }

            bw.Write(unknownBytes.ToArray(), currIdx, 2);
            currIdx += 2;
            bw.Write(BlockDrop);
            bw.Write(BlockTrade);
            bw.Write(BlockNpcSell);
            bw.Write(unknownBytes.ToArray(), currIdx, 7);
            currIdx += 7;
            bw.Write(CashCheck);
            bw.Write(Time);
            bw.Write(BlockStorage);
            bw.Write(unknownBytes.ToArray(), currIdx, 4);
            currIdx += 4;
            bw.Write(maxSlots);
            bw.Write(unknownBytes.ToArray(), currIdx, 1);
            currIdx += 1;
            bw.Write(reduceLevel);
            bw.Write(unknownBytes.ToArray(), currIdx, 3);
            currIdx += 3;
        }

        #region ItemWeapon fields

        //XSD stuff
        public ushort xsdNick;
        public ushort xsdAddTo;
        public uint xsdName;
        uint xsdItemInfo;
        //
        public sbyte thirdType;
        //stats
        public short minDmg;
        public short maxDmg;
        public ushort durabiliy;
        public sbyte balance;
        public sbyte attackRate;
        public short critRate;

        //sbyte unknown1;
        //public sbyte tears;
        //sbyte unknown2;
        public sbyte hardness;
        //public byte clan;
        public short level;
        public short mainStat;
        public short secondaryStat;
        //public uint price;
        public sbyte rank;
        public short hiddenID;
        public byte sockets;
        
        //public short time;
        //public short modelIndex;
        //public short iconIndex;
        public VectorPos[] vecItemPosition = new VectorPos[4];
        public Effect[] effects = new Effect[5];
        public Special[] specials = new Special[4];
        public byte reduceLevel; //or short maybe
        //public bool cantNPC;
        //public bool cantTrade; //stand
        //public bool cantStorage;
        public byte maxSlots;
        public bool statTrade;
        #endregion

        #region Data from XSD
        public new string FullName
        {
            get
            {
                return string.Format("({0})\t", this.ID)
                    + (string.IsNullOrEmpty(AddTos) || AddTos == "null" ? "" : AddTos + ' ')
                    + (string.IsNullOrEmpty(Nicknames) || Nicknames == "null" ? "" : Nicknames + ' ')
                    + Name;
            }
        }

        public string Nicknames;
        public string AddTos;

        #endregion


        //public List<byte> unknownBytes = new List<byte>();
    }
}
