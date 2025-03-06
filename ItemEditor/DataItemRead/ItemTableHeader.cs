using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemEditor
{
    public class SYSTEMTIME
    {
        public void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            year = br.ReadUInt16();
            month = br.ReadUInt16();
            dayOfWeek = br.ReadUInt16();
            day = br.ReadUInt16();
            hour = br.ReadUInt16();
            minute = br.ReadUInt16();
            second = br.ReadUInt16();
            milliseconds = br.ReadUInt16();
        }

        public void Save(Stream s)
        {
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(year);
            bw.Write(month);
            bw.Write(dayOfWeek);
            bw.Write(day);
            bw.Write(hour);
            bw.Write(minute);
            bw.Write(second);
            bw.Write(milliseconds);
        }

        public string GetDate()
        {
            string time = "";
            time += year.ToString() + '-' + month.ToString() + '-' + day.ToString();
            time += '\t';
            time += hour.ToString() + ':' + minute.ToString() + ':' + second.ToString() + '.' + milliseconds.ToString();

            return time;
        }

        internal ushort year;
        internal ushort month;
        internal ushort dayOfWeek;
        internal ushort day;
        internal ushort hour;
        internal ushort minute;
        internal ushort second;
        internal ushort milliseconds;
    }

    public enum ItemType
    {
        WEAPON = 0,         //0
        CLOTHES,            //1
        BOOK,               //2
        POTION,             //3
        CONSUMING,          //4
        ELIXIR,             //5
        COUNTERACT,         //6
        RESOURCE,           //7
        QUEST,              //8
        ACCESSORY,          //9
        LIFE,               //10
        MUSIC,              //11
        PASS,               //12
        MONEY,              //13
        SOCKET,             //14
        WEAPON2,            //15
        CLOTHES2,           //16
        BOX,                //17
        BOXKEY,             //18
        WEAPON3,            //19
        CLOTHES3			//20
    }

    class ItemTableHeader
    {
        public void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            toolName = br.ReadBytes(48);
            version1 = br.ReadInt16();
            version2 = br.ReadInt16();
            updateTime.Load(s);
            userName = br.ReadBytes(16);
            comName = br.ReadBytes(20);

            int cont = BOOL.TRUE; //continue
            sbyte type;
            uint size; //why sbyte tho
            short count;
            short maxIndex;
            int cnt = 0;
            int tmpCnt = 0;
            string tst = "";
            do
            {
                cnt = 0;
                type = br.ReadSByte();
                size = br.ReadUInt32();
                count = br.ReadInt16();
                maxIndex = br.ReadInt16();
                MaxItemCount[type] = maxIndex;

                ItemType itemType = (ItemType)type;
                byte[] arr = null;
                tst += string.Format("{0}: \t{1}\n", itemType, size);
                switch (itemType)
                {
                    case ItemType.WEAPON:
                    case ItemType.WEAPON2:
                    case ItemType.WEAPON3:
                        {
                            
                            while (cnt++ < count)
                            {
                                //s.Position--;
                                arr = br.ReadBytes((int)size);
                                ItemWeapon weapon = new ItemWeapon();
                                weapon.Load(new MemoryStream(arr));
                                if (itemType == ItemType.WEAPON)
                                    ItemWeapon.Weapons.Add(weapon.ID, weapon);
                                if (itemType == ItemType.WEAPON2)
                                    ItemWeapon.Weapons2.Add(weapon.ID, weapon);
                                if (itemType == ItemType.WEAPON3)
                                    ItemWeapon.Weapons3.Add(weapon.ID, weapon);
                                tmpCnt++;
                            }
                            //cont = BOOL.FALSE;
                            break;
                        }
                    case ItemType.CLOTHES:
                    case ItemType.CLOTHES2:
                    case ItemType.CLOTHES3:
                        {
                            while (cnt++ < count)
                            {
                                //s.Position--;
                                arr = br.ReadBytes((int)size);
                                ItemCloth cloth = new ItemCloth();
                                cloth.Load(new MemoryStream(arr));
                                if (itemType == ItemType.CLOTHES)
                                    ItemCloth.Clothes.Add(cloth.ID, cloth);
                                if (itemType == ItemType.CLOTHES2)
                                    ItemCloth.Clothes2.Add(cloth.ID, cloth);
                                if (itemType == ItemType.CLOTHES3)
                                    ItemCloth.Clothes3.Add(cloth.ID, cloth);
                                cloth.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.BOOK: //TODO
                        {
                            while (cnt++ < count)
                            {
                                ItemBook book = new ItemBook();
                                arr = br.ReadBytes(0x6C);
                                book.Load(new MemoryStream(arr));
                                ItemBook.Books.Add(book.ID, book);
                                book.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.POTION:
                        {
                            while (cnt++ < count)
                            {
                                ItemPotion potion = new ItemPotion();
                                arr = br.ReadBytes((int)size);
                                potion.Load(new MemoryStream(arr));
                                ItemPotion.Potions.Add(potion.ID, potion);
                                potion.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.CONSUMING:
                        {
                            while (cnt++ < count)
                            {
                                ItemConsuming consuming = new ItemConsuming();
                                arr = br.ReadBytes((int)size);
                                consuming.Load(new MemoryStream(arr));
                                ItemConsuming.Consumings.Add(consuming.ID, consuming);
                                consuming.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.ELIXIR:
                        {
                            while (cnt++ < count)
                            {
                                ItemElixir elixir = new ItemElixir();
                                arr = br.ReadBytes((int)size);
                                elixir.Load(new MemoryStream(arr));
                                ItemElixir.Elixirs.Add(elixir.ID, elixir);
                                elixir.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.COUNTERACT:
                        {
                            while (cnt++ < count)
                            {
                                ItemCounteract counteract = new ItemCounteract();
                                arr = br.ReadBytes((int)size);
                                counteract.Load(new MemoryStream(arr));
                                ItemCounteract.Counteracts.Add(counteract.ID, counteract);
                                counteract.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.RESOURCE:
                        {
                            while (cnt++ < count)
                            {
                                ItemResource resource = new ItemResource();
                                arr = br.ReadBytes((int)size);
                                resource.Load(new MemoryStream(arr));
                                ItemResource.Resources.Add(resource.ID, resource);
                                resource.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.QUEST:
                        {
                            while (cnt++ < count)
                            {
                                ItemQuest quest = new ItemQuest();
                                arr = br.ReadBytes((int)size);
                                quest.Load(new MemoryStream(arr));
                                ItemQuest.Quests.Add(quest.ID, quest);
                                quest.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.ACCESSORY:
                        {
                            while (cnt++ < count)
                            {
                                ItemAccessory accessory = new ItemAccessory();
                                arr = br.ReadBytes((int)size);
                                accessory.Load(new MemoryStream(arr));
                                ItemAccessory.Accessories.Add(accessory.ID, accessory);
                                accessory.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.LIFE:
                        {
                            while (cnt++ < count)
                            {
                                ItemLife life = new ItemLife();
                                arr = br.ReadBytes((int)size);
                                life.Load(new MemoryStream(arr));
                                ItemLife.Lifes.Add(life.ID, life);
                                life.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.MUSIC:
                        {
                            while (cnt++ < count)
                            {
                                ItemMusic music = new ItemMusic();
                                arr = br.ReadBytes((int)size);
                                music.Load(new MemoryStream(arr));
                                ItemMusic.Musics.Add(music.ID, music);
                                music.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.PASS:
                        {
                            /*bool tmp = true;
                            if (tmp)
                            {
                                tmp = false;
                                MessageBox.Show(size.ToString());
                            }*/
                            while (cnt++ < count)
                            {
                                ItemPass pass = new ItemPass();
                                arr = br.ReadBytes((int)size);
                                pass.Load(new MemoryStream(arr));
                                ItemPass.Passes.Add(pass.ID, pass);
                                pass.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.MONEY:
                        {
                            while (cnt++ < count)
                            {
                                ItemMoney money = new ItemMoney();
                                arr = br.ReadBytes((int)size);
                                money.Load(new MemoryStream(arr));
                                ItemMoney.Moneys.Add(money.ID, money);
                                money.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.SOCKET:
                        {
                            while (cnt++ < count)
                            {
                                ItemSocket socket = new ItemSocket();
                                arr = br.ReadBytes((int)size);
                                socket.Load(new MemoryStream(arr));
                                ItemSocket.Sockets.Add(socket.ID, socket);
                                socket.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }

                    case ItemType.BOX:
                        {
                            while (cnt++ < count)
                            {
                                ItemBox box = new ItemBox();
                                arr = br.ReadBytes((int)size);
                                box.Load(new MemoryStream(arr));
                                ItemBox.Boxes.Add(box.ID, box);
                                box.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    case ItemType.BOXKEY:
                        {
                            while (cnt++ < count)
                            {
                                ItemBoxKey boxkey = new ItemBoxKey();
                                arr = br.ReadBytes((int)size);
                                boxkey.Load(new MemoryStream(arr));
                                ItemBoxKey.BoxKeys.Add(boxkey.ID, boxkey);
                                boxkey.AddToItemRankMap();
                                tmpCnt++;
                            }
                            break;
                        }
                    
                    default:
                        {
                            while (cnt++ < count)
                            {
                                arr = br.ReadBytes((int)size);
                                tmpCnt++;
                            }
                            break;
                        }
                }
            } while //(cont == BOOL.TRUE);
            (br.BaseStream.Position != br.BaseStream.Length);
            s.Close();
           // MessageBox.Show(tst);
        }

        public void Save(Stream s)
        {
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(toolName);
            bw.Write(version1);
            bw.Write(version2);
            updateTime.Save(s);
            bw.Write(userName);
            bw.Write(comName);

            //int cont = BOOL.TRUE; //continue

            /*do
            {
                bw.Write((sbyte)0);
                bw.Write((uint)0xE2);
                bw.Write((short)ItemWeapon.Weapons.Count);
                bw.Write(ItemWeapon.Weapons.Keys.Max());
                foreach(ItemWeapon weapon in ItemWeapon.Weapons.Values)
                {
                    weapon.Save(s);
                }
            } while (false);
            */
            //do it by hand, noob

            bw.Write((sbyte)ItemType.WEAPON);
            bw.Write(ItemWeapon.Size);
            bw.Write((short)ItemWeapon.Weapons.Count);
            bw.Write(ItemWeapon.Weapons.Keys.Max());
            foreach (ItemWeapon item in ItemWeapon.Weapons.Values) item.Save(s);

            bw.Write((sbyte)ItemType.CLOTHES);
            bw.Write(ItemCloth.Size);
            bw.Write((short)ItemCloth.Clothes.Count);
            bw.Write(ItemCloth.Clothes.Keys.Max());
            foreach (ItemCloth item in ItemCloth.Clothes.Values) item.Save(s);

            bw.Write((sbyte)ItemType.BOOK);
            bw.Write(ItemBook.Size);
            bw.Write((short)ItemBook.Books.Count);
            bw.Write(ItemBook.Books.Keys.Max());
            foreach (ItemBook item in ItemBook.Books.Values) item.Save(s);

            bw.Write((sbyte)ItemType.POTION);
            bw.Write(ItemPotion.Size);
            bw.Write((short)ItemPotion.Potions.Count);
            bw.Write(ItemPotion.Potions.Keys.Max());
            foreach (ItemPotion item in ItemPotion.Potions.Values) item.Save(s);

            bw.Write((sbyte)ItemType.CONSUMING);
            bw.Write(ItemConsuming.Size);
            bw.Write((short)ItemConsuming.Consumings.Count);
            bw.Write(ItemConsuming.Consumings.Keys.Max());
            foreach (ItemConsuming item in ItemConsuming.Consumings.Values) item.Save(s);

            bw.Write((sbyte)ItemType.ELIXIR);
            bw.Write(ItemElixir.Size);
            bw.Write((short)ItemElixir.Elixirs.Count);
            bw.Write(ItemElixir.Elixirs.Keys.Max());
            foreach (ItemElixir item in ItemElixir.Elixirs.Values) item.Save(s);

            bw.Write((sbyte)ItemType.COUNTERACT);
            bw.Write(ItemCounteract.Size);
            bw.Write((short)ItemCounteract.Counteracts.Count);
            bw.Write(ItemCounteract.Counteracts.Keys.Max());
            foreach (ItemCounteract item in ItemCounteract.Counteracts.Values) item.Save(s);

            bw.Write((sbyte)ItemType.RESOURCE);
            bw.Write(ItemResource.Size);
            bw.Write((short)ItemResource.Resources.Count);
            bw.Write(ItemResource.Resources.Keys.Max());
            foreach (ItemResource item in ItemResource.Resources.Values) item.Save(s);

            bw.Write((sbyte)ItemType.QUEST);
            bw.Write(ItemQuest.Size);
            bw.Write((short)ItemQuest.Quests.Count);
            bw.Write(ItemQuest.Quests.Keys.Max());
            foreach (ItemQuest item in ItemQuest.Quests.Values) item.Save(s);

            bw.Write((sbyte)ItemType.ACCESSORY);
            bw.Write(ItemAccessory.Size);
            bw.Write((short)ItemAccessory.Accessories.Count);
            bw.Write(ItemAccessory.Accessories.Keys.Max());
            foreach (ItemAccessory item in ItemAccessory.Accessories.Values) item.Save(s);

            bw.Write((sbyte)ItemType.LIFE);
            bw.Write(ItemLife.Size);
            bw.Write((short)ItemLife.Lifes.Count);
            bw.Write(ItemLife.Lifes.Keys.Max());
            foreach (ItemLife item in ItemLife.Lifes.Values) item.Save(s);

            bw.Write((sbyte)ItemType.MUSIC);
            bw.Write(ItemMusic.Size);
            bw.Write((short)ItemMusic.Musics.Count);
            bw.Write((short)(ItemMusic.Musics.Keys.Count == 0 ? 0 : ItemMusic.Musics.Keys.Max()));
            foreach (ItemMusic item in ItemMusic.Musics.Values) item.Save(s);

            bw.Write((sbyte)ItemType.PASS);
            bw.Write(ItemPass.Size);
            bw.Write((short)ItemPass.Passes.Count);
            bw.Write((short)(ItemPass.Passes.Keys.Count == 0 ? 0 : ItemPass.Passes.Keys.Max()));
            foreach (ItemPass item in ItemPass.Passes.Values) item.Save(s);
            /* it's skipped in table tho
            bw.Write((sbyte)ItemType.MONEY);
            bw.Write(51); //w/e
            bw.Write((short)ItemMoney.Moneys.Count);
            bw.Write(ItemMoney.Moneys.Keys.Max());
            foreach (ItemMoney item in ItemMoney.Moneys.Values) item.Save(s);
            */
            bw.Write((sbyte)ItemType.SOCKET);
            bw.Write(ItemSocket.Size);
            bw.Write((short)ItemSocket.Sockets.Count);
            bw.Write((short)(ItemSocket.Sockets.Keys.Max()));
            foreach (ItemSocket item in ItemSocket.Sockets.Values) item.Save(s);

            bw.Write((sbyte)ItemType.WEAPON2);
            bw.Write(ItemWeapon.Size);
            bw.Write((short)ItemWeapon.Weapons2.Count);
            bw.Write((short)(ItemWeapon.Weapons2.Keys.Max()));
            foreach (ItemWeapon item in ItemWeapon.Weapons2.Values) item.Save(s);

            bw.Write((sbyte)ItemType.CLOTHES2);
            bw.Write(ItemCloth.Size);
            bw.Write((short)ItemCloth.Clothes2.Count);
            bw.Write((short)(ItemCloth.Clothes2.Keys.Max()));
            foreach (ItemCloth item in ItemCloth.Clothes2.Values) item.Save(s);

            bw.Write((sbyte)ItemType.BOX);
            bw.Write(ItemBox.Size);
            bw.Write((short)ItemBox.Boxes.Count);
            bw.Write((short)(ItemBox.Boxes.Keys.Max()));
            foreach (ItemBox item in ItemBox.Boxes.Values) item.Save(s);

            bw.Write((sbyte)ItemType.BOXKEY);
            bw.Write(ItemBoxKey.Size);
            bw.Write((short)ItemBoxKey.BoxKeys.Count);
            bw.Write((short)(ItemBoxKey.BoxKeys.Keys.Max()));
            foreach (ItemBoxKey item in ItemBoxKey.BoxKeys.Values) item.Save(s);

            bw.Write((sbyte)ItemType.WEAPON3);
            bw.Write(ItemWeapon.Size);
            bw.Write((short)ItemWeapon.Weapons3.Count);
            bw.Write((short)(ItemWeapon.Weapons3.Keys.Max()));
            foreach (ItemWeapon item in ItemWeapon.Weapons3.Values) item.Save(s);

            bw.Write((sbyte)ItemType.CLOTHES3);
            bw.Write(ItemCloth.Size);
            bw.Write((short)ItemCloth.Clothes3.Count);
            bw.Write((short)(ItemCloth.Clothes3.Keys.Max()));
            foreach (ItemCloth item in ItemCloth.Clothes3.Values) item.Save(s);

            s.Close();
        }

        public string GetInfo()
        {
            string s = "";
            s += ToolName;
            s += "\nVersion: " + version1 + '.' + version2 + '\n';
            s += updateTime.GetDate();
            s += '\n';
            s += UserName + '\n';
            s += CompanyName;

            return s;
        }

        static readonly short MAX_ITEM_COUNT = 23;


        public string ToolName {get{return Encoding.Default.GetString(toolName, 0, 48);}}
        public string UserName {get{return Convert.ToString(userName);}}
        public string CompanyName {get{return Convert.ToString(comName);}}
        public SYSTEMTIME Datetime { get { return updateTime; } }

        short[] MaxItemCount = new short[MAX_ITEM_COUNT + 1];

        byte[] toolName = new byte[48];
        short version1;
        short version2;
        SYSTEMTIME updateTime = new SYSTEMTIME();
        byte[] userName = new byte[16];
        byte[] comName = new byte[20];
    }
}
