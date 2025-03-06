using ItemEditor.XStringDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemEditor
{
    static class XsdManager
    {
        static XsdManager()
        {
            tables["Nickname"] = "ItemTable_Nickname";
            tables["AddTo"] = "ItemTable_AddTo";
            tables["WeaponName"] = "ItemTable_SeedWeapon";
            tables["WeaponInfo"] = "ItemTable_SeedInfoWeapon";
            tables["ClothName"] = "ItemTable_SeedClothes";
            tables["ClothInfo"] = "ItemTable_SeedInfoClothes";
            tables["BookName"] = "ItemTable_SeedBook";
            tables["BookInfo"] = "ItemTable_SeedInfoBook";
            tables["PotionName"] = "ItemTable_SeedPotion";
            tables["PotionInfo"] = "ItemTable_SeedInfoPotion";
            tables["ConsumingName"] = "ItemTable_SeedConsuming";
            tables["ConsumingInfo"] = "ItemTable_SeedInfoConsuming";
            tables["ElixirName"] = "ItemTable_SeedElixir";
            tables["ElixirInfo"] = "ItemTable_SeedInfoElixir";
            tables["QuestName"] = "ItemTable_SeedQuest";
            tables["QuestInfo"] = "ItemTable_SeedInfoQuest";
            tables["AccessoryName"] = "ItemTable_SeedAccessory";
            tables["AccessoryInfo"] = "ItemTable_SeedInfoAccessory";
            tables["ResourceName"] = "ItemTable_SeedResource";
            tables["ResourceInfo"] = "ItemTable_SeedInfoResource";
            tables["LifeName"] = "ItemTable_SeedLife";
            tables["LifeInfo"] = "ItemTable_SeedInfoLife";
            tables["SocketName"] = "ItemTable_SeedSocket";
            tables["SocketInfo"] = "ItemTable_SeedInfoSocket";
            tables["BoxName"] = "ItemTable_SeedBox";
            tables["BoxInfo"] = "ItemTable_SeedInfoBox";
            tables["BoxkeyName"] = "ItemTable_SeedBoxkey";
            tables["BoxkeyInfo"] = "ItemTable_SeedInfoBoxkey";
            tables["EffectsName"] = "CharacterState_name";
            tables["EffectsInfo"] = "CharacterState_info";
            tables["Fame"] = "Fame_Infamy_Ref";

            foreach (string table in tables.Keys)
            {
                maps[table] = new Map();
                GetDataTo(maps[table], tables[table]);
            }
            FameTableFix();
        }

        public static string GetInfoFrom(string tablename, uint index)
        {
            int key = (int)(index);
            if (Maps[tablename].Count == 0) GetDataTo(Maps[tablename], TableNames[tablename]);
            if (Maps[tablename].ContainsKey(key))
            {
                return Maps[tablename][key];
            }
            return null;
        }

        static void FameTableFix()
        {
            int[] keys = maps["Fame"].Keys.ToArray();
            foreach(int k in keys)
            {
                maps["Fame"][k] = maps["Fame"][k].Replace('_', ' ');
            }
            maps["Fame"].Add(0, "None");
            maps["Fame"].Add(99, "Danh tiếng");
            maps["Fame"].Add(199, "Ác Danh");

        }
        public static void GetDataTo(Map map, string tableName)
        {
            if (XsdManager.xsd.Count == 0)
                XsdManager.OpenXsd(0);

            Section findMe = null;
            foreach (Section section in XsdManager.XSD.sectionCollection.Sections)
            {
                if (section.UnicodeName.Contains(tableName))
                {
                    findMe = section;
                    break;
                }
            }

            if (findMe == null) return; //if not found
            foreach (XString str in findMe.XStrings.Rows)
            {
                if (!(map.ContainsKey(str.ResourceIndex)))
                    map.Add(str.ResourceIndex, str.UnicodeName());
            }
        }

        #region ALL MAPS
        public static Map<string, Map> Maps {get{return maps;}}
        public static Map<string, string> TableNames {get{return tables;}}

        public static Map AddTos {get{return mapAddTo;}}
        public static Map Nicknames {get{return mapNicknames;}}
        public static Map WeaponNames {get{return mapWeaponNames;}}
        public static Map WeaponInfo {get{return mapWeaponInfo;}}
        public static Map ClothNames {get{return mapClothNames;}}
        public static Map ClothInfo {get{return mapClothInfo;}}
        public static Map EffectsName {get{return mapEffectsName;}}
        public static Map EffectsInfo {get{return mapEffectsInfo;}}

        static Map<string, Map> maps = new Map<string, Map>();
        static Map<string, string> tables = new Map<string, string>();
        //static Map<string> fame = new Map<string>();
        static Map mapEffectsName = new Map();
        static Map mapEffectsInfo = new Map();
        static Map mapWeaponNames = new Map();
        static Map mapClothNames = new Map();
        static Map mapClothInfo = new Map();
        static Map mapNicknames = new Map();
        static Map mapAddTo = new Map();
        static Map mapWeaponInfo = new Map();
        public static Map mapelixirs = new Map();
        #endregion
        //XSD-related
        public static Xsd XSD { get { return xsd[0]; } }
        public static List<Xsd> xsd = new List<Xsd>();
        
        private static byte[] keys = new byte[] { 0x17, 0x08 };

        internal static bool OpenXsd(int xsdIndex)
        {
            string filename = OpenXsdDialog();
            if (filename == string.Empty)
            {
                return false;
            }

            if (xsdIndex == 0)
                xsd.Clear();

            if (xsdIndex > 0 && !(xsd[0] is Xsd))
                MessageBox.Show("Cannot open additional XSDs. Try loading an XSD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            xsd.Insert(xsdIndex, (new XsdFile(filename, keys)));
            xsd[xsdIndex].load();
           
            return true;
        }
        
        private static string OpenXsdDialog()
        {
                return System.IO.Path.GetFullPath(".\\Main\\NDTEXTDB_US.XSD");
        }


    }
}
