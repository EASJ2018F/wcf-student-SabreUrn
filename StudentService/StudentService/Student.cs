using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentService {
    public class Student {
        private string _name;
        private string _className;
        private string _room;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public string ClassName {
            get { return _className; }
            set { _className = value; }
        }

        public string Room {
            get { return _room; }
            set { _room = value; }
        }

        public Student(string name, string className, string room) {
            _name = name;
            _className = className;
            _room = room;
        }
    }
}