using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bazadedate
{
    public  class tabel
    {
        public int idTabel;
        public string denumireTabel;

        public List<rand> table = new List<rand>();
        
        public tabel() { }

        public void adugaRandul()
        {
            table.Add(new rand());
          
           
        }
       
        public void adaugaInregistrarea(int pid, int prand , int coloana, string pvaloare, string pformatul)
        {
            this.table[coloana].randul[prand].idCelula = pid;
            this.table[coloana].randul[prand].valoare = pvaloare;
            this.table[coloana].randul[prand].formatul = pformatul;
        }
        
    }
}
