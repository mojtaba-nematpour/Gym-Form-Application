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
            this.EmployeeSortSalary = new System.Windows.Forms.Label();
            this.EmployeeSortPosition = new System.Windows.Forms.Label();
            this.EmployeeSortPerCode = new System.Windows.Forms.Label();
            this.EmployeeSortAge = new System.Windows.Forms.Label();
            this.EmployeeSortNational = new System.Windows.Forms.Label();
            this.EmployeeSortName = new System.Windows.Forms.Label();
            this.EmployeeSortId = new System.Windows.Forms.Label();
            this.EmployeeTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeAddBtn = new System.Windows.Forms.Button();
            this.CoachTab = new System.Windows.Forms.TabPage();
            this.CoachPanel = new System.Windows.Forms.Panel();
            this.CoachSortContractValue = new System.Windows.Forms.Label();
            this.CoachSortField = new System.Windows.Forms.Label();
            this.CoachSortAge = new System.Windows.Forms.Label();
            this.CoachSortNational = new System.Windows.Forms.Label();
            this.CoachSortName = new System.Windows.Forms.Label();
            this.CoachSortId = new System.Windows.Forms.Label();
            this.CoachTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CoachAddBtn = new System.Windows.Forms.Button();
            this.PlayerTab = new System.Windows.Forms.TabPage();
            this.PlayerPanel = new System.Windows.Forms.Panel();
            this.PlayerSortPosition = new System.Windows.Forms.Label();
            this.PlayerSortContractValue = new System.Windows.Forms.Label();
            this.PlayerSortGoals = new System.Windows.Forms.Label();
            this.PlayerSortAge = new System.Windows.Forms.Label();
            this.PlayerSortNational = new System.Windows.Forms.Label();
            this.PlayerSortName = new System.Windows.Forms.Label();
            this.PlayerSortId = new System.Windows.Forms.Label();
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
            this.EmployeePanel.Controls.Add(this.EmployeeSortSalary);
            this.EmployeePanel.Controls.Add(this.EmployeeSortPosition);
            this.EmployeePanel.Controls.Add(this.EmployeeSortPerCode);
            this.EmployeePanel.Controls.Add(this.EmployeeSortAge);
            this.EmployeePanel.Controls.Add(this.EmployeeSortNational);
            this.EmployeePanel.Controls.Add(this.EmployeeSortName);
            this.EmployeePanel.Controls.Add(this.EmployeeSortId);
            this.EmployeePanel.Controls.Add(this.EmployeeTable);
            this.EmployeePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeePanel.Location = new System.Drawing.Point(6, 42);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(1447, 670);
            this.EmployeePanel.TabIndex = 3;
            // 
            // EmployeeSortSalary
            // 
            this.EmployeeSortSalary.AutoSize = true;
            this.EmployeeSortSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSortSalary.Location = new System.Drawing.Point(259, 9);
            this.EmployeeSortSalary.Name = "EmployeeSortSalary";
            this.EmployeeSortSalary.Size = new System.Drawing.Size(77, 20);
            this.EmployeeSortSalary.TabIndex = 7;
            this.EmployeeSortSalary.Text = "حقوق ماهیانه";
            this.EmployeeSortSalary.Click += new System.EventHandler(this.EmployeeSortSalary_Click);
            // 
            // EmployeeSortPosition
            // 
            this.EmployeeSortPosition.AutoSize = true;
            this.EmployeeSortPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSortPosition.Location = new System.Drawing.Point(507, 9);
            this.EmployeeSortPosition.Name = "EmployeeSortPosition";
            this.EmployeeSortPosition.Size = new System.Drawing.Size(34, 20);
            this.EmployeeSortPosition.TabIndex = 6;
            this.EmployeeSortPosition.Text = "سمت";
            this.EmployeeSortPosition.Click += new System.EventHandler(this.EmployeeSortPosition_Click);
            // 
            // EmployeeSortPerCode
            // 
            this.EmployeeSortPerCode.AutoSize = true;
            this.EmployeeSortPerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSortPerCode.Location = new System.Drawing.Point(672, 9);
            this.EmployeeSortPerCode.Name = "EmployeeSortPerCode";
            this.EmployeeSortPerCode.Size = new System.Drawing.Size(61, 20);
            this.EmployeeSortPerCode.TabIndex = 5;
            this.EmployeeSortPerCode.Text = "کد پرسنلی";
            this.EmployeeSortPerCode.Click += new System.EventHandler(this.EmployeeSortPerCode_Click);
            // 
            // EmployeeSortAge
            // 
            this.EmployeeSortAge.AutoSize = true;
            this.EmployeeSortAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSortAge.Location = new System.Drawing.Point(805, 9);
            this.EmployeeSortAge.Name = "EmployeeSortAge";
            this.EmployeeSortAge.Size = new System.Drawing.Size(26, 20);
            this.EmployeeSortAge.TabIndex = 4;
            this.EmployeeSortAge.Text = "سن";
            this.EmployeeSortAge.Click += new System.EventHandler(this.EmployeeSortAge_Click);
            // 
            // EmployeeSortNational
            // 
            this.EmployeeSortNational.AutoSize = true;
            this.EmployeeSortNational.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSortNational.Location = new System.Drawing.Point(998, 9);
            this.EmployeeSortNational.Name = "EmployeeSortNational";
            this.EmployeeSortNational.Size = new System.Drawing.Size(41, 20);
            this.EmployeeSortNational.TabIndex = 3;
            this.EmployeeSortNational.Text = "کد ملی";
            this.EmployeeSortNational.Click += new System.EventHandler(this.EmployeeSortNational_Click);
            // 
            // EmployeeSortName
            // 
            this.EmployeeSortName.AutoSize = true;
            this.EmployeeSortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSortName.Location = new System.Drawing.Point(1244, 9);
            this.EmployeeSortName.Name = "EmployeeSortName";
            this.EmployeeSortName.Size = new System.Drawing.Size(90, 20);
            this.EmployeeSortName.TabIndex = 2;
            this.EmployeeSortName.Text = "نام نام خانوادگی";
            this.EmployeeSortName.Click += new System.EventHandler(this.EmployeeSortName_Click);
            // 
            // EmployeeSortId
            // 
            this.EmployeeSortId.AutoSize = true;
            this.EmployeeSortId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSortId.Location = new System.Drawing.Point(1388, 9);
            this.EmployeeSortId.Name = "EmployeeSortId";
            this.EmployeeSortId.Size = new System.Drawing.Size(42, 20);
            this.EmployeeSortId.TabIndex = 1;
            this.EmployeeSortId.Text = "شناسه";
            this.EmployeeSortId.Click += new System.EventHandler(this.EmployeeSortId_Click);
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
            this.EmployeeTable.Size = new System.Drawing.Size(1433, 50);
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
            this.CoachPanel.Controls.Add(this.CoachSortContractValue);
            this.CoachPanel.Controls.Add(this.CoachSortField);
            this.CoachPanel.Controls.Add(this.CoachSortAge);
            this.CoachPanel.Controls.Add(this.CoachSortNational);
            this.CoachPanel.Controls.Add(this.CoachSortName);
            this.CoachPanel.Controls.Add(this.CoachSortId);
            this.CoachPanel.Controls.Add(this.CoachTable);
            this.CoachPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CoachPanel.Location = new System.Drawing.Point(6, 42);
            this.CoachPanel.Name = "CoachPanel";
            this.CoachPanel.Size = new System.Drawing.Size(1447, 670);
            this.CoachPanel.TabIndex = 3;
            // 
            // CoachSortContractValue
            // 
            this.CoachSortContractValue.AutoSize = true;
            this.CoachSortContractValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachSortContractValue.Location = new System.Drawing.Point(442, 8);
            this.CoachSortContractValue.Name = "CoachSortContractValue";
            this.CoachSortContractValue.Size = new System.Drawing.Size(88, 20);
            this.CoachSortContractValue.TabIndex = 14;
            this.CoachSortContractValue.Text = "ارزش قرار داد";
            this.CoachSortContractValue.Click += new System.EventHandler(this.CoachSortContractValue_Click);
            // 
            // CoachSortField
            // 
            this.CoachSortField.AutoSize = true;
            this.CoachSortField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachSortField.Location = new System.Drawing.Point(656, 8);
            this.CoachSortField.Name = "CoachSortField";
            this.CoachSortField.Size = new System.Drawing.Size(73, 20);
            this.CoachSortField.TabIndex = 13;
            this.CoachSortField.Text = "زمینه فعالیت";
            this.CoachSortField.Click += new System.EventHandler(this.CoachSortField_Click);
            // 
            // CoachSortAge
            // 
            this.CoachSortAge.AutoSize = true;
            this.CoachSortAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachSortAge.Location = new System.Drawing.Point(804, 8);
            this.CoachSortAge.Name = "CoachSortAge";
            this.CoachSortAge.Size = new System.Drawing.Size(26, 20);
            this.CoachSortAge.TabIndex = 12;
            this.CoachSortAge.Text = "سن";
            this.CoachSortAge.Click += new System.EventHandler(this.CoachSortAge_Click);
            // 
            // CoachSortNational
            // 
            this.CoachSortNational.AutoSize = true;
            this.CoachSortNational.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachSortNational.Location = new System.Drawing.Point(990, 8);
            this.CoachSortNational.Name = "CoachSortNational";
            this.CoachSortNational.Size = new System.Drawing.Size(41, 20);
            this.CoachSortNational.TabIndex = 11;
            this.CoachSortNational.Text = "کد ملی";
            this.CoachSortNational.Click += new System.EventHandler(this.CoachSortNational_Click);
            // 
            // CoachSortName
            // 
            this.CoachSortName.AutoSize = true;
            this.CoachSortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachSortName.Location = new System.Drawing.Point(1240, 8);
            this.CoachSortName.Name = "CoachSortName";
            this.CoachSortName.Size = new System.Drawing.Size(90, 20);
            this.CoachSortName.TabIndex = 10;
            this.CoachSortName.Text = "نام نام خانوادگی";
            this.CoachSortName.Click += new System.EventHandler(this.CoachSortName_Click);
            // 
            // CoachSortId
            // 
            this.CoachSortId.AutoSize = true;
            this.CoachSortId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachSortId.Location = new System.Drawing.Point(1387, 8);
            this.CoachSortId.Name = "CoachSortId";
            this.CoachSortId.Size = new System.Drawing.Size(42, 20);
            this.CoachSortId.TabIndex = 9;
            this.CoachSortId.Text = "شناسه";
            this.CoachSortId.Click += new System.EventHandler(this.CoachSortId_Click);
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
            this.CoachTable.Size = new System.Drawing.Size(1431, 50);
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
            this.PlayerPanel.Controls.Add(this.PlayerSortPosition);
            this.PlayerPanel.Controls.Add(this.PlayerSortContractValue);
            this.PlayerPanel.Controls.Add(this.PlayerSortGoals);
            this.PlayerPanel.Controls.Add(this.PlayerSortAge);
            this.PlayerPanel.Controls.Add(this.PlayerSortNational);
            this.PlayerPanel.Controls.Add(this.PlayerSortName);
            this.PlayerPanel.Controls.Add(this.PlayerSortId);
            this.PlayerPanel.Controls.Add(this.PlayerTable);
            this.PlayerPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayerPanel.Location = new System.Drawing.Point(6, 42);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(1447, 670);
            this.PlayerPanel.TabIndex = 2;
            // 
            // PlayerSortPosition
            // 
            this.PlayerSortPosition.AutoSize = true;
            this.PlayerSortPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSortPosition.Location = new System.Drawing.Point(397, 10);
            this.PlayerSortPosition.Name = "PlayerSortPosition";
            this.PlayerSortPosition.Size = new System.Drawing.Size(34, 20);
            this.PlayerSortPosition.TabIndex = 22;
            this.PlayerSortPosition.Text = "سمت";
            this.PlayerSortPosition.Click += new System.EventHandler(this.PlayerSortPosition_Click);
            // 
            // PlayerSortContractValue
            // 
            this.PlayerSortContractValue.AutoSize = true;
            this.PlayerSortContractValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSortContractValue.Location = new System.Drawing.Point(539, 10);
            this.PlayerSortContractValue.Name = "PlayerSortContractValue";
            this.PlayerSortContractValue.Size = new System.Drawing.Size(88, 20);
            this.PlayerSortContractValue.TabIndex = 21;
            this.PlayerSortContractValue.Text = "ارزش قرار داد";
            this.PlayerSortContractValue.Click += new System.EventHandler(this.PlayerSortContractValue_Click);
            // 
            // PlayerSortGoals
            // 
            this.PlayerSortGoals.AutoSize = true;
            this.PlayerSortGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSortGoals.Location = new System.Drawing.Point(633, 10);
            this.PlayerSortGoals.Name = "PlayerSortGoals";
            this.PlayerSortGoals.Size = new System.Drawing.Size(94, 20);
            this.PlayerSortGoals.TabIndex = 20;
            this.PlayerSortGoals.Text = "تعداد دستاورد ها";
            this.PlayerSortGoals.Click += new System.EventHandler(this.PlayerSortGoals_Click);
            // 
            // PlayerSortAge
            // 
            this.PlayerSortAge.AutoSize = true;
            this.PlayerSortAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSortAge.Location = new System.Drawing.Point(806, 10);
            this.PlayerSortAge.Name = "PlayerSortAge";
            this.PlayerSortAge.Size = new System.Drawing.Size(26, 20);
            this.PlayerSortAge.TabIndex = 19;
            this.PlayerSortAge.Text = "سن";
            this.PlayerSortAge.Click += new System.EventHandler(this.PlayerSortAge_Click);
            // 
            // PlayerSortNational
            // 
            this.PlayerSortNational.AutoSize = true;
            this.PlayerSortNational.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSortNational.Location = new System.Drawing.Point(992, 10);
            this.PlayerSortNational.Name = "PlayerSortNational";
            this.PlayerSortNational.Size = new System.Drawing.Size(41, 20);
            this.PlayerSortNational.TabIndex = 18;
            this.PlayerSortNational.Text = "کد ملی";
            this.PlayerSortNational.Click += new System.EventHandler(this.PlayerSortNational_Click);
            // 
            // PlayerSortName
            // 
            this.PlayerSortName.AutoSize = true;
            this.PlayerSortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSortName.Location = new System.Drawing.Point(1238, 10);
            this.PlayerSortName.Name = "PlayerSortName";
            this.PlayerSortName.Size = new System.Drawing.Size(90, 20);
            this.PlayerSortName.TabIndex = 17;
            this.PlayerSortName.Text = "نام نام خانوادگی";
            this.PlayerSortName.Click += new System.EventHandler(this.PlayerSortName_Click);
            // 
            // PlayerSortId
            // 
            this.PlayerSortId.AutoSize = true;
            this.PlayerSortId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSortId.Location = new System.Drawing.Point(1386, 10);
            this.PlayerSortId.Name = "PlayerSortId";
            this.PlayerSortId.Size = new System.Drawing.Size(42, 20);
            this.PlayerSortId.TabIndex = 16;
            this.PlayerSortId.Text = "شناسه";
            this.PlayerSortId.Click += new System.EventHandler(this.PlayerSortId_Click);
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
            this.PlayerTable.Size = new System.Drawing.Size(1431, 50);
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
        private System.Windows.Forms.Label EmployeeSortName;
        private System.Windows.Forms.Label EmployeeSortId;
        private System.Windows.Forms.Label EmployeeSortSalary;
        private System.Windows.Forms.Label EmployeeSortPosition;
        private System.Windows.Forms.Label EmployeeSortPerCode;
        private System.Windows.Forms.Label EmployeeSortAge;
        private System.Windows.Forms.Label EmployeeSortNational;
        private System.Windows.Forms.Label CoachSortContractValue;
        private System.Windows.Forms.Label CoachSortField;
        private System.Windows.Forms.Label CoachSortAge;
        private System.Windows.Forms.Label CoachSortNational;
        private System.Windows.Forms.Label CoachSortName;
        private System.Windows.Forms.Label CoachSortId;
        private System.Windows.Forms.TableLayoutPanel CoachTable;
        private System.Windows.Forms.Label PlayerSortContractValue;
        private System.Windows.Forms.Label PlayerSortGoals;
        private System.Windows.Forms.Label PlayerSortAge;
        private System.Windows.Forms.Label PlayerSortNational;
        private System.Windows.Forms.Label PlayerSortName;
        private System.Windows.Forms.Label PlayerSortId;
        private System.Windows.Forms.TableLayoutPanel PlayerTable;
        private System.Windows.Forms.Label PlayerSortPosition;
    }
}

