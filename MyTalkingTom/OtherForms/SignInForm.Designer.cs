namespace MyTalkingTom
{
    partial class SignInForm
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
            this.txb_TomName = new System.Windows.Forms.TextBox();
            this.btn_SignIn = new MyTalkingTom.RoundPictureBox();
            this.btn_SignInClose = new MyTalkingTom.RoundPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SignInClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_TomName
            // 
            this.txb_TomName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txb_TomName.Font = new System.Drawing.Font("UVN Thanh Pho Nang", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TomName.Location = new System.Drawing.Point(330, 614);
            this.txb_TomName.Multiline = true;
            this.txb_TomName.Name = "txb_TomName";
            this.txb_TomName.Size = new System.Drawing.Size(350, 36);
            this.txb_TomName.TabIndex = 1;
            this.txb_TomName.WordWrap = false;
            this.txb_TomName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SI_PressEnter);
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.Color.DarkGray;
            this.btn_SignIn.BackgroundImage = global::MyTalkingTom.Properties.Resources.icon;
            this.btn_SignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SignIn.Location = new System.Drawing.Point(770, 578);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(100, 100);
            this.btn_SignIn.TabIndex = 3;
            this.btn_SignIn.TabStop = false;
            this.btn_SignIn.Click += new System.EventHandler(this.SI_SignInBtnClick);
            // 
            // btn_SignInClose
            // 
            this.btn_SignInClose.BackColor = System.Drawing.Color.Transparent;
            this.btn_SignInClose.BackgroundImage = global::MyTalkingTom.Properties.Resources.close_icon;
            this.btn_SignInClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SignInClose.Location = new System.Drawing.Point(1524, 12);
            this.btn_SignInClose.Name = "btn_SignInClose";
            this.btn_SignInClose.Size = new System.Drawing.Size(64, 64);
            this.btn_SignInClose.TabIndex = 2;
            this.btn_SignInClose.TabStop = false;
            this.btn_SignInClose.Click += new System.EventHandler(this.SI_CloseBtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UVN Thanh Pho Nang", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(77, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Tom\'s Name:";
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MyTalkingTom.Properties.Resources.LogIn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.btn_SignInClose);
            this.Controls.Add(this.txb_TomName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            ((System.ComponentModel.ISupportInitialize)(this.btn_SignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SignInClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_TomName;
        private RoundPictureBox btn_SignInClose;
        private RoundPictureBox btn_SignIn;
        private System.Windows.Forms.Label label1;
    }
}