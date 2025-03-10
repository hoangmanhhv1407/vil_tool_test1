﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    class ItemBoxKey : ItemBase
    {
        public static uint Size { get { return 62; } }
        public static Map<ItemBoxKey> BoxKeys = new Map<ItemBoxKey>();

        public override void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            Type = br.ReadSByte();
            SecondType = br.ReadSByte();
            ID = br.ReadInt16();
            unknownBytes.AddRange(br.ReadBytes(58));
        }

        public override void Save(Stream s)
        {
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(Type);
            bw.Write(SecondType);
            bw.Write(ID);
            int currIdx = 0;
            bw.Write(unknownBytes.ToArray(), currIdx, 58);
            currIdx += 58;
        }
    }
}
