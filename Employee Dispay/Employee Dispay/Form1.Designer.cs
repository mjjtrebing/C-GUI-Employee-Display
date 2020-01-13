namespace Employee_Dispay
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
            this.firstCall = new System.Windows.Forms.TextBox();
            this.empList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.EIN = new System.Windows.Forms.TextBox();
            this.SSN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.birth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.TextBox();
            this.work = new System.Windows.Forms.TextBox();
            this.cell = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.hired = new System.Windows.Forms.TextBox();
            this.dpt = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.SEIN = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.sal = new System.Windows.Forms.TextBox();
            this.exemption = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.witholdings = new System.Windows.Forms.TextBox();
            this.raise = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.emp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstCall
            // 
            this.firstCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.firstCall.ForeColor = System.Drawing.SystemColors.Menu;
            this.firstCall.Location = new System.Drawing.Point(71, 52);
            this.firstCall.Name = "firstCall";
            this.firstCall.ReadOnly = true;
            this.firstCall.Size = new System.Drawing.Size(179, 20);
            this.firstCall.TabIndex = 1;
            this.firstCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.firstCall.TextChanged += new System.EventHandler(this.firstCall_TextChanged);
            // 
            // empList
            // 
            this.empList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.empList.ForeColor = System.Drawing.SystemColors.Menu;
            this.empList.FormattingEnabled = true;
            this.empList.Location = new System.Drawing.Point(444, 34);
            this.empList.Name = "empList";
            this.empList.Size = new System.Drawing.Size(179, 21);
            this.empList.TabIndex = 2;
            this.empList.SelectedIndexChanged += new System.EventHandler(this.empList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SSN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DOB";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(111, 108);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 9;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(184, 108);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 10;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // EIN
            // 
            this.EIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.EIN.ForeColor = System.Drawing.SystemColors.Menu;
            this.EIN.Location = new System.Drawing.Point(71, 23);
            this.EIN.Name = "EIN";
            this.EIN.ReadOnly = true;
            this.EIN.Size = new System.Drawing.Size(179, 20);
            this.EIN.TabIndex = 11;
            this.EIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SSN
            // 
            this.SSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.SSN.ForeColor = System.Drawing.SystemColors.Menu;
            this.SSN.Location = new System.Drawing.Point(71, 80);
            this.SSN.Name = "SSN";
            this.SSN.ReadOnly = true;
            this.SSN.Size = new System.Drawing.Size(179, 20);
            this.SSN.TabIndex = 12;
            this.SSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.birth);
            this.groupBox1.Controls.Add(this.SSN);
            this.groupBox1.Controls.Add(this.EIN);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.firstCall);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(16, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 191);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Personal Info";
            // 
            // birth
            // 
            this.birth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.birth.ForeColor = System.Drawing.SystemColors.Menu;
            this.birth.Location = new System.Drawing.Point(71, 141);
            this.birth.Name = "birth";
            this.birth.ReadOnly = true;
            this.birth.Size = new System.Drawing.Size(179, 20);
            this.birth.TabIndex = 31;
            this.birth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Home Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Office Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cell Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Street Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Work Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "City/State/Zip";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.home.ForeColor = System.Drawing.SystemColors.Menu;
            this.home.Location = new System.Drawing.Point(95, 23);
            this.home.Name = "home";
            this.home.ReadOnly = true;
            this.home.Size = new System.Drawing.Size(179, 20);
            this.home.TabIndex = 22;
            this.home.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // work
            // 
            this.work.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.work.ForeColor = System.Drawing.SystemColors.Menu;
            this.work.Location = new System.Drawing.Point(95, 49);
            this.work.Name = "work";
            this.work.ReadOnly = true;
            this.work.Size = new System.Drawing.Size(179, 20);
            this.work.TabIndex = 23;
            this.work.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cell
            // 
            this.cell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.cell.ForeColor = System.Drawing.SystemColors.Menu;
            this.cell.Location = new System.Drawing.Point(95, 75);
            this.cell.Name = "cell";
            this.cell.ReadOnly = true;
            this.cell.Size = new System.Drawing.Size(179, 20);
            this.cell.TabIndex = 24;
            this.cell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // location
            // 
            this.location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.location.ForeColor = System.Drawing.SystemColors.Menu;
            this.location.Location = new System.Drawing.Point(95, 101);
            this.location.Name = "location";
            this.location.ReadOnly = true;
            this.location.Size = new System.Drawing.Size(179, 20);
            this.location.TabIndex = 25;
            this.location.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // street
            // 
            this.street.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.street.ForeColor = System.Drawing.SystemColors.Menu;
            this.street.Location = new System.Drawing.Point(95, 127);
            this.street.Name = "street";
            this.street.ReadOnly = true;
            this.street.Size = new System.Drawing.Size(179, 20);
            this.street.TabIndex = 26;
            this.street.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zip
            // 
            this.zip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.zip.ForeColor = System.Drawing.SystemColors.Menu;
            this.zip.Location = new System.Drawing.Point(218, 153);
            this.zip.Name = "zip";
            this.zip.ReadOnly = true;
            this.zip.Size = new System.Drawing.Size(56, 20);
            this.zip.TabIndex = 27;
            this.zip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.city.ForeColor = System.Drawing.SystemColors.Menu;
            this.city.Location = new System.Drawing.Point(95, 153);
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Size = new System.Drawing.Size(56, 20);
            this.city.TabIndex = 28;
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.state.ForeColor = System.Drawing.SystemColors.Menu;
            this.state.Location = new System.Drawing.Point(157, 153);
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Size = new System.Drawing.Size(56, 20);
            this.state.TabIndex = 29;
            this.state.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.state);
            this.groupBox2.Controls.Add(this.city);
            this.groupBox2.Controls.Add(this.zip);
            this.groupBox2.Controls.Add(this.street);
            this.groupBox2.Controls.Add(this.location);
            this.groupBox2.Controls.Add(this.cell);
            this.groupBox2.Controls.Add(this.home);
            this.groupBox2.Controls.Add(this.work);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(349, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 191);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Contact Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Date Hired";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Supervisor EIN";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Title";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Employee Type";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Department Code";
            // 
            // hired
            // 
            this.hired.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.hired.ForeColor = System.Drawing.SystemColors.Menu;
            this.hired.Location = new System.Drawing.Point(95, 99);
            this.hired.Name = "hired";
            this.hired.ReadOnly = true;
            this.hired.Size = new System.Drawing.Size(179, 20);
            this.hired.TabIndex = 37;
            this.hired.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dpt
            // 
            this.dpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.dpt.ForeColor = System.Drawing.SystemColors.Menu;
            this.dpt.Location = new System.Drawing.Point(95, 47);
            this.dpt.Name = "dpt";
            this.dpt.ReadOnly = true;
            this.dpt.Size = new System.Drawing.Size(179, 20);
            this.dpt.TabIndex = 38;
            this.dpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.type.ForeColor = System.Drawing.SystemColors.Menu;
            this.type.Location = new System.Drawing.Point(95, 73);
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Size = new System.Drawing.Size(179, 20);
            this.type.TabIndex = 39;
            this.type.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.title.ForeColor = System.Drawing.SystemColors.Menu;
            this.title.Location = new System.Drawing.Point(95, 21);
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Size = new System.Drawing.Size(179, 20);
            this.title.TabIndex = 40;
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SEIN
            // 
            this.SEIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.SEIN.ForeColor = System.Drawing.SystemColors.Menu;
            this.SEIN.Location = new System.Drawing.Point(95, 125);
            this.SEIN.Name = "SEIN";
            this.SEIN.ReadOnly = true;
            this.SEIN.Size = new System.Drawing.Size(179, 20);
            this.SEIN.TabIndex = 41;
            this.SEIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SEIN);
            this.groupBox3.Controls.Add(this.title);
            this.groupBox3.Controls.Add(this.type);
            this.groupBox3.Controls.Add(this.dpt);
            this.groupBox3.Controls.Add(this.hired);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(349, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 163);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee Position Information";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Salary or Wage";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 13);
            this.label20.TabIndex = 44;
            this.label20.Text = "Date of Last Raise";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 13);
            this.label21.TabIndex = 45;
            this.label21.Text = "Extra Witholdings";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "Tax Filing Status";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 54);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "Tax Exemption";
            // 
            // sal
            // 
            this.sal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.sal.ForeColor = System.Drawing.SystemColors.Menu;
            this.sal.Location = new System.Drawing.Point(112, 25);
            this.sal.Name = "sal";
            this.sal.ReadOnly = true;
            this.sal.Size = new System.Drawing.Size(138, 20);
            this.sal.TabIndex = 48;
            this.sal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // exemption
            // 
            this.exemption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.exemption.ForeColor = System.Drawing.SystemColors.Menu;
            this.exemption.Location = new System.Drawing.Point(112, 51);
            this.exemption.Name = "exemption";
            this.exemption.ReadOnly = true;
            this.exemption.Size = new System.Drawing.Size(138, 20);
            this.exemption.TabIndex = 49;
            this.exemption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.status.ForeColor = System.Drawing.SystemColors.Menu;
            this.status.Location = new System.Drawing.Point(112, 77);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(138, 20);
            this.status.TabIndex = 50;
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // witholdings
            // 
            this.witholdings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.witholdings.ForeColor = System.Drawing.SystemColors.Menu;
            this.witholdings.Location = new System.Drawing.Point(112, 103);
            this.witholdings.Name = "witholdings";
            this.witholdings.ReadOnly = true;
            this.witholdings.Size = new System.Drawing.Size(138, 20);
            this.witholdings.TabIndex = 51;
            this.witholdings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // raise
            // 
            this.raise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.raise.ForeColor = System.Drawing.SystemColors.Menu;
            this.raise.Location = new System.Drawing.Point(112, 129);
            this.raise.Name = "raise";
            this.raise.ReadOnly = true;
            this.raise.Size = new System.Drawing.Size(138, 20);
            this.raise.TabIndex = 52;
            this.raise.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.raise);
            this.groupBox4.Controls.Add(this.witholdings);
            this.groupBox4.Controls.Add(this.status);
            this.groupBox4.Controls.Add(this.exemption);
            this.groupBox4.Controls.Add(this.sal);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(15, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 163);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Employee Wages Information";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label24.Location = new System.Drawing.Point(482, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(104, 13);
            this.label24.TabIndex = 54;
            this.label24.Text = "Pick an Empoyee ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(12, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 22);
            this.label12.TabIndex = 55;
            this.label12.Text = "Employee:";
            // 
            // emp
            // 
            this.emp.AutoSize = true;
            this.emp.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emp.Location = new System.Drawing.Point(99, 32);
            this.emp.Name = "emp";
            this.emp.Size = new System.Drawing.Size(246, 24);
            this.emp.TabIndex = 56;
            this.emp.Text = "Dumbledore Dies in the end";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(660, 488);
            this.Controls.Add(this.emp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.empList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstCall;
        private System.Windows.Forms.ComboBox empList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.TextBox EIN;
        private System.Windows.Forms.TextBox SSN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox home;
        private System.Windows.Forms.TextBox work;
        private System.Windows.Forms.TextBox cell;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox birth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox hired;
        private System.Windows.Forms.TextBox dpt;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox SEIN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox sal;
        private System.Windows.Forms.TextBox exemption;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.TextBox witholdings;
        private System.Windows.Forms.TextBox raise;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label emp;
    }
}

