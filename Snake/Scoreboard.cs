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
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Scoreboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            try
            {
                // Název souboru
                string line;

                using (StreamReader reader = new StreamReader(@"../../Scoreboard.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }

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
    }
}
