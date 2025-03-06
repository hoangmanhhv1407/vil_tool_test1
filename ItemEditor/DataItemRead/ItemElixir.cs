using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    enum ElixirSecondType
    {
        SUPPORT = 0,     
        STR,
        ESS,           
        WIS,           
        CON,          
        DEX
    }

    class ItemElixir : ItemBase
    {
        public static uint Size {get{return 88;}}
        static uint XSD_START_INDEX = 35000;
        public override void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            Type = br.ReadSByte();
            SecondType = br.ReadSByte();
            ID = br.ReadInt16();

            xsdName = br.ReadUInt32();
            thirdType = br.ReadSByte();
            ModelIndex = br.ReadInt16();
            IconIndex = br.ReadInt16();
            ItemRank = br.ReadUInt16();
            Grade = br.ReadByte();
            Quality = br.ReadByte();
            Quality2 = br.ReadByte();
            xsdInfo = br.ReadUInt32();
            //
            xsdName -= XSD_START_INDEX;
            xsdInfo -= XSD_START_INDEX;
            //
            int key = (int)(xsdName);
            if (XsdManager.Maps["ElixirName"].Count == 0) XsdManager.GetDataTo(XsdManager.Maps["ElixirName"], XsdManager.TableNames["ElixirName"]);
            if (XsdManager.Maps["ElixirInfo"].Count == 0) XsdManager.GetDataTo(XsdManager.Maps["ElixirInfo"], XsdManager.TableNames["ElixirInfo"]);
            if (XsdManager.Maps["ElixirName"].ContainsKey(key))
            {
                Name = XsdManager.Maps["ElixirName"][key];
            }
            key = (int)xsdInfo;
            if (XsdManager.Maps["ElixirInfo"].ContainsKey(key))
            {
                Description = XsdManager.Maps["ElixirInfo"][key];
            }
            //unknownBytes.AddRange(br.ReadBytes(18));
            step = br.ReadByte();
            level = br.ReadByte();
            minValue = br.ReadUInt16();
            maxValue = br.ReadUInt16();
            cooldownDelay = br.ReadUInt16();
            successRate = br.ReadUInt16();
            for (int i = 0; i < 8; i++) bodyType[i] = br.ReadUInt16();
            intox = br.ReadByte();
            visualEff = br.ReadByte();
            for (int i = 0; i < 4; i++) tmp[i] = br.ReadUInt16();
            ApplyClan = br.ReadSByte();
            ClanPoint1 = br.ReadInt32();
            ClanPoint2 = br.ReadInt32();
            Price = br.ReadUInt32();
            BlockDrop = br.ReadBoolean();
            BlockTrade = br.ReadByte();
            BlockNpcSell = br.ReadBoolean();
            unknownBytes.AddRange(br.ReadBytes(7));
            CashCheck = br.ReadSByte();
            unknownBytes.AddRange(br.ReadBytes(2));
            BlockStorage = br.ReadBoolean();
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

            bw.Write(xsdName);
            bw.Write(ThirdType);
            bw.Write(ModelIndex);
            bw.Write(IconIndex);
            bw.Write(ItemRank);
            bw.Write(Grade);
            bw.Write(Quality);
            bw.Write(Quality2);
            bw.Write(xsdInfo);
            bw.Write(step);
            bw.Write(level);
            bw.Write(minValue);
            bw.Write(maxValue);
            bw.Write(cooldownDelay);
            //unknownBytes.AddRange(br.ReadBytes(18));
            bw.Write(successRate);
            for (int i = 0; i < 8; ++i) bw.Write(bodyType[i]);
            bw.Write(intox);
            bw.Write(visualEff);
            for (int i = 0; i < 4; ++i) bw.Write(tmp[i]);
            bw.Write(ApplyClan);
            bw.Write(ClanPoint1);
            bw.Write(ClanPoint2);
            bw.Write(Price);
            bw.Write(BlockDrop);
            bw.Write(BlockTrade);
            bw.Write(BlockNpcSell);
            int currIdx = 0;
            bw.Write(unknownBytes.ToArray(), currIdx, 7);
            currIdx += 7;
            bw.Write(CashCheck);
            bw.Write(unknownBytes.ToArray(), currIdx, 2);
            currIdx += 2;
            bw.Write(BlockStorage);
            bw.Write(unknownBytes.ToArray(), currIdx, 3);
            currIdx += 3;
        }

        //public string FullName {get{return string.Format("({0})\t{1}", this.ID, this.Name);
        public sbyte ThirdType {get{return thirdType;}}
        public byte Step {get{return step;}}
        public byte Level {get{return level;}}
        public ushort MinValue {get{return minValue;}}
        public ushort MaxValue {get{return maxValue;}}
        public byte Intoxication {get{return intox;}}
        public byte VisualEffect {get{return visualEff;}}
        public ushort Cooldown {get{return cooldownDelay;}}
        public ushort SuccessRate {get{return successRate;}}
        public static Map<ItemElixir> Elixirs { get { return mapElixirs; } }

        static Map<ItemElixir> mapElixirs = new Map<ItemElixir>();
        //public List<byte> unknownBytes = new List<byte>();
        public uint xsdName;
        public uint xsdInfo;
        sbyte thirdType;
        
        byte step; //or sbyte
        byte level;
        ushort minValue;
        ushort maxValue; //or sbyt
        byte intox;
        ushort cooldownDelay;
        ushort successRate;
        ushort[] bodyType = new ushort[8];
        byte visualEff;
        ushort[] tmp = new ushort[4];
    }
}
