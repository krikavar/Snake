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
    public partial class Hra : Form
    {
        int sirka, vyska, score, NejSkore;
        bool doleva, doprava, dolu, nahoru;
        private List<Pozice> Snake = new List<Pozice>();
        private Pozice jidlo = new Pozice();
        Random rand = new Random();
        int rychlost;

        public Hra(int rychlost)
        {
            InitializeComponent();
            this.rychlost = rychlost;
            new Nastaveni();
        }

        
        private void startButton_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void Hra_Load(object sender, EventArgs e)
        {
            //Nastavení názvu formuláře podle rychlosti 
            if (rychlost == 100) { this.Text = "Lehký Snake"; }
            if (rychlost == 50) { this.Text = "Střední Snake"; }
            if (rychlost == 25) { this.Text = "Nejtěžší Snake"; }
            if (rychlost == 10) { this.Text = "Hardcore Snake"; }
        }

        private void startButton_KeyUp(object sender, KeyEventArgs e)

        {
            
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void Hra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && Nastaveni.smer != "up") { dolu = true; }
            if (e.KeyCode == Keys.Left && Nastaveni.smer != "right") { doleva = true; }
            if (e.KeyCode == Keys.Up && Nastaveni.smer != "down") { nahoru = true; }
            if (e.KeyCode == Keys.Right && Nastaveni.smer != "left") { doprava = true; }
        }

        private void Hra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { doprava = false; }
            if (e.KeyCode == Keys.Down) { dolu = false; }
            if (e.KeyCode == Keys.Left) { doleva = false; }
            if (e.KeyCode == Keys.Up) { nahoru = false; }
        }

        private void timer_pohyb_Tick(object sender, EventArgs e)
        {
            timer_pohyb.Interval = rychlost;
            if (nahoru) { Nastaveni.smer = "up"; }
            if (doprava) { Nastaveni.smer = "right"; }
            if (doleva) { Nastaveni.smer = "left"; }
            if (dolu) { Nastaveni.smer = "down"; }
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Nastaveni.smer)
                    {
                        case "right":
                            Snake[i].x++;
                            break;
                        case "left":
                            Snake[i].x--;
                            break;
                        case "up":
                            Snake[i].y--;
                            break;
                        case "down":
                            Snake[i].y++;
                            break;
                    }
                    if (Snake[i].x < 0) { Snake[i].x = sirka; }
                    if (Snake[i].x > sirka) { Snake[i].x = 0; }
                    if (Snake[i].y < 0) { Snake[i].y = vyska; }
                    if (Snake[i].y > vyska) { Snake[i].y = 0; }
                    if (Snake[i].x == jidlo.x && Snake[i].y == jidlo.y) { Papani(); }
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].x == Snake[j].x && Snake[i].y == Snake[j].y) { GameOver(); }
                    }
                }
                else
                {
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }
            picBox.Invalidate();
        }
        private void picBox_Paint(object sender, PaintEventArgs e)
        {
            //vykreslování hada a nastavení jeho barvy
            Graphics obraz = e.Graphics;
            Brush barvaHada;
            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    barvaHada = Brushes.Pink;
                }
                else
                {
                    barvaHada = Brushes.DeepPink;
                }
                obraz.FillEllipse(barvaHada, new Rectangle
                    (
                    Snake[i].x * Nastaveni.Sirka,
                    Snake[i].y * Nastaveni.Vyska,
                    Nastaveni.Sirka, Nastaveni.Vyska
                    ));
            }
            obraz.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            jidlo.x * Nastaveni.Sirka,
            jidlo.y * Nastaveni.Vyska,
            Nastaveni.Sirka, Nastaveni.Vyska
            ));
        }

        

        private void button_close_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        

       
        private void RestartGame()
        {
            sirka = picBox.Width / Nastaveni.Sirka - 1;
            vyska = picBox.Height / Nastaveni.Vyska - 1;
            Snake.Clear();
            startButton.Enabled = false;
            if (startButton.Enabled == false)
            {
                button_close.Enabled = false;
            }
            score = 0;
            Skore.Text = "Skóre: " + score;
            Pozice hlava = new Pozice { x = 15, y = 15 };
            Snake.Add(hlava);
            for (int i = 0; i < 10; i++)
            {
                Pozice telo = new Pozice();
                Snake.Add(telo);
            }
            jidlo = new Pozice { x = rand.Next(2, sirka), y = rand.Next(2, vyska) };
            timer_pohyb.Start();

        }
        private void Papani()
        {
            //když se zavolá tahle metoda, tak se přidá skore a vypíše do labelu
            score += 1;
            Skore.Text = "Skóre: " + score;
            Pozice telo = new Pozice
            {
                x = Snake[Snake.Count - 1].x,
                y = Snake[Snake.Count - 1].y
            };
            Snake.Add(telo);
            jidlo = new Pozice { x = rand.Next(2, sirka), y = rand.Next(2, vyska) };
        }
        private void GameOver()
        {
            //kdyz hra skončí povolí se button na start
            timer_pohyb.Stop();
            MessageBox.Show("GAME OVER!");
            startButton.Enabled = true;
            button_close.Enabled = true;
            //přepisování největšího skóre
            if (score > NejSkore)
            {
                NejSkore = score;

                NejScore.Text = "Největší skóre: " + Environment.NewLine + NejSkore;
                NejScore.ForeColor = Color.GreenYellow;
                NejScore.TextAlign = ContentAlignment.MiddleCenter;
            }
            //ukládání do txt skóre, úroveň a nickname
            if (rychlost == 100)
            {
                using (StreamWriter writer = new StreamWriter(@"../../Scoreboard.txt", true)) // Použití příznaku "true" pro přidávání dat na konec souboru
                {
                    writer.WriteLine("Skóre: " + score.ToString() + ", obtížnost: lehká, hráč: " + zapis.prezdivka);
                }
            }
            if (rychlost == 50)
            {
                using (StreamWriter writer = new StreamWriter(@"../../Scoreboard.txt", true)) // Použití příznaku "true" pro přidávání dat na konec souboru
                {
                    writer.WriteLine("Skóre: " + score.ToString() + ", obtížnost: střední, hráč: " + zapis.prezdivka);
                }
            }
            if (rychlost == 25)
            {
                using (StreamWriter writer = new StreamWriter(@"../../Scoreboard.txt", true)) // Použití příznaku "true" pro přidávání dat na konec souboru
                {
                    writer.WriteLine("Skóre: " + score.ToString() + ", obtížnost: nejtěžší, hráč: " + zapis.prezdivka);
                }
            }
            if (rychlost == 10)
            {
                using (StreamWriter writer = new StreamWriter(@"../../Scoreboard.txt", true)) // Použití příznaku "true" pro přidávání dat na konec souboru
                {
                    writer.WriteLine("Skóre: " + score.ToString() + ", obtížnost: hardcore, hráč: " + zapis.prezdivka);
                }
            }

        }
    }
}
