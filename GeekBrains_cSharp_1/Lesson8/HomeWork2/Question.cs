using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    [Serializable]
    public class Question
    {
        public string Text { get; set; }
        public bool TrueFalse { get; set; }

        public Question()
        {

        }
        public Question(string _text, bool _truefalse)
        {
            Text = _text;
            TrueFalse = _truefalse;
        }
    }
}
