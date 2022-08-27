using EnglishDictionary.excellParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishDictionary
{
    public partial class play : Form
    {
        public play()
        {
            InitializeComponent();


            // в мкнопу это
            String path = @"g:\27.08/2022\Test";//путь к эксель
            Parser parser = new Parser(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void plai_Click(object sender, EventArgs e)
        {

        }
    }
}
