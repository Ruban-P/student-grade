using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    class grade1
    {
        List<int> lst;

        public List<int> Lst
        {
            get { return lst; }
            
        } 
        public void add(List<int> l)
        {
            lst = new List<int>();
            foreach (int x in l)
            {
                lst.Add(x);
            }
        }
        public grade1()
        {
            Sname = null;
            Rollno = 0;
            
        }
        public grade1(string name,int rollno)
        {
            this.Sname = name;
            this.Rollno = rollno;
            
           
        }
        string _sname;

        public string Sname
        {
            get { return _sname; }
            set { _sname = value; }
        }
        int _rollno;

        public int Rollno
        {
            get { return _rollno; }
            set { _rollno = value; }
        }


        public override string ToString()
        {
            string x = "";
            string y = "";
            int j = 1;
            foreach (int i in lst)
            {
                y += "mark" + j + "\t";
                x += i + "\t";
                j++;
            }

            return "NAME\tROLLNO\t"+y+"\n\n"+Sname + "\t" + Rollno + "\t" + x;

        }
    }
}
