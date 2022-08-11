
namespace GorselProgrammingProject
{
    partial class Havale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Havale));
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.textBoxTransfer = new System.Windows.Forms.TextBox();
            this.checkBoxOkey = new System.Windows.Forms.CheckBox();
            this.btnOkey = new System.Windows.Forms.Button();
            this.lblSurname1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.lblTransferAccount = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(636, 263);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(141, 20);
            this.textBoxPhone.TabIndex = 0;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Location = new System.Drawing.Point(619, 209);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(187, 36);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Havale Yapacağınız Kişinin \r\n     Telefon Numarası\r\n";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(668, 302);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 42);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnOkey_Click);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName1.Location = new System.Drawing.Point(44, 208);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(29, 20);
            this.lblName1.TabIndex = 3;
            this.lblName1.Text = "Ad";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(341, 222);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(404, 222);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(0, 20);
            this.lblSurname.TabIndex = 5;
            // 
            // textBoxTransfer
            // 
            this.textBoxTransfer.Location = new System.Drawing.Point(331, 276);
            this.textBoxTransfer.Name = "textBoxTransfer";
            this.textBoxTransfer.Size = new System.Drawing.Size(140, 20);
            this.textBoxTransfer.TabIndex = 7;
            this.textBoxTransfer.Visible = false;
            this.textBoxTransfer.WordWrap = false;
            this.textBoxTransfer.TextChanged += new System.EventHandler(this.textBoxTransfer_TextChanged);
            // 
            // checkBoxOkey
            // 
            this.checkBoxOkey.AutoSize = true;
            this.checkBoxOkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxOkey.Location = new System.Drawing.Point(331, 245);
            this.checkBoxOkey.Name = "checkBoxOkey";
            this.checkBoxOkey.Size = new System.Drawing.Size(147, 22);
            this.checkBoxOkey.TabIndex = 8;
            this.checkBoxOkey.Text = "Devam Etmek İçin";
            this.checkBoxOkey.UseVisualStyleBackColor = true;
            this.checkBoxOkey.Visible = false;
            this.checkBoxOkey.CheckedChanged += new System.EventHandler(this.checkBoxOkey_CheckedChanged_1);
            // 
            // btnOkey
            // 
            this.btnOkey.Location = new System.Drawing.Point(353, 302);
            this.btnOkey.Name = "btnOkey";
            this.btnOkey.Size = new System.Drawing.Size(75, 42);
            this.btnOkey.TabIndex = 9;
            this.btnOkey.Text = "Onay";
            this.btnOkey.UseVisualStyleBackColor = true;
            this.btnOkey.Visible = false;
            this.btnOkey.Click += new System.EventHandler(this.btnOkey_Click_1);
            // 
            // lblSurname1
            // 
            this.lblSurname1.AutoSize = true;
            this.lblSurname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname1.Location = new System.Drawing.Point(107, 208);
            this.lblSurname1.Name = "lblSurname1";
            this.lblSurname1.Size = new System.Drawing.Size(54, 20);
            this.lblSurname1.TabIndex = 10;
            this.lblSurname1.Text = "Soyad";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(67, 245);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Bakiye";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameSurname.Location = new System.Drawing.Point(11, 136);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(217, 22);
            this.lblNameSurname.TabIndex = 12;
            this.lblNameSurname.Text = "Gönderen Hesap Bilgileri";
            // 
            // lblTransferAccount
            // 
            this.lblTransferAccount.AutoSize = true;
            this.lblTransferAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTransferAccount.Location = new System.Drawing.Point(305, 136);
            this.lblTransferAccount.Name = "lblTransferAccount";
            this.lblTransferAccount.Size = new System.Drawing.Size(246, 22);
            this.lblTransferAccount.TabIndex = 13;
            this.lblTransferAccount.Text = "Gönderilecek Hesap Bilgileri";
            this.lblTransferAccount.Visible = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(345, 29);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(155, 79);
            this.pictureBoxLogo.TabIndex = 14;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Havale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(832, 472);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblTransferAccount);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSurname1);
            this.Controls.Add(this.btnOkey);
            this.Controls.Add(this.checkBoxOkey);
            this.Controls.Add(this.textBoxTransfer);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Name = "Havale";
            this.Text = "Havale";
            this.Load += new System.EventHandler(this.Havale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox textBoxTransfer;
        private System.Windows.Forms.CheckBox checkBoxOkey;
        private System.Windows.Forms.Button btnOkey;
        private System.Windows.Forms.Label lblSurname1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label lblTransferAccount;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}