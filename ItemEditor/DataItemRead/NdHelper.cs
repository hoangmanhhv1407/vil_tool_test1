using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCReader
{
    class NdString
    {
        public NdString()
        {
            count = 0;
            str = new byte[]{ };
        }

        public NdString(Stream s, int length = -1)
        {
            count = length;
            Load(s);
        }

        public byte[] Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            if (count == -1) count = br.ReadInt32();
            str = br.ReadBytes(count);
            return str;
        }

        public byte[] Load(Stream s, int length)
        {
            BinaryReader br = new BinaryReader(s);
            count = length;
            str = br.ReadBytes(count);
            return str;
        }

        public string Encode(byte[] str, string encoding = "euc-kr")
        {
            return Encoding.GetEncoding(encoding).GetString(str);
        }

        public string Value { get { return Encode(str); } }

        private int count;
        private byte[] str;

    }

    class Level
    {
        static string[] levels = {
                            "Losing Self",
                            "Gathering Chi",
                            "Opening Chi",
                            "Revolving Chakra",
                            "Raising Light",
                            "Five Dragons",
                            "Sun and Moon",
                            "Golden Blossom",
                            "Elemental Crown",
                            "Floral Crown",
                            "Crimson Snake",
                            "Golden Lotus",
                            "Humble Master",
                            "Little Master",
                            "Hermit",
                            "Projected Soul",
                            "Dissolved Body",
                            "Immortal",
                            "Heaven's Gate",
                            "Heavenly Immortal"};

        public static string Get(short lv)
        {
            if (lv > 240 || lv < 0) return "";
            if (lv == 0) return "None 0";
            if (lv % 12 == 0)
            {
                return levels[lv / 12 - 1] + " 12";
            }
            return levels[lv / 12] + ' ' + (lv % 12 == 0 ? 12 : lv % 12).ToString();
        }
    }

    class BOOL
    {
        public static readonly int FALSE = 0;
        public static readonly int TRUE = 1;
    }
}
