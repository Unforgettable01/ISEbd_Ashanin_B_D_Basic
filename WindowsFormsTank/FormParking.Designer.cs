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
            this.buttonParkingArmoredVehicle = new System.Windows.Forms.Button();
            this.buttonParkingTank = new System.Windows.Forms.Button();
            this.groupBoxForGetVehicle = new System.Windows.Forms.GroupBox();
            this.buttonGetVehicle = new System.Windows.Forms.Button();
            this.maskedTextBoxParkingNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelParkingNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxForGetVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(1, 12);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1697, 676);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonParkingArmoredVehicle
            // 
            this.buttonParkingArmoredVehicle.Location = new System.Drawing.Point(1486, 65);
            this.buttonParkingArmoredVehicle.Name = "buttonParkingArmoredVehicle";
            this.buttonParkingArmoredVehicle.Size = new System.Drawing.Size(132, 92);
            this.buttonParkingArmoredVehicle.TabIndex = 1;
            this.buttonParkingArmoredVehicle.Text = "Припарковать брон.машину";
            this.buttonParkingArmoredVehicle.UseVisualStyleBackColor = true;
            this.buttonParkingArmoredVehicle.Click += new System.EventHandler(this.buttonParkingArmoredVehicle_Click);
            // 
            // buttonParkingTank
            // 
            this.buttonParkingTank.Location = new System.Drawing.Point(1486, 163);
            this.buttonParkingTank.Name = "buttonParkingTank";
            this.buttonParkingTank.Size = new System.Drawing.Size(131, 94);
            this.buttonParkingTank.TabIndex = 2;
            this.buttonParkingTank.Text = "Припарковать танк";
            this.buttonParkingTank.UseVisualStyleBackColor = true;
            this.buttonParkingTank.Click += new System.EventHandler(this.buttonParkingTank_Click);
            // 
            // groupBoxForGetVehicle
            // 
            this.groupBoxForGetVehicle.Controls.Add(this.buttonGetVehicle);
            this.groupBoxForGetVehicle.Controls.Add(this.maskedTextBoxParkingNumber);
            this.groupBoxForGetVehicle.Controls.Add(this.labelParkingNumber);
            this.groupBoxForGetVehicle.Location = new System.Drawing.Point(1486, 290);
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
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 689);
            this.Controls.Add(this.groupBoxForGetVehicle);
            this.Controls.Add(this.buttonParkingTank);
            this.Controls.Add(this.buttonParkingArmoredVehicle);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxForGetVehicle.ResumeLayout(false);
            this.groupBoxForGetVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkingArmoredVehicle;
        private System.Windows.Forms.Button buttonParkingTank;
        private System.Windows.Forms.GroupBox groupBoxForGetVehicle;
        private System.Windows.Forms.Label labelParkingNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxParkingNumber;
        private System.Windows.Forms.Button buttonGetVehicle;
    }
}