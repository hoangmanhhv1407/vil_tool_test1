using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    public interface IItem
    {
        void Load(Stream s);
        void Save(Stream s);
        //void SaveMap(Map<IItem> map, Type type, ItemType itemType, Stream s);
    }
}
