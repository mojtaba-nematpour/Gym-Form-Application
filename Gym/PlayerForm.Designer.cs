namespace Gym
{
    partial class PlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.PlayerRmBtn = new System.Windows.Forms.Button();
            this.PlayerSaveBtn = new System.Windows.Forms.Button();
            this.PlayerOtherBox = new System.Windows.Forms.GroupBox();
            this.PlayerGoalsTb = new System.Windows.Forms.TextBox();
            this.PlayerNumberTb = new System.Windows.Forms.TextBox();
            this.PlayerGoalsLbl = new System.Windows.Forms.Label();
            this.PlayerNumberLbl = new System.Windows.Forms.Label();
            this.PlayerImg = new System.Windows.Forms.PictureBox();
            this.PlayerInfoBox = new System.Windows.Forms.GroupBox();
            this.PlayerAgeTb = new System.Windows.Forms.TextBox();
            this.PlayerNationalTb = new System.Windows.Forms.TextBox();
            this.PlayerNameTb = new System.Windows.Forms.TextBox();
            this.PlayerAgeLbl = new System.Windows.Forms.Label();
            this.PlayerNationalLbl = new System.Windows.Forms.Label();
            this.PlayerNameLbl = new System.Windows.Forms.Label();
            this.PlayerContractValyeTb = new System.Windows.Forms.TextBox();
            this.PlayerContractValueLbl = new System.Windows.Forms.Label();
            this.PlayerPositionTb = new System.Windows.Forms.TextBox();
            this.PlayerPositionLbl = new System.Windows.Forms.Label();
            this.PlayerOtherBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImg)).BeginInit();
            this.PlayerInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerRmBtn
            // 
            this.PlayerRmBtn.Location = new System.Drawing.Point(346, 259);
            this.PlayerRmBtn.Name = "PlayerRmBtn";
            this.PlayerRmBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayerRmBtn.TabIndex = 19;
            this.PlayerRmBtn.Text = "حذف";
            this.PlayerRmBtn.UseVisualStyleBackColor = true;
            // 
            // PlayerSaveBtn
            // 
            this.PlayerSaveBtn.Location = new System.Drawing.Point(427, 259);
            this.PlayerSaveBtn.Name = "PlayerSaveBtn";
            this.PlayerSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayerSaveBtn.TabIndex = 18;
            this.PlayerSaveBtn.Text = "ذخیره";
            this.PlayerSaveBtn.UseVisualStyleBackColor = true;
            // 
            // PlayerOtherBox
            // 
            this.PlayerOtherBox.Controls.Add(this.PlayerPositionTb);
            this.PlayerOtherBox.Controls.Add(this.PlayerPositionLbl);
            this.PlayerOtherBox.Controls.Add(this.PlayerContractValyeTb);
            this.PlayerOtherBox.Controls.Add(this.PlayerContractValueLbl);
            this.PlayerOtherBox.Controls.Add(this.PlayerGoalsTb);
            this.PlayerOtherBox.Controls.Add(this.PlayerNumberTb);
            this.PlayerOtherBox.Controls.Add(this.PlayerGoalsLbl);
            this.PlayerOtherBox.Controls.Add(this.PlayerNumberLbl);
            this.PlayerOtherBox.Location = new System.Drawing.Point(168, 118);
            this.PlayerOtherBox.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerOtherBox.Name = "PlayerOtherBox";
            this.PlayerOtherBox.Padding = new System.Windows.Forms.Padding(2);
            this.PlayerOtherBox.Size = new System.Drawing.Size(334, 136);
            this.PlayerOtherBox.TabIndex = 16;
            this.PlayerOtherBox.TabStop = false;
            this.PlayerOtherBox.Text = "دیگر مشخصات";
            // 
            // PlayerGoalsTb
            // 
            this.PlayerGoalsTb.Enabled = false;
            this.PlayerGoalsTb.Location = new System.Drawing.Point(161, 56);
            this.PlayerGoalsTb.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerGoalsTb.Name = "PlayerGoalsTb";
            this.PlayerGoalsTb.Size = new System.Drawing.Size(152, 20);
            this.PlayerGoalsTb.TabIndex = 7;
            // 
            // PlayerNumberTb
            // 
            this.PlayerNumberTb.Enabled = false;
            this.PlayerNumberTb.Location = new System.Drawing.Point(161, 31);
            this.PlayerNumberTb.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerNumberTb.Name = "PlayerNumberTb";
            this.PlayerNumberTb.Size = new System.Drawing.Size(152, 20);
            this.PlayerNumberTb.TabIndex = 6;
            // 
            // PlayerGoalsLbl
            // 
            this.PlayerGoalsLbl.AutoSize = true;
            this.PlayerGoalsLbl.Location = new System.Drawing.Point(15, 58);
            this.PlayerGoalsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerGoalsLbl.Name = "PlayerGoalsLbl";
            this.PlayerGoalsLbl.Size = new System.Drawing.Size(85, 13);
            this.PlayerGoalsLbl.TabIndex = 4;
            this.PlayerGoalsLbl.Text = "تعداد دستاورد ها";
            // 
            // PlayerNumberLbl
            // 
            this.PlayerNumberLbl.AutoSize = true;
            this.PlayerNumberLbl.Location = new System.Drawing.Point(15, 35);
            this.PlayerNumberLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerNumberLbl.Name = "PlayerNumberLbl";
            this.PlayerNumberLbl.Size = new System.Drawing.Size(73, 13);
            this.PlayerNumberLbl.TabIndex = 3;
            this.PlayerNumberLbl.Text = "شماره عضویت";
            // 
            // PlayerImg
            // 
            this.PlayerImg.Location = new System.Drawing.Point(11, 11);
            this.PlayerImg.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerImg.Name = "PlayerImg";
            this.PlayerImg.Size = new System.Drawing.Size(94, 103);
            this.PlayerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerImg.TabIndex = 17;
            this.PlayerImg.TabStop = false;
            // 
            // PlayerInfoBox
            // 
            this.PlayerInfoBox.Controls.Add(this.PlayerAgeTb);
            this.PlayerInfoBox.Controls.Add(this.PlayerNationalTb);
            this.PlayerInfoBox.Controls.Add(this.PlayerNameTb);
            this.PlayerInfoBox.Controls.Add(this.PlayerAgeLbl);
            this.PlayerInfoBox.Controls.Add(this.PlayerNationalLbl);
            this.PlayerInfoBox.Controls.Add(this.PlayerNameLbl);
            this.PlayerInfoBox.Location = new System.Drawing.Point(168, 11);
            this.PlayerInfoBox.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerInfoBox.Name = "PlayerInfoBox";
            this.PlayerInfoBox.Padding = new System.Windows.Forms.Padding(2);
            this.PlayerInfoBox.Size = new System.Drawing.Size(334, 103);
            this.PlayerInfoBox.TabIndex = 15;
            this.PlayerInfoBox.TabStop = false;
            this.PlayerInfoBox.Text = "اطلاعات عمومی";
            // 
            // PlayerAgeTb
            // 
            this.PlayerAgeTb.Enabled = false;
            this.PlayerAgeTb.Location = new System.Drawing.Point(161, 73);
            this.PlayerAgeTb.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerAgeTb.Name = "PlayerAgeTb";
            this.PlayerAgeTb.Size = new System.Drawing.Size(152, 20);
            this.PlayerAgeTb.TabIndex = 9;
            // 
            // PlayerNationalTb
            // 
            this.PlayerNationalTb.Enabled = false;
            this.PlayerNationalTb.Location = new System.Drawing.Point(161, 47);
            this.PlayerNationalTb.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerNationalTb.Name = "PlayerNationalTb";
            this.PlayerNationalTb.Size = new System.Drawing.Size(152, 20);
            this.PlayerNationalTb.TabIndex = 4;
            // 
            // PlayerNameTb
            // 
            this.PlayerNameTb.Enabled = false;
            this.PlayerNameTb.Location = new System.Drawing.Point(161, 23);
            this.PlayerNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerNameTb.Name = "PlayerNameTb";
            this.PlayerNameTb.Size = new System.Drawing.Size(152, 20);
            this.PlayerNameTb.TabIndex = 3;
            // 
            // PlayerAgeLbl
            // 
            this.PlayerAgeLbl.AutoSize = true;
            this.PlayerAgeLbl.Location = new System.Drawing.Point(15, 77);
            this.PlayerAgeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerAgeLbl.Name = "PlayerAgeLbl";
            this.PlayerAgeLbl.Size = new System.Drawing.Size(23, 13);
            this.PlayerAgeLbl.TabIndex = 2;
            this.PlayerAgeLbl.Text = "سن";
            // 
            // PlayerNationalLbl
            // 
            this.PlayerNationalLbl.AutoSize = true;
            this.PlayerNationalLbl.Location = new System.Drawing.Point(15, 50);
            this.PlayerNationalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerNationalLbl.Name = "PlayerNationalLbl";
            this.PlayerNationalLbl.Size = new System.Drawing.Size(40, 13);
            this.PlayerNationalLbl.TabIndex = 1;
            this.PlayerNationalLbl.Text = "کد ملی";
            // 
            // PlayerNameLbl
            // 
            this.PlayerNameLbl.AutoSize = true;
            this.PlayerNameLbl.Location = new System.Drawing.Point(15, 25);
            this.PlayerNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerNameLbl.Name = "PlayerNameLbl";
            this.PlayerNameLbl.Size = new System.Drawing.Size(20, 13);
            this.PlayerNameLbl.TabIndex = 0;
            this.PlayerNameLbl.Text = "نام";
            // 
            // PlayerContractValyeTb
            // 
            this.PlayerContractValyeTb.Enabled = false;
            this.PlayerContractValyeTb.Location = new System.Drawing.Point(161, 80);
            this.PlayerContractValyeTb.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerContractValyeTb.Name = "PlayerContractValyeTb";
            this.PlayerContractValyeTb.Size = new System.Drawing.Size(152, 20);
            this.PlayerContractValyeTb.TabIndex = 9;
            // 
            // PlayerContractValueLbl
            // 
            this.PlayerContractValueLbl.AutoSize = true;
            this.PlayerContractValueLbl.Location = new System.Drawing.Point(15, 82);
            this.PlayerContractValueLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerContractValueLbl.Name = "PlayerContractValueLbl";
            this.PlayerContractValueLbl.Size = new System.Drawing.Size(67, 13);
            this.PlayerContractValueLbl.TabIndex = 8;
            this.PlayerContractValueLbl.Text = "ارزش قرار داد";
            // 
            // PlayerPositionTb
            // 
            this.PlayerPositionTb.Enabled = false;
            this.PlayerPositionTb.Location = new System.Drawing.Point(161, 104);
            this.PlayerPositionTb.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerPositionTb.Name = "PlayerPositionTb";
            this.PlayerPositionTb.Size = new System.Drawing.Size(152, 20);
            this.PlayerPositionTb.TabIndex = 11;
            // 
            // PlayerPositionLbl
            // 
            this.PlayerPositionLbl.AutoSize = true;
            this.PlayerPositionLbl.Location = new System.Drawing.Point(15, 106);
            this.PlayerPositionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerPositionLbl.Name = "PlayerPositionLbl";
            this.PlayerPositionLbl.Size = new System.Drawing.Size(29, 13);
            this.PlayerPositionLbl.TabIndex = 10;
            this.PlayerPositionLbl.Text = "سمت";
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 296);
            this.Controls.Add(this.PlayerRmBtn);
            this.Controls.Add(this.PlayerSaveBtn);
            this.Controls.Add(this.PlayerOtherBox);
            this.Controls.Add(this.PlayerImg);
            this.Controls.Add(this.PlayerInfoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(530, 335);
            this.MinimumSize = new System.Drawing.Size(530, 335);
            this.Name = "PlayerForm";
            this.Text = "افزودن ورزشکار";
            this.PlayerOtherBox.ResumeLayout(false);
            this.PlayerOtherBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImg)).EndInit();
            this.PlayerInfoBox.ResumeLayout(false);
            this.PlayerInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayerRmBtn;
        private System.Windows.Forms.Button PlayerSaveBtn;
        private System.Windows.Forms.GroupBox PlayerOtherBox;
        private System.Windows.Forms.TextBox PlayerGoalsTb;
        private System.Windows.Forms.TextBox PlayerNumberTb;
        private System.Windows.Forms.Label PlayerGoalsLbl;
        private System.Windows.Forms.Label PlayerNumberLbl;
        private System.Windows.Forms.PictureBox PlayerImg;
        private System.Windows.Forms.GroupBox PlayerInfoBox;
        private System.Windows.Forms.TextBox PlayerAgeTb;
        private System.Windows.Forms.TextBox PlayerNationalTb;
        private System.Windows.Forms.TextBox PlayerNameTb;
        private System.Windows.Forms.Label PlayerAgeLbl;
        private System.Windows.Forms.Label PlayerNationalLbl;
        private System.Windows.Forms.Label PlayerNameLbl;
        private System.Windows.Forms.TextBox PlayerPositionTb;
        private System.Windows.Forms.Label PlayerPositionLbl;
        private System.Windows.Forms.TextBox PlayerContractValyeTb;
        private System.Windows.Forms.Label PlayerContractValueLbl;
    }
}