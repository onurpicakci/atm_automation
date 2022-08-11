
namespace GorselProgrammingProject
{
    partial class BilgiGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilgiGuncelleme));
            this.btnOkey = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.txtBoxNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblNewPasswordAgain = new System.Windows.Forms.Label();
            this.txtBoxNewPhone = new System.Windows.Forms.TextBox();
            this.txtBoxNewPhoneAgain = new System.Windows.Forms.TextBox();
            this.lblNewPhone = new System.Windows.Forms.Label();
            this.lblNewPhoneAgain = new System.Windows.Forms.Label();
            this.buttonOkey = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOkey
            // 
            this.btnOkey.Location = new System.Drawing.Point(52, 333);
            this.btnOkey.Name = "btnOkey";
            this.btnOkey.Size = new System.Drawing.Size(129, 58);
            this.btnOkey.TabIndex = 3;
            this.btnOkey.Text = "Onay";
            this.btnOkey.UseVisualStyleBackColor = true;
            this.btnOkey.Click += new System.EventHandler(this.btnOkey_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(319, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 26);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "label1";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(408, 43);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(74, 26);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "label1";
            this.lblSurname.Click += new System.EventHandler(this.lblSurname_Click_1);
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Location = new System.Drawing.Point(52, 232);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.PasswordChar = '*';
            this.txtBoxNewPassword.Size = new System.Drawing.Size(129, 20);
            this.txtBoxNewPassword.TabIndex = 6;
            // 
            // txtBoxNewPasswordAgain
            // 
            this.txtBoxNewPasswordAgain.Location = new System.Drawing.Point(55, 290);
            this.txtBoxNewPasswordAgain.Name = "txtBoxNewPasswordAgain";
            this.txtBoxNewPasswordAgain.PasswordChar = '*';
            this.txtBoxNewPasswordAgain.Size = new System.Drawing.Size(126, 20);
            this.txtBoxNewPasswordAgain.TabIndex = 7;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPassword.Location = new System.Drawing.Point(49, 212);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(70, 18);
            this.lblNewPassword.TabIndex = 8;
            this.lblNewPassword.Text = "Yeni Şifre";
            // 
            // lblNewPasswordAgain
            // 
            this.lblNewPasswordAgain.AutoSize = true;
            this.lblNewPasswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPasswordAgain.Location = new System.Drawing.Point(52, 270);
            this.lblNewPasswordAgain.Name = "lblNewPasswordAgain";
            this.lblNewPasswordAgain.Size = new System.Drawing.Size(127, 18);
            this.lblNewPasswordAgain.TabIndex = 9;
            this.lblNewPasswordAgain.Text = "Yeni Şifre (Tekrar)";
            // 
            // txtBoxNewPhone
            // 
            this.txtBoxNewPhone.Location = new System.Drawing.Point(600, 232);
            this.txtBoxNewPhone.Name = "txtBoxNewPhone";
            this.txtBoxNewPhone.Size = new System.Drawing.Size(198, 20);
            this.txtBoxNewPhone.TabIndex = 10;
            // 
            // txtBoxNewPhoneAgain
            // 
            this.txtBoxNewPhoneAgain.Location = new System.Drawing.Point(600, 290);
            this.txtBoxNewPhoneAgain.Name = "txtBoxNewPhoneAgain";
            this.txtBoxNewPhoneAgain.Size = new System.Drawing.Size(198, 20);
            this.txtBoxNewPhoneAgain.TabIndex = 11;
            // 
            // lblNewPhone
            // 
            this.lblNewPhone.AutoSize = true;
            this.lblNewPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPhone.Location = new System.Drawing.Point(597, 212);
            this.lblNewPhone.Name = "lblNewPhone";
            this.lblNewPhone.Size = new System.Drawing.Size(157, 18);
            this.lblNewPhone.TabIndex = 12;
            this.lblNewPhone.Text = "Yeni Telefon Numarası";
            this.lblNewPhone.Click += new System.EventHandler(this.lblNewPhone_Click);
            // 
            // lblNewPhoneAgain
            // 
            this.lblNewPhoneAgain.AutoSize = true;
            this.lblNewPhoneAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPhoneAgain.Location = new System.Drawing.Point(597, 270);
            this.lblNewPhoneAgain.Name = "lblNewPhoneAgain";
            this.lblNewPhoneAgain.Size = new System.Drawing.Size(210, 18);
            this.lblNewPhoneAgain.TabIndex = 13;
            this.lblNewPhoneAgain.Text = "Yeni Telefon Numarası(Tekrar)";
            this.lblNewPhoneAgain.Click += new System.EventHandler(this.lblNewPhoneAgain_Click);
            // 
            // buttonOkey
            // 
            this.buttonOkey.Location = new System.Drawing.Point(623, 333);
            this.buttonOkey.Name = "buttonOkey";
            this.buttonOkey.Size = new System.Drawing.Size(129, 58);
            this.buttonOkey.TabIndex = 14;
            this.buttonOkey.Text = "Onay";
            this.buttonOkey.UseVisualStyleBackColor = true;
            this.buttonOkey.Click += new System.EventHandler(this.buttonOkey_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(48, 151);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(143, 22);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Şifre Değiştirme";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Location = new System.Drawing.Point(558, 151);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(249, 22);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Telefon Numarası Değiştirme";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(324, 115);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(158, 79);
            this.pictureBoxLogo.TabIndex = 17;
            this.pictureBoxLogo.TabStop = false;
            // 
            // BilgiGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(819, 499);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.buttonOkey);
            this.Controls.Add(this.lblNewPhoneAgain);
            this.Controls.Add(this.lblNewPhone);
            this.Controls.Add(this.txtBoxNewPhoneAgain);
            this.Controls.Add(this.txtBoxNewPhone);
            this.Controls.Add(this.lblNewPasswordAgain);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtBoxNewPasswordAgain);
            this.Controls.Add(this.txtBoxNewPassword);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnOkey);
            this.Name = "BilgiGuncelleme";
            this.Text = "BilgiGuncelleme";
            this.Load += new System.EventHandler(this.BilgiGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOkey;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
        private System.Windows.Forms.TextBox txtBoxNewPasswordAgain;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblNewPasswordAgain;
        private System.Windows.Forms.TextBox txtBoxNewPhone;
        private System.Windows.Forms.TextBox txtBoxNewPhoneAgain;
        private System.Windows.Forms.Label lblNewPhone;
        private System.Windows.Forms.Label lblNewPhoneAgain;
        private System.Windows.Forms.Button buttonOkey;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}