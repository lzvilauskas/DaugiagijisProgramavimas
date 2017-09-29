using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1_praktine_uzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            failuListBox.HorizontalScrollbar = true;
        }

        private void aplankoBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog aplankoPasirinkimas = new FolderBrowserDialog();
            if (aplankoPasirinkimas.ShowDialog() == DialogResult.OK)
            {
                pranesimasLabel.Text = "Vykdoma paieška. Palaukite";
                failuListBox.Items.Clear();

                Paieska ieska = new Paieska(aplankoPasirinkimas.SelectedPath);
                List<string> pasikartojantysFailai = ieska.rastiPasikartojanciusAplankus();


                foreach (string failas in pasikartojantysFailai)
                {
                    failuListBox.Items.Add(failas);
                }

                pranesimasLabel.Text = "Paieška baigta. Praėjo: " + ieska.praejesLaikas.ElapsedMilliseconds + " ms";

            }
        }
    }
}
