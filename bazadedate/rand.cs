using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bazadedate
{
    public class rand
    {
        public int idrand;
        public List<celula> randul  = new List<celula>();
        public void adaugaCelula() { 
            randul.Add(new celula());
        }
        public void adaugaNCelule(int n) {
            for(int i = 0; i< n; i++)
            {
                adaugaCelula();
            }
        }
    }
}
