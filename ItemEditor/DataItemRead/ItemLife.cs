using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    class ItemLife : ItemBase
    {
        public static uint Size
        {
            get
            {
                return 66;
            }
        }
        static uint XSD_START_INDEX = 55000;
        public override void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            Type = br.ReadSByte();
            SecondType = br.ReadSByte();
            ID = br.ReadInt16();

            xsdName = br.ReadUInt32();
            unknownBytes.AddRange(br.ReadBytes(2));
            xsdInfo = br.ReadUInt32();

            //XSD
            xsdName -= XSD_START_INDEX;
            xsdInfo -= XSD_START_INDEX;

            Name = XsdManager.GetInfoFrom("LifeName", xsdName);
            Description = XsdManager.GetInfoFrom("LifeInfo", xsdInfo);
            //

            unknownBytes.AddRange(br.ReadBytes(52));
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
            int currIdx = 0;
            bw.Write(unknownBytes.ToArray(), currIdx, 2);
            currIdx += 2;
            bw.Write(xsdInfo);
            bw.Write(unknownBytes.ToArray(), currIdx, 52);
            currIdx += 52;
        }

        public static Map<ItemLife> Lifes { get { return mapLifes; } }
        //public List<byte> unknownBytes = new List<byte>();
        static Map<ItemLife> mapLifes = new Map<ItemLife>();

        uint xsdName;
        uint xsdInfo;
    }
}
