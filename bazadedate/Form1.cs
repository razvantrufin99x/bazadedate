using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bazadedate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public db db0 = new db();

        private void Form1_Load(object sender, EventArgs e)
        {
            db0.denumire = "tabel gol";
            db0.iddb = 1;

            db0.tabele.Add(new tabel());

            db0.tabele[0].adugaRandul();
            
            db0.tabele[0].table[0].adaugaCelula();
            db0.tabele[0].table[0].adaugaNCelule(9);

            db0.tabele[0].table[0].randul[0].idCelula = 1;
            db0.tabele[0].table[0].randul[0].valoare = "100";
            db0.tabele[0].table[0].randul[0].formatul = "integer";

            db0.tabele[0].table[0].randul[1].idCelula = 2;
            db0.tabele[0].table[0].randul[1].valoare = "200";
            db0.tabele[0].table[0].randul[1].formatul = "integer";

            db0.tabele[0].table[0].randul[2].idCelula = 3;
            db0.tabele[0].table[0].randul[2].valoare = "1300";
            db0.tabele[0].table[0].randul[2].formatul = "integer";

            db0.tabele[0].table[0].randul[3].idCelula = 4;
            db0.tabele[0].table[0].randul[3].valoare = "14400";
            db0.tabele[0].table[0].randul[3].formatul = "integer";


            Text = db0.tabele[0].table[0].randul[0].valoare;
            Text += ";";
            Text += db0.tabele[0].table[0].randul[1].valoare;
            Text += ";";
            Text += db0.tabele[0].table[0].randul[2].valoare;
            Text += ";";
            Text += db0.tabele[0].table[0].randul[3].valoare;
            Text += ";";

            int a = Convert.ToInt16(db0.tabele[0].table[0].randul[0].valoare);
            int b = Convert.ToInt16(db0.tabele[0].table[0].randul[1].valoare);
            int c = Convert.ToInt16(db0.tabele[0].table[0].randul[2].valoare);
            int d = Convert.ToInt16(db0.tabele[0].table[0].randul[3].valoare);
            int pe = a + b + c + d;

            db0.tabele[0].table[0].randul[4].idCelula = 5;
            db0.tabele[0].table[0].randul[4].valoare = pe.ToString();
            db0.tabele[0].table[0].randul[4].formatul = "integer";
        
            Text += "=";
            Text += db0.tabele[0].table[0].randul[4].valoare;
            Text += ";";
        }
    }
}
