using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    class ItemCloth : ItemBase
    {
        public static uint Size
		{
			get
			{
				return 185;
			}
		}
        static uint XSD_START_INDEX = 10000;
        public override void Load(Stream s)
        {
            if (XsdManager.Maps["ClothName"].Count == 0)
                XsdManager.GetDataTo(XsdManager.Maps["ClothName"], XsdManager.TableNames["ClothName"]);
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
            ApplyClan = br.ReadSByte();
            ClanPoint1 = br.ReadInt32();
            ClanPoint2 = br.ReadInt32();
            Price = br.ReadUInt32();
            unknownBytes.AddRange(br.ReadBytes(8));
            xsdName = br.ReadUInt32();

            //XSD
            xsdName -= XSD_START_INDEX;
            xsdInfo -= XSD_START_INDEX;

            Name = XsdManager.GetInfoFrom("ClothName", xsdName);
            Description = XsdManager.GetInfoFrom("ClothInfo", xsdInfo);
            //

            //unknownBytes.AddRange(br.ReadBytes(9));
            precedence = br.ReadSByte();
            clan = br.ReadSByte();
            characGrade = br.ReadByte();
            sex = br.ReadByte();
            itemSet = br.ReadUInt16();
            unknownBytes.AddRange(br.ReadBytes(20));
            def = br.ReadUInt16();
            unknownBytes.AddRange(br.ReadBytes(7));
            durability = br.ReadUInt16();
            unknownBytes.AddRange(br.ReadBytes(1));
            for (int i = 0; i < 5; i++)
            {
                effects[i] = new Effect();
                effects[i].Load(new MemoryStream(br.ReadBytes(8)));
            }
            level = br.ReadByte();
            //36

            //62
            unknownBytes.AddRange(br.ReadBytes(5));
            pockets = br.ReadByte();
            unknownBytes.AddRange(br.ReadBytes(32));
            slots = br.ReadByte();
            unknownBytes.AddRange(br.ReadBytes(20));
          maxSlots = br.ReadByte();
            unknownBytes.AddRange(br.ReadBytes(2));
        }

        public override void Save(Stream s)
        {
            xsdName += XSD_START_INDEX;
            xsdInfo += XSD_START_INDEX;
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(Type);
            bw.Write(SecondType);
            bw.Write(ID);
            bw.Write(ModelIndex);
            bw.Write(IconIndex);
            bw.Write(ItemRank);
            bw.Write(group);
            bw.Write(itemCase);
            bw.Write(Grade);
            bw.Write(xsdInfo);
            bw.Write(ApplyClan);
            bw.Write(ClanPoint1);
            bw.Write(ClanPoint2);
            bw.Write(Price);
            int currIdx = 0;
            bw.Write(unknownBytes.ToArray(), currIdx, 8);
            currIdx += 8;
            bw.Write(xsdName);

            bw.Write(precedence);
            bw.Write(clan);
            bw.Write(characGrade);
            bw.Write(sex);
            bw.Write(itemSet);
            bw.Write(unknownBytes.ToArray(), currIdx, 20);
            currIdx += 20;
            bw.Write(def);
            
            bw.Write(unknownBytes.ToArray(), currIdx, 7);
            currIdx += 7;

            bw.Write(durability);
            bw.Write(unknownBytes.ToArray(), currIdx, 1);
            currIdx += 1;
            
            for (int i = 0; i < 5; i++)
            {
                effects[i].Save(s);
            }
            bw.Write(level);
            bw.Write(unknownBytes.ToArray(), currIdx, 5);
            currIdx += 5;
            bw.Write(pockets);
            bw.Write(unknownBytes.ToArray(), currIdx, 32);
            currIdx += 32;
            bw.Write(slots);
            bw.Write(unknownBytes.ToArray(), currIdx, 20);
            currIdx += 20;
            bw.Write(maxSlots);
            bw.Write(unknownBytes.ToArray(), currIdx, 2);
            currIdx += 2;
        }

        //public string FullName => string.Format("({0})\t{1}", id, Name);

        public Effect[] Effects 
        {
            get
            {
                return effects;
            }
        }
        //public List<byte> unknownBytes = new List<byte>();
        public static Map<ItemCloth> Clothes 
        {
            get
            {
                return mapClothes;
            }
        }
        public static Map<ItemCloth> Clothes2 
        {
            get
            {
                    return mapClothes2;
            }
        }
        public ushort Defence 
        {
            get
            {
                return def;
            }
        }
        public static Map<ItemCloth> Clothes3
        {
            get
            {
                return mapClothes3;
            }
        }

        static Map<ItemCloth> mapClothes = new Map<ItemCloth>();
        static Map<ItemCloth> mapClothes2 = new Map<ItemCloth>();
        static Map<ItemCloth> mapClothes3 = new Map<ItemCloth>();

        public byte slots;
        public byte maxSlots;
        public byte pockets;
        public uint xsdName;
        public uint xsdInfo;
        public short group;
        public byte level;
        public short itemCase;
        public sbyte precedence; //wtf
        public sbyte clan;
        public byte characGrade;
        public byte sex;
        public ushort durability;
        public Effect[] effects = new Effect[5];
        public Special[] specials = new Special[4];
        public VectorPos center = new VectorPos();
        public ushort itemSet;
        public ushort def;
    }
}
