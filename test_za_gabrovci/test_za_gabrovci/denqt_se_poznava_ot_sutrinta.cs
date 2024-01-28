using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_za_gabrovci
{
    public partial class denqt_se_poznava_ot_sutrinta : Form
    {
        public denqt_se_poznava_ot_sutrinta()
        {
            InitializeComponent();
        }

        private int chances = 3;
        //Generating Gevreci
        Random gevrek_location = new Random();
        List<PictureBox> gevreci = new List<PictureBox>();
        private void red_big_btn_Click(object sender, EventArgs e)
        {
            if (gevrek_timer.Enabled)
            {
                newGevrekGenerator();
            }
        }

        //Ne zasicha when space pressed
        private void denqt_se_poznava_ot_sutrinta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && gevrek_timer.Enabled)
            {
                newGevrekGenerator();
                MessageBox.Show("hdgfh");
            }
        }

        private void newGevrekGenerator()
        {
            gevrek_count_txtbox.Text = gevreci.Count.ToString();
            PictureBox newGevrek = new PictureBox();
            newGevrek.Height = 119;
            newGevrek.Width = 121;
            newGevrek.BackColor = Color.Transparent;
            newGevrek.BackgroundImage = Image.FromFile(@"C:\Users\HP\Desktop\nat\gamejam\repo\test_za_gabrovci\test_za_gabrovci\Resources\gevrek.png");
            newGevrek.SizeMode = PictureBoxSizeMode.Zoom;
            //ne se stratchva image-a

            int x = gevrek_location.Next(0, this.ClientSize.Width - (gevrek_broika_panel.Width + newGevrek.Width));
            int y = gevrek_location.Next(name_panel.Height, (this.ClientSize.Height - newGevrek.Height));
            newGevrek.Location = new Point(x, y);

            gevreci.Add(newGevrek);
            this.Controls.Add(newGevrek);
        }

        //Timer
        private int gevrekTime = 0;
        private void gevrek_time_Tick(object sender, EventArgs e)
        {
            Random crazy_time = new Random();
            crazy_time_lbl.Text = "00:" + crazy_time.Next(0, 100).ToString();

            gevrekTime++;
            if(gevrekTime > 30)
            {
                gevrek_timer.Dispose();
                crazy_time_lbl.Text = "00:00";
                if(gevreci.Count >= 50)
                {
                    MessageBox.Show("Поздравления! Ти спечели своя бадж за тази игра!", "Победа");
                    this.Close();
                }
                else
                {
                    chances--;
                    if (chances > 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Загуби! Имаш още " + chances.ToString() + " опита.", "Загуба");
                        if(dialogResult == DialogResult.OK)
                        {
                            gevrek_timer.Start();
                            gevrekTime = 0;
                            crazy_time_lbl.Text = "00:30";
                            gevreci.Clear();
                            gevrek_count_txtbox.Text = gevreci.Count.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Съжалявам! Нямате повече опити! Окончателно изгубихте своя бадж!", "Загуба");
                        this.Close();
                    }
                }
            }
        }

        private void denqt_se_poznava_ot_sutrinta_Load(object sender, EventArgs e)
        {
            gevrek_timer.Start();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void info_box_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Малко габровче пита продавача на гевреци:\r\n— Чичо, колко струва дупката на геврека?\r\n— Нищо не струва.\r\n— Тогава продай ми един геврек с по-голяма дупка!\r\n Желаете ли инструкция за играта? При натискане на No, таймерът и играта започват! Успех!", "Денят се познава от сутринта!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResultInstruct = MessageBox.Show("Купете, колкото се може повече гевречета с дупки за 30 секунди и спечелете своя бадж!\r\nКупуването на гевречетата се случва чрез натискане на големия червен бутон в долния десен ъгъл! При всяко натискане на бутона, вие закупувате един геврек!", "Информация за игра", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if(dialogResultInstruct == DialogResult.OK)
                {
                    gevrek_timer.Start();
                }
            }
            else
            {
                gevrek_timer.Start();
            }
        }
    }
}
