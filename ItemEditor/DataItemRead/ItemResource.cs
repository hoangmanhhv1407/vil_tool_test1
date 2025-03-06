using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    enum ResourceSecondType
    {
        PRODUCTION = 0,    
        COLLECTION,        
        PRESENT,           
        MOVE               
    };

    class ItemResource : ItemBase
    {
        public static uint Size {get{return 63;}}
        static uint XSD_START_INDEX = 50000;
        public override void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            Type = br.ReadSByte();
            SecondType = br.ReadSByte();
            ID = br.ReadInt16();

            ModelIndex = br.ReadInt16();
            IconIndex = br.ReadInt16();
            ItemRank = br.ReadUInt16();
            Grade = br.ReadByte();
            xsdInfo = br.ReadUInt32();
            Quality = br.ReadByte();
            Quality2 = br.ReadByte();
            ApplyClan = br.ReadSByte();
            ClanPoint1 = br.ReadInt32();
            ClanPoint2 = br.ReadInt32();
            Price = br.ReadUInt32();
            unknownBytes.AddRange(br.ReadBytes(6));
            packageNumber = br.ReadInt16();
            xsdName = br.ReadUInt32();

            //XSD data
            xsdName -= XSD_START_INDEX;
            xsdInfo -= XSD_START_INDEX;

            Name = XsdManager.GetInfoFrom("ResourceName", xsdName);
            Description = XsdManager.GetInfoFrom("ResourceInfo", xsdInfo);
            //

            BlockDrop = br.ReadBoolean();
            BlockTrade = br.ReadByte();
            BlockNpcSell = br.ReadBoolean();
            //fame = br.ReadByte();
            //cashCheck = br.ReadSByte();
            //time = br.ReadInt16();

            unknownBytes.AddRange(br.ReadBytes(7));
            CashCheck = br.ReadSByte();
            Time = br.ReadInt16();
            BlockStorage = br.ReadBoolean();
            unknownBytes.AddRange(br.ReadBytes(7));
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
            bw.Write(Grade);
            bw.Write(xsdInfo);
            bw.Write(Quality);
            bw.Write(Quality2);
            bw.Write(ApplyClan);
            bw.Write(ClanPoint1);
            bw.Write(ClanPoint2); 
            bw.Write(Price);
            int currIdx = 0;
            bw.Write(unknownBytes.ToArray(), currIdx, 6);
            currIdx += 6;
            bw.Write(packageNumber);
            bw.Write(xsdName);
            bw.Write(BlockDrop);
            bw.Write(BlockTrade);
            bw.Write(BlockNpcSell);
            bw.Write(unknownBytes.ToArray(), currIdx, 7);
            currIdx += 7;
            bw.Write(CashCheck);
            bw.Write(Time);
            bw.Write(BlockStorage);
            bw.Write(unknownBytes.ToArray(), currIdx, 7);
            currIdx += 7;
        }

        public short Package {get{return packageNumber;}}
        public static Map<ItemResource> Resources { get { return mapResources; } }
        //public List<byte> unknownBytes = new List<byte>();

        static Map<ItemResource> mapResources = new Map<ItemResource>();
        uint xsdName;
        uint xsdInfo;
        short packageNumber;
    }
}
