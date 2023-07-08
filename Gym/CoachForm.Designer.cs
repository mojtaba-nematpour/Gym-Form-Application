namespace Gym
{
    partial class CoachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoachForm));
            this.CoachOtherBox = new System.Windows.Forms.GroupBox();
            this.CoachContractValueTb = new System.Windows.Forms.TextBox();
            this.CoachFieldTb = new System.Windows.Forms.TextBox();
            this.CoachContractValueLbl = new System.Windows.Forms.Label();
            this.CoachFieldLbl = new System.Windows.Forms.Label();
            this.CoachImg = new System.Windows.Forms.PictureBox();
            this.CoachInfoBox = new System.Windows.Forms.GroupBox();
            this.CoachAgeTb = new System.Windows.Forms.TextBox();
            this.CoachNationalTb = new System.Windows.Forms.TextBox();
            this.CoachNameTb = new System.Windows.Forms.TextBox();
            this.CoachAgeLbl = new System.Windows.Forms.Label();
            this.CoachNationalLbl = new System.Windows.Forms.Label();
            this.CoachNameLbl = new System.Windows.Forms.Label();
            this.CoachSaveBtn = new System.Windows.Forms.Button();
            this.CoachRmBtn = new System.Windows.Forms.Button();
            this.CoachOtherBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoachImg)).BeginInit();
            this.CoachInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CoachOtherBox
            // 
            this.CoachOtherBox.Controls.Add(this.CoachContractValueTb);
            this.CoachOtherBox.Controls.Add(this.CoachFieldTb);
            this.CoachOtherBox.Controls.Add(this.CoachContractValueLbl);
            this.CoachOtherBox.Controls.Add(this.CoachFieldLbl);
            this.CoachOtherBox.Location = new System.Drawing.Point(166, 118);
            this.CoachOtherBox.Margin = new System.Windows.Forms.Padding(2);
            this.CoachOtherBox.Name = "CoachOtherBox";
            this.CoachOtherBox.Padding = new System.Windows.Forms.Padding(2);
            this.CoachOtherBox.Size = new System.Drawing.Size(334, 93);
            this.CoachOtherBox.TabIndex = 11;
            this.CoachOtherBox.TabStop = false;
            this.CoachOtherBox.Text = "دیگر مشخصات";
            // 
            // CoachContractValueTb
            // 
            this.CoachContractValueTb.Enabled = false;
            this.CoachContractValueTb.Location = new System.Drawing.Point(161, 56);
            this.CoachContractValueTb.Margin = new System.Windows.Forms.Padding(2);
            this.CoachContractValueTb.Name = "CoachContractValueTb";
            this.CoachContractValueTb.Size = new System.Drawing.Size(152, 20);
            this.CoachContractValueTb.TabIndex = 7;
            // 
            // CoachFieldTb
            // 
            this.CoachFieldTb.Enabled = false;
            this.CoachFieldTb.Location = new System.Drawing.Point(161, 31);
            this.CoachFieldTb.Margin = new System.Windows.Forms.Padding(2);
            this.CoachFieldTb.Name = "CoachFieldTb";
            this.CoachFieldTb.Size = new System.Drawing.Size(152, 20);
            this.CoachFieldTb.TabIndex = 6;
            // 
            // CoachContractValueLbl
            // 
            this.CoachContractValueLbl.AutoSize = true;
            this.CoachContractValueLbl.Location = new System.Drawing.Point(15, 58);
            this.CoachContractValueLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoachContractValueLbl.Name = "CoachContractValueLbl";
            this.CoachContractValueLbl.Size = new System.Drawing.Size(67, 13);
            this.CoachContractValueLbl.TabIndex = 4;
            this.CoachContractValueLbl.Text = "ارزش قرار داد";
            // 
            // CoachFieldLbl
            // 
            this.CoachFieldLbl.AutoSize = true;
            this.CoachFieldLbl.Location = new System.Drawing.Point(15, 35);
            this.CoachFieldLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoachFieldLbl.Name = "CoachFieldLbl";
            this.CoachFieldLbl.Size = new System.Drawing.Size(64, 13);
            this.CoachFieldLbl.TabIndex = 3;
            this.CoachFieldLbl.Text = "زمینه فعالیت";
            // 
            // CoachImg
            // 
            this.CoachImg.Location = new System.Drawing.Point(9, 11);
            this.CoachImg.Margin = new System.Windows.Forms.Padding(2);
            this.CoachImg.Name = "CoachImg";
            this.CoachImg.Size = new System.Drawing.Size(94, 103);
            this.CoachImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoachImg.TabIndex = 12;
            this.CoachImg.TabStop = false;
            // 
            // CoachInfoBox
            // 
            this.CoachInfoBox.Controls.Add(this.CoachAgeTb);
            this.CoachInfoBox.Controls.Add(this.CoachNationalTb);
            this.CoachInfoBox.Controls.Add(this.CoachNameTb);
            this.CoachInfoBox.Controls.Add(this.CoachAgeLbl);
            this.CoachInfoBox.Controls.Add(this.CoachNationalLbl);
            this.CoachInfoBox.Controls.Add(this.CoachNameLbl);
            this.CoachInfoBox.Location = new System.Drawing.Point(166, 11);
            this.CoachInfoBox.Margin = new System.Windows.Forms.Padding(2);
            this.CoachInfoBox.Name = "CoachInfoBox";
            this.CoachInfoBox.Padding = new System.Windows.Forms.Padding(2);
            this.CoachInfoBox.Size = new System.Drawing.Size(334, 103);
            this.CoachInfoBox.TabIndex = 10;
            this.CoachInfoBox.TabStop = false;
            this.CoachInfoBox.Text = "اطلاعات عمومی";
            this.CoachInfoBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CoachAgeTb
            // 
            this.CoachAgeTb.Enabled = false;
            this.CoachAgeTb.Location = new System.Drawing.Point(161, 73);
            this.CoachAgeTb.Margin = new System.Windows.Forms.Padding(2);
            this.CoachAgeTb.Name = "CoachAgeTb";
            this.CoachAgeTb.Size = new System.Drawing.Size(152, 20);
            this.CoachAgeTb.TabIndex = 9;
            // 
            // CoachNationalTb
            // 
            this.CoachNationalTb.Enabled = false;
            this.CoachNationalTb.Location = new System.Drawing.Point(161, 47);
            this.CoachNationalTb.Margin = new System.Windows.Forms.Padding(2);
            this.CoachNationalTb.Name = "CoachNationalTb";
            this.CoachNationalTb.Size = new System.Drawing.Size(152, 20);
            this.CoachNationalTb.TabIndex = 4;
            // 
            // CoachNameTb
            // 
            this.CoachNameTb.Enabled = false;
            this.CoachNameTb.Location = new System.Drawing.Point(161, 23);
            this.CoachNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.CoachNameTb.Name = "CoachNameTb";
            this.CoachNameTb.Size = new System.Drawing.Size(152, 20);
            this.CoachNameTb.TabIndex = 3;
            // 
            // CoachAgeLbl
            // 
            this.CoachAgeLbl.AutoSize = true;
            this.CoachAgeLbl.Location = new System.Drawing.Point(15, 77);
            this.CoachAgeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoachAgeLbl.Name = "CoachAgeLbl";
            this.CoachAgeLbl.Size = new System.Drawing.Size(23, 13);
            this.CoachAgeLbl.TabIndex = 2;
            this.CoachAgeLbl.Text = "سن";
            // 
            // CoachNationalLbl
            // 
            this.CoachNationalLbl.AutoSize = true;
            this.CoachNationalLbl.Location = new System.Drawing.Point(15, 50);
            this.CoachNationalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoachNationalLbl.Name = "CoachNationalLbl";
            this.CoachNationalLbl.Size = new System.Drawing.Size(40, 13);
            this.CoachNationalLbl.TabIndex = 1;
            this.CoachNationalLbl.Text = "کد ملی";
            // 
            // CoachNameLbl
            // 
            this.CoachNameLbl.AutoSize = true;
            this.CoachNameLbl.Location = new System.Drawing.Point(15, 25);
            this.CoachNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoachNameLbl.Name = "CoachNameLbl";
            this.CoachNameLbl.Size = new System.Drawing.Size(20, 13);
            this.CoachNameLbl.TabIndex = 0;
            this.CoachNameLbl.Text = "نام";
            // 
            // CoachSaveBtn
            // 
            this.CoachSaveBtn.Location = new System.Drawing.Point(425, 216);
            this.CoachSaveBtn.Name = "CoachSaveBtn";
            this.CoachSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.CoachSaveBtn.TabIndex = 13;
            this.CoachSaveBtn.Text = "ذخیره";
            this.CoachSaveBtn.UseVisualStyleBackColor = true;
            // 
            // CoachRmBtn
            // 
            this.CoachRmBtn.Location = new System.Drawing.Point(344, 216);
            this.CoachRmBtn.Name = "CoachRmBtn";
            this.CoachRmBtn.Size = new System.Drawing.Size(75, 23);
            this.CoachRmBtn.TabIndex = 14;
            this.CoachRmBtn.Text = "حذف";
            this.CoachRmBtn.UseVisualStyleBackColor = true;
            // 
            // CoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 251);
            this.Controls.Add(this.CoachRmBtn);
            this.Controls.Add(this.CoachSaveBtn);
            this.Controls.Add(this.CoachOtherBox);
            this.Controls.Add(this.CoachImg);
            this.Controls.Add(this.CoachInfoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(530, 290);
            this.MinimumSize = new System.Drawing.Size(530, 290);
            this.Name = "CoachForm";
            this.Text = "افزودن مربی";
            this.CoachOtherBox.ResumeLayout(false);
            this.CoachOtherBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoachImg)).EndInit();
            this.CoachInfoBox.ResumeLayout(false);
            this.CoachInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CoachOtherBox;
        private System.Windows.Forms.TextBox CoachContractValueTb;
        private System.Windows.Forms.TextBox CoachFieldTb;
        private System.Windows.Forms.Label CoachContractValueLbl;
        private System.Windows.Forms.Label CoachFieldLbl;
        private System.Windows.Forms.PictureBox CoachImg;
        private System.Windows.Forms.GroupBox CoachInfoBox;
        private System.Windows.Forms.TextBox CoachAgeTb;
        private System.Windows.Forms.TextBox CoachNationalTb;
        private System.Windows.Forms.TextBox CoachNameTb;
        private System.Windows.Forms.Label CoachAgeLbl;
        private System.Windows.Forms.Label CoachNationalLbl;
        private System.Windows.Forms.Label CoachNameLbl;
        private System.Windows.Forms.Button CoachSaveBtn;
        private System.Windows.Forms.Button CoachRmBtn;
    }
}