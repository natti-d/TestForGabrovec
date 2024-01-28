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
    public partial class toi_plashta : Form
    {
        public toi_plashta()
        {
            InitializeComponent();
        }
        Random items_price = new Random();
        List<int> items_prices = new List<int>();
        int correct_input = 0;
        int selected = 0;
        int chances = 3;
        private void toi_plashta_Load(object sender, EventArgs e)
        {
            loadInterfcae();
        }

        private int menuTime = 0;
        private void menu_timer_Tick(object sender, EventArgs e)
        {
            Random crazy_time = new Random();
            crazy_time_lbl.Text = "00:" + crazy_time.Next(0, 100).ToString();
            menuTime++;
            if (menuTime > 30)
            {
                menu_timer.Dispose();
                crazy_time_lbl.Text = "00:00";
            }
        }

        private void item_price1_Click(object sender, EventArgs e)
        {
            var largestNumbers = items_prices.OrderByDescending(n => n).Take(3);
            bool isNumberAmongTopThree = largestNumbers.Contains(items_prices[0]);
            selected++;
            menu_count_items_lbl.Text = selected.ToString() + "/3";
            chercked1.Visible = Enabled;
            if (isNumberAmongTopThree)
            {
                correct_input++;
            }

            if(selected == 3)
            {
                menu_timer.Dispose();
                winsOrNot();
            }
        }

        private void menu_item2_Click(object sender, EventArgs e)
        {
            var largestNumbers = items_prices.OrderByDescending(n => n).Take(3);
            bool isNumberAmongTopThree = largestNumbers.Contains(items_prices[1]);
            selected++;
            menu_count_items_lbl.Text = selected.ToString() + "/3";
            chercked2.Visible = Enabled;
            if (isNumberAmongTopThree)
            {
                correct_input++;
            }

            if (selected == 3)
            {
                menu_timer.Dispose();
                winsOrNot();
            }
        }

        private void menu_item3_Click(object sender, EventArgs e)
        {
            var largestNumbers = items_prices.OrderByDescending(n => n).Take(3);
            bool isNumberAmongTopThree = largestNumbers.Contains(items_prices[2]);
            selected++;
            menu_count_items_lbl.Text = selected.ToString() + "/3";
            chercked3.Visible = Enabled;
            if (isNumberAmongTopThree)
            {
                correct_input++;
            }

            if (selected == 3)
            {
                menu_timer.Dispose();
                winsOrNot();
            }
        }

        private void menu_item4_Click(object sender, EventArgs e)
        {
            var largestNumbers = items_prices.OrderByDescending(n => n).Take(3);
            bool isNumberAmongTopThree = largestNumbers.Contains(items_prices[3]);
            selected++;
            menu_count_items_lbl.Text = selected.ToString() + "/3";
            chercked4.Visible = Enabled;
            if (isNumberAmongTopThree)
            {
                correct_input++;
            }

            if (selected == 3)
            {
                menu_timer.Dispose();
                winsOrNot();
            }
        }

        private void menu_item5_Click(object sender, EventArgs e)
        {
            var largestNumbers = items_prices.OrderByDescending(n => n).Take(3);
            bool isNumberAmongTopThree = largestNumbers.Contains(items_prices[4]);
            selected++;
            menu_count_items_lbl.Text = selected.ToString() + "/3";
            chercked5.Visible = Enabled;
            if (isNumberAmongTopThree)
            {
                correct_input++;
            }

            if (selected == 3)
            {
                menu_timer.Dispose();
                winsOrNot();
            }
        }

        private void menu_item6_Click(object sender, EventArgs e)
        {
            var largestNumbers = items_prices.OrderByDescending(n => n).Take(3);
            bool isNumberAmongTopThree = largestNumbers.Contains(items_prices[5]);
            selected++;
            menu_count_items_lbl.Text = selected.ToString() + "/3";
            chercked6.Visible = Enabled;
            if (isNumberAmongTopThree)
            {
                correct_input++;
            }

            if (selected == 3)
            {
                menu_timer.Dispose();
                winsOrNot();
            }
        }

        private void menu_item7_Click(object sender, EventArgs e)
        {
            var largestNumbers = items_prices.OrderByDescending(n => n).Take(3);
            bool isNumberAmongTopThree = largestNumbers.Contains(items_prices[6]);
            selected++;
            menu_count_items_lbl.Text = selected.ToString() + "/3";
            chercked7.Visible = Enabled;
            if (isNumberAmongTopThree)
            {
                correct_input++;
            }

            if (selected == 3)
            {
                menu_timer.Dispose();
                winsOrNot();
            }
        }

        private void menu_item8_Click(object sender, EventArgs e)
        {
            var largestNumbers = items_prices.OrderByDescending(n => n).Take(3);
            bool isNumberAmongTopThree = largestNumbers.Contains(items_prices[7]);
            selected++;
            menu_count_items_lbl.Text = selected.ToString() + "/3";
            chercked8.Visible = Enabled;
            if (isNumberAmongTopThree)
            {
                correct_input++;
            }

            if (selected == 3)
            {
                menu_timer.Dispose();
                winsOrNot();
            }
        }

        private void menu_item9_Click(object sender, EventArgs e)
        {
            var largestNumbers = items_prices.OrderByDescending(n => n).Take(3);
            bool isNumberAmongTopThree = largestNumbers.Contains(items_prices[8]);
            selected++;
            menu_count_items_lbl.Text = selected.ToString() + "/3";
            chercked9.Visible = Enabled;
            if (isNumberAmongTopThree)
            {
                correct_input++;
            }

            if (selected == 3)
            {
                menu_timer.Dispose();
                winsOrNot();
            }
        }

        private void menu_item10_Click(object sender, EventArgs e)
        {
            var largestNumbers = items_prices.OrderByDescending(n => n).Take(3);
            bool isNumberAmongTopThree = largestNumbers.Contains(items_prices[9]);
            selected++;
            menu_count_items_lbl.Text = selected.ToString() + "/3";
            chercked10.Visible = Enabled;
            if (isNumberAmongTopThree)
            {
                correct_input++;
            }

            if (selected == 3)
            {
                menu_timer.Dispose();
                winsOrNot();
            }
        }

        private void menu_item11_Click(object sender, EventArgs e)
        {
            var largestNumbers = items_prices.OrderByDescending(n => n).Take(3);
            bool isNumberAmongTopThree = largestNumbers.Contains(items_prices[10]);
            selected++;
            menu_count_items_lbl.Text = selected.ToString() + "/3";
            chercked11.Visible = Enabled;
            if (isNumberAmongTopThree)
            {
                correct_input++;
            }

            if (selected == 3)
            {
                menu_timer.Dispose();
                winsOrNot();
            }
        }

        private void menu_item12_Click(object sender, EventArgs e)
        {
            var largestNumbers = items_prices.OrderByDescending(n => n).Take(3);
            bool isNumberAmongTopThree = largestNumbers.Contains(items_prices[11]);
            selected++;
            menu_count_items_lbl.Text = selected.ToString() + "/3";
            chercked12.Visible = Enabled;
            if (isNumberAmongTopThree)
            {
                correct_input++;
            }

            if (selected == 3)
            {
                menu_timer.Dispose();
                winsOrNot();
            }
        }

        private void winsOrNot()
        {
            if(correct_input == 3)
            {
                MessageBox.Show("Поздравления! Ти спечели своя бадж за тази игра!", "Победа");
                this.Close();
            }
            else
            {
                chances--;
                if(chances > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Загуби! Имаш още " + chances.ToString() + " опита.", "Загуба");
                    if (dialogResult == DialogResult.OK)
                    {
                        menu_timer.Start();
                        menuTime = 0;
                        correct_input = 0;
                        selected = 0;
                        crazy_time_lbl.Text = "00:30";
                        items_prices.Clear();
                        menu_count_items_lbl.Text = "0/3";
                        loadInterfcae();
                    }
                }
                else
                {
                    MessageBox.Show("Съжалявам! Нямате повече опити! Окончателно изгубихте своя бадж!", "Загуба");
                    this.Close();
                }
            }
        }

        private void loadInterfcae()
        {
            for (int i = 0; i < 12; i++)
            {
                items_prices.Add(items_price.Next(20, 100));
            }
            item_price1.Text = items_prices[0].ToString() + ",0";
            item_price2.Text = items_prices[1].ToString() + ",0";
            item_price3.Text = items_prices[2].ToString() + ",0";
            item_price4.Text = items_prices[3].ToString() + ",0";
            item_price5.Text = items_prices[4].ToString() + ",0";
            item_price6.Text = items_prices[5].ToString() + ",0";
            item_price7.Text = items_prices[6].ToString() + ",0";
            item_price8.Text = items_prices[7].ToString() + ",0";
            item_price9.Text = items_prices[8].ToString() + ",0";
            item_price10.Text = items_prices[9].ToString() + ",0";
            item_price11.Text = items_prices[10].ToString() + ",0";
            item_price12.Text = items_prices[11].ToString() + ",0";
            menu_timer.Start();

            chercked1.Visible = !Enabled;
            chercked2.Visible = !Enabled;
            chercked3.Visible = !Enabled;
            chercked4.Visible = !Enabled;
            chercked5.Visible = !Enabled;
            chercked6.Visible = !Enabled;
            chercked7.Visible = !Enabled;
            chercked8.Visible = !Enabled;
            chercked9.Visible = !Enabled;
            chercked10.Visible = !Enabled;
            chercked11.Visible = !Enabled;
            chercked12.Visible = !Enabled;
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void info_box_Click(object sender, EventArgs e)
        {
            menu_timer.Stop();
            DialogResult dialogResult = MessageBox.Show("Трима приятели влезли в една гостилница. Докато двамата отишли до тоалетната, третият, който бил габровец, взел листа с менюто и набързо задраскал по-скъпите гозби. А притичалия се съдържател успокоил:\r\n— Нали аз плащам яденето…\r\n Желаете ли инструкция за играта? При натискане на No, таймерът и играта започват! Успех!", "Той плаща",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResultInstruct = MessageBox.Show("Прочетете традиционното габровксо меню и като типични габровци, задраскайте трите най-скъпи ястия! Но побързайте! Имате само 20 секунди да спестите някой лев и спечелите своя бадж, преди приятелите ви да се върнат на масата!\r\rЗадраскването на цените се случва чрез натискане на самата цена!", "Информация за игра", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if(dialogResultInstruct == DialogResult.OK)
                {
                    menu_timer.Start(); 
                }
            }
            else
            {
                menu_timer.Start();
            }
        }
    }
}
