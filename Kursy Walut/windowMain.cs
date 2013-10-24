using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.IO;
//TODO oddzielić logikę od interfejsu - pewnie nigdy mi się nie będzie chciało

namespace Kursy_Walut
{
    public partial class windowMain : Form
    {
        public windowMain()
        {
            InitializeComponent();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pobierzKursyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewKursy.Items.Clear();

            if (siec.pobierzKursy() == 0) MessageBox.Show("Wystąpił błąd podczas pobierania kursów!");

            StreamReader reader = new StreamReader("bankier.html");
            string input = reader.ReadToEnd();
            reader.Close();

            //Pobieranie jednostek np 1 AUD
            List<string> liJednostki = new List<string>();
            Match matchJednostka = Regex.Match(input, @"<td>\d+ [A-Z]{3}");
            while (matchJednostka.Success)
            {
                liJednostki.Add(matchJednostka.Value.Remove(0, 4));
                matchJednostka = matchJednostka.NextMatch();
            }

            //Pobieranie wartosci np 3.1231
            List<string> liWartosci = new List<string>();
            Match matchWartosc = Regex.Match(input, @"<b>\d\.\d{4}");
            while (matchWartosc.Success)
            {
                liWartosci.Add(matchWartosc.Value.Remove(0, 3));
                matchWartosc = matchWartosc.NextMatch();
            }

            //Wypisanie wyników
            for (int i = 0; i < liJednostki.Count; i++)
            {
                ListViewItem nowyElem = new ListViewItem(liJednostki[i]);
                nowyElem.SubItems.Add(liWartosci[i]);
                listViewKursy.Items.Add(nowyElem);
            }
        }
    }
}
