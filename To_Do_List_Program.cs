using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class To_Do_List_Program : Form
    {
        public To_Do_List_Program()
        {
            InitializeComponent();
            monthCalendar1.SelectionStart = DateTime.Now;
        }

        private void To_Do_List_Program_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (pTarihCheckBox.Checked)
            {
                pTarihText.Text = monthCalendar1.SelectionStart.ToLongDateString();
                pTarihTextShort.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            }
            else
            {
                pTarihText.Text = "Son Tarih Seçilmedi";
                pTarihTextShort.Text = "Süresiz";
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeSpan countdown = TimeSpan.FromSeconds(int.Parse(pTimerSureSecsLabel.Text));
            pTimerSure.Text=countdown.ToString();
            pTimerPBar.Maximum = int.Parse(pPBarMax.Text);
            pTimerSureSecsLabel.Text= ((int.Parse(pTimerSureSecsLabel.Text)-1).ToString());
            pTimerPBar.Value++; 
            if (int.Parse(pTimerSureSecsLabel.Text) < 10)
            {
                pTimerSure.ForeColor = Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            }
            else
            {
                pTimerSure.ForeColor = Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(209)))), ((int)(((byte)(160)))));
            }

            if (int.Parse(pTimerSureSecsLabel.Text)==0)
            {
                timer1.Stop();
                DialogResult timerDialog= MessageBox.Show("Ayarladığınız Süre Doldu!","Sayaç",MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (timerDialog == DialogResult.OK)
                {
                    pTimerKalanSureText.Visible = false;
                    pTimerSure.Visible = false;
                    pTimerSureSecsLabel.Text = "0";
                    pTimerSure.ForeColor = Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(209)))), ((int)(((byte)(160)))));
                    pTimerPBar.Visible = false;
                    pTimerPauseButton.Visible = false;
                    pTimerPRButton.Visible = false;
                    pTimerStopButton.Visible = false;
                    pTimerSSButton.Visible = true;
                    pTimerSec.Visible = true;
                    pTimerMin.Visible = true;
                    pTimerHr.Visible = true;
                    pTimerExpLabel.Visible = true;
                    pTimerHr.Value = 0;
                    pTimerMin.Value = 0;
                    pTimerSec.Value = 0;
                    pTimerPBar.Value = 0;
                }

            }
        }

        private void pGEkleButton_Click(object sender, EventArgs e)
        {
            if (pGGirdisiText.Text != String.Empty && pGGirdisiText.Text != " ")
            {
                pGListesiCheckBox.Items.Add(pTarihTextShort.Text + " - " + pGGirdisiText.Text);
                pGGirdisiText.Clear();
            }
            else
            {
                MessageBox.Show("Eklenecek Görev Bulunamadı!", "Görev Programlayıcı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pTamamlaButton_Click(object sender, EventArgs e)
        {
            for (int i = pGListesiCheckBox.SelectedIndices.Count -1;i >= 0; i--)
            {
                pTGListesiBox.Items.Add(pGListesiCheckBox.SelectedItems[i]);
                pGListesiCheckBox.Items.RemoveAt(pGListesiCheckBox.SelectedIndices[i]);
            }
        }

        private void pSilButton_Click(object sender, EventArgs e)
        {
            
            if (pGListesiCheckBox.SelectedIndex !=-1 || pTGListesiBox.SelectedIndex != -1)
            {
                if (pTGListesiBox.SelectedIndex != -1)
                {
                    pTGListesiBox.Items.RemoveAt(pTGListesiBox.SelectedIndex);
                }
                else
                {
                    pGListesiCheckBox.Items.RemoveAt(pGListesiCheckBox.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Silinecek Görev Bulunamadı!", "Görev Programlayıcı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void pTimerSSButton_Click(object sender, EventArgs e)
        {
            if (pTimerSec.Value != 0 || pTimerMin.Value != 0 || pTimerHr.Value != 0)
            {
                pTimerSureSecsLabel.Text = ((pTimerHr.Value * 60 * 60) + (pTimerMin.Value * 60) + (pTimerSec.Value)).ToString();
                pPBarMax.Text = ((pTimerHr.Value * 60 * 60) + (pTimerMin.Value * 60) + (pTimerSec.Value)).ToString();
                pTimerSSButton.Visible = false;
                pTimerStopButton.Visible = true;
                pTimerPauseButton.Visible = true;
                pTimerSec.Visible = false;
                pTimerMin.Visible = false;
                pTimerHr.Visible = false;
                pTimerExpLabel.Visible = false;
                pTimerPBar.Visible = true;
                pTimerSure.Visible = true;
                pTimerKalanSureText.Visible = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Geçerli Değer Giriniz", "Sayaç Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void pTimerPRButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pTimerPRButton.Visible = false;
            pTimerPauseButton.Visible = true;
        }

        private void pClearListButton_Click(object sender, EventArgs e)
        {
            DialogResult clearMessage = MessageBox.Show("Tüm Listeleri Temizlemek İstiyor Musunuz?", "Liste Temizleyici", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( clearMessage == DialogResult.Yes)
            {
                pTGListesiBox.Items.Clear();
                pGListesiCheckBox.Items.Clear();
            }
        }

        private void pReportButton_Click(object sender, EventArgs e)
        {
            string yol = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyadi = yol + "/Görev Planlayıcı Raporu.txt";
            StreamWriter sw = new StreamWriter(dosyadi);
            sw.WriteLine("- Görev Planlayıcı Raporu -\n");
            sw.WriteLine("Devam Eden Görevler: ");
            sw.WriteLine("NO-)Son Tarih - Görev \n");
            for (int i = 0; i < pGListesiCheckBox.Items.Count; i++)
            {
                sw.WriteLine((i+1)+"-)"+Convert.ToString(pGListesiCheckBox.Items[i]));
            }
            sw.WriteLine("\n");
            sw.WriteLine("Tamamlanmış Görevler: ");
            sw.WriteLine("NO-)Son Tarih - Görev \n");
            for (int i = 0; i < pTGListesiBox.Items.Count; i++)
            {
                sw.WriteLine((i + 1) + "-)" + Convert.ToString(pTGListesiBox.Items[i]));
            }
            sw.WriteLine("\n");
            sw.Write("*To Do List Program tarafından otomatik oluşturulmuştur.*");
            sw.WriteLine("*-Mert Denizci*");
            sw.Close();

            MessageBox.Show("Raporunuz masaüstüne kaydedildi!", "Rapor Oluşturucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pTarihCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = DateTime.Now;
        }

        private void pGeriButton_Click(object sender, EventArgs e)
        {
            for (int i = pTGListesiBox.SelectedIndices.Count -1;i >= 0; i--)
            {
                pGListesiCheckBox.Items.Add(pTGListesiBox.SelectedItems[i]);
                pTGListesiBox.Items.RemoveAt(pTGListesiBox.SelectedIndices[i]);
            }
        }

        private void pTimerStopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pTimerStopButton.Visible=false;
            pTimerSSButton.Visible=true;
            pTimerPauseButton.Visible = false;
            pTimerPRButton.Visible=false;
            pTimerSec.Visible=true;
            pTimerMin.Visible=true;
            pTimerHr.Visible=true;
            pTimerExpLabel.Visible = true;
            pTimerPBar.Visible = false;
            pTimerSure.Visible = false;
            pTimerKalanSureText.Visible = false;
            pTimerHr.Value = 0;
            pTimerMin.Value = 0;
            pTimerSec.Value = 0;
            pTimerSureSecsLabel.Text = "0";
            pPBarMax.Text = "0";
            pTimerPBar.Value = 0;
        }

        private void pTimerPauseButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pTimerPauseButton.Visible=false;
            pTimerPRButton.Visible=true;     
        }
    }
}
