namespace MyTalkingTom
{
    partial class MarketForm
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
            this.btn_Back = new MyTalkingTom.RoundPictureBox();
            this.btn_Close = new MyTalkingTom.RoundPictureBox();
            this.btn_FastFoods = new MyTalkingTom.RoundPictureBox();
            this.btn_Drinks = new MyTalkingTom.RoundPictureBox();
            this.btn_Desserts = new MyTalkingTom.RoundPictureBox();
            this.btn_Fruits = new MyTalkingTom.RoundPictureBox();
            this.btn_Medicines = new MyTalkingTom.RoundPictureBox();
            this.lb_Market_Coins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_FastFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Drinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Desserts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Fruits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Medicines)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BackgroundImage = global::MyTalkingTom.Properties.Resources.btn_Kitchen_Back;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 100);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.TabStop = false;
            this.btn_Back.Click += new System.EventHandler(this.Market_BackButtonClick);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = global::MyTalkingTom.Properties.Resources.close_icon;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Location = new System.Drawing.Point(1524, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(64, 64);
            this.btn_Close.TabIndex = 13;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.Market_CloseButtonClick);
            // 
            // btn_FastFoods
            // 
            this.btn_FastFoods.BackColor = System.Drawing.Color.DarkGray;
            this.btn_FastFoods.BackgroundImage = global::MyTalkingTom.Properties.Resources.shop_icon_2;
            this.btn_FastFoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_FastFoods.Location = new System.Drawing.Point(421, 537);
            this.btn_FastFoods.Name = "btn_FastFoods";
            this.btn_FastFoods.Size = new System.Drawing.Size(140, 140);
            this.btn_FastFoods.TabIndex = 14;
            this.btn_FastFoods.TabStop = false;
            this.btn_FastFoods.Click += new System.EventHandler(this.FastFoodsButtonClick);
            // 
            // btn_Drinks
            // 
            this.btn_Drinks.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Drinks.BackgroundImage = global::MyTalkingTom.Properties.Resources.shop_icon_4;
            this.btn_Drinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Drinks.Location = new System.Drawing.Point(1195, 143);
            this.btn_Drinks.Name = "btn_Drinks";
            this.btn_Drinks.Size = new System.Drawing.Size(140, 140);
            this.btn_Drinks.TabIndex = 15;
            this.btn_Drinks.TabStop = false;
            this.btn_Drinks.Click += new System.EventHandler(this.DrinksButtonClick);
            // 
            // btn_Desserts
            // 
            this.btn_Desserts.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Desserts.BackgroundImage = global::MyTalkingTom.Properties.Resources.shop_icon_5;
            this.btn_Desserts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Desserts.Location = new System.Drawing.Point(920, 422);
            this.btn_Desserts.Name = "btn_Desserts";
            this.btn_Desserts.Size = new System.Drawing.Size(140, 140);
            this.btn_Desserts.TabIndex = 16;
            this.btn_Desserts.TabStop = false;
            this.btn_Desserts.Click += new System.EventHandler(this.DessertsButtonClick);
            // 
            // btn_Fruits
            // 
            this.btn_Fruits.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Fruits.BackgroundImage = global::MyTalkingTom.Properties.Resources.shop_icon_3;
            this.btn_Fruits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Fruits.Location = new System.Drawing.Point(820, 60);
            this.btn_Fruits.Name = "btn_Fruits";
            this.btn_Fruits.Size = new System.Drawing.Size(140, 140);
            this.btn_Fruits.TabIndex = 17;
            this.btn_Fruits.TabStop = false;
            this.btn_Fruits.Click += new System.EventHandler(this.FruitsButtonClick);
            // 
            // btn_Medicines
            // 
            this.btn_Medicines.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Medicines.BackgroundImage = global::MyTalkingTom.Properties.Resources.shop_icon_1;
            this.btn_Medicines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Medicines.Location = new System.Drawing.Point(187, 202);
            this.btn_Medicines.Name = "btn_Medicines";
            this.btn_Medicines.Size = new System.Drawing.Size(140, 140);
            this.btn_Medicines.TabIndex = 18;
            this.btn_Medicines.TabStop = false;
            this.btn_Medicines.Click += new System.EventHandler(this.MedicinesButtonClick);
            // 
            // lb_Market_Coins
            // 
            this.lb_Market_Coins.AutoSize = true;
            this.lb_Market_Coins.Font = new System.Drawing.Font("UVN Thanh Pho Nang", 16.2F, System.Drawing.FontStyle.Bold);
            this.lb_Market_Coins.Location = new System.Drawing.Point(118, 40);
            this.lb_Market_Coins.Name = "lb_Market_Coins";
            this.lb_Market_Coins.Size = new System.Drawing.Size(87, 36);
            this.lb_Market_Coins.TabIndex = 19;
            this.lb_Market_Coins.Text = "label1";
            // 
            // MarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MyTalkingTom.Properties.Resources.Market;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.lb_Market_Coins);
            this.Controls.Add(this.btn_Medicines);
            this.Controls.Add(this.btn_Fruits);
            this.Controls.Add(this.btn_Desserts);
            this.Controls.Add(this.btn_Drinks);
            this.Controls.Add(this.btn_FastFoods);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Back);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarketForm";
            this.Text = "Market";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_FastFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Drinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Desserts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Fruits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Medicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundPictureBox btn_Back;
        private RoundPictureBox btn_Close;
        private RoundPictureBox btn_FastFoods;
        private RoundPictureBox btn_Drinks;
        private RoundPictureBox btn_Desserts;
        private RoundPictureBox btn_Fruits;
        private RoundPictureBox btn_Medicines;
        private System.Windows.Forms.Label lb_Market_Coins;
    }
}