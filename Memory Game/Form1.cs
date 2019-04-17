using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class MemoryGame : Form
    {
        public bool isStart = false;
        int time;
        Button marked;
        Dictionary<Button, bool> cards = new Dictionary<Button, bool>();

        public MemoryGame()
        {
            InitializeComponent();            
            isStart = false;
            timer.Interval = 1000;
            generateNumbers();
        }

        public void generateNumbers()
        {
            time = 0;
            marked = null;
            timeLabel.Text = "0s";
            Random rand = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                numbers.Add(i);
                numbers.Add(i);
            }
            foreach (var elem in topTable.Controls)
            {
                Button b = (Button)elem;
                if (!cards.ContainsKey(b))
                    cards.Add(b, false);
                else cards[b] = false;                
                b.Visible = true;
                b.BackColor = Color.AliceBlue;
                int cardValue = rand.Next(0, numbers.Count);
                b.Text = (numbers[cardValue]).ToString();
                numbers.RemoveAt(cardValue);
            }
        }

        private void Card_MouseEnters(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (cards[b] == true) return;
            b.BackColor = Color.Blue;
        }

        private void Card_MouseLeaves(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            if (cards[b] == true) return;
            b.BackColor = Color.AliceBlue;          
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if(isStart)
            {
                Button b = (Button)sender;        
                if(marked!=null)
                {
                    if(marked.Equals(b)) return;
                    if(marked.Text.Equals(b.Text))
                    {
                        marked.Visible = false;
                        b.Visible = false;
                        marked = null;
                        bool IsWin = true;
                        foreach(Button elem in topTable.Controls)
                        {
                            if(elem.Visible == true)
                            {
                                IsWin = false;
                                break;
                            }
                        }
                        if(IsWin)
                        {
                            timer.Stop();
                            isStart = false;
                            StartPauseButton.Text = "Start";
                            string message = "Your time: " + time.ToString() + "s. Do you want to play again?";                            
                            DialogResult res = MessageBox.Show(message, "The end", MessageBoxButtons.YesNo);
                            if(res == DialogResult.No)
                                this.Close();
                            else generateNumbers();
                        }
                        return;
                    }
                    cards[marked] = false;
                    marked.BackColor = Color.AliceBlue;
                    marked = null;
                }
                else
                {
                    b.BackColor = Color.OrangeRed;
                    cards[b] = true;
                    marked = b;
                }                
            }            
        }

        private void Start_Pause_Click(object sender, EventArgs e)
        {
            if (isStart)
            {
                isStart = false;
                timer.Stop();
                StartPauseButton.Text = "Start";
            }
            else
            {
                isStart = true;
                timer.Start();
                StartPauseButton.Text = "Pause";
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            isStart = false;
            StartPauseButton.Text = "Start";
            timer.Stop();
            generateNumbers();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            timeLabel.Text = time.ToString() + "s";
        }
    }
}
