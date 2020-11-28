using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Executer
{
    public class Software
    {
        private int id;
        private int scheme_id;
        private String name;
        private String path;
        private String openPath;

        public Software(int id, int scheme_id, string name, string path, string openPath)
        {
            this.id = id;
            this.scheme_id = scheme_id;
            this.name = name;
            this.path = path;
            this.openPath = openPath;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Scheme_id
        {
            get { return scheme_id; }
            set { scheme_id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        public string OpenPath
        {
            get { return openPath; }
            set { openPath = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
