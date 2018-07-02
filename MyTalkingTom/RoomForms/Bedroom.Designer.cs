namespace MyTalkingTom
{
    partial class Bedroom
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
            this.btn_Sleep_Eat = new MyTalkingTom.RoundPictureBox();
            this.btn_Sleep_PooPoo = new MyTalkingTom.RoundPictureBox();
            this.btn_Sleep_Sleep = new MyTalkingTom.RoundPictureBox();
            this.btn_Sleep_Sound = new MyTalkingTom.RoundPictureBox();
            this.btn_Sleep_Info = new MyTalkingTom.RoundPictureBox();
            this.btn_Sleep_Shopping = new MyTalkingTom.RoundPictureBox();
            this.btn_Sleep_Home = new MyTalkingTom.RoundPictureBox();
            this.lb_BER_Play = new System.Windows.Forms.Label();
            this.lb_BER_Eat = new System.Windows.Forms.Label();
            this.lb_BER_PooPoo = new System.Windows.Forms.Label();
            this.lb_BER_Sleep = new System.Windows.Forms.Label();
            this.btn_Sleep_Light = new MyTalkingTom.RoundPictureBox();
            this.btn_Sleep_Close = new MyTalkingTom.RoundPictureBox();
            this.lb_BER_Coins = new System.Windows.Forms.Label();
            this.ptb_Wardrove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Eat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_PooPoo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Sleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Shopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Light)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Wardrove)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sleep_Eat
            // 
            this.btn_Sleep_Eat.BackColor = System.Drawing.Color.Black;
            this.btn_Sleep_Eat.BackgroundImage = global::MyTalkingTom.Properties.Resources.btn_Kitchen;
            this.btn_Sleep_Eat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sleep_Eat.Location = new System.Drawing.Point(734, 702);
            this.btn_Sleep_Eat.Name = "btn_Sleep_Eat";
            this.btn_Sleep_Eat.Size = new System.Drawing.Size(140, 140);
            this.btn_Sleep_Eat.TabIndex = 9;
            this.btn_Sleep_Eat.TabStop = false;
            this.btn_Sleep_Eat.Click += new System.EventHandler(this.BER_KitchenBtnClick);
            // 
            // btn_Sleep_PooPoo
            // 
            this.btn_Sleep_PooPoo.BackColor = System.Drawing.Color.Black;
            this.btn_Sleep_PooPoo.BackgroundImage = global::MyTalkingTom.Properties.Resources.btn_Bathroom;
            this.btn_Sleep_PooPoo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sleep_PooPoo.Location = new System.Drawing.Point(998, 702);
            this.btn_Sleep_PooPoo.Name = "btn_Sleep_PooPoo";
            this.btn_Sleep_PooPoo.Size = new System.Drawing.Size(140, 140);
            this.btn_Sleep_PooPoo.TabIndex = 8;
            this.btn_Sleep_PooPoo.TabStop = false;
            this.btn_Sleep_PooPoo.Click += new System.EventHandler(this.BER_BathroomBtnClick);
            // 
            // btn_Sleep_Sleep
            // 
            this.btn_Sleep_Sleep.BackColor = System.Drawing.Color.Black;
            this.btn_Sleep_Sleep.BackgroundImage = global::MyTalkingTom.Properties.Resources.btn_Bedroom;
            this.btn_Sleep_Sleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sleep_Sleep.Location = new System.Drawing.Point(1238, 702);
            this.btn_Sleep_Sleep.Name = "btn_Sleep_Sleep";
            this.btn_Sleep_Sleep.Size = new System.Drawing.Size(140, 140);
            this.btn_Sleep_Sleep.TabIndex = 7;
            this.btn_Sleep_Sleep.TabStop = false;
            // 
            // btn_Sleep_Sound
            // 
            this.btn_Sleep_Sound.BackColor = System.Drawing.Color.Black;
            this.btn_Sleep_Sound.BackgroundImage = global::MyTalkingTom.Properties.Resources.btn_SoundOn;
            this.btn_Sleep_Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sleep_Sound.Location = new System.Drawing.Point(1418, 12);
            this.btn_Sleep_Sound.Name = "btn_Sleep_Sound";
            this.btn_Sleep_Sound.Size = new System.Drawing.Size(100, 100);
            this.btn_Sleep_Sound.TabIndex = 6;
            this.btn_Sleep_Sound.TabStop = false;
            this.btn_Sleep_Sound.Click += new System.EventHandler(this.BER_SoundBtnClick);
            // 
            // btn_Sleep_Info
            // 
            this.btn_Sleep_Info.BackColor = System.Drawing.Color.White;
            this.btn_Sleep_Info.BackgroundImage = global::MyTalkingTom.Properties.Resources.info_icon;
            this.btn_Sleep_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sleep_Info.Location = new System.Drawing.Point(70, 12);
            this.btn_Sleep_Info.Name = "btn_Sleep_Info";
            this.btn_Sleep_Info.Size = new System.Drawing.Size(100, 100);
            this.btn_Sleep_Info.TabIndex = 5;
            this.btn_Sleep_Info.TabStop = false;
            this.btn_Sleep_Info.Click += new System.EventHandler(this.BER_InfoBtnClick);
            // 
            // btn_Sleep_Shopping
            // 
            this.btn_Sleep_Shopping.BackColor = System.Drawing.Color.Black;
            this.btn_Sleep_Shopping.BackgroundImage = global::MyTalkingTom.Properties.Resources.btn_Market;
            this.btn_Sleep_Shopping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sleep_Shopping.Location = new System.Drawing.Point(230, 702);
            this.btn_Sleep_Shopping.Name = "btn_Sleep_Shopping";
            this.btn_Sleep_Shopping.Size = new System.Drawing.Size(140, 140);
            this.btn_Sleep_Shopping.TabIndex = 11;
            this.btn_Sleep_Shopping.TabStop = false;
            this.btn_Sleep_Shopping.Click += new System.EventHandler(this.BER_MarketBtnClick);
            // 
            // btn_Sleep_Home
            // 
            this.btn_Sleep_Home.BackColor = System.Drawing.Color.Black;
            this.btn_Sleep_Home.BackgroundImage = global::MyTalkingTom.Properties.Resources.btn_Livingroom_Happy;
            this.btn_Sleep_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sleep_Home.Location = new System.Drawing.Point(482, 702);
            this.btn_Sleep_Home.Name = "btn_Sleep_Home";
            this.btn_Sleep_Home.Size = new System.Drawing.Size(140, 140);
            this.btn_Sleep_Home.TabIndex = 12;
            this.btn_Sleep_Home.TabStop = false;
            this.btn_Sleep_Home.Click += new System.EventHandler(this.BER_LivingroomBtnClick);
            // 
            // lb_BER_Play
            // 
            this.lb_BER_Play.AutoSize = true;
            this.lb_BER_Play.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_BER_Play.Location = new System.Drawing.Point(477, 673);
            this.lb_BER_Play.Name = "lb_BER_Play";
            this.lb_BER_Play.Size = new System.Drawing.Size(74, 26);
            this.lb_BER_Play.TabIndex = 3;
            this.lb_BER_Play.Text = "label1";
            this.lb_BER_Play.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_BER_Eat
            // 
            this.lb_BER_Eat.AutoSize = true;
            this.lb_BER_Eat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_BER_Eat.Location = new System.Drawing.Point(729, 673);
            this.lb_BER_Eat.Name = "lb_BER_Eat";
            this.lb_BER_Eat.Size = new System.Drawing.Size(74, 26);
            this.lb_BER_Eat.TabIndex = 2;
            this.lb_BER_Eat.Text = "label2";
            this.lb_BER_Eat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_BER_PooPoo
            // 
            this.lb_BER_PooPoo.AutoSize = true;
            this.lb_BER_PooPoo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_BER_PooPoo.Location = new System.Drawing.Point(993, 673);
            this.lb_BER_PooPoo.Name = "lb_BER_PooPoo";
            this.lb_BER_PooPoo.Size = new System.Drawing.Size(74, 26);
            this.lb_BER_PooPoo.TabIndex = 1;
            this.lb_BER_PooPoo.Text = "label3";
            this.lb_BER_PooPoo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_BER_Sleep
            // 
            this.lb_BER_Sleep.AutoSize = true;
            this.lb_BER_Sleep.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_BER_Sleep.Location = new System.Drawing.Point(1233, 673);
            this.lb_BER_Sleep.Name = "lb_BER_Sleep";
            this.lb_BER_Sleep.Size = new System.Drawing.Size(74, 26);
            this.lb_BER_Sleep.TabIndex = 0;
            this.lb_BER_Sleep.Text = "label4";
            this.lb_BER_Sleep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Sleep_Light
            // 
            this.btn_Sleep_Light.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Sleep_Light.BackgroundImage = global::MyTalkingTom.Properties.Resources.btn_Bedroom_LightOn;
            this.btn_Sleep_Light.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sleep_Light.Location = new System.Drawing.Point(1322, 506);
            this.btn_Sleep_Light.Name = "btn_Sleep_Light";
            this.btn_Sleep_Light.Size = new System.Drawing.Size(140, 140);
            this.btn_Sleep_Light.TabIndex = 13;
            this.btn_Sleep_Light.TabStop = false;
            this.btn_Sleep_Light.Click += new System.EventHandler(this.BER_LightBtnClick);
            // 
            // btn_Sleep_Close
            // 
            this.btn_Sleep_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sleep_Close.BackgroundImage = global::MyTalkingTom.Properties.Resources.close_icon;
            this.btn_Sleep_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sleep_Close.Location = new System.Drawing.Point(1524, 12);
            this.btn_Sleep_Close.Name = "btn_Sleep_Close";
            this.btn_Sleep_Close.Size = new System.Drawing.Size(64, 64);
            this.btn_Sleep_Close.TabIndex = 14;
            this.btn_Sleep_Close.TabStop = false;
            this.btn_Sleep_Close.Click += new System.EventHandler(this.BER_CloseBtnClick);
            // 
            // lb_BER_Coins
            // 
            this.lb_BER_Coins.AutoSize = true;
            this.lb_BER_Coins.Font = new System.Drawing.Font("UVN Thanh Pho Nang", 16.2F, System.Drawing.FontStyle.Bold);
            this.lb_BER_Coins.Location = new System.Drawing.Point(176, 40);
            this.lb_BER_Coins.Name = "lb_BER_Coins";
            this.lb_BER_Coins.Size = new System.Drawing.Size(87, 36);
            this.lb_BER_Coins.TabIndex = 15;
            this.lb_BER_Coins.Text = "label1";
            // 
            // ptb_Wardrove
            // 
            this.ptb_Wardrove.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Wardrove.BackgroundImage = global::MyTalkingTom.Properties.Resources.Bedroom_Wardrove;
            this.ptb_Wardrove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_Wardrove.Location = new System.Drawing.Point(12, 12);
            this.ptb_Wardrove.Name = "ptb_Wardrove";
            this.ptb_Wardrove.Size = new System.Drawing.Size(579, 741);
            this.ptb_Wardrove.TabIndex = 16;
            this.ptb_Wardrove.TabStop = false;
            this.ptb_Wardrove.Click += new System.EventHandler(this.ptb_Wardrove_Click);
            // 
            // Bedroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MyTalkingTom.Properties.Resources.Bedroom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.lb_BER_Coins);
            this.Controls.Add(this.btn_Sleep_Close);
            this.Controls.Add(this.btn_Sleep_Light);
            this.Controls.Add(this.lb_BER_Sleep);
            this.Controls.Add(this.lb_BER_PooPoo);
            this.Controls.Add(this.lb_BER_Eat);
            this.Controls.Add(this.lb_BER_Play);
            this.Controls.Add(this.btn_Sleep_Home);
            this.Controls.Add(this.btn_Sleep_Shopping);
            this.Controls.Add(this.btn_Sleep_Info);
            this.Controls.Add(this.btn_Sleep_Sound);
            this.Controls.Add(this.btn_Sleep_Sleep);
            this.Controls.Add(this.btn_Sleep_PooPoo);
            this.Controls.Add(this.btn_Sleep_Eat);
            this.Controls.Add(this.ptb_Wardrove);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bedroom";
            this.Text = "BedRoom";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Eat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_PooPoo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Sleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Shopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Light)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sleep_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Wardrove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundPictureBox btn_Sleep_Eat;
        private RoundPictureBox btn_Sleep_PooPoo;
        private RoundPictureBox btn_Sleep_Sleep;
        private RoundPictureBox btn_Sleep_Sound;
        private RoundPictureBox btn_Sleep_Info;
        private RoundPictureBox btn_Sleep_Shopping;
        private RoundPictureBox btn_Sleep_Home;
        private RoundPictureBox btn_Sleep_Light;
        private RoundPictureBox btn_Sleep_Close;

        private System.Windows.Forms.Label lb_BER_Play;
        private System.Windows.Forms.Label lb_BER_Eat;
        private System.Windows.Forms.Label lb_BER_PooPoo;
        private System.Windows.Forms.Label lb_BER_Sleep;
        private System.Windows.Forms.Label lb_BER_Coins;
        private System.Windows.Forms.PictureBox ptb_Wardrove;
    }
}