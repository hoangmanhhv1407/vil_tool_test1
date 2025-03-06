using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    class ItemPass : ItemBase
    {
        public static uint Size
		{
			get
			{
				return 51;
			}
		}
        public override void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            Type = br.ReadSByte();
            SecondType = br.ReadSByte();
            ID = br.ReadInt16();
            unknownBytes.AddRange(br.ReadBytes(47));
        }

        public override void Save(Stream s)
        {
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(Type);
            bw.Write(SecondType);
            bw.Write(ID);
            int currIdx = 0;
            bw.Write(unknownBytes.ToArray(), currIdx, 47);
            currIdx += 47;
        }

        public static Map<ItemPass> Passes
        {
            get
            {
                return mapPasses;
            }
        }
        //public List<byte> unknownBytes = new List<byte>();

        static Map<ItemPass> mapPasses = new Map<ItemPass>();
    }
}
