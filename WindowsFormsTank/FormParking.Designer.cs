namespace WindowsFormsTank
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxForGetVehicle = new System.Windows.Forms.GroupBox();
            this.buttonGetVehicle = new System.Windows.Forms.Button();
            this.maskedTextBoxParkingNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelParkingNumber = new System.Windows.Forms.Label();
            this.labelParkingName = new System.Windows.Forms.Label();
            this.textBoxNumberParking = new System.Windows.Forms.TextBox();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.buttonDelParking = new System.Windows.Forms.Button();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.menuStripSaveParking = new System.Windows.Forms.MenuStrip();
            this.фаилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxForGetVehicle.SuspendLayout();
            this.menuStripSaveParking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(6, 27);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1697, 676);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxForGetVehicle
            // 
            this.groupBoxForGetVehicle.Controls.Add(this.buttonGetVehicle);
            this.groupBoxForGetVehicle.Controls.Add(this.maskedTextBoxParkingNumber);
            this.groupBoxForGetVehicle.Controls.Add(this.labelParkingNumber);
            this.groupBoxForGetVehicle.Location = new System.Drawing.Point(1562, 450);
            this.groupBoxForGetVehicle.Name = "groupBoxForGetVehicle";
            this.groupBoxForGetVehicle.Size = new System.Drawing.Size(179, 178);
            this.groupBoxForGetVehicle.TabIndex = 3;
            this.groupBoxForGetVehicle.TabStop = false;
            this.groupBoxForGetVehicle.Text = "Забрать транспорт";
            // 
            // buttonGetVehicle
            // 
            this.buttonGetVehicle.Location = new System.Drawing.Point(51, 134);
            this.buttonGetVehicle.Name = "buttonGetVehicle";
            this.buttonGetVehicle.Size = new System.Drawing.Size(90, 38);
            this.buttonGetVehicle.TabIndex = 2;
            this.buttonGetVehicle.Text = "Забрать ";
            this.buttonGetVehicle.UseVisualStyleBackColor = true;
            this.buttonGetVehicle.Click += new System.EventHandler(this.buttonGetVehicle_Click);
            // 
            // maskedTextBoxParkingNumber
            // 
            this.maskedTextBoxParkingNumber.Location = new System.Drawing.Point(74, 85);
            this.maskedTextBoxParkingNumber.Name = "maskedTextBoxParkingNumber";
            this.maskedTextBoxParkingNumber.Size = new System.Drawing.Size(67, 26);
            this.maskedTextBoxParkingNumber.TabIndex = 1;
            // 
            // labelParkingNumber
            // 
            this.labelParkingNumber.AutoSize = true;
            this.labelParkingNumber.Location = new System.Drawing.Point(6, 88);
            this.labelParkingNumber.Name = "labelParkingNumber";
            this.labelParkingNumber.Size = new System.Drawing.Size(57, 20);
            this.labelParkingNumber.TabIndex = 0;
            this.labelParkingNumber.Text = "Место";
            // 
            // labelParkingName
            // 
            this.labelParkingName.AutoSize = true;
            this.labelParkingName.Location = new System.Drawing.Point(1580, 37);
            this.labelParkingName.Name = "labelParkingName";
            this.labelParkingName.Size = new System.Drawing.Size(82, 20);
            this.labelParkingName.TabIndex = 4;
            this.labelParkingName.Text = "Парковки";
            // 
            // textBoxNumberParking
            // 
            this.textBoxNumberParking.Location = new System.Drawing.Point(1529, 61);
            this.textBoxNumberParking.Name = "textBoxNumberParking";
            this.textBoxNumberParking.Size = new System.Drawing.Size(212, 26);
            this.textBoxNumberParking.TabIndex = 5;
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(1529, 107);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(212, 29);
            this.buttonAddParking.TabIndex = 6;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click1);
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.ItemHeight = 20;
            this.listBoxParkings.Location = new System.Drawing.Point(1529, 143);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(212, 104);
            this.listBoxParkings.TabIndex = 7;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // buttonDelParking
            // 
            this.buttonDelParking.Location = new System.Drawing.Point(1529, 254);
            this.buttonDelParking.Name = "buttonDelParking";
            this.buttonDelParking.Size = new System.Drawing.Size(212, 34);
            this.buttonDelParking.TabIndex = 8;
            this.buttonDelParking.Text = "Удалить парковку";
            this.buttonDelParking.UseVisualStyleBackColor = true;
            this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click1);
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.Location = new System.Drawing.Point(1572, 351);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(149, 53);
            this.buttonAddVehicle.TabIndex = 9;
            this.buttonAddVehicle.Text = "Добавить ";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // menuStripSaveParking
            // 
            this.menuStripSaveParking.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripSaveParking.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripSaveParking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фаилToolStripMenuItem});
            this.menuStripSaveParking.Location = new System.Drawing.Point(0, 0);
            this.menuStripSaveParking.Name = "menuStripSaveParking";
            this.menuStripSaveParking.Size = new System.Drawing.Size(1762, 33);
            this.menuStripSaveParking.TabIndex = 10;
            this.menuStripSaveParking.Text = "Menu";
            // 
            // фаилToolStripMenuItem
            // 
            this.фаилToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.фаилToolStripMenuItem.Name = "фаилToolStripMenuItem";
            this.фаилToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.фаилToolStripMenuItem.Text = "Фаил";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1762, 689);
            this.Controls.Add(this.buttonAddVehicle);
            this.Controls.Add(this.buttonDelParking);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.textBoxNumberParking);
            this.Controls.Add(this.labelParkingName);
            this.Controls.Add(this.groupBoxForGetVehicle);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStripSaveParking);
            this.MainMenuStrip = this.menuStripSaveParking;
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxForGetVehicle.ResumeLayout(false);
            this.groupBoxForGetVehicle.PerformLayout();
            this.menuStripSaveParking.ResumeLayout(false);
            this.menuStripSaveParking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxForGetVehicle;
        private System.Windows.Forms.Label labelParkingNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxParkingNumber;
        private System.Windows.Forms.Button buttonGetVehicle;
        private System.Windows.Forms.Label labelParkingName;
        private System.Windows.Forms.TextBox textBoxNumberParking;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Button buttonDelParking;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.MenuStrip menuStripSaveParking;
        private System.Windows.Forms.ToolStripMenuItem фаилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}