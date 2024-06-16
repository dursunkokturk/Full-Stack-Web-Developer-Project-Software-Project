namespace Kokturk_Software_And_Hardware_Company
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSoftwareServiceSelect = new System.Windows.Forms.GroupBox();
            this.ButtonAvailableSoftwareLanguagesShow = new System.Windows.Forms.Button();
            this.comboBoxAppUsageIntended = new System.Windows.Forms.ComboBox();
            this.comboBoxUsedDeviceSelect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewAvailableSoftwareLanguages = new System.Windows.Forms.DataGridView();
            this.radioButtonOnlyMobileProgrammingLanguages = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyDesktopProgrammingLanguages = new System.Windows.Forms.RadioButton();
            this.radioButtonMobileAndComputerProgrammingLanguages = new System.Windows.Forms.RadioButton();
            this.radioButtonComputerFrontEndLanguages = new System.Windows.Forms.RadioButton();
            this.radioButtonComputerBackEndLanguages = new System.Windows.Forms.RadioButton();
            this.radioButtonMobileAppDatabaseLanguages = new System.Windows.Forms.RadioButton();
            this.radioButtonComputerAppDatabaseLanguages = new System.Windows.Forms.RadioButton();
            this.ButtonLanguagesList = new System.Windows.Forms.Button();
            this.groupBoxSoftwareServiceSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableSoftwareLanguages)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cihaza Göre Uygulama Yapımı İçin Kullanılacak Diller";
            // 
            // groupBoxSoftwareServiceSelect
            // 
            this.groupBoxSoftwareServiceSelect.Controls.Add(this.ButtonAvailableSoftwareLanguagesShow);
            this.groupBoxSoftwareServiceSelect.Controls.Add(this.comboBoxAppUsageIntended);
            this.groupBoxSoftwareServiceSelect.Controls.Add(this.comboBoxUsedDeviceSelect);
            this.groupBoxSoftwareServiceSelect.Controls.Add(this.label6);
            this.groupBoxSoftwareServiceSelect.Controls.Add(this.label5);
            this.groupBoxSoftwareServiceSelect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxSoftwareServiceSelect.Location = new System.Drawing.Point(11, 60);
            this.groupBoxSoftwareServiceSelect.Name = "groupBoxSoftwareServiceSelect";
            this.groupBoxSoftwareServiceSelect.Size = new System.Drawing.Size(393, 191);
            this.groupBoxSoftwareServiceSelect.TabIndex = 3;
            this.groupBoxSoftwareServiceSelect.TabStop = false;
            this.groupBoxSoftwareServiceSelect.Text = "Cihaz Seçimi ve Uygulama Kullanım Amacını Belirleme";
            // 
            // ButtonAvailableSoftwareLanguagesShow
            // 
            this.ButtonAvailableSoftwareLanguagesShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAvailableSoftwareLanguagesShow.Location = new System.Drawing.Point(31, 129);
            this.ButtonAvailableSoftwareLanguagesShow.Name = "ButtonAvailableSoftwareLanguagesShow";
            this.ButtonAvailableSoftwareLanguagesShow.Size = new System.Drawing.Size(302, 44);
            this.ButtonAvailableSoftwareLanguagesShow.TabIndex = 6;
            this.ButtonAvailableSoftwareLanguagesShow.Text = "Kullanılabilir Yazılım Dillerini Göster";
            this.ButtonAvailableSoftwareLanguagesShow.UseVisualStyleBackColor = true;
            this.ButtonAvailableSoftwareLanguagesShow.Click += new System.EventHandler(this.ButtonAvailableSoftwareLanguagesShow_Click);
            // 
            // comboBoxAppUsageIntended
            // 
            this.comboBoxAppUsageIntended.FormattingEnabled = true;
            this.comboBoxAppUsageIntended.Items.AddRange(new object[] {
            "Bankacılık",
            "Oyun",
            "Personel Giriş Çıkış Takibi",
            "Ürün Satışı",
            "Siber Güvenlik",
            "Şirket Tanıtımı"});
            this.comboBoxAppUsageIntended.Location = new System.Drawing.Point(189, 67);
            this.comboBoxAppUsageIntended.Name = "comboBoxAppUsageIntended";
            this.comboBoxAppUsageIntended.Size = new System.Drawing.Size(185, 24);
            this.comboBoxAppUsageIntended.TabIndex = 8;
            // 
            // comboBoxUsedDeviceSelect
            // 
            this.comboBoxUsedDeviceSelect.FormattingEnabled = true;
            this.comboBoxUsedDeviceSelect.Items.AddRange(new object[] {
            "Cep Telefonu",
            "Bilgisayar"});
            this.comboBoxUsedDeviceSelect.Location = new System.Drawing.Point(189, 37);
            this.comboBoxUsedDeviceSelect.Name = "comboBoxUsedDeviceSelect";
            this.comboBoxUsedDeviceSelect.Size = new System.Drawing.Size(185, 24);
            this.comboBoxUsedDeviceSelect.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Uygulama Kullanım Amacı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kullanılacak Cihaz Seçimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(760, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Desinged By Dursun Köktürk";
            // 
            // dataGridViewAvailableSoftwareLanguages
            // 
            this.dataGridViewAvailableSoftwareLanguages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableSoftwareLanguages.Location = new System.Drawing.Point(418, 67);
            this.dataGridViewAvailableSoftwareLanguages.Name = "dataGridViewAvailableSoftwareLanguages";
            this.dataGridViewAvailableSoftwareLanguages.Size = new System.Drawing.Size(516, 184);
            this.dataGridViewAvailableSoftwareLanguages.TabIndex = 7;
            // 
            // radioButtonOnlyMobileProgrammingLanguages
            // 
            this.radioButtonOnlyMobileProgrammingLanguages.AutoSize = true;
            this.radioButtonOnlyMobileProgrammingLanguages.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonOnlyMobileProgrammingLanguages.Location = new System.Drawing.Point(11, 270);
            this.radioButtonOnlyMobileProgrammingLanguages.Name = "radioButtonOnlyMobileProgrammingLanguages";
            this.radioButtonOnlyMobileProgrammingLanguages.Size = new System.Drawing.Size(434, 20);
            this.radioButtonOnlyMobileProgrammingLanguages.TabIndex = 8;
            this.radioButtonOnlyMobileProgrammingLanguages.TabStop = true;
            this.radioButtonOnlyMobileProgrammingLanguages.Text = "Sadece Cep Telefonu İçin Uygulama Yapımında Kullanılan Diller";
            this.radioButtonOnlyMobileProgrammingLanguages.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnlyDesktopProgrammingLanguages
            // 
            this.radioButtonOnlyDesktopProgrammingLanguages.AutoSize = true;
            this.radioButtonOnlyDesktopProgrammingLanguages.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonOnlyDesktopProgrammingLanguages.Location = new System.Drawing.Point(11, 294);
            this.radioButtonOnlyDesktopProgrammingLanguages.Name = "radioButtonOnlyDesktopProgrammingLanguages";
            this.radioButtonOnlyDesktopProgrammingLanguages.Size = new System.Drawing.Size(396, 20);
            this.radioButtonOnlyDesktopProgrammingLanguages.TabIndex = 9;
            this.radioButtonOnlyDesktopProgrammingLanguages.TabStop = true;
            this.radioButtonOnlyDesktopProgrammingLanguages.Text = "Sadece Bilgisayar Uygulaması Yapımında Kullanılan Diller";
            this.radioButtonOnlyDesktopProgrammingLanguages.UseVisualStyleBackColor = true;
            // 
            // radioButtonMobileAndComputerProgrammingLanguages
            // 
            this.radioButtonMobileAndComputerProgrammingLanguages.AutoSize = true;
            this.radioButtonMobileAndComputerProgrammingLanguages.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonMobileAndComputerProgrammingLanguages.Location = new System.Drawing.Point(11, 317);
            this.radioButtonMobileAndComputerProgrammingLanguages.Name = "radioButtonMobileAndComputerProgrammingLanguages";
            this.radioButtonMobileAndComputerProgrammingLanguages.Size = new System.Drawing.Size(269, 20);
            this.radioButtonMobileAndComputerProgrammingLanguages.TabIndex = 10;
            this.radioButtonMobileAndComputerProgrammingLanguages.TabStop = true;
            this.radioButtonMobileAndComputerProgrammingLanguages.Text = "Mobil ve Bilgisayarda Kullanılan Diller";
            this.radioButtonMobileAndComputerProgrammingLanguages.UseVisualStyleBackColor = true;
            // 
            // radioButtonComputerFrontEndLanguages
            // 
            this.radioButtonComputerFrontEndLanguages.AutoSize = true;
            this.radioButtonComputerFrontEndLanguages.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonComputerFrontEndLanguages.Location = new System.Drawing.Point(11, 343);
            this.radioButtonComputerFrontEndLanguages.Name = "radioButtonComputerFrontEndLanguages";
            this.radioButtonComputerFrontEndLanguages.Size = new System.Drawing.Size(394, 20);
            this.radioButtonComputerFrontEndLanguages.TabIndex = 11;
            this.radioButtonComputerFrontEndLanguages.TabStop = true;
            this.radioButtonComputerFrontEndLanguages.Text = "Front-End (Önyüz) Uygulaması Yapımında Kullanılan Diller";
            this.radioButtonComputerFrontEndLanguages.UseVisualStyleBackColor = true;
            // 
            // radioButtonComputerBackEndLanguages
            // 
            this.radioButtonComputerBackEndLanguages.AutoSize = true;
            this.radioButtonComputerBackEndLanguages.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonComputerBackEndLanguages.Location = new System.Drawing.Point(450, 270);
            this.radioButtonComputerBackEndLanguages.Name = "radioButtonComputerBackEndLanguages";
            this.radioButtonComputerBackEndLanguages.Size = new System.Drawing.Size(403, 20);
            this.radioButtonComputerBackEndLanguages.TabIndex = 12;
            this.radioButtonComputerBackEndLanguages.TabStop = true;
            this.radioButtonComputerBackEndLanguages.Text = "Back-End (Arkayüz) Uygulaması Yapımında Kullanılan Diller";
            this.radioButtonComputerBackEndLanguages.UseVisualStyleBackColor = true;
            // 
            // radioButtonMobileAppDatabaseLanguages
            // 
            this.radioButtonMobileAppDatabaseLanguages.AutoSize = true;
            this.radioButtonMobileAppDatabaseLanguages.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonMobileAppDatabaseLanguages.Location = new System.Drawing.Point(450, 296);
            this.radioButtonMobileAppDatabaseLanguages.Name = "radioButtonMobileAppDatabaseLanguages";
            this.radioButtonMobileAppDatabaseLanguages.Size = new System.Drawing.Size(338, 20);
            this.radioButtonMobileAppDatabaseLanguages.TabIndex = 13;
            this.radioButtonMobileAppDatabaseLanguages.TabStop = true;
            this.radioButtonMobileAppDatabaseLanguages.Text = "Mobil Uygulama Veri Tabanı İçin Kullanılan Diller";
            this.radioButtonMobileAppDatabaseLanguages.UseVisualStyleBackColor = true;
            // 
            // radioButtonComputerAppDatabaseLanguages
            // 
            this.radioButtonComputerAppDatabaseLanguages.AutoSize = true;
            this.radioButtonComputerAppDatabaseLanguages.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonComputerAppDatabaseLanguages.Location = new System.Drawing.Point(450, 322);
            this.radioButtonComputerAppDatabaseLanguages.Name = "radioButtonComputerAppDatabaseLanguages";
            this.radioButtonComputerAppDatabaseLanguages.Size = new System.Drawing.Size(484, 20);
            this.radioButtonComputerAppDatabaseLanguages.TabIndex = 14;
            this.radioButtonComputerAppDatabaseLanguages.TabStop = true;
            this.radioButtonComputerAppDatabaseLanguages.Text = "Bilgisayarda Kullanılan Uygulamalarda Veri Tabanı İçin Kullanılan Diller";
            this.radioButtonComputerAppDatabaseLanguages.UseVisualStyleBackColor = true;
            // 
            // ButtonLanguagesList
            // 
            this.ButtonLanguagesList.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonLanguagesList.Location = new System.Drawing.Point(292, 385);
            this.ButtonLanguagesList.Name = "ButtonLanguagesList";
            this.ButtonLanguagesList.Size = new System.Drawing.Size(218, 43);
            this.ButtonLanguagesList.TabIndex = 15;
            this.ButtonLanguagesList.Text = "Dilleri Listele";
            this.ButtonLanguagesList.UseVisualStyleBackColor = true;
            this.ButtonLanguagesList.Click += new System.EventHandler(this.ButtonLanguagesList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 461);
            this.Controls.Add(this.ButtonLanguagesList);
            this.Controls.Add(this.radioButtonComputerAppDatabaseLanguages);
            this.Controls.Add(this.radioButtonMobileAppDatabaseLanguages);
            this.Controls.Add(this.radioButtonComputerBackEndLanguages);
            this.Controls.Add(this.radioButtonComputerFrontEndLanguages);
            this.Controls.Add(this.radioButtonMobileAndComputerProgrammingLanguages);
            this.Controls.Add(this.radioButtonOnlyDesktopProgrammingLanguages);
            this.Controls.Add(this.radioButtonOnlyMobileProgrammingLanguages);
            this.Controls.Add(this.dataGridViewAvailableSoftwareLanguages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxSoftwareServiceSelect);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Köktürk Software Company";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSoftwareServiceSelect.ResumeLayout(false);
            this.groupBoxSoftwareServiceSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableSoftwareLanguages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSoftwareServiceSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAppUsageIntended;
        private System.Windows.Forms.ComboBox comboBoxUsedDeviceSelect;
        private System.Windows.Forms.Button ButtonAvailableSoftwareLanguagesShow;
        private System.Windows.Forms.DataGridView dataGridViewAvailableSoftwareLanguages;
        private System.Windows.Forms.RadioButton radioButtonOnlyMobileProgrammingLanguages;
        private System.Windows.Forms.RadioButton radioButtonOnlyDesktopProgrammingLanguages;
        private System.Windows.Forms.RadioButton radioButtonMobileAndComputerProgrammingLanguages;
        private System.Windows.Forms.RadioButton radioButtonComputerFrontEndLanguages;
        private System.Windows.Forms.RadioButton radioButtonComputerBackEndLanguages;
        private System.Windows.Forms.RadioButton radioButtonMobileAppDatabaseLanguages;
        private System.Windows.Forms.RadioButton radioButtonComputerAppDatabaseLanguages;
        private System.Windows.Forms.Button ButtonLanguagesList;
    }
}

