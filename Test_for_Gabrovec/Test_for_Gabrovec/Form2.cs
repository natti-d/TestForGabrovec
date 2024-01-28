using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_for_Gabrovec
{
    public partial class toplata_staq : Form
    {
        private bool movingUp = true;
        private bool isMoving = true;
        private int chances = 3;
        public toplata_staq()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMoving)
            {
                if (movingUp)
                {
                    nojici.Top -= 35;
                }
                else
                {
                    nojici.Top += 35;
                }

             
                if (nojici.Top <= 0)
                {
                    movingUp = false;
                }
                else if (nojici.Bottom >= this.ClientSize.Height - name_panel.Height)
                {
                    movingUp = true;
                }
            }

            

        }

        private void toplata_staq_Load(object sender, EventArgs e)
        {
            nojici.Location = new System.Drawing.Point(50, 50);
            timer1.Start();
        }

        private void toplata_staq_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                isMoving = !isMoving;
                if (nojici.Bounds.IntersectsWith(opashka.Bounds))
                {
                    timer1.Stop();
                    MessageBox.Show("Поздравления! Ти спечели своят бадж за истински габровец и скъперник!");
                    this.Close();
                }
                else
                {
                    chances--;
                    if (chances > 0)
                    {
                        MessageBox.Show($"Опитай отново! Остават ти {chances} опита.");
                        ResetGame();
                    }
                    else
                    {
                        MessageBox.Show("Свършиха ти опитите. Загуби играта.");
                        timer1.Stop();
                        this.Close();
                    }

                }
            }
        }

        private void ResetGame()
        {
            nojici.Location = new System.Drawing.Point(32, 177);
            opashka.Location = new System.Drawing.Point(35, 178);

            isMoving = true;
        }
    }
}
