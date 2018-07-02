namespace MyTalkingTom.MarketForms
{
    partial class MedicinesForm
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
            this.medicinesShopName = new MyTalkingTom.RoundPictureBox();
            this.roundPictureBox1 = new MyTalkingTom.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesShopName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // medicinesShopName
            // 
            this.medicinesShopName.BackColor = System.Drawing.Color.DarkGray;
            this.medicinesShopName.BackgroundImage = global::MyTalkingTom.Properties.Resources.shop_icon_1;
            this.medicinesShopName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.medicinesShopName.Location = new System.Drawing.Point(45, 45);
            this.medicinesShopName.Name = "medicinesShopName";
            this.medicinesShopName.Size = new System.Drawing.Size(140, 140);
            this.medicinesShopName.TabIndex = 0;
            this.medicinesShopName.TabStop = false;
            this.medicinesShopName.Click += new System.EventHandler(this.MedicinesBtnClick);
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.roundPictureBox1.Location = new System.Drawing.Point(1457, 35);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(100, 50);
            this.roundPictureBox1.TabIndex = 1;
            this.roundPictureBox1.TabStop = false;
            // 
            // MedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MyTalkingTom.Properties.Resources.ListItem;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.roundPictureBox1);
            this.Controls.Add(this.medicinesShopName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicinesForm";
            this.Text = "MedicinesForm";
            ((System.ComponentModel.ISupportInitialize)(this.medicinesShopName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPictureBox medicinesShopName;
        private RoundPictureBox roundPictureBox1;
    }
}