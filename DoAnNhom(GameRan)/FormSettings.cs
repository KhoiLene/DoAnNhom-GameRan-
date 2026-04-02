using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnNhom_GameRan_
{
    public partial class FormSettings : Form
    {
        Dictionary<string, string> languages = new Dictionary<string, string>()
        {
            { "Vietnamese (Tiếng Việt)", "vi" },
            { "English (English)", "en" },
            { "Japanese (日本語)", "ja" },
            { "Chinese (中文)", "zh" },
            { "Korean (한국어)", "ko" }
        };

        public FormSettings()
        {
            InitializeComponent();
            InitUI();
            LoadSettings();

            LanguageManager.ApplyLanguage(this);
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            //Âm lượng
            tbVolume.Minimum = 0;
            tbVolume.Maximum = 100;

            tbVolume.Value = Properties.Settings.Default.Volume;
            radOn.Checked = Properties.Settings.Default.SoundOn;
            radOff.Checked = !Properties.Settings.Default.SoundOn;

            lblVolumeValue.Text = tbVolume.Value + "%";
            MoveLabelWithTrackBar();
        }

        private void InitUI()
        {
            cmbLanguage.DataSource = new BindingSource(languages, null);
            cmbLanguage.DisplayMember = "Key";
            cmbLanguage.ValueMember = "Value";

            tbVolume.Minimum = 0;
            tbVolume.Maximum = 100;
        }

        private void LoadSettings()
        {
            cmbLanguage.SelectedValue = Properties.Settings.Default.Language;

            radOn.Checked = Properties.Settings.Default.SoundOn;
            radOff.Checked = !Properties.Settings.Default.SoundOn;

            tbVolume.Value = Properties.Settings.Default.Volume;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // ===== LƯU NGÔN NGỮ =====
            Properties.Settings.Default.Language = cmbLanguage.SelectedValue.ToString();

            // ===== LƯU ÂM THANH =====
            Properties.Settings.Default.SoundOn = radOn.Checked;

            // ===== LƯU ÂM LƯỢNG =====
            Properties.Settings.Default.Volume = tbVolume.Value;

            // 🔥 QUAN TRỌNG
            Properties.Settings.Default.Save();

            MessageBox.Show(LanguageManager.Get("settings_saved"));

            this.Close(); // đóng form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoveLabelWithTrackBar()
        {
            int min = tbVolume.Minimum;
            int max = tbVolume.Maximum;
            int value = tbVolume.Value;

            // Tính % vị trí
            float percent = (float)(value - min) / (max - min);

            // Tính vị trí X của thumb
            int trackWidth = tbVolume.Width - 10; // trừ padding 2 bên
            int x = tbVolume.Left + (int)(trackWidth * percent);

            // Canh giữa label
            lblVolumeValue.Left = x - (lblVolumeValue.Width / 2);

            // Đặt dưới trackbar
            lblVolumeValue.Top = tbVolume.Bottom + 5;

            // Update text
            lblVolumeValue.Text = value + "%";
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            MoveLabelWithTrackBar();

            int vol = tbVolume.Value;

            lblVolumeValue.Text = vol + "%";

            Properties.Settings.Default.Volume = vol;

            if (vol == 0)
            {
                Properties.Settings.Default.SoundOn = false;
                SoundManager.StopBackground();
                radOff.Checked = true;
            }
            else
            {
                Properties.Settings.Default.SoundOn = true;
                SoundManager.PlayBackground();
                radOn.Checked = true;
            }
        }

        private void radOn_CheckedChanged(object sender, EventArgs e)
        {
            if (radOn.Checked)
            {
                Properties.Settings.Default.SoundOn = true;

                SoundManager.PlayBackground(); // bật lại
            }
        }

        private void radOff_CheckedChanged(object sender, EventArgs e)
        {
            if (radOff.Checked)
            {
                Properties.Settings.Default.SoundOn = false;

                SoundManager.StopBackground(); // 🔥 QUAN TRỌNG
            }
        }
    }
}
