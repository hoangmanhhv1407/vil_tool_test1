using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
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
            if (lv%12 == 0)
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
    class ItemParser
    {
        public static byte[] LoadString(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            int count = br.ReadInt32();
            return br.ReadBytes(count);
        }
        public static string Encode(byte[] str, string encoding = "euc-kr")
        {
            return Encoding.GetEncoding(encoding).GetString(str);
        }

        #region Icons
        public static Bitmap SetIcon(ItemWeapon weapon)
        {
            int idx = weapon.IconIndex;
            int col = --idx % 8;
            int row = idx / 8;

            WeaponSecondType type2 = (WeaponSecondType)weapon.SecondType;
            string name = "";
            //ResourceManager rm = new ResourceManager(typeof(Bitmap));
            ResourceManager rm = Properties.Icons.ResourceManager;
            switch (type2)
            {
                case (WeaponSecondType.LONG):
                    {
                        name = ((ThirdTypeWeaponLong)weapon.thirdType).ToString();
                        break;
                    }
                case (WeaponSecondType.SHORT):
                    {
                        name = ((ThirdTypeWeaponShort)weapon.thirdType).ToString();
                        break;
                    }
                case (WeaponSecondType.SPECIAL):
                    {
                        name = ((ThirdTypeWeaponSpecial)weapon.thirdType).ToString();
                        break;
                    }
            }
            Bitmap b = null;
            try
            {
                b = rm.GetObject(name) as Bitmap;
            }
            catch
            {
                //no resource found
            }
            return CropImage(b as Bitmap, new Rectangle(col * 32, row * 32, 32, 32));
        }
        public static Bitmap SetIcon(ItemElixir elixir)
        {
            int idx = elixir.IconIndex;
            string name = "";
            switch (elixir.ThirdType)
            {
                case 0:
                    {
                        name = "ELIXIRS";
                        break;
                    }
                default:
                    {
                        name = "SUPPLEMENTS";
                        idx -= 64;
                        break;
                    }
            }
            int col = --idx % 8;
            int row = idx / 8;
            
            ResourceManager rm = Properties.Icons.ResourceManager;

            Bitmap b = null;
            try
            {
                b = rm.GetObject(name) as Bitmap;
            }
            catch
            {
                //no resource found
            }
            return CropImage(b as Bitmap, new Rectangle(col * 32, row * 32, 32, 32));
        }
        public static Bitmap SetIcon(ItemAccessory accessory)
        {
            int idx = accessory.IconIndex;

            string name = string.Format("ACCESSORIES{0}", 1 + (--idx / 64));
            idx %= 64;
            int col = idx % 8;
            int row = idx / 8;
            
            ResourceManager rm = Properties.Icons.ResourceManager;

            Bitmap b = null;
            try
            {
                b = rm.GetObject(name) as Bitmap;
            }
            catch
            {
                //no resource found
            }
            return CropImage(b as Bitmap, new Rectangle(col * 32, row * 32, 32, 32));
        }
        static Bitmap CropImage(Image originalImage, Rectangle sourceRectangle, Rectangle? destinationRectangle = null)
        {
            if (destinationRectangle == null)
            {
                destinationRectangle = new Rectangle(Point.Empty, sourceRectangle.Size);
            }

            var croppedImage = new Bitmap(destinationRectangle.Value.Width,
                destinationRectangle.Value.Height);
            using (var graphics = Graphics.FromImage(croppedImage))
            {
                graphics.DrawImage(originalImage, destinationRectangle.Value,
                    sourceRectangle, GraphicsUnit.Pixel);
            }
            return croppedImage;
        }

        #endregion

        public static Map<ushort, List<ItemBase>> ItemRanks = new Map<ushort, List<ItemBase>>();
    }
}
