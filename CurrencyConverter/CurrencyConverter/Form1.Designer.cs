namespace CurrencyConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbCurrent = new MetroFramework.Controls.MetroComboBox();
            this.cmbNew = new MetroFramework.Controls.MetroComboBox();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtRate = new MetroFramework.Controls.MetroTextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnCredits = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cmbCurrent
            // 
            this.cmbCurrent.FormattingEnabled = true;
            this.cmbCurrent.ItemHeight = 23;
            this.cmbCurrent.Location = new System.Drawing.Point(155, 137);
            this.cmbCurrent.Name = "cmbCurrent";
            this.cmbCurrent.Size = new System.Drawing.Size(191, 29);
            this.cmbCurrent.TabIndex = 0;
            // 
            // cmbNew
            // 
            this.cmbNew.FormattingEnabled = true;
            this.cmbNew.ItemHeight = 23;
            this.cmbNew.Location = new System.Drawing.Point(155, 182);
            this.cmbNew.Name = "cmbNew";
            this.cmbNew.Size = new System.Drawing.Size(191, 29);
            this.cmbNew.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(155, 257);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(191, 29);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "See Exchange Rate";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 141);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Current Currency";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(47, 186);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "New Currency";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(205, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Exchange Rate";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(199, 96);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(105, 23);
            this.txtRate.TabIndex = 6;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(155, 225);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(191, 20);
            this.dtpDate.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 224);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Select Historial Data";
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(3, 272);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(75, 23);
            this.btnCredits.TabIndex = 9;
            this.btnCredits.Text = "Credits";
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 298);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbNew);
            this.Controls.Add(this.cmbCurrent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Exchange Rates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbCurrent;
        private MetroFramework.Controls.MetroComboBox cmbNew;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtRate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnCredits;
    }
}

