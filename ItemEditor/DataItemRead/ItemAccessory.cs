using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    enum AccessorySecondType
    {
        RING = 0,         
        CHARM = 1,            
        BACKPACK = 2,         
        NECKLACE = 3,         
        EARRING = 4,          

        STRENGTH = 11,    
        CONSTITUTION = 12,     
        ESS = 13,              
        WIS = 14,              
        DEX = 15,              

        ARMOR_MULTI = 50, 
        ARMOR = 51
    }
    class ItemAccessory : ItemBase
    {
        static uint XSD_START_INDEX = 45000;
        public override void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            Type = br.ReadSByte();
            SecondType = br.ReadSByte();
            ID = br.ReadInt16();
            ModelIndex = br.ReadInt16();
            IconIndex = br.ReadInt16();
            ItemRank = br.ReadUInt16();
            group = br.ReadInt16();
            itemCase = br.ReadInt16();
            Grade = br.ReadByte();
            xsdInfo = br.ReadUInt32();
            xsdName = br.ReadUInt32();

            //
            xsdName -= XSD_START_INDEX;
            xsdInfo -= XSD_START_INDEX;
            //

            int key = (int)(xsdName);
            if (XsdManager.Maps["AccessoryName"].Count == 0) XsdManager.GetDataTo(XsdManager.Maps["AccessoryName"], XsdManager.TableNames["AccessoryName"]);
            if (XsdManager.Maps["AccessoryInfo"].Count == 0) XsdManager.GetDataTo(XsdManager.Maps["AccessoryInfo"], XsdManager.TableNames["AccessoryInfo"]);
            if (XsdManager.Maps["AccessoryName"].ContainsKey(key))
            {
                Name = XsdManager.Maps["AccessoryName"][key];
            }
            key = (int)xsdInfo;
            if (XsdManager.Maps["AccessoryInfo"].ContainsKey(key))
            {
                Description = XsdManager.Maps["AccessoryInfo"][key];
            }
            pack = br.ReadSByte();
            clan = br.ReadSByte();
            rank = br.ReadSByte();
            durability = br.ReadUInt16();
            Quality = br.ReadByte();
            Quality2 = br.ReadByte();

            //effects
            if (XsdManager.EffectsName.Count == 0) XsdManager.GetDataTo(XsdManager.EffectsName, "CharacterState_name");
            if (XsdManager.EffectsInfo.Count == 0) XsdManager.GetDataTo(XsdManager.EffectsInfo, "CharacterState_info");
            for (int i = 0; i < 5; ++i)
            {
                effects[i] = new Effect();
                effects[i].Load(new MemoryStream(br.ReadBytes(8)));
                if (XsdManager.EffectsInfo.ContainsKey(effects[i].ID))
                {
                    effects[i].Desc = XsdManager.EffectsInfo[effects[i].ID];
                }
                if (XsdManager.EffectsName.ContainsKey(effects[i].ID))
                {
                    effects[i].Name = XsdManager.EffectsName[effects[i].ID];
                }
            }
            //

            requiredLevel = br.ReadInt16();
            requiredDex = br.ReadInt16();
            requiredStr = br.ReadInt16();
            requiredCon = br.ReadInt16();
            requiredEss = br.ReadInt16();
            requiredWis = br.ReadInt16();

            ApplyClan = br.ReadSByte();
            ClanPoint1 = br.ReadInt32();
            ClanPoint2 = br.ReadInt32();
            Price = br.ReadUInt32();
            for (int i = 0; i < 4; i++)
            {
                specials[i] = new Special();
                specials[i].Load(new MemoryStream(br.ReadBytes(8)));
            }
            unknownBytes.AddRange(br.ReadBytes(8));
            maxSocket = br.ReadByte();
            itemSet = br.ReadInt16();
            BlockDrop = br.ReadBoolean();
            BlockTrade = br.ReadByte();
            BlockNpcSell = br.ReadBoolean();
            Fame = br.ReadByte();
            unknownBytes.AddRange(br.ReadBytes(6));
            CashCheck = br.ReadSByte();
            Time = br.ReadInt16();
            BlockStorage = br.ReadBoolean(); //to test
            unknownBytes.AddRange(br.ReadBytes(3));
        }

        public override void Save(Stream s)
        {
            xsdName += XSD_START_INDEX;
            xsdInfo += XSD_START_INDEX;
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(Type);
            bw.Write(SecondType);
            bw.Write(ID);
            //throw new NotImplementedException();
            bw.Write(ModelIndex);
            bw.Write(IconIndex);
            bw.Write(ItemRank);
            bw.Write(group);
            bw.Write(itemCase);
            bw.Write(Grade);
            bw.Write(xsdInfo);
            bw.Write(xsdName);
            bw.Write(pack);
            bw.Write(clan);
            bw.Write(rank);
            bw.Write(durability);
            bw.Write(Quality);
            bw.Write(Quality2);

            for (int i = 0; i < 5; ++i)
            {
                effects[i].Save(s);
            }
            bw.Write(requiredLevel);
            bw.Write(requiredDex);
            bw.Write(requiredStr);

            bw.Write(requiredCon);
            bw.Write(requiredEss);
            bw.Write(requiredWis);
            bw.Write(ApplyClan);
            bw.Write(ClanPoint1);
            bw.Write(ClanPoint2);
            bw.Write(Price);
            for (int i = 0; i < 4; i++)
            {
                specials[i].Save(s);
            }
            int currIdx = 0;
            bw.Write(unknownBytes.ToArray(), currIdx, 8);
            currIdx += 8;
            bw.Write(maxSocket);
            bw.Write(itemSet);
            bw.Write(BlockDrop);
            bw.Write(BlockTrade);
            bw.Write(BlockNpcSell);
            bw.Write(Fame);
            bw.Write(unknownBytes.ToArray(), currIdx, 6);
            currIdx += 6;
            bw.Write(CashCheck);
            bw.Write(Time);
            bw.Write(BlockStorage);
            bw.Write(unknownBytes.ToArray(), currIdx, 3);
            currIdx += 3;

            
        }
        public static uint Size
        {
            get
            {
                return 155u;
            }
        }
        public static Map<ItemAccessory> Accessories
		{
			get
			{
				return ItemAccessory.mapAccessories;
			}
		}
        //public List<byte> unknownBytes = new List<byte>();
        public short RequiredLevel
		{
			get
			{
				return this.requiredLevel;
			}
		}
        public short RequiredDex
		{
			get
			{
				return this.requiredDex;
			}
		}
        public short RequiredStr
		{
			get
			{
				return this.requiredStr;
			}
		}
        public short RequiredCon
		{
			get
			{
				return this.requiredCon;
			}
		}
        public short RequiredEss
		{
			get
			{
				return this.requiredEss;
			}
		}
        public short RequiredWis
		{
			get
			{
				return this.requiredWis;
			}
		}
        public byte MaxSockets
		{
			get
			{
				return this.maxSocket;
			}
		}
        public short ItemSet
		{
			get
			{
				return this.itemSet;
			}
		}
        public Effect[] Effects
		{
			get
			{
				return this.effects;
			}
		}
        public Special[] Specials
		{
			get
			{
				return this.specials;
			}
		}
        public short Case
		{
			get
			{
				return this.itemCase;
			}
		}
        public short Group
        {
            get
            {
                return this.group;
            }
        }

        static Map<ItemAccessory> mapAccessories = new Map<ItemAccessory>();
        public short group;
        public short itemCase;
        public uint xsdName;
        public uint xsdInfo;
        public sbyte pack;
        public sbyte clan;
        public sbyte rank;
        public ushort durability;
        public Effect[] effects = new Effect[5];
        public Special[] specials = new Special[5];
        public short requiredLevel;
        public short requiredDex;
        public short requiredStr;
        public short requiredCon;
        public short requiredEss;
        public short requiredWis;
        public byte maxSocket;
        public short itemSet;
    }
}
