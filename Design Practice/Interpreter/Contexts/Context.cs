using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.Contexts
{
    class Context
    {
        private string _input;
        private int _output;

        //constructor
        public Context(string input)
        {
            _input = input;
        }

        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        public int Output
        {
            get { return _output; }
            set { _output = value; }
        }
    }
}
