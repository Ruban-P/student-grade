using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    class find
    {
        List<grade1> _stud;
        public find()
        {
            _stud = new List<grade1>();
        }
        public void Addstud(grade1 g1)
        {
            _stud.Add(g1);
        }
        int _total;

        public int Total
        {
            get { return _total; }
           
        }
        public void totl(List<int> l)
        {
            int sum = 0;
            
            for (int i = 0; i < l.Count; i++)
            {
                sum += l[i];
            }
            _total = sum;
        }
      
        int _min;

        public int Min
        {
            get { return _min; }
            
        }

        public void mini(List<int> l)
        {
           _min= l.Min();
        }

        int _maxm;

        public int Maxm
        {
            get { return _maxm; }
            
        }
        public void maxi(List<int> l)
        {
           _maxm= l.Max();
        }
        double _avg;

        public double Avg
        {
            get {
                return _avg;             
                }           
        }
        public void avgerage(int value)
        {
            _avg = (double)_total / value;
        }

        public override string ToString()
        {
            string X = "";
            X += "\nName\tROLLNO\tTOTAL\tMINIMUM\tMAXIMUM\tavgerage\n\n";
            foreach (grade1 g1 in _stud)
            {
                X += g1.Sname + "\t" + g1.Rollno + "\t" + _total + "\t" + _min + "\t" + _maxm +"\t"+Avg+ "\n";
            }

            return X;
        }
    }
}
