using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    enum BookSecondType
    {
        SKILL = 0,     
        STUDY,         
        ABILITY,       
        SCROLL,        
        STUFF,         
        PAPER,         
        SKILL2   
    };

    enum BookThirdType
    {
        APPOINTMENT = 0,   
        GROUP,             
        DUTIES,            
        SERIES            
    };

    class RequiredSkill
    {
        public void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            skillID = br.ReadUInt16();
            skillStep = br.ReadSByte();
        }

        public void Save(Stream s)
        {
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(skillID);
            bw.Write(skillStep);
        }

        public ushort SkillID
        {
            get { return skillID; }
            set { skillID = value; }
        }
        public sbyte SkillStep
        {
            get { return skillStep; }
            set { skillStep = value; }
        }

        ushort skillID;
        sbyte skillStep;
    }

    class ItemBook : ItemBase
    {
        public static uint Size {get{return 0x6D;}}
        static uint XSD_START_INDEX = 20000;
        public override void Load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            Type = br.ReadSByte();
            SecondType = br.ReadSByte();
            ID = br.ReadInt16();
            xsdName = br.ReadUInt32();
            thirdType = br.ReadSByte();
            xsdInfo = br.ReadUInt32();

            //XSD data
            xsdName -= XSD_START_INDEX;
            xsdInfo -= XSD_START_INDEX;

            int key = (int)(xsdName);
            if (XsdManager.Maps["BookName"].Count == 0) XsdManager.GetDataTo(XsdManager.Maps["BookName"], XsdManager.TableNames["BookName"]);
            if (XsdManager.Maps["BookInfo"].Count == 0) XsdManager.GetDataTo(XsdManager.Maps["BookInfo"], XsdManager.TableNames["BookInfo"]);
            if (XsdManager.Maps["BookName"].ContainsKey(key))
            {
                Name = XsdManager.Maps["BookName"][key];
            }
            key = (int)xsdInfo;
            if (XsdManager.Maps["BookInfo"].ContainsKey(key))
            {
                Description = XsdManager.Maps["BookInfo"][key];
            }
            //
            skillID = br.ReadUInt16();
            value = br.ReadByte();
            skillGroup = br.ReadByte();
            skillClass = br.ReadByte();
            skillStep = br.ReadSByte();
            skillLevel = br.ReadByte();
            abilityID = br.ReadUInt16();
            questID = br.ReadUInt16();
            clan = br.ReadByte();
            characGrade = br.ReadByte();
            classID = br.ReadByte();
            for (int i = 0; i < 3; i++) 
            {
                skills[i] = new RequiredSkill();
                skills[i].Load(new MemoryStream(br.ReadBytes(3)));
            }
            requiredAbilityID = br.ReadUInt16();
            requiredAbilityStep = br.ReadSByte();


            hiddenID = br.ReadUInt16();
            prob = br.ReadSByte();
            delay = br.ReadUInt16();
            delete = br.ReadBoolean();
            applyTime = br.ReadUInt32();
            cooldown = br.ReadUInt16();
            ApplyClan = br.ReadSByte();
            ClanPoint1 = br.ReadInt32();
            ClanPoint2 = br.ReadInt32();
            Price = br.ReadUInt32();

            ModelIndex = br.ReadInt16();
            IconIndex = br.ReadInt16();
            Grade = br.ReadByte();
            ItemRank = br.ReadUInt16();
            Quality = br.ReadByte();
            Quality2 = br.ReadByte();
            requiredLevel = br.ReadUInt16();
            requiredStr = br.ReadUInt16();
            requiredEss = br.ReadUInt16();
            requiredWis = br.ReadUInt16();
            requiredCon = br.ReadUInt16();
            requiredDex = br.ReadUInt16();
            requiredHP = br.ReadUInt16();
            requiredVE = br.ReadUInt16();
            unknownBytes.AddRange(br.ReadBytes(2)); //conc?
            BlockDrop = br.ReadBoolean();
            BlockTrade = br.ReadByte();
            BlockNpcSell = br.ReadBoolean();
            unknownBytes.AddRange(br.ReadBytes(7));
            CashCheck = br.ReadSByte();
            Time = br.ReadInt16();
            BlockStorage = br.ReadBoolean();
            unknownBytes.AddRange(br.ReadBytes(3));
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
            bw.Write(thirdType);
            bw.Write(xsdInfo);
            bw.Write(skillID);
            bw.Write(value);
            bw.Write(skillGroup);
            bw.Write(skillClass);
            bw.Write(skillStep);
            bw.Write(skillLevel);
            bw.Write(abilityID);
            bw.Write(questID);
            bw.Write(clan);
            bw.Write(characGrade);
            bw.Write(classID);
            for (int i = 0; i < 3; i++)
            {
                skills[i].Save(s);
            }
            bw.Write(requiredAbilityID);
            bw.Write(requiredAbilityStep);
            bw.Write(hiddenID);
            bw.Write(prob);
            bw.Write(delay);
            bw.Write(delete);
            bw.Write(applyTime);
            bw.Write(cooldown);
            bw.Write(ApplyClan);
            bw.Write(ClanPoint1);
            bw.Write(ClanPoint2);
            bw.Write(Price);
            bw.Write(ModelIndex);
            bw.Write(IconIndex);
            bw.Write(Grade);
            bw.Write(ItemRank);
            bw.Write(Quality);
            bw.Write(Quality2);
            bw.Write(requiredLevel);
            bw.Write(requiredStr);
            bw.Write(requiredEss);
            bw.Write(requiredWis);
            bw.Write(requiredCon);
            bw.Write(requiredDex);
            bw.Write(requiredHP);
            bw.Write(requiredVE);
            int currIdx = 0;
            bw.Write(unknownBytes.ToArray(), currIdx, 2);
            currIdx += 2;
            
            bw.Write(BlockDrop);
            bw.Write(BlockTrade);
            bw.Write(BlockNpcSell);
            bw.Write(unknownBytes.ToArray(), currIdx, 7);
            currIdx += 7;
            bw.Write(CashCheck);
            bw.Write(Time);
            bw.Write(BlockStorage);
            bw.Write(unknownBytes.ToArray(), currIdx, 3);
            currIdx += 3;
        }

        public static Map<ItemBook> Books {get{return mapBooks;}}
        //public List<byte> unknownBytes = new List<byte>();
        public sbyte ThirdType {get{return thirdType;}}

        public ushort SkillID {get{return skillID;}}
        public byte Value {get{return value;}}
        public byte SkillGroup {get{return skillGroup;}}
        public byte SkillClass {get{return skillClass;}}
        public sbyte SkillStep {get{return skillStep;}}
        public byte SkillLevel {get{return skillLevel;}}
        public ushort AbilityID {get{return abilityID;}}
        public ushort QuestID {get{return questID;}}
        public byte Clan {get{return clan;}}
        public byte CharacterGrade {get{return characGrade;}}
        public byte Class { get { return classID; } }
        public uint xsdName;
        public uint xsdInfo;

        public static Map<ItemBook> mapBooks = new Map<ItemBook>();
        public sbyte thirdType;
        public ushort skillID;
        public byte value;
        public byte skillGroup;
        public byte skillClass;
        public sbyte skillStep;
        public byte skillLevel;
        public ushort abilityID;
        public ushort questID;
        public ushort hiddenID;
        public sbyte prob;
        public ushort delay;
        public bool delete;
        public uint applyTime;
        public ushort cooldown;
        public byte clan;
        public byte characGrade; //2nd role or not - 0/2 value
        public byte classID; //role
        public RequiredSkill[] skills = new RequiredSkill[3];
        public ushort requiredAbilityID;
        public sbyte requiredAbilityStep;
        public ushort requiredLevel;
        public ushort requiredStr;
        public ushort requiredEss;
        public ushort requiredWis;
        public ushort requiredCon;
        public ushort requiredDex;
        public ushort requiredHP;
        public ushort requiredVE;
    }
}
