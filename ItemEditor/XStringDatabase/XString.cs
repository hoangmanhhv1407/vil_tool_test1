using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ItemEditor
{
    public class XString : INotifyPropertyChanged
    {
        private int _resourceIndex;
        private List<byte[]> _textString = new List<byte[]>();
        private List<int> _textStringLength = new List<int>();
        private List<int> _parameterOrder = new List<int>();

        public string UnicodeName (int x = 0) 
            { 
               return Encoding.Unicode.GetString(_textString[x]); 
            }

        public event PropertyChangedEventHandler PropertyChanged;

        public XString()
        {
        }

        public XString(int resourceIndex, byte[] textString, int parameterOrder, int textStringLength)
        {
            _resourceIndex = resourceIndex;
            _textString.Add(textString);
            _textStringLength.Add(textStringLength);
            _parameterOrder.Add(parameterOrder);
        }

        public int ResourceIndex
        {
            get { return _resourceIndex; }
            set { _resourceIndex = value; this.NotifyPropertyChanged("ResourceIndex"); }
        }

        public List<byte[]> TextString
        {
            get { return _textString; }
            set { _textString = value; this.NotifyPropertyChanged("TextString"); }
        }

        public List<int> TextStringLength
        {
            get { return _textStringLength; }
            set { _textStringLength = value; this.NotifyPropertyChanged("TextStringLength"); }
        }

        public List<int> ParameterOrder
        {
            get { return _parameterOrder; }
            set { _parameterOrder = value; this.NotifyPropertyChanged("ParameterOrder"); }
        }

        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
