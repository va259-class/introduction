namespace Vektorel.StringAndDate
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUpper = new Button();
            btnLower = new Button();
            btnNoA = new Button();
            btnSpellCount = new Button();
            btnWordCount = new Button();
            btnCrop3Words = new Button();
            btnIndex = new Button();
            btnSplit = new Button();
            btnJoin = new Button();
            btnTrim = new Button();
            btnStartCheck = new Button();
            btnPadLeft = new Button();
            btnTimeZone = new Button();
            btnKind = new Button();
            btnDayOfYear = new Button();
            btnDayCount = new Button();
            btnDateDiff = new Button();
            btnCustomFormat = new Button();
            btn1HourLater = new Button();
            btnUtcNow = new Button();
            btnNow = new Button();
            btn2MonthsLater = new Button();
            btnYesterday = new Button();
            btnAddDay = new Button();
            txtRef = new TextBox();
            dtpRef = new DateTimePicker();
            txtStringResult = new TextBox();
            txtDateResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnUpper
            // 
            btnUpper.Location = new Point(12, 12);
            btnUpper.Name = "btnUpper";
            btnUpper.Size = new Size(150, 23);
            btnUpper.TabIndex = 0;
            btnUpper.Text = "Büyük Harf";
            btnUpper.UseVisualStyleBackColor = true;
            btnUpper.Click += btnUpper_Click;
            // 
            // btnLower
            // 
            btnLower.Location = new Point(12, 41);
            btnLower.Name = "btnLower";
            btnLower.Size = new Size(150, 23);
            btnLower.TabIndex = 1;
            btnLower.Text = "Küçük Harf";
            btnLower.UseVisualStyleBackColor = true;
            btnLower.Click += btnLower_Click;
            // 
            // btnNoA
            // 
            btnNoA.Location = new Point(12, 70);
            btnNoA.Name = "btnNoA";
            btnNoA.Size = new Size(150, 23);
            btnNoA.TabIndex = 2;
            btnNoA.Text = "A'sız Cümle";
            btnNoA.UseVisualStyleBackColor = true;
            btnNoA.Click += btnNoA_Click;
            // 
            // btnSpellCount
            // 
            btnSpellCount.Location = new Point(12, 157);
            btnSpellCount.Name = "btnSpellCount";
            btnSpellCount.Size = new Size(150, 23);
            btnSpellCount.TabIndex = 5;
            btnSpellCount.Text = "Harf Sayısı";
            btnSpellCount.UseVisualStyleBackColor = true;
            btnSpellCount.Click += btnSpellCount_Click;
            // 
            // btnWordCount
            // 
            btnWordCount.Location = new Point(12, 128);
            btnWordCount.Name = "btnWordCount";
            btnWordCount.Size = new Size(150, 23);
            btnWordCount.TabIndex = 4;
            btnWordCount.Text = "Kelime Sayısı";
            btnWordCount.UseVisualStyleBackColor = true;
            btnWordCount.Click += btnWordCount_Click;
            // 
            // btnCrop3Words
            // 
            btnCrop3Words.Location = new Point(12, 99);
            btnCrop3Words.Name = "btnCrop3Words";
            btnCrop3Words.Size = new Size(150, 23);
            btnCrop3Words.TabIndex = 3;
            btnCrop3Words.Text = "İlk 3 Kelimesiz";
            btnCrop3Words.UseVisualStyleBackColor = true;
            btnCrop3Words.Click += btnCrop3Words_Click;
            // 
            // btnIndex
            // 
            btnIndex.Location = new Point(12, 331);
            btnIndex.Name = "btnIndex";
            btnIndex.Size = new Size(150, 23);
            btnIndex.TabIndex = 11;
            btnIndex.Text = "Sıra Bul";
            btnIndex.UseVisualStyleBackColor = true;
            btnIndex.Click += btnIndex_Click;
            // 
            // btnSplit
            // 
            btnSplit.Location = new Point(12, 302);
            btnSplit.Name = "btnSplit";
            btnSplit.Size = new Size(150, 23);
            btnSplit.TabIndex = 10;
            btnSplit.Text = "Parçala";
            btnSplit.UseVisualStyleBackColor = true;
            btnSplit.Click += btnSplit_Click;
            // 
            // btnJoin
            // 
            btnJoin.Location = new Point(12, 273);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(150, 23);
            btnJoin.TabIndex = 9;
            btnJoin.Text = "Metin Birleştir";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += btnJoin_Click;
            // 
            // btnTrim
            // 
            btnTrim.Location = new Point(12, 244);
            btnTrim.Name = "btnTrim";
            btnTrim.Size = new Size(150, 23);
            btnTrim.TabIndex = 8;
            btnTrim.Text = "Boşluk Temizle";
            btnTrim.UseVisualStyleBackColor = true;
            btnTrim.Click += btnTrim_Click;
            // 
            // btnStartCheck
            // 
            btnStartCheck.Location = new Point(12, 215);
            btnStartCheck.Name = "btnStartCheck";
            btnStartCheck.Size = new Size(150, 23);
            btnStartCheck.TabIndex = 7;
            btnStartCheck.Text = "Başlangıç Kontrolü";
            btnStartCheck.UseVisualStyleBackColor = true;
            btnStartCheck.Click += btnStartCheck_Click;
            // 
            // btnPadLeft
            // 
            btnPadLeft.Location = new Point(12, 186);
            btnPadLeft.Name = "btnPadLeft";
            btnPadLeft.Size = new Size(150, 23);
            btnPadLeft.TabIndex = 6;
            btnPadLeft.Text = "Sola Doldur";
            btnPadLeft.UseVisualStyleBackColor = true;
            btnPadLeft.Click += btnPadLeft_Click;
            // 
            // btnTimeZone
            // 
            btnTimeZone.Location = new Point(387, 331);
            btnTimeZone.Name = "btnTimeZone";
            btnTimeZone.Size = new Size(150, 23);
            btnTimeZone.TabIndex = 23;
            btnTimeZone.Text = "Zaman Dilimi Ekle";
            btnTimeZone.UseVisualStyleBackColor = true;
            btnTimeZone.Click += btnTimeZone_Click;
            // 
            // btnKind
            // 
            btnKind.Location = new Point(387, 302);
            btnKind.Name = "btnKind";
            btnKind.Size = new Size(150, 23);
            btnKind.TabIndex = 22;
            btnKind.Text = "DateTime Kind";
            btnKind.UseVisualStyleBackColor = true;
            btnKind.Click += btnKind_Click;
            // 
            // btnDayOfYear
            // 
            btnDayOfYear.Location = new Point(387, 273);
            btnDayOfYear.Name = "btnDayOfYear";
            btnDayOfYear.Size = new Size(150, 23);
            btnDayOfYear.TabIndex = 21;
            btnDayOfYear.Text = "Yılın Günü";
            btnDayOfYear.UseVisualStyleBackColor = true;
            btnDayOfYear.Click += btnDayOfYear_Click;
            // 
            // btnDayCount
            // 
            btnDayCount.Location = new Point(387, 244);
            btnDayCount.Name = "btnDayCount";
            btnDayCount.Size = new Size(150, 23);
            btnDayCount.TabIndex = 20;
            btnDayCount.Text = "Aydaki Gün Sayısı";
            btnDayCount.UseVisualStyleBackColor = true;
            btnDayCount.Click += btnDayCount_Click;
            // 
            // btnDateDiff
            // 
            btnDateDiff.Location = new Point(387, 215);
            btnDateDiff.Name = "btnDateDiff";
            btnDateDiff.Size = new Size(150, 23);
            btnDateDiff.TabIndex = 19;
            btnDateDiff.Text = "Tarih Farkı";
            btnDateDiff.UseVisualStyleBackColor = true;
            btnDateDiff.Click += btnDateDiff_Click;
            // 
            // btnCustomFormat
            // 
            btnCustomFormat.Location = new Point(387, 186);
            btnCustomFormat.Name = "btnCustomFormat";
            btnCustomFormat.Size = new Size(150, 23);
            btnCustomFormat.TabIndex = 18;
            btnCustomFormat.Text = "Farklı Formatta Göster";
            btnCustomFormat.UseVisualStyleBackColor = true;
            btnCustomFormat.Click += btnCustomFormat_Click;
            // 
            // btn1HourLater
            // 
            btn1HourLater.Location = new Point(387, 157);
            btn1HourLater.Name = "btn1HourLater";
            btn1HourLater.Size = new Size(150, 23);
            btn1HourLater.TabIndex = 17;
            btn1HourLater.Text = "1 Saat Sonra";
            btn1HourLater.UseVisualStyleBackColor = true;
            btn1HourLater.Click += btn1HourLater_Click;
            // 
            // btnUtcNow
            // 
            btnUtcNow.Location = new Point(387, 128);
            btnUtcNow.Name = "btnUtcNow";
            btnUtcNow.Size = new Size(150, 23);
            btnUtcNow.TabIndex = 16;
            btnUtcNow.Text = "Global Şu An";
            btnUtcNow.UseVisualStyleBackColor = true;
            btnUtcNow.Click += btnUtcNow_Click;
            // 
            // btnNow
            // 
            btnNow.Location = new Point(387, 99);
            btnNow.Name = "btnNow";
            btnNow.Size = new Size(150, 23);
            btnNow.TabIndex = 15;
            btnNow.Text = "Şu An";
            btnNow.UseVisualStyleBackColor = true;
            btnNow.Click += btnNow_Click;
            // 
            // btn2MonthsLater
            // 
            btn2MonthsLater.Location = new Point(387, 70);
            btn2MonthsLater.Name = "btn2MonthsLater";
            btn2MonthsLater.Size = new Size(150, 23);
            btn2MonthsLater.TabIndex = 14;
            btn2MonthsLater.Text = "2 Ay Sonrası";
            btn2MonthsLater.UseVisualStyleBackColor = true;
            btn2MonthsLater.Click += btn2MonthsLater_Click;
            // 
            // btnYesterday
            // 
            btnYesterday.Location = new Point(387, 41);
            btnYesterday.Name = "btnYesterday";
            btnYesterday.Size = new Size(150, 23);
            btnYesterday.TabIndex = 13;
            btnYesterday.Text = "Düne Git";
            btnYesterday.UseVisualStyleBackColor = true;
            btnYesterday.Click += btnYesterday_Click;
            // 
            // btnAddDay
            // 
            btnAddDay.Location = new Point(387, 12);
            btnAddDay.Name = "btnAddDay";
            btnAddDay.Size = new Size(150, 23);
            btnAddDay.TabIndex = 12;
            btnAddDay.Text = "3 Gün Ekle";
            btnAddDay.UseVisualStyleBackColor = true;
            btnAddDay.Click += btnAddDay_Click;
            // 
            // txtRef
            // 
            txtRef.Location = new Point(168, 41);
            txtRef.Multiline = true;
            txtRef.Name = "txtRef";
            txtRef.Size = new Size(213, 81);
            txtRef.TabIndex = 24;
            txtRef.Text = "I am in love with the shape of you! We push and pull like a magnet do. Although my heart is falling to. I am in love with your body...";
            // 
            // dtpRef
            // 
            dtpRef.Location = new Point(168, 128);
            dtpRef.Name = "dtpRef";
            dtpRef.Size = new Size(213, 23);
            dtpRef.TabIndex = 25;
            // 
            // txtStringResult
            // 
            txtStringResult.Location = new Point(168, 186);
            txtStringResult.Multiline = true;
            txtStringResult.Name = "txtStringResult";
            txtStringResult.Size = new Size(213, 81);
            txtStringResult.TabIndex = 26;
            // 
            // txtDateResult
            // 
            txtDateResult.Location = new Point(168, 273);
            txtDateResult.Name = "txtDateResult";
            txtDateResult.Size = new Size(213, 23);
            txtDateResult.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 16);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 28;
            label1.Text = "Referans";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 161);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 29;
            label2.Text = "Sonuç";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 363);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDateResult);
            Controls.Add(txtStringResult);
            Controls.Add(dtpRef);
            Controls.Add(txtRef);
            Controls.Add(btnTimeZone);
            Controls.Add(btnKind);
            Controls.Add(btnDayOfYear);
            Controls.Add(btnDayCount);
            Controls.Add(btnDateDiff);
            Controls.Add(btnCustomFormat);
            Controls.Add(btn1HourLater);
            Controls.Add(btnUtcNow);
            Controls.Add(btnNow);
            Controls.Add(btn2MonthsLater);
            Controls.Add(btnYesterday);
            Controls.Add(btnAddDay);
            Controls.Add(btnIndex);
            Controls.Add(btnSplit);
            Controls.Add(btnJoin);
            Controls.Add(btnTrim);
            Controls.Add(btnStartCheck);
            Controls.Add(btnPadLeft);
            Controls.Add(btnSpellCount);
            Controls.Add(btnWordCount);
            Controls.Add(btnCrop3Words);
            Controls.Add(btnNoA);
            Controls.Add(btnLower);
            Controls.Add(btnUpper);
            Name = "FrmMain";
            Text = "Metin & Tarih İşlemleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpper;
        private Button btnLower;
        private Button btnNoA;
        private Button btnSpellCount;
        private Button btnWordCount;
        private Button btnCrop3Words;
        private Button btnIndex;
        private Button btnSplit;
        private Button btnJoin;
        private Button btnTrim;
        private Button btnStartCheck;
        private Button btnPadLeft;
        private Button btnTimeZone;
        private Button btnKind;
        private Button btnDayOfYear;
        private Button btnDayCount;
        private Button btnDateDiff;
        private Button btnCustomFormat;
        private Button btn1HourLater;
        private Button btnUtcNow;
        private Button btnNow;
        private Button btn2MonthsLater;
        private Button btnYesterday;
        private Button btnAddDay;
        private TextBox txtRef;
        private DateTimePicker dtpRef;
        private TextBox txtStringResult;
        private TextBox txtDateResult;
        private Label label1;
        private Label label2;
    }
}
