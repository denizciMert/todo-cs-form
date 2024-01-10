namespace To_Do_List
{
    partial class To_Do_List_Program
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(To_Do_List_Program));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pGEkleyiciBox = new System.Windows.Forms.GroupBox();
            this.pGGirdisiLabel = new System.Windows.Forms.Label();
            this.pTarihExLabel = new System.Windows.Forms.Label();
            this.pGGirdisiText = new System.Windows.Forms.TextBox();
            this.pTarihText = new System.Windows.Forms.TextBox();
            this.pTarihCheckBox = new System.Windows.Forms.CheckBox();
            this.pGEkleButton = new System.Windows.Forms.Button();
            this.pGPlanlanyiciBox = new System.Windows.Forms.GroupBox();
            this.pGeriButton = new System.Windows.Forms.Button();
            this.pGListesiCheckBox = new System.Windows.Forms.ListBox();
            this.pGEkleLabel = new System.Windows.Forms.Label();
            this.pTamamlanmisLabel = new System.Windows.Forms.Label();
            this.pTamamlanacakLabel = new System.Windows.Forms.Label();
            this.pTGListesiBox = new System.Windows.Forms.ListBox();
            this.pSilButton = new System.Windows.Forms.Button();
            this.pTamamlaButton = new System.Windows.Forms.Button();
            this.pTimerPRButton = new System.Windows.Forms.Button();
            this.pTimerGroupBox = new System.Windows.Forms.GroupBox();
            this.pTimerSure = new System.Windows.Forms.Label();
            this.pTimerKalanSureText = new System.Windows.Forms.Label();
            this.pTimerPauseButton = new System.Windows.Forms.Button();
            this.pTimerExpLabel = new System.Windows.Forms.Label();
            this.pTimerStopButton = new System.Windows.Forms.Button();
            this.pTimerHr = new System.Windows.Forms.NumericUpDown();
            this.pTimerMin = new System.Windows.Forms.NumericUpDown();
            this.pTimerSec = new System.Windows.Forms.NumericUpDown();
            this.pTimerPBar = new System.Windows.Forms.ProgressBar();
            this.pTimerSSButton = new System.Windows.Forms.Button();
            this.pReportButton = new System.Windows.Forms.Button();
            this.pClearListButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pTarihTextShort = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pProgExp1Label = new System.Windows.Forms.Label();
            this.pProgExp2Label = new System.Windows.Forms.Label();
            this.pTimerSureSecsLabel = new System.Windows.Forms.Label();
            this.pPBarMax = new System.Windows.Forms.Label();
            this.pGEkleyiciBox.SuspendLayout();
            this.pGPlanlanyiciBox.SuspendLayout();
            this.pTimerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pTimerHr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTimerMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTimerSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 84);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pGEkleyiciBox
            // 
            this.pGEkleyiciBox.Controls.Add(this.pGGirdisiLabel);
            this.pGEkleyiciBox.Controls.Add(this.pTarihExLabel);
            this.pGEkleyiciBox.Controls.Add(this.pGGirdisiText);
            this.pGEkleyiciBox.Controls.Add(this.pTarihText);
            this.pGEkleyiciBox.Controls.Add(this.pTarihCheckBox);
            this.pGEkleyiciBox.Controls.Add(this.monthCalendar1);
            this.pGEkleyiciBox.Controls.Add(this.pGEkleButton);
            this.pGEkleyiciBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pGEkleyiciBox.Location = new System.Drawing.Point(17, 48);
            this.pGEkleyiciBox.Name = "pGEkleyiciBox";
            this.pGEkleyiciBox.Size = new System.Drawing.Size(476, 272);
            this.pGEkleyiciBox.TabIndex = 1;
            this.pGEkleyiciBox.TabStop = false;
            // 
            // pGGirdisiLabel
            // 
            this.pGGirdisiLabel.AutoSize = true;
            this.pGGirdisiLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pGGirdisiLabel.Location = new System.Drawing.Point(12, 19);
            this.pGGirdisiLabel.Name = "pGGirdisiLabel";
            this.pGGirdisiLabel.Size = new System.Drawing.Size(138, 17);
            this.pGGirdisiLabel.TabIndex = 13;
            this.pGGirdisiLabel.Text = "Eklenecek görevi girin:";
            // 
            // pTarihExLabel
            // 
            this.pTarihExLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTarihExLabel.Location = new System.Drawing.Point(281, 176);
            this.pTarihExLabel.Name = "pTarihExLabel";
            this.pTarihExLabel.Size = new System.Drawing.Size(155, 70);
            this.pTarihExLabel.TabIndex = 12;
            this.pTarihExLabel.Text = "Bitiş süresi eklemek için yukarıdaki kutucuğu işaretleyin ve tarih seçin.";
            // 
            // pGGirdisiText
            // 
            this.pGGirdisiText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.pGGirdisiText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGGirdisiText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pGGirdisiText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.pGGirdisiText.Location = new System.Drawing.Point(12, 38);
            this.pGGirdisiText.Name = "pGGirdisiText";
            this.pGGirdisiText.Size = new System.Drawing.Size(234, 33);
            this.pGGirdisiText.TabIndex = 11;
            // 
            // pTarihText
            // 
            this.pTarihText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.pTarihText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTarihText.Cursor = System.Windows.Forms.Cursors.Default;
            this.pTarihText.Enabled = false;
            this.pTarihText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.pTarihText.Location = new System.Drawing.Point(258, 131);
            this.pTarihText.Name = "pTarihText";
            this.pTarihText.Size = new System.Drawing.Size(207, 29);
            this.pTarihText.TabIndex = 10;
            this.pTarihText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pTarihCheckBox
            // 
            this.pTarihCheckBox.AutoSize = true;
            this.pTarihCheckBox.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTarihCheckBox.Location = new System.Drawing.Point(276, 104);
            this.pTarihCheckBox.Name = "pTarihCheckBox";
            this.pTarihCheckBox.Size = new System.Drawing.Size(169, 24);
            this.pTarihCheckBox.TabIndex = 4;
            this.pTarihCheckBox.Text = "Tarih Seçimini Uygula";
            this.pTarihCheckBox.UseVisualStyleBackColor = true;
            this.pTarihCheckBox.CheckedChanged += new System.EventHandler(this.pTarihCheckBox_CheckedChanged);
            // 
            // pGEkleButton
            // 
            this.pGEkleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pGEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pGEkleButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pGEkleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.pGEkleButton.Location = new System.Drawing.Point(284, 30);
            this.pGEkleButton.Name = "pGEkleButton";
            this.pGEkleButton.Size = new System.Drawing.Size(136, 49);
            this.pGEkleButton.TabIndex = 3;
            this.pGEkleButton.Text = "Görevi Ekle";
            this.pGEkleButton.UseVisualStyleBackColor = true;
            this.pGEkleButton.Click += new System.EventHandler(this.pGEkleButton_Click);
            // 
            // pGPlanlanyiciBox
            // 
            this.pGPlanlanyiciBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.pGPlanlanyiciBox.Controls.Add(this.pGeriButton);
            this.pGPlanlanyiciBox.Controls.Add(this.pGListesiCheckBox);
            this.pGPlanlanyiciBox.Controls.Add(this.pGEkleLabel);
            this.pGPlanlanyiciBox.Controls.Add(this.pTamamlanmisLabel);
            this.pGPlanlanyiciBox.Controls.Add(this.pTamamlanacakLabel);
            this.pGPlanlanyiciBox.Controls.Add(this.pTGListesiBox);
            this.pGPlanlanyiciBox.Controls.Add(this.pSilButton);
            this.pGPlanlanyiciBox.Controls.Add(this.pTamamlaButton);
            this.pGPlanlanyiciBox.Controls.Add(this.pGEkleyiciBox);
            this.pGPlanlanyiciBox.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pGPlanlanyiciBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(209)))), ((int)(((byte)(160)))));
            this.pGPlanlanyiciBox.Location = new System.Drawing.Point(14, 12);
            this.pGPlanlanyiciBox.Name = "pGPlanlanyiciBox";
            this.pGPlanlanyiciBox.Size = new System.Drawing.Size(1293, 339);
            this.pGPlanlanyiciBox.TabIndex = 2;
            this.pGPlanlanyiciBox.TabStop = false;
            this.pGPlanlanyiciBox.Text = "Görev Planlayıcı";
            // 
            // pGeriButton
            // 
            this.pGeriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pGeriButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pGeriButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(79)))));
            this.pGeriButton.Location = new System.Drawing.Point(827, 230);
            this.pGeriButton.Name = "pGeriButton";
            this.pGeriButton.Size = new System.Drawing.Size(124, 70);
            this.pGeriButton.TabIndex = 11;
            this.pGeriButton.Text = "İşlemi Geri Al";
            this.pGeriButton.UseVisualStyleBackColor = true;
            this.pGeriButton.Click += new System.EventHandler(this.pGeriButton_Click);
            // 
            // pGListesiCheckBox
            // 
            this.pGListesiCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.pGListesiCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGListesiCheckBox.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pGListesiCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.pGListesiCheckBox.FormattingEnabled = true;
            this.pGListesiCheckBox.ItemHeight = 20;
            this.pGListesiCheckBox.Location = new System.Drawing.Point(499, 58);
            this.pGListesiCheckBox.Name = "pGListesiCheckBox";
            this.pGListesiCheckBox.Size = new System.Drawing.Size(310, 262);
            this.pGListesiCheckBox.TabIndex = 11;
            // 
            // pGEkleLabel
            // 
            this.pGEkleLabel.AutoSize = true;
            this.pGEkleLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pGEkleLabel.Location = new System.Drawing.Point(172, 30);
            this.pGEkleLabel.Name = "pGEkleLabel";
            this.pGEkleLabel.Size = new System.Drawing.Size(135, 25);
            this.pGEkleLabel.TabIndex = 14;
            this.pGEkleLabel.Text = "Görevleri Ekle";
            // 
            // pTamamlanmisLabel
            // 
            this.pTamamlanmisLabel.AutoSize = true;
            this.pTamamlanmisLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTamamlanmisLabel.Location = new System.Drawing.Point(1015, 30);
            this.pTamamlanmisLabel.Name = "pTamamlanmisLabel";
            this.pTamamlanmisLabel.Size = new System.Drawing.Size(216, 25);
            this.pTamamlanmisLabel.TabIndex = 13;
            this.pTamamlanmisLabel.Text = "Tamamlanmış Görevler";
            // 
            // pTamamlanacakLabel
            // 
            this.pTamamlanacakLabel.AutoSize = true;
            this.pTamamlanacakLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTamamlanacakLabel.Location = new System.Drawing.Point(541, 30);
            this.pTamamlanacakLabel.Name = "pTamamlanacakLabel";
            this.pTamamlanacakLabel.Size = new System.Drawing.Size(224, 25);
            this.pTamamlanacakLabel.TabIndex = 12;
            this.pTamamlanacakLabel.Text = "Tamamlanacak Görevler";
            // 
            // pTGListesiBox
            // 
            this.pTGListesiBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.pTGListesiBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTGListesiBox.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTGListesiBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(174)))), ((int)(((byte)(235)))));
            this.pTGListesiBox.FormattingEnabled = true;
            this.pTGListesiBox.ItemHeight = 20;
            this.pTGListesiBox.Location = new System.Drawing.Point(968, 58);
            this.pTGListesiBox.Name = "pTGListesiBox";
            this.pTGListesiBox.Size = new System.Drawing.Size(310, 262);
            this.pTGListesiBox.TabIndex = 3;
            // 
            // pSilButton
            // 
            this.pSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pSilButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSilButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.pSilButton.Location = new System.Drawing.Point(827, 154);
            this.pSilButton.Name = "pSilButton";
            this.pSilButton.Size = new System.Drawing.Size(124, 70);
            this.pSilButton.TabIndex = 5;
            this.pSilButton.Text = "Seçili Görevleri Sil";
            this.pSilButton.UseVisualStyleBackColor = true;
            this.pSilButton.Click += new System.EventHandler(this.pSilButton_Click);
            // 
            // pTamamlaButton
            // 
            this.pTamamlaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pTamamlaButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTamamlaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(174)))), ((int)(((byte)(235)))));
            this.pTamamlaButton.Location = new System.Drawing.Point(827, 78);
            this.pTamamlaButton.Name = "pTamamlaButton";
            this.pTamamlaButton.Size = new System.Drawing.Size(124, 70);
            this.pTamamlaButton.TabIndex = 4;
            this.pTamamlaButton.Text = "Seçili Görevleri Tamamla";
            this.pTamamlaButton.UseVisualStyleBackColor = true;
            this.pTamamlaButton.Click += new System.EventHandler(this.pTamamlaButton_Click);
            // 
            // pTimerPRButton
            // 
            this.pTimerPRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pTimerPRButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimerPRButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(174)))), ((int)(((byte)(235)))));
            this.pTimerPRButton.Location = new System.Drawing.Point(447, 105);
            this.pTimerPRButton.Name = "pTimerPRButton";
            this.pTimerPRButton.Size = new System.Drawing.Size(115, 71);
            this.pTimerPRButton.TabIndex = 6;
            this.pTimerPRButton.Text = "Sayacı Sürdür";
            this.pTimerPRButton.UseVisualStyleBackColor = true;
            this.pTimerPRButton.Visible = false;
            this.pTimerPRButton.Click += new System.EventHandler(this.pTimerPRButton_Click);
            // 
            // pTimerGroupBox
            // 
            this.pTimerGroupBox.Controls.Add(this.pTimerSure);
            this.pTimerGroupBox.Controls.Add(this.pTimerKalanSureText);
            this.pTimerGroupBox.Controls.Add(this.pTimerPauseButton);
            this.pTimerGroupBox.Controls.Add(this.pTimerExpLabel);
            this.pTimerGroupBox.Controls.Add(this.pTimerStopButton);
            this.pTimerGroupBox.Controls.Add(this.pTimerHr);
            this.pTimerGroupBox.Controls.Add(this.pTimerMin);
            this.pTimerGroupBox.Controls.Add(this.pTimerSec);
            this.pTimerGroupBox.Controls.Add(this.pTimerPBar);
            this.pTimerGroupBox.Controls.Add(this.pTimerSSButton);
            this.pTimerGroupBox.Controls.Add(this.pTimerPRButton);
            this.pTimerGroupBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimerGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(209)))), ((int)(((byte)(160)))));
            this.pTimerGroupBox.Location = new System.Drawing.Point(14, 357);
            this.pTimerGroupBox.Name = "pTimerGroupBox";
            this.pTimerGroupBox.Size = new System.Drawing.Size(579, 196);
            this.pTimerGroupBox.TabIndex = 7;
            this.pTimerGroupBox.TabStop = false;
            this.pTimerGroupBox.Text = "Sayaç Ayarı";
            // 
            // pTimerSure
            // 
            this.pTimerSure.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimerSure.Location = new System.Drawing.Point(90, 73);
            this.pTimerSure.Name = "pTimerSure";
            this.pTimerSure.Size = new System.Drawing.Size(263, 50);
            this.pTimerSure.TabIndex = 18;
            this.pTimerSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pTimerSure.Visible = false;
            // 
            // pTimerKalanSureText
            // 
            this.pTimerKalanSureText.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimerKalanSureText.Location = new System.Drawing.Point(90, 25);
            this.pTimerKalanSureText.Name = "pTimerKalanSureText";
            this.pTimerKalanSureText.Size = new System.Drawing.Size(263, 49);
            this.pTimerKalanSureText.TabIndex = 17;
            this.pTimerKalanSureText.Text = "Kalan Süre:";
            this.pTimerKalanSureText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pTimerKalanSureText.Visible = false;
            // 
            // pTimerPauseButton
            // 
            this.pTimerPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pTimerPauseButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimerPauseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(79)))));
            this.pTimerPauseButton.Location = new System.Drawing.Point(447, 105);
            this.pTimerPauseButton.Name = "pTimerPauseButton";
            this.pTimerPauseButton.Size = new System.Drawing.Size(115, 71);
            this.pTimerPauseButton.TabIndex = 16;
            this.pTimerPauseButton.Text = "Sayacı Duraklat";
            this.pTimerPauseButton.UseVisualStyleBackColor = true;
            this.pTimerPauseButton.Visible = false;
            this.pTimerPauseButton.Click += new System.EventHandler(this.pTimerPauseButton_Click);
            // 
            // pTimerExpLabel
            // 
            this.pTimerExpLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimerExpLabel.Location = new System.Drawing.Point(90, 25);
            this.pTimerExpLabel.Name = "pTimerExpLabel";
            this.pTimerExpLabel.Size = new System.Drawing.Size(263, 50);
            this.pTimerExpLabel.TabIndex = 14;
            this.pTimerExpLabel.Text = "Saat, dakika ve saniye girerek sayacı başlatabilirsiniz.";
            this.pTimerExpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTimerStopButton
            // 
            this.pTimerStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pTimerStopButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimerStopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.pTimerStopButton.Location = new System.Drawing.Point(447, 28);
            this.pTimerStopButton.Name = "pTimerStopButton";
            this.pTimerStopButton.Size = new System.Drawing.Size(115, 71);
            this.pTimerStopButton.TabIndex = 15;
            this.pTimerStopButton.Text = "Sayacı Bitir";
            this.pTimerStopButton.UseVisualStyleBackColor = true;
            this.pTimerStopButton.Visible = false;
            this.pTimerStopButton.Click += new System.EventHandler(this.pTimerStopButton_Click);
            // 
            // pTimerHr
            // 
            this.pTimerHr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.pTimerHr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pTimerHr.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimerHr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(209)))), ((int)(((byte)(160)))));
            this.pTimerHr.Location = new System.Drawing.Point(144, 84);
            this.pTimerHr.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.pTimerHr.Name = "pTimerHr";
            this.pTimerHr.Size = new System.Drawing.Size(44, 25);
            this.pTimerHr.TabIndex = 12;
            this.pTimerHr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pTimerMin
            // 
            this.pTimerMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.pTimerMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pTimerMin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimerMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(209)))), ((int)(((byte)(160)))));
            this.pTimerMin.Location = new System.Drawing.Point(194, 84);
            this.pTimerMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.pTimerMin.Name = "pTimerMin";
            this.pTimerMin.Size = new System.Drawing.Size(44, 25);
            this.pTimerMin.TabIndex = 11;
            this.pTimerMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pTimerSec
            // 
            this.pTimerSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.pTimerSec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pTimerSec.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimerSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(209)))), ((int)(((byte)(160)))));
            this.pTimerSec.Location = new System.Drawing.Point(244, 84);
            this.pTimerSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.pTimerSec.Name = "pTimerSec";
            this.pTimerSec.Size = new System.Drawing.Size(44, 25);
            this.pTimerSec.TabIndex = 10;
            this.pTimerSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pTimerPBar
            // 
            this.pTimerPBar.Location = new System.Drawing.Point(34, 126);
            this.pTimerPBar.Name = "pTimerPBar";
            this.pTimerPBar.Size = new System.Drawing.Size(372, 39);
            this.pTimerPBar.Step = 1;
            this.pTimerPBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pTimerPBar.TabIndex = 9;
            this.pTimerPBar.Visible = false;
            // 
            // pTimerSSButton
            // 
            this.pTimerSSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pTimerSSButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimerSSButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.pTimerSSButton.Location = new System.Drawing.Point(447, 28);
            this.pTimerSSButton.Name = "pTimerSSButton";
            this.pTimerSSButton.Size = new System.Drawing.Size(115, 71);
            this.pTimerSSButton.TabIndex = 8;
            this.pTimerSSButton.Text = "Sayacı Başlat";
            this.pTimerSSButton.UseVisualStyleBackColor = true;
            this.pTimerSSButton.Click += new System.EventHandler(this.pTimerSSButton_Click);
            // 
            // pReportButton
            // 
            this.pReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pReportButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pReportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(143)))), ((int)(((byte)(12)))));
            this.pReportButton.Location = new System.Drawing.Point(632, 462);
            this.pReportButton.Name = "pReportButton";
            this.pReportButton.Size = new System.Drawing.Size(257, 71);
            this.pReportButton.TabIndex = 9;
            this.pReportButton.Text = "Günlük Rapor Çıkar";
            this.pReportButton.UseVisualStyleBackColor = true;
            this.pReportButton.Click += new System.EventHandler(this.pReportButton_Click);
            // 
            // pClearListButton
            // 
            this.pClearListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pClearListButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pClearListButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.pClearListButton.Location = new System.Drawing.Point(632, 385);
            this.pClearListButton.Name = "pClearListButton";
            this.pClearListButton.Size = new System.Drawing.Size(257, 71);
            this.pClearListButton.TabIndex = 8;
            this.pClearListButton.Text = "Listeleri Temizle";
            this.pClearListButton.UseVisualStyleBackColor = true;
            this.pClearListButton.Click += new System.EventHandler(this.pClearListButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pTarihTextShort
            // 
            this.pTarihTextShort.AutoSize = true;
            this.pTarihTextShort.Location = new System.Drawing.Point(1251, 546);
            this.pTarihTextShort.Name = "pTarihTextShort";
            this.pTarihTextShort.Size = new System.Drawing.Size(35, 13);
            this.pTarihTextShort.TabIndex = 10;
            this.pTarihTextShort.Text = "label1";
            this.pTarihTextShort.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1135, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pProgExp1Label
            // 
            this.pProgExp1Label.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pProgExp1Label.Location = new System.Drawing.Point(930, 413);
            this.pProgExp1Label.Name = "pProgExp1Label";
            this.pProgExp1Label.Size = new System.Drawing.Size(199, 50);
            this.pProgExp1Label.TabIndex = 13;
            this.pProgExp1Label.Text = "Basit ToDoList uygulamasıdır.";
            this.pProgExp1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pProgExp2Label
            // 
            this.pProgExp2Label.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pProgExp2Label.Location = new System.Drawing.Point(930, 451);
            this.pProgExp2Label.Name = "pProgExp2Label";
            this.pProgExp2Label.Size = new System.Drawing.Size(199, 50);
            this.pProgExp2Label.TabIndex = 14;
            this.pProgExp2Label.Text = "Mert Denizci";
            this.pProgExp2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTimerSureSecsLabel
            // 
            this.pTimerSureSecsLabel.AutoSize = true;
            this.pTimerSureSecsLabel.Location = new System.Drawing.Point(1210, 546);
            this.pTimerSureSecsLabel.Name = "pTimerSureSecsLabel";
            this.pTimerSureSecsLabel.Size = new System.Drawing.Size(35, 13);
            this.pTimerSureSecsLabel.TabIndex = 15;
            this.pTimerSureSecsLabel.Text = "label1";
            this.pTimerSureSecsLabel.Visible = false;
            // 
            // pPBarMax
            // 
            this.pPBarMax.AutoSize = true;
            this.pPBarMax.Location = new System.Drawing.Point(1177, 546);
            this.pPBarMax.Name = "pPBarMax";
            this.pPBarMax.Size = new System.Drawing.Size(35, 13);
            this.pPBarMax.TabIndex = 16;
            this.pPBarMax.Text = "label1";
            this.pPBarMax.Visible = false;
            // 
            // To_Do_List_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1319, 565);
            this.Controls.Add(this.pPBarMax);
            this.Controls.Add(this.pTimerSureSecsLabel);
            this.Controls.Add(this.pProgExp2Label);
            this.Controls.Add(this.pProgExp1Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pTarihTextShort);
            this.Controls.Add(this.pReportButton);
            this.Controls.Add(this.pClearListButton);
            this.Controls.Add(this.pTimerGroupBox);
            this.Controls.Add(this.pGPlanlanyiciBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(209)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "To_Do_List_Program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do List Application";
            this.Load += new System.EventHandler(this.To_Do_List_Program_Load);
            this.pGEkleyiciBox.ResumeLayout(false);
            this.pGEkleyiciBox.PerformLayout();
            this.pGPlanlanyiciBox.ResumeLayout(false);
            this.pGPlanlanyiciBox.PerformLayout();
            this.pTimerGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pTimerHr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTimerMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTimerSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox pGEkleyiciBox;
        private System.Windows.Forms.GroupBox pGPlanlanyiciBox;
        private System.Windows.Forms.Button pTimerPRButton;
        private System.Windows.Forms.Button pGEkleButton;
        private System.Windows.Forms.Button pSilButton;
        private System.Windows.Forms.Button pTamamlaButton;
        private System.Windows.Forms.ListBox pTGListesiBox;
        private System.Windows.Forms.GroupBox pTimerGroupBox;
        private System.Windows.Forms.Button pReportButton;
        private System.Windows.Forms.Button pClearListButton;
        private System.Windows.Forms.Button pTimerSSButton;
        private System.Windows.Forms.CheckBox pTarihCheckBox;
        private System.Windows.Forms.TextBox pTarihText;
        private System.Windows.Forms.Label pTamamlanacakLabel;
        private System.Windows.Forms.TextBox pGGirdisiText;
        private System.Windows.Forms.Label pTarihExLabel;
        private System.Windows.Forms.Label pGGirdisiLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pTimerPBar;
        private System.Windows.Forms.Label pTamamlanmisLabel;
        private System.Windows.Forms.Label pTarihTextShort;
        private System.Windows.Forms.Label pGEkleLabel;
        private System.Windows.Forms.ListBox pGListesiCheckBox;
        private System.Windows.Forms.Button pGeriButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pProgExp1Label;
        private System.Windows.Forms.Label pProgExp2Label;
        private System.Windows.Forms.NumericUpDown pTimerSec;
        private System.Windows.Forms.NumericUpDown pTimerHr;
        private System.Windows.Forms.NumericUpDown pTimerMin;
        private System.Windows.Forms.Label pTimerExpLabel;
        private System.Windows.Forms.Button pTimerStopButton;
        private System.Windows.Forms.Button pTimerPauseButton;
        private System.Windows.Forms.Label pTimerSure;
        private System.Windows.Forms.Label pTimerKalanSureText;
        private System.Windows.Forms.Label pTimerSureSecsLabel;
        private System.Windows.Forms.Label pPBarMax;
    }
}