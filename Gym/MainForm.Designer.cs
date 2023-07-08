namespace Gym
{
    partial class MainForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AllTabs = new System.Windows.Forms.TabControl();
            this.EmployeeTab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeAddBtn = new System.Windows.Forms.Button();
            this.CoachTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CoachAddBtn = new System.Windows.Forms.Button();
            this.PlayerTab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PlayerAddBtn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.AllTabs.SuspendLayout();
            this.EmployeeTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CoachTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PlayerTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(1303, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(138, 31);
            label2.TabIndex = 1;
            label2.Text = "لیست مربیان";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(1297, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(144, 31);
            label3.TabIndex = 1;
            label3.Text = "لیست نیرو ها";
            label3.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            label1.AutoSize = true;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(1255, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(186, 31);
            label1.TabIndex = 0;
            label1.Text = "لیست ورزشکاران";
            label1.UseWaitCursor = true;
            // 
            // AllTabs
            // 
            this.AllTabs.AccessibleName = "";
            this.AllTabs.CausesValidation = false;
            this.AllTabs.Controls.Add(this.EmployeeTab);
            this.AllTabs.Controls.Add(this.CoachTab);
            this.AllTabs.Controls.Add(this.PlayerTab);
            this.AllTabs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTabs.Location = new System.Drawing.Point(10, 10);
            this.AllTabs.Margin = new System.Windows.Forms.Padding(50);
            this.AllTabs.Multiline = true;
            this.AllTabs.Name = "AllTabs";
            this.AllTabs.SelectedIndex = 0;
            this.AllTabs.Size = new System.Drawing.Size(1464, 741);
            this.AllTabs.TabIndex = 0;
            this.AllTabs.Tag = "";
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.Controls.Add(this.panel6);
            this.EmployeeTab.Controls.Add(this.panel1);
            this.EmployeeTab.Location = new System.Drawing.Point(4, 22);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTab.Size = new System.Drawing.Size(1456, 715);
            this.EmployeeTab.TabIndex = 0;
            this.EmployeeTab.Text = "کادر اداری";
            this.EmployeeTab.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(6, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1447, 670);
            this.panel6.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.EmployeeAddBtn);
            this.panel1.Controls.Add(label3);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 30);
            this.panel1.TabIndex = 0;
            // 
            // EmployeeAddBtn
            // 
            this.EmployeeAddBtn.Location = new System.Drawing.Point(3, 3);
            this.EmployeeAddBtn.Name = "EmployeeAddBtn";
            this.EmployeeAddBtn.Size = new System.Drawing.Size(75, 23);
            this.EmployeeAddBtn.TabIndex = 1;
            this.EmployeeAddBtn.Text = "افزودن";
            this.EmployeeAddBtn.UseVisualStyleBackColor = true;
            this.EmployeeAddBtn.Click += new System.EventHandler(this.EmployeeAddBtn_Click);
            // 
            // CoachTab
            // 
            this.CoachTab.Controls.Add(this.panel5);
            this.CoachTab.Controls.Add(this.panel2);
            this.CoachTab.Location = new System.Drawing.Point(4, 22);
            this.CoachTab.Name = "CoachTab";
            this.CoachTab.Padding = new System.Windows.Forms.Padding(3);
            this.CoachTab.Size = new System.Drawing.Size(1456, 715);
            this.CoachTab.TabIndex = 1;
            this.CoachTab.Text = "مربیان";
            this.CoachTab.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(6, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1447, 670);
            this.panel5.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.CoachAddBtn);
            this.panel2.Controls.Add(label2);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1444, 30);
            this.panel2.TabIndex = 2;
            // 
            // CoachAddBtn
            // 
            this.CoachAddBtn.Location = new System.Drawing.Point(3, 3);
            this.CoachAddBtn.Name = "CoachAddBtn";
            this.CoachAddBtn.Size = new System.Drawing.Size(75, 23);
            this.CoachAddBtn.TabIndex = 3;
            this.CoachAddBtn.Text = "افزودن";
            this.CoachAddBtn.UseVisualStyleBackColor = true;
            this.CoachAddBtn.Click += new System.EventHandler(this.CoachAddBtn_Click);
            // 
            // PlayerTab
            // 
            this.PlayerTab.Controls.Add(this.panel4);
            this.PlayerTab.Controls.Add(this.panel3);
            this.PlayerTab.Location = new System.Drawing.Point(4, 22);
            this.PlayerTab.Margin = new System.Windows.Forms.Padding(10);
            this.PlayerTab.Name = "PlayerTab";
            this.PlayerTab.Padding = new System.Windows.Forms.Padding(10);
            this.PlayerTab.Size = new System.Drawing.Size(1456, 715);
            this.PlayerTab.TabIndex = 2;
            this.PlayerTab.Text = "ورزشکاران";
            this.PlayerTab.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(6, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1447, 670);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.PlayerAddBtn);
            this.panel3.Controls.Add(label1);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1444, 30);
            this.panel3.TabIndex = 1;
            // 
            // PlayerAddBtn
            // 
            this.PlayerAddBtn.Location = new System.Drawing.Point(3, 3);
            this.PlayerAddBtn.Name = "PlayerAddBtn";
            this.PlayerAddBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayerAddBtn.TabIndex = 2;
            this.PlayerAddBtn.Text = "افزودن";
            this.PlayerAddBtn.UseVisualStyleBackColor = true;
            this.PlayerAddBtn.Click += new System.EventHandler(this.PlayerAddBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.AllTabs);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "باشگاه ورزشی";
            this.AllTabs.ResumeLayout(false);
            this.EmployeeTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CoachTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PlayerTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AllTabs;
        private System.Windows.Forms.TabPage EmployeeTab;
        private System.Windows.Forms.TabPage CoachTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage PlayerTab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button EmployeeAddBtn;
        private System.Windows.Forms.Button CoachAddBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button PlayerAddBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}

