using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class zapis : Form
    {
        public zapis()
        {
            InitializeComponent();
        }
        public static string prezdivka;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {


                    prezdivka = textBox1.Text;
                    FileStream zapis = new FileStream(@"../../Scoreboard.txt", FileMode.Open, FileAccess.Write);
                    BinaryWriter zapisb = new BinaryWriter(zapis, Encoding.UTF8);
                    zapisb.BaseStream.Position = zapisb.BaseStream.Length;
                    zapisb.Write(prezdivka);
                    zapisb.Write(' ');
                    zapis.Close();
                    zapisb.Close();
                    Menu f = new Menu();
                    this.Hide();
                    f.ShowDialog();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Nastala chyba: " + ex);
                }
                catch (FileLoadException ex)
                {
                    MessageBox.Show("Nastala chyba: " + ex);
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Nastala chyba: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Nezadal jste přezdívku!!");
            }
        }
    }
    
}
