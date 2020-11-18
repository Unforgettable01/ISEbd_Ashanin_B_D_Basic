namespace WindowsFormsTank
{
    partial class FormTankConfig
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
            this.groupBoxParametrs = new System.Windows.Forms.GroupBox();
            this.checkBoxDopWheel = new System.Windows.Forms.CheckBox();
            this.checkBoxTopGun = new System.Windows.Forms.CheckBox();
            this.checkBoxBackShield = new System.Windows.Forms.CheckBox();
            this.checkBoxSideShield = new System.Windows.Forms.CheckBox();
            this.CheckBoxFrontShield = new System.Windows.Forms.CheckBox();
            this.numericUpDown_WeightVehicle = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_MaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeightVehicle = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxForDisplayVehicle = new System.Windows.Forms.PictureBox();
            this.labelArmoredVehicle = new System.Windows.Forms.Label();
            this.labelTank = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelForPictureBox = new System.Windows.Forms.Panel();
            this.groupBoxForColor = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.panelHaki = new System.Windows.Forms.Panel();
            this.panelGrey = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelBrown = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.groupBoxParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WeightVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForDisplayVehicle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelForPictureBox.SuspendLayout();
            this.groupBoxForColor.SuspendLayout();
            this.panelGrey.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.Controls.Add(this.checkBoxDopWheel);
            this.groupBoxParametrs.Controls.Add(this.checkBoxTopGun);
            this.groupBoxParametrs.Controls.Add(this.checkBoxBackShield);
            this.groupBoxParametrs.Controls.Add(this.checkBoxSideShield);
            this.groupBoxParametrs.Controls.Add(this.CheckBoxFrontShield);
            this.groupBoxParametrs.Controls.Add(this.numericUpDown_WeightVehicle);
            this.groupBoxParametrs.Controls.Add(this.numericUpDown_MaxSpeed);
            this.groupBoxParametrs.Controls.Add(this.labelWeightVehicle);
            this.groupBoxParametrs.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParametrs.Location = new System.Drawing.Point(12, 201);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(615, 177);
            this.groupBoxParametrs.TabIndex = 0;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "Параметры";
            // 
            // checkBoxDopWheel
            // 
            this.checkBoxDopWheel.AutoSize = true;
            this.checkBoxDopWheel.Location = new System.Drawing.Point(329, 117);
            this.checkBoxDopWheel.Name = "checkBoxDopWheel";
            this.checkBoxDopWheel.Size = new System.Drawing.Size(122, 24);
            this.checkBoxDopWheel.TabIndex = 9;
            this.checkBoxDopWheel.Text = "Доп.колеса";
            this.checkBoxDopWheel.UseVisualStyleBackColor = true;
            // 
            // checkBoxTopGun
            // 
            this.checkBoxTopGun.AutoSize = true;
            this.checkBoxTopGun.Location = new System.Drawing.Point(329, 147);
            this.checkBoxTopGun.Name = "checkBoxTopGun";
            this.checkBoxTopGun.Size = new System.Drawing.Size(167, 24);
            this.checkBoxTopGun.TabIndex = 8;
            this.checkBoxTopGun.Text = "Основное орудие";
            this.checkBoxTopGun.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackShield
            // 
            this.checkBoxBackShield.AutoSize = true;
            this.checkBoxBackShield.Location = new System.Drawing.Point(329, 88);
            this.checkBoxBackShield.Name = "checkBoxBackShield";
            this.checkBoxBackShield.Size = new System.Drawing.Size(128, 24);
            this.checkBoxBackShield.TabIndex = 7;
            this.checkBoxBackShield.Text = "Задний щит";
            this.checkBoxBackShield.UseVisualStyleBackColor = true;
            // 
            // checkBoxSideShield
            // 
            this.checkBoxSideShield.AutoSize = true;
            this.checkBoxSideShield.Location = new System.Drawing.Point(329, 57);
            this.checkBoxSideShield.Name = "checkBoxSideShield";
            this.checkBoxSideShield.Size = new System.Drawing.Size(134, 24);
            this.checkBoxSideShield.TabIndex = 6;
            this.checkBoxSideShield.Text = "Боковой щит";
            this.checkBoxSideShield.UseVisualStyleBackColor = true;
            // 
            // CheckBoxFrontShield
            // 
            this.CheckBoxFrontShield.AutoSize = true;
            this.CheckBoxFrontShield.Location = new System.Drawing.Point(329, 26);
            this.CheckBoxFrontShield.Name = "CheckBoxFrontShield";
            this.CheckBoxFrontShield.Size = new System.Drawing.Size(147, 24);
            this.CheckBoxFrontShield.TabIndex = 5;
            this.CheckBoxFrontShield.Text = "Передний щит";
            this.CheckBoxFrontShield.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_WeightVehicle
            // 
            this.numericUpDown_WeightVehicle.Location = new System.Drawing.Point(143, 118);
            this.numericUpDown_WeightVehicle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_WeightVehicle.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_WeightVehicle.Name = "numericUpDown_WeightVehicle";
            this.numericUpDown_WeightVehicle.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_WeightVehicle.TabIndex = 4;
            this.numericUpDown_WeightVehicle.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_MaxSpeed
            // 
            this.numericUpDown_MaxSpeed.Location = new System.Drawing.Point(143, 44);
            this.numericUpDown_MaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_MaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_MaxSpeed.Name = "numericUpDown_MaxSpeed";
            this.numericUpDown_MaxSpeed.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_MaxSpeed.TabIndex = 3;
            this.numericUpDown_MaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeightVehicle
            // 
            this.labelWeightVehicle.AutoSize = true;
            this.labelWeightVehicle.Location = new System.Drawing.Point(21, 104);
            this.labelWeightVehicle.Name = "labelWeightVehicle";
            this.labelWeightVehicle.Size = new System.Drawing.Size(41, 20);
            this.labelWeightVehicle.TabIndex = 2;
            this.labelWeightVehicle.Text = "Вес ";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(17, 44);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(120, 20);
            this.labelMaxSpeed.TabIndex = 1;
            this.labelMaxSpeed.Text = "Макс.скорость";
            // 
            // pictureBoxForDisplayVehicle
            // 
            this.pictureBoxForDisplayVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxForDisplayVehicle.Location = new System.Drawing.Point(25, 12);
            this.pictureBoxForDisplayVehicle.Name = "pictureBoxForDisplayVehicle";
            this.pictureBoxForDisplayVehicle.Size = new System.Drawing.Size(464, 353);
            this.pictureBoxForDisplayVehicle.TabIndex = 1;
            this.pictureBoxForDisplayVehicle.TabStop = false;
            // 
            // labelArmoredVehicle
            // 
            this.labelArmoredVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelArmoredVehicle.Location = new System.Drawing.Point(47, 35);
            this.labelArmoredVehicle.Name = "labelArmoredVehicle";
            this.labelArmoredVehicle.Size = new System.Drawing.Size(111, 36);
            this.labelArmoredVehicle.TabIndex = 2;
            this.labelArmoredVehicle.Text = "Брон.машина";
            this.labelArmoredVehicle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelArmoredVehicle_MouseDown);
            // 
            // labelTank
            // 
            this.labelTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTank.Location = new System.Drawing.Point(47, 83);
            this.labelTank.Name = "labelTank";
            this.labelTank.Size = new System.Drawing.Size(111, 36);
            this.labelTank.TabIndex = 3;
            this.labelTank.Text = "Танк";
            this.labelTank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTank_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelArmoredVehicle);
            this.groupBox1.Controls.Add(this.labelTank);
            this.groupBox1.Location = new System.Drawing.Point(70, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panelForPictureBox
            // 
            this.panelForPictureBox.AllowDrop = true;
            this.panelForPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForPictureBox.Controls.Add(this.pictureBoxForDisplayVehicle);
            this.panelForPictureBox.Location = new System.Drawing.Point(627, 12);
            this.panelForPictureBox.Name = "panelForPictureBox";
            this.panelForPictureBox.Size = new System.Drawing.Size(512, 387);
            this.panelForPictureBox.TabIndex = 5;
            this.panelForPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelForPictureBox_DragDrop);
            this.panelForPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelForPictureBox_DragEnter);
            // 
            // groupBoxForColor
            // 
            this.groupBoxForColor.Controls.Add(this.labelDopColor);
            this.groupBoxForColor.Controls.Add(this.labelBaseColor);
            this.groupBoxForColor.Controls.Add(this.panelHaki);
            this.groupBoxForColor.Controls.Add(this.panelGrey);
            this.groupBoxForColor.Controls.Add(this.panelBlue);
            this.groupBoxForColor.Controls.Add(this.panelBrown);
            this.groupBoxForColor.Controls.Add(this.panelGreen);
            this.groupBoxForColor.Controls.Add(this.panelBlack);
            this.groupBoxForColor.Controls.Add(this.panelYellow);
            this.groupBoxForColor.Controls.Add(this.panelRed);
            this.groupBoxForColor.Controls.Add(this.panel1);
            this.groupBoxForColor.Location = new System.Drawing.Point(1145, 12);
            this.groupBoxForColor.Name = "groupBoxForColor";
            this.groupBoxForColor.Size = new System.Drawing.Size(200, 239);
            this.groupBoxForColor.TabIndex = 6;
            this.groupBoxForColor.TabStop = false;
            this.groupBoxForColor.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(98, 26);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(80, 69);
            this.labelDopColor.TabIndex = 9;
            this.labelDopColor.Text = "Доп.   цвет";
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(7, 26);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(84, 69);
            this.labelBaseColor.TabIndex = 8;
            this.labelBaseColor.Text = "Основной          цвет";
            // 
            // panelHaki
            // 
            this.panelHaki.BackColor = System.Drawing.Color.Olive;
            this.panelHaki.Location = new System.Drawing.Point(143, 177);
            this.panelHaki.Name = "panelHaki";
            this.panelHaki.Size = new System.Drawing.Size(35, 41);
            this.panelHaki.TabIndex = 7;
            // 
            // panelGrey
            // 
            this.panelGrey.BackColor = System.Drawing.Color.Silver;
            this.panelGrey.Controls.Add(this.panel2);
            this.panelGrey.Location = new System.Drawing.Point(98, 177);
            this.panelGrey.Name = "panelGrey";
            this.panelGrey.Size = new System.Drawing.Size(38, 41);
            this.panelGrey.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(53, 177);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(38, 41);
            this.panelBlue.TabIndex = 5;
            // 
            // panelBrown
            // 
            this.panelBrown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBrown.Location = new System.Drawing.Point(6, 177);
            this.panelBrown.Name = "panelBrown";
            this.panelBrown.Size = new System.Drawing.Size(40, 41);
            this.panelBrown.TabIndex = 4;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(142, 109);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(36, 39);
            this.panelGreen.TabIndex = 0;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(98, 109);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(38, 39);
            this.panelBlack.TabIndex = 3;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(53, 109);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(38, 39);
            this.panelYellow.TabIndex = 2;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(6, 109);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(40, 39);
            this.panelRed.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(185, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 39);
            this.panel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1198, 286);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 39);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonCancle
            // 
            this.buttonCancle.Location = new System.Drawing.Point(1198, 342);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(94, 30);
            this.buttonCancle.TabIndex = 8;
            this.buttonCancle.Text = "Отменить";
            this.buttonCancle.UseVisualStyleBackColor = true;
            // 
            // FormTankConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1381, 671);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxForColor);
            this.Controls.Add(this.panelForPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxParametrs);
            this.Name = "FormTankConfig";
            this.Text = "FormTankConfig";
            this.groupBoxParametrs.ResumeLayout(false);
            this.groupBoxParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WeightVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForDisplayVehicle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelForPictureBox.ResumeLayout(false);
            this.groupBoxForColor.ResumeLayout(false);
            this.panelGrey.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.NumericUpDown numericUpDown_WeightVehicle;
        private System.Windows.Forms.NumericUpDown numericUpDown_MaxSpeed;
        private System.Windows.Forms.Label labelWeightVehicle;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.CheckBox CheckBoxFrontShield;
        private System.Windows.Forms.CheckBox checkBoxTopGun;
        private System.Windows.Forms.CheckBox checkBoxBackShield;
        private System.Windows.Forms.CheckBox checkBoxSideShield;
        private System.Windows.Forms.CheckBox checkBoxDopWheel;
        private System.Windows.Forms.PictureBox pictureBoxForDisplayVehicle;
        private System.Windows.Forms.Label labelArmoredVehicle;
        private System.Windows.Forms.Label labelTank;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelForPictureBox;
        private System.Windows.Forms.GroupBox groupBoxForColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Panel panelHaki;
        private System.Windows.Forms.Panel panelGrey;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelBrown;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancle;
    }
}