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
            this.EmployeePanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeAddBtn = new System.Windows.Forms.Button();
            this.CoachTab = new System.Windows.Forms.TabPage();
            this.CoachPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CoachTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CoachAddBtn = new System.Windows.Forms.Button();
            this.PlayerTab = new System.Windows.Forms.TabPage();
            this.PlayerPanel = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.PlayerTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PlayerAddBtn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.AllTabs.SuspendLayout();
            this.EmployeeTab.SuspendLayout();
            this.EmployeePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CoachTab.SuspendLayout();
            this.CoachPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PlayerTab.SuspendLayout();
            this.PlayerPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            label2.AutoSize = true;
            label2.Cursor = System.Windows.Forms.Cursors.Default;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(1303, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(138, 31);
            label2.TabIndex = 1;
            label2.Text = "لیست مربیان";
            // 
            // label3
            // 
            label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Cursor = System.Windows.Forms.Cursors.Default;
            label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(1297, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(144, 31);
            label3.TabIndex = 1;
            label3.Text = "لیست نیرو ها";
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
            this.AllTabs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllTabs.RightToLeftLayout = true;
            this.AllTabs.SelectedIndex = 0;
            this.AllTabs.Size = new System.Drawing.Size(1464, 741);
            this.AllTabs.TabIndex = 0;
            this.AllTabs.Tag = "";
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.Controls.Add(this.EmployeePanel);
            this.EmployeeTab.Controls.Add(this.panel1);
            this.EmployeeTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeeTab.Location = new System.Drawing.Point(4, 22);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTab.Size = new System.Drawing.Size(1456, 715);
            this.EmployeeTab.TabIndex = 0;
            this.EmployeeTab.Text = "کادر اداری";
            this.EmployeeTab.UseVisualStyleBackColor = true;
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.BackColor = System.Drawing.Color.White;
            this.EmployeePanel.Controls.Add(this.label10);
            this.EmployeePanel.Controls.Add(this.label9);
            this.EmployeePanel.Controls.Add(this.label8);
            this.EmployeePanel.Controls.Add(this.label7);
            this.EmployeePanel.Controls.Add(this.label6);
            this.EmployeePanel.Controls.Add(this.label5);
            this.EmployeePanel.Controls.Add(this.label4);
            this.EmployeePanel.Controls.Add(this.EmployeeTable);
            this.EmployeePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeePanel.Location = new System.Drawing.Point(6, 42);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(1447, 670);
            this.EmployeePanel.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "حقوق ماهیانه";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(507, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "سمت";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(680, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "کد پرسنلی";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(814, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "سن";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(998, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "کد ملی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1244, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "نام نام خانوادگی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1398, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "شناسه";
            // 
            // EmployeeTable
            // 
            this.EmployeeTable.ColumnCount = 8;
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.EmployeeTable.Location = new System.Drawing.Point(3, 32);
            this.EmployeeTable.Name = "EmployeeTable";
            this.EmployeeTable.RowCount = 1;
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EmployeeTable.Size = new System.Drawing.Size(1441, 50);
            this.EmployeeTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.EmployeeAddBtn);
            this.panel1.Controls.Add(label3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 30);
            this.panel1.TabIndex = 0;
            // 
            // EmployeeAddBtn
            // 
            this.EmployeeAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.CoachTab.Controls.Add(this.CoachPanel);
            this.CoachTab.Controls.Add(this.panel2);
            this.CoachTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.CoachTab.Location = new System.Drawing.Point(4, 22);
            this.CoachTab.Name = "CoachTab";
            this.CoachTab.Padding = new System.Windows.Forms.Padding(3);
            this.CoachTab.Size = new System.Drawing.Size(1456, 715);
            this.CoachTab.TabIndex = 1;
            this.CoachTab.Text = "مربیان";
            this.CoachTab.UseVisualStyleBackColor = true;
            // 
            // CoachPanel
            // 
            this.CoachPanel.BackColor = System.Drawing.Color.White;
            this.CoachPanel.Controls.Add(this.label12);
            this.CoachPanel.Controls.Add(this.label13);
            this.CoachPanel.Controls.Add(this.label14);
            this.CoachPanel.Controls.Add(this.label15);
            this.CoachPanel.Controls.Add(this.label16);
            this.CoachPanel.Controls.Add(this.label17);
            this.CoachPanel.Controls.Add(this.CoachTable);
            this.CoachPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CoachPanel.Location = new System.Drawing.Point(6, 42);
            this.CoachPanel.Name = "CoachPanel";
            this.CoachPanel.Size = new System.Drawing.Size(1447, 670);
            this.CoachPanel.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(452, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "ارزش قرار داد";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(665, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "زمینه فعالیت";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(814, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "سن";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(998, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "کد ملی";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1244, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "نام نام خانوادگی";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1398, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "شناسه";
            // 
            // CoachTable
            // 
            this.CoachTable.ColumnCount = 7;
            this.CoachTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CoachTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.CoachTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.CoachTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CoachTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.CoachTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.CoachTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.CoachTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CoachTable.Location = new System.Drawing.Point(4, 31);
            this.CoachTable.Name = "CoachTable";
            this.CoachTable.RowCount = 1;
            this.CoachTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CoachTable.Size = new System.Drawing.Size(1440, 50);
            this.CoachTable.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.CoachAddBtn);
            this.panel2.Controls.Add(label2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1444, 30);
            this.panel2.TabIndex = 2;
            // 
            // CoachAddBtn
            // 
            this.CoachAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.PlayerTab.Controls.Add(this.PlayerPanel);
            this.PlayerTab.Controls.Add(this.panel3);
            this.PlayerTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayerTab.Location = new System.Drawing.Point(4, 22);
            this.PlayerTab.Margin = new System.Windows.Forms.Padding(10);
            this.PlayerTab.Name = "PlayerTab";
            this.PlayerTab.Padding = new System.Windows.Forms.Padding(10);
            this.PlayerTab.Size = new System.Drawing.Size(1456, 715);
            this.PlayerTab.TabIndex = 2;
            this.PlayerTab.Text = "ورزشکاران";
            this.PlayerTab.UseVisualStyleBackColor = true;
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.BackColor = System.Drawing.Color.White;
            this.PlayerPanel.Controls.Add(this.label23);
            this.PlayerPanel.Controls.Add(this.label11);
            this.PlayerPanel.Controls.Add(this.label18);
            this.PlayerPanel.Controls.Add(this.label19);
            this.PlayerPanel.Controls.Add(this.label20);
            this.PlayerPanel.Controls.Add(this.label21);
            this.PlayerPanel.Controls.Add(this.label22);
            this.PlayerPanel.Controls.Add(this.PlayerTable);
            this.PlayerPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayerPanel.Location = new System.Drawing.Point(6, 42);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(1447, 670);
            this.PlayerPanel.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(406, 10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 20);
            this.label23.TabIndex = 22;
            this.label23.Text = "سمت";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(553, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "ارزش قرار داد";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(647, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "تعداد دستاورد ها";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(814, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 20);
            this.label19.TabIndex = 19;
            this.label19.Text = "سن";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(998, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 20);
            this.label20.TabIndex = 18;
            this.label20.Text = "کد ملی";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1244, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 20);
            this.label21.TabIndex = 17;
            this.label21.Text = "نام نام خانوادگی";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1398, 10);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 20);
            this.label22.TabIndex = 16;
            this.label22.Text = "شناسه";
            // 
            // PlayerTable
            // 
            this.PlayerTable.ColumnCount = 8;
            this.PlayerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.PlayerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.PlayerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.PlayerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.PlayerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.PlayerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.PlayerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.PlayerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PlayerTable.Location = new System.Drawing.Point(4, 33);
            this.PlayerTable.Name = "PlayerTable";
            this.PlayerTable.RowCount = 1;
            this.PlayerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlayerTable.Size = new System.Drawing.Size(1440, 50);
            this.PlayerTable.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.PlayerAddBtn);
            this.panel3.Controls.Add(label1);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1444, 30);
            this.panel3.TabIndex = 1;
            // 
            // PlayerAddBtn
            // 
            this.PlayerAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.BackColor = System.Drawing.Color.White;
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
            this.EmployeePanel.ResumeLayout(false);
            this.EmployeePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CoachTab.ResumeLayout(false);
            this.CoachPanel.ResumeLayout(false);
            this.CoachPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PlayerTab.ResumeLayout(false);
            this.PlayerPanel.ResumeLayout(false);
            this.PlayerPanel.PerformLayout();
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
        private System.Windows.Forms.Panel PlayerPanel;
        private System.Windows.Forms.Button PlayerAddBtn;
        private System.Windows.Forms.Panel EmployeePanel;
        private System.Windows.Forms.Panel CoachPanel;
        private System.Windows.Forms.TableLayoutPanel EmployeeTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TableLayoutPanel CoachTable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TableLayoutPanel PlayerTable;
        private System.Windows.Forms.Label label23;
    }
}

