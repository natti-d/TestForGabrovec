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
    public partial class badge_collection : Form
    {
        public badge_collection()
        {
            InitializeComponent();
        }
        
        private void toplata_staq_picbox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Казват, че габровци режат опашките на котките, за да се затваря по - бързо след тях вратата и да не изстива собата.\r\n Желаете ли инструкция за играта? При натискане на No, играта започва! Успех!", "Топлата стая",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Отрежете опашката на котката и затворете стаята по-бързо, за да я запазите по-топла! Чрез space клавиша, оцелете линията, където трябва да срежете опашката.", "Информация за игра", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            /*toplata_staq game1 = new toplata_staq();
            this.Hide();
            game1.ShowDialog();
            this.Close();*/
        }

        private void denqt_se_poznava_ot_sutrinta_picbox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Малко габровче пита продавача на гевреци:\r\n— Чичо, колко струва дупката на геврека?\r\n— Нищо не струва.\r\n— Тогава продай ми един геврек с по-голяма дупка!\r\n Желаете ли инструкция за играта? При натискане на No, таймерът и играта започват! Успех!", "Денят се познава от сутринта!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Купете, колкото се може повече гевречета с дупки за 30 секунди и спечелете своя бадж!\r\nКупуването на гевречетата се случва чрез натискане на големия червен бутон в долния десен ъгъл! При всяко натискане на бутона, вие закупувате един геврек!", "Информация за игра", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            denqt_se_poznava_ot_sutrinta game2 = new denqt_se_poznava_ot_sutrinta();
            this.Hide();
            game2.ShowDialog();
            this.Close();
        }

        private void toi_plashta_picbox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Трима приятели влезли в една гостилница. Докато двамата отишли до тоалетната, третият, който бил габровец, взел листа с менюто и набързо задраскал по-скъпите гозби. А притичалия се съдържател успокоил:\r\n— Нали аз плащам яденето…\r\n Желаете ли инструкция за играта? При натискане на No, таймерът и играта започват! Успех!", "Той плаща",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Прочетете традиционното габровксо меню и като типични габровци, задраскайте трите най-скъпи ястия! Но побързайте! Имате само 20 секунди да спестите някой лев и спечелите своя бадж, преди приятелите ви да се върнат на масата!\r\rЗадраскването на цените се случва чрез натискане на самата цена!", "Информация за игра", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            toi_plashta game3 = new toi_plashta();
            this.Hide();
            game3.ShowDialog();
            this.Close();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }
    }
}
