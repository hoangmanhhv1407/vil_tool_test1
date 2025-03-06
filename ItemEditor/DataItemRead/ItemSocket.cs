﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    class ItemSocket : ItemBase
    {
        public static uint Size
        {
            get
            {
                return 112u;
            }
        }
        public static Map<ItemSocket> Sockets = new Map<ItemSocket>();

        public override void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            Type = br.ReadSByte();
            SecondType = br.ReadSByte();
            ID = br.ReadInt16();
            unknownBytes.AddRange(br.ReadBytes(108));
        }

        public override void Save(Stream s)
        {
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(Type);
            bw.Write(SecondType);
            bw.Write(ID);
            int currIdx = 0;
            bw.Write(unknownBytes.ToArray(), currIdx, 108);
            currIdx += 108;
        }
    }
}
