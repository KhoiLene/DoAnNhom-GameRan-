namespace DoAnNhom_GameRan_
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblSound = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.radOn = new System.Windows.Forms.RadioButton();
            this.radOff = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblVolumeValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblSettings.Image = global::DoAnNhom_GameRan_.Properties.Resources.Font;
            this.lblSettings.Location = new System.Drawing.Point(112, 16);
            this.lblSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(86, 25);
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Tag = "settings";
            this.lblSettings.Text = "Settings";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblLanguage.Image = global::DoAnNhom_GameRan_.Properties.Resources.Font;
            this.lblLanguage.Location = new System.Drawing.Point(30, 58);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(77, 17);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Tag = "language";
            this.lblLanguage.Text = "Language :";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblVolume.Image = global::DoAnNhom_GameRan_.Properties.Resources.Font;
            this.lblVolume.Location = new System.Drawing.Point(30, 115);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(64, 17);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Tag = "volume";
            this.lblVolume.Text = "Volume :";
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblSound.Image = global::DoAnNhom_GameRan_.Properties.Resources.Font;
            this.lblSound.Location = new System.Drawing.Point(30, 174);
            this.lblSound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(103, 17);
            this.lblSound.TabIndex = 3;
            this.lblSound.Tag = "sound_toggle";
            this.lblSound.Text = "Sound On/Off :";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(103, 55);
            this.cmbLanguage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(132, 21);
            this.cmbLanguage.TabIndex = 4;
            // 
            // tbVolume
            // 
            this.tbVolume.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbVolume.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.tbVolume.Location = new System.Drawing.Point(103, 104);
            this.tbVolume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(202, 45);
            this.tbVolume.TabIndex = 8;
            this.tbVolume.TabStop = false;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // radOn
            // 
            this.radOn.AutoSize = true;
            this.radOn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radOn.Location = new System.Drawing.Point(160, 174);
            this.radOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radOn.Name = "radOn";
            this.radOn.Size = new System.Drawing.Size(45, 18);
            this.radOn.TabIndex = 9;
            this.radOn.TabStop = true;
            this.radOn.Tag = "on";
            this.radOn.Text = "On";
            this.radOn.UseVisualStyleBackColor = true;
            this.radOn.CheckedChanged += new System.EventHandler(this.radOn_CheckedChanged);
            // 
            // radOff
            // 
            this.radOff.AutoSize = true;
            this.radOff.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radOff.Location = new System.Drawing.Point(213, 174);
            this.radOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radOff.Name = "radOff";
            this.radOff.Size = new System.Drawing.Size(45, 18);
            this.radOff.TabIndex = 10;
            this.radOff.TabStop = true;
            this.radOff.Tag = "off";
            this.radOff.Text = "Off";
            this.radOff.UseVisualStyleBackColor = true;
            this.radOff.CheckedChanged += new System.EventHandler(this.radOff_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btnSave.Image = global::DoAnNhom_GameRan_.Properties.Resources.Font;
            this.btnSave.Location = new System.Drawing.Point(98, 210);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 11;
            this.btnSave.Tag = "save";
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.button2.Image = global::DoAnNhom_GameRan_.Properties.Resources.Font;
            this.button2.Location = new System.Drawing.Point(178, 210);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 12;
            this.button2.Tag = "cancel";
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblVolumeValue
            // 
            this.lblVolumeValue.AutoSize = true;
            //this.lblVolumeValue.Image = global::DoAnNhom_GameRan_.Properties.Resources.Font;
            this.lblVolumeValue.Location = new System.Drawing.Point(115, 152);
            this.lblVolumeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumeValue.Name = "lblVolumeValue";
            this.lblVolumeValue.Size = new System.Drawing.Size(0, 13);
            this.lblVolumeValue.TabIndex = 13;
            this.lblVolumeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            //this.BackgroundImage = global::DoAnNhom_GameRan_.Properties.Resources.Font;
            this.ClientSize = new System.Drawing.Size(357, 245);
            this.Controls.Add(this.lblVolumeValue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radOff);
            this.Controls.Add(this.radOn);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblSettings);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.RadioButton radOn;
        private System.Windows.Forms.RadioButton radOff;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblVolumeValue;
    }
}