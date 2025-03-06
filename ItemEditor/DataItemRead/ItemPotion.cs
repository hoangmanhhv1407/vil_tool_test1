using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    class ItemPotion : ItemBase
    {
        public static uint Size
		{
			get
			{
				return 77;
			}
		}
        static uint XSD_START_INDEX = 25000;
        public override void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            Type = br.ReadSByte();
            SecondType = br.ReadSByte();
            ID = br.ReadInt16();
            //testing changes
            ModelIndex = br.ReadInt16();
            IconIndex = br.ReadInt16();
            ItemRank = br.ReadUInt16();
            Grade = br.ReadByte();
            XsdItemInfo = br.ReadUInt32();
            XsdItemInfo -= XSD_START_INDEX;
            var key = (int)XsdItemInfo;
            if (XsdManager.Maps["PotionInfo"].ContainsKey(key))
            {
                Description = XsdManager.Maps["PotionInfo"][key];
            }
            unknownBytes.AddRange(br.ReadBytes(21));
            XsdName = br.ReadUInt32();
            XsdName -= XSD_START_INDEX;
            key = (int)XsdName;
            if (XsdManager.Maps["PotionName"].ContainsKey(key))
            {
                Name = XsdManager.Maps["PotionName"][key];
            }
            unknownBytes.AddRange(br.ReadBytes(37));
        }

        public override void Save(Stream s)
        {
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(Type);
            bw.Write(SecondType);
            bw.Write(ID);
            bw.Write(ModelIndex);
            bw.Write(IconIndex);
            bw.Write(ItemRank);
            bw.Write(Grade);
            bw.Write(XsdItemInfo + XSD_START_INDEX);
            int curr = 0;
            bw.Write(unknownBytes.ToArray(), curr, 21);
            curr += 21;
            bw.Write(XsdName + XSD_START_INDEX);
            bw.Write(unknownBytes.ToArray(), curr, 37);
            curr += 37;
        }
        public static Map<ItemPotion> Potions { get { return ItemPotion.mapPotions; } }

        private static Map<ItemPotion> mapPotions = new Map<ItemPotion>();
    }
}
