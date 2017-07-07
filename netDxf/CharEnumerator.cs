using System.Collections;
using System.Collections.Generic;

namespace netDxf
{

    public class CharEnumerator : IEnumerator<char>
    {

        int idx = -1;
        string str;

        public CharEnumerator(string str)
        {
            this.str = str;
        }

        char _Current
        {
            get
            {
                if (idx == -1 || idx >= str.Length) throw new System.IndexOutOfRangeException();

                return str[idx];
            }
        }

        public char Current
        {
            get
            {
                return _Current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return _Current;
            }
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            idx++;
            return idx < str.Length;
        }

        public void Reset()
        {
            idx = 0;
        }
    }

    public static partial class Extensions
    {

        public static CharEnumerator GetEnumerator(this string str)
        {
            return new CharEnumerator(str);
        }

    }

}