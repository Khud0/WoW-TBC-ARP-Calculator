namespace WoW_TBC_ARP_Calculator
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
            this.lbBossName = new System.Windows.Forms.ListBox();
            this.lbDungeonName = new System.Windows.Forms.ListBox();
            this.tbBossArmor = new System.Windows.Forms.TextBox();
            this.tbBossArmorReduced = new System.Windows.Forms.TextBox();
            this.tbPercent = new System.Windows.Forms.TextBox();
            this.cbFaerieFire = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbCoR = new System.Windows.Forms.CheckBox();
            this.tbTotalARP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cbExecutioner = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cbCrystal = new System.Windows.Forms.CheckBox();
            this.trackSunder = new System.Windows.Forms.TrackBar();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cbMadness = new System.Windows.Forms.CheckBox();
            this.tbPassiveARP = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.cbCoil = new System.Windows.Forms.CheckBox();
            this.tbExtraARP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackExpose = new System.Windows.Forms.TrackBar();
            this.trackExposeImproved = new System.Windows.Forms.TrackBar();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackAnnihilator = new System.Windows.Forms.TrackBar();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khud0authorTwitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excaliburWoW243ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSunder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackExpose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackExposeImproved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAnnihilator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.gbUser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBossName
            // 
            this.lbBossName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbBossName.FormattingEnabled = true;
            this.lbBossName.Location = new System.Drawing.Point(395, 94);
            this.lbBossName.Name = "lbBossName";
            this.lbBossName.Size = new System.Drawing.Size(238, 56);
            this.lbBossName.TabIndex = 0;
            this.lbBossName.SelectedIndexChanged += new System.EventHandler(this.lbBossName_SelectedIndexChanged);
            // 
            // lbDungeonName
            // 
            this.lbDungeonName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbDungeonName.FormattingEnabled = true;
            this.lbDungeonName.Location = new System.Drawing.Point(395, 32);
            this.lbDungeonName.Name = "lbDungeonName";
            this.lbDungeonName.Size = new System.Drawing.Size(238, 56);
            this.lbDungeonName.TabIndex = 1;
            this.lbDungeonName.SelectedIndexChanged += new System.EventHandler(this.lbDungeonName_SelectedIndexChanged);
            // 
            // tbBossArmor
            // 
            this.tbBossArmor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbBossArmor.Location = new System.Drawing.Point(454, 387);
            this.tbBossArmor.Name = "tbBossArmor";
            this.tbBossArmor.Size = new System.Drawing.Size(120, 20);
            this.tbBossArmor.TabIndex = 2;
            this.tbBossArmor.Text = "Boss Armor";
            this.tbBossArmor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBossArmor.TextChanged += new System.EventHandler(this.tbBossArmor_TextChanged);
            // 
            // tbBossArmorReduced
            // 
            this.tbBossArmorReduced.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbBossArmorReduced.Location = new System.Drawing.Point(454, 413);
            this.tbBossArmorReduced.MaxLength = 10;
            this.tbBossArmorReduced.Name = "tbBossArmorReduced";
            this.tbBossArmorReduced.ReadOnly = true;
            this.tbBossArmorReduced.Size = new System.Drawing.Size(120, 20);
            this.tbBossArmorReduced.TabIndex = 2;
            this.tbBossArmorReduced.Text = "Armor After Reduction";
            this.tbBossArmorReduced.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPercent
            // 
            this.tbPercent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbPercent.Location = new System.Drawing.Point(484, 439);
            this.tbPercent.MaxLength = 10;
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(60, 20);
            this.tbPercent.TabIndex = 2;
            this.tbPercent.Text = "DR%";
            this.tbPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbFaerieFire
            // 
            this.cbFaerieFire.AutoSize = true;
            this.cbFaerieFire.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbFaerieFire.Location = new System.Drawing.Point(78, 53);
            this.cbFaerieFire.Name = "cbFaerieFire";
            this.cbFaerieFire.Size = new System.Drawing.Size(75, 17);
            this.cbFaerieFire.TabIndex = 3;
            this.cbFaerieFire.Text = "Faerie Fire";
            this.cbFaerieFire.UseVisualStyleBackColor = false;
            this.cbFaerieFire.CheckedChanged += new System.EventHandler(this.cbFaerieFire_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // cbCoR
            // 
            this.cbCoR.AutoSize = true;
            this.cbCoR.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbCoR.Location = new System.Drawing.Point(78, 89);
            this.cbCoR.Name = "cbCoR";
            this.cbCoR.Size = new System.Drawing.Size(134, 17);
            this.cbCoR.TabIndex = 5;
            this.cbCoR.Text = "Curse of Recklessness";
            this.cbCoR.UseVisualStyleBackColor = false;
            this.cbCoR.CheckedChanged += new System.EventHandler(this.cbCoR_CheckedChanged);
            // 
            // tbTotalARP
            // 
            this.tbTotalARP.Location = new System.Drawing.Point(488, 266);
            this.tbTotalARP.MaxLength = 10;
            this.tbTotalARP.Name = "tbTotalARP";
            this.tbTotalARP.ReadOnly = true;
            this.tbTotalARP.Size = new System.Drawing.Size(57, 20);
            this.tbTotalARP.TabIndex = 11;
            this.tbTotalARP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total ARP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(39, 405);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // cbExecutioner
            // 
            this.cbExecutioner.AutoSize = true;
            this.cbExecutioner.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbExecutioner.Location = new System.Drawing.Point(77, 411);
            this.cbExecutioner.Name = "cbExecutioner";
            this.cbExecutioner.Size = new System.Drawing.Size(82, 17);
            this.cbExecutioner.TabIndex = 12;
            this.cbExecutioner.Text = "Executioner";
            this.cbExecutioner.UseVisualStyleBackColor = false;
            this.cbExecutioner.CheckedChanged += new System.EventHandler(this.cbExecutioner_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(39, 120);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 28);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // cbCrystal
            // 
            this.cbCrystal.AutoSize = true;
            this.cbCrystal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbCrystal.Location = new System.Drawing.Point(78, 126);
            this.cbCrystal.Name = "cbCrystal";
            this.cbCrystal.Size = new System.Drawing.Size(83, 17);
            this.cbCrystal.TabIndex = 14;
            this.cbCrystal.Text = "Crystal Yield";
            this.cbCrystal.UseVisualStyleBackColor = false;
            this.cbCrystal.CheckedChanged += new System.EventHandler(this.cbCrystal_CheckedChanged);
            // 
            // trackSunder
            // 
            this.trackSunder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackSunder.Location = new System.Drawing.Point(78, 188);
            this.trackSunder.Maximum = 5;
            this.trackSunder.Name = "trackSunder";
            this.trackSunder.Size = new System.Drawing.Size(75, 45);
            this.trackSunder.TabIndex = 16;
            this.trackSunder.Scroll += new System.EventHandler(this.trackSunder_Scroll);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(39, 473);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 28);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // cbMadness
            // 
            this.cbMadness.AutoSize = true;
            this.cbMadness.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbMadness.Location = new System.Drawing.Point(77, 479);
            this.cbMadness.Name = "cbMadness";
            this.cbMadness.Size = new System.Drawing.Size(141, 17);
            this.cbMadness.TabIndex = 17;
            this.cbMadness.Text = "Madness of the Betrayer";
            this.cbMadness.UseVisualStyleBackColor = false;
            this.cbMadness.CheckedChanged += new System.EventHandler(this.cbMadness_CheckedChanged);
            // 
            // tbPassiveARP
            // 
            this.tbPassiveARP.Location = new System.Drawing.Point(27, 32);
            this.tbPassiveARP.MaxLength = 10;
            this.tbPassiveARP.Name = "tbPassiveARP";
            this.tbPassiveARP.Size = new System.Drawing.Size(88, 20);
            this.tbPassiveARP.TabIndex = 19;
            this.tbPassiveARP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassiveARP.TextChanged += new System.EventHandler(this.tbPassiveARP_TextChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(39, 439);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 28);
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // cbCoil
            // 
            this.cbCoil.AutoSize = true;
            this.cbCoil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbCoil.Location = new System.Drawing.Point(77, 445);
            this.cbCoil.Name = "cbCoil";
            this.cbCoil.Size = new System.Drawing.Size(105, 17);
            this.cbCoil.TabIndex = 20;
            this.cbCoil.Text = "Warp-Spring Coil";
            this.cbCoil.UseVisualStyleBackColor = false;
            this.cbCoil.CheckedChanged += new System.EventHandler(this.cbCoil_CheckedChanged);
            // 
            // tbExtraARP
            // 
            this.tbExtraARP.Location = new System.Drawing.Point(27, 58);
            this.tbExtraARP.MaxLength = 10;
            this.tbExtraARP.Name = "tbExtraARP";
            this.tbExtraARP.Size = new System.Drawing.Size(88, 20);
            this.tbExtraARP.TabIndex = 22;
            this.tbExtraARP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbExtraARP.TextChanged += new System.EventHandler(this.tbExtraARP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Passive ARP (Items)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Extra ARP (Your Sources)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackExpose
            // 
            this.trackExpose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackExpose.Location = new System.Drawing.Point(78, 242);
            this.trackExpose.Maximum = 5;
            this.trackExpose.Name = "trackExpose";
            this.trackExpose.Size = new System.Drawing.Size(75, 45);
            this.trackExpose.TabIndex = 25;
            this.trackExpose.Scroll += new System.EventHandler(this.trackExpose_Scroll);
            // 
            // trackExposeImproved
            // 
            this.trackExposeImproved.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackExposeImproved.Location = new System.Drawing.Point(166, 242);
            this.trackExposeImproved.Maximum = 2;
            this.trackExposeImproved.Name = "trackExposeImproved";
            this.trackExposeImproved.Size = new System.Drawing.Size(53, 45);
            this.trackExposeImproved.TabIndex = 26;
            this.trackExposeImproved.Scroll += new System.EventHandler(this.trackExposeImproved_Scroll);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(39, 196);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 28);
            this.pictureBox7.TabIndex = 27;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(39, 250);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 28);
            this.pictureBox8.TabIndex = 28;
            this.pictureBox8.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(62, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Sunder Armor Stacks";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(71, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Expose Armor CP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(164, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "(Improved)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackAnnihilator
            // 
            this.trackAnnihilator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackAnnihilator.LargeChange = 3;
            this.trackAnnihilator.Location = new System.Drawing.Point(76, 341);
            this.trackAnnihilator.Maximum = 3;
            this.trackAnnihilator.Name = "trackAnnihilator";
            this.trackAnnihilator.Size = new System.Drawing.Size(75, 45);
            this.trackAnnihilator.TabIndex = 32;
            this.trackAnnihilator.Scroll += new System.EventHandler(this.trackAnnihilator_Scroll);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(39, 349);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(28, 28);
            this.pictureBox9.TabIndex = 33;
            this.pictureBox9.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(67, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Annihilator Stacks";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbUser.Controls.Add(this.label1);
            this.gbUser.Controls.Add(this.tbPassiveARP);
            this.gbUser.Controls.Add(this.tbExtraARP);
            this.gbUser.Controls.Add(this.label2);
            this.gbUser.Location = new System.Drawing.Point(247, 220);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(142, 99);
            this.gbUser.TabIndex = 36;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User-Defined Values";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linksToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khud0authorTwitterToolStripMenuItem,
            this.excaliburWoW243ToolStripMenuItem,
            this.sourceCodeToolStripMenuItem});
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.linksToolStripMenuItem.Text = "Links";
            // 
            // khud0authorTwitterToolStripMenuItem
            // 
            this.khud0authorTwitterToolStripMenuItem.Name = "khud0authorTwitterToolStripMenuItem";
            this.khud0authorTwitterToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.khud0authorTwitterToolStripMenuItem.Text = "Khud0 (author) - Twitter";
            this.khud0authorTwitterToolStripMenuItem.Click += new System.EventHandler(this.khud0authorTwitterToolStripMenuItem_Click);
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sourceCodeToolStripMenuItem.Text = "Source Code";
            this.sourceCodeToolStripMenuItem.Click += new System.EventHandler(this.sourceCodeToolStripMenuItem_Click);
            // 
            // excaliburWoW243ToolStripMenuItem
            // 
            this.excaliburWoW243ToolStripMenuItem.Name = "excaliburWoW243ToolStripMenuItem";
            this.excaliburWoW243ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.excaliburWoW243ToolStripMenuItem.Text = "Excalibur WoW 2.4.3";
            this.excaliburWoW243ToolStripMenuItem.Click += new System.EventHandler(this.excaliburWoW243ToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 538);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.trackAnnihilator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.trackExposeImproved);
            this.Controls.Add(this.trackExpose);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.cbCoil);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.cbMadness);
            this.Controls.Add(this.trackSunder);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cbCrystal);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.cbExecutioner);
            this.Controls.Add(this.tbTotalARP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbCoR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbFaerieFire);
            this.Controls.Add(this.tbPercent);
            this.Controls.Add(this.tbBossArmorReduced);
            this.Controls.Add(this.tbBossArmor);
            this.Controls.Add(this.lbDungeonName);
            this.Controls.Add(this.lbBossName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WoW TBC ARP Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSunder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackExpose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackExposeImproved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAnnihilator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBossName;
        private System.Windows.Forms.ListBox lbDungeonName;
        private System.Windows.Forms.TextBox tbBossArmor;
        private System.Windows.Forms.TextBox tbBossArmorReduced;
        private System.Windows.Forms.TextBox tbPercent;
        private System.Windows.Forms.CheckBox cbFaerieFire;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox cbCoR;
        private System.Windows.Forms.TextBox tbTotalARP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox cbExecutioner;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox cbCrystal;
        private System.Windows.Forms.TrackBar trackSunder;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox cbMadness;
        private System.Windows.Forms.TextBox tbPassiveARP;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.CheckBox cbCoil;
        private System.Windows.Forms.TextBox tbExtraARP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackExpose;
        private System.Windows.Forms.TrackBar trackExposeImproved;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackAnnihilator;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khud0authorTwitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excaliburWoW243ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

