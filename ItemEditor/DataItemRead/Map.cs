using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    /// <summary>
    /// Default map is using int as key and string as value
    /// </summary>
    public class Map : SortedDictionary<int, string>
    {
        
    }

    /// <summary>
    /// Map that uses short as a key
    /// </summary>
    /// <typeparam name="T">Value type</typeparam>
    public class Map<T> : SortedDictionary<short, T>
    {

    }

    public class Map<K, T> : SortedDictionary<K, T>
    {

    }
}
