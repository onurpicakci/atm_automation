
namespace GorselProgrammingProject
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonOkey = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.picBoxPhone = new System.Windows.Forms.PictureBox();
            this.picBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxExecutive = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPasswordd = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword2 = new System.Windows.Forms.TextBox();
            this.lblExecutive = new System.Windows.Forms.Label();
            this.btnExecutive = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExecutive)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxPhone.Location = new System.Drawing.Point(122, 89);
            this.textBoxPhone.MaxLength = 10;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(142, 20);
            this.textBoxPhone.TabIndex = 0;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxPassword.Location = new System.Drawing.Point(122, 180);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(142, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonOkey
            // 
            this.buttonOkey.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonOkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOkey.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOkey.Image = ((System.Drawing.Image)(resources.GetObject("buttonOkey.Image")));
            this.buttonOkey.Location = new System.Drawing.Point(122, 258);
            this.buttonOkey.Name = "buttonOkey";
            this.buttonOkey.Size = new System.Drawing.Size(142, 100);
            this.buttonOkey.TabIndex = 2;
            this.buttonOkey.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonOkey.UseVisualStyleBackColor = false;
            this.buttonOkey.Click += new System.EventHandler(this.button1_Click);
            this.buttonOkey.MouseHover += new System.EventHandler(this.buttonOkey_MouseHover);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Location = new System.Drawing.Point(122, 68);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(125, 18);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Telefon Numarası";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(122, 159);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(38, 18);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Şifre";
            // 
            // picBoxPhone
            // 
            this.picBoxPhone.BackColor = System.Drawing.Color.DarkCyan;
            this.picBoxPhone.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPhone.Image")));
            this.picBoxPhone.Location = new System.Drawing.Point(61, 68);
            this.picBoxPhone.Name = "picBoxPhone";
            this.picBoxPhone.Size = new System.Drawing.Size(55, 56);
            this.picBoxPhone.TabIndex = 5;
            this.picBoxPhone.TabStop = false;
            // 
            // picBoxPassword
            // 
            this.picBoxPassword.BackColor = System.Drawing.Color.DarkCyan;
            this.picBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPassword.Image")));
            this.picBoxPassword.Location = new System.Drawing.Point(54, 159);
            this.picBoxPassword.Name = "picBoxPassword";
            this.picBoxPassword.Size = new System.Drawing.Size(65, 64);
            this.picBoxPassword.TabIndex = 6;
            this.picBoxPassword.TabStop = false;
            // 
            // pictureBoxExecutive
            // 
            this.pictureBoxExecutive.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExecutive.Image")));
            this.pictureBoxExecutive.Location = new System.Drawing.Point(494, 89);
            this.pictureBoxExecutive.Name = "pictureBoxExecutive";
            this.pictureBoxExecutive.Size = new System.Drawing.Size(100, 120);
            this.pictureBoxExecutive.TabIndex = 7;
            this.pictureBoxExecutive.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(624, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 18);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Kullanıcı Adı";
            // 
            // lblPasswordd
            // 
            this.lblPasswordd.AutoSize = true;
            this.lblPasswordd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordd.Location = new System.Drawing.Point(624, 159);
            this.lblPasswordd.Name = "lblPasswordd";
            this.lblPasswordd.Size = new System.Drawing.Size(38, 18);
            this.lblPasswordd.TabIndex = 9;
            this.lblPasswordd.Text = "Şifre";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBoxUsername.Location = new System.Drawing.Point(627, 89);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(134, 20);
            this.txtBoxUsername.TabIndex = 10;
            // 
            // txtBoxPassword2
            // 
            this.txtBoxPassword2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBoxPassword2.Location = new System.Drawing.Point(627, 180);
            this.txtBoxPassword2.Name = "txtBoxPassword2";
            this.txtBoxPassword2.PasswordChar = '*';
            this.txtBoxPassword2.Size = new System.Drawing.Size(134, 20);
            this.txtBoxPassword2.TabIndex = 11;
            this.txtBoxPassword2.UseSystemPasswordChar = true;
            // 
            // lblExecutive
            // 
            this.lblExecutive.AutoSize = true;
            this.lblExecutive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExecutive.Location = new System.Drawing.Point(623, 26);
            this.lblExecutive.Name = "lblExecutive";
            this.lblExecutive.Size = new System.Drawing.Size(138, 24);
            this.lblExecutive.TabIndex = 12;
            this.lblExecutive.Text = "Yönetici Girişi";
            // 
            // btnExecutive
            // 
            this.btnExecutive.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExecutive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecutive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExecutive.Image = ((System.Drawing.Image)(resources.GetObject("btnExecutive.Image")));
            this.btnExecutive.Location = new System.Drawing.Point(627, 258);
            this.btnExecutive.Name = "btnExecutive";
            this.btnExecutive.Size = new System.Drawing.Size(134, 100);
            this.btnExecutive.TabIndex = 13;
            this.btnExecutive.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnExecutive.UseVisualStyleBackColor = false;
            this.btnExecutive.Click += new System.EventHandler(this.btnExecutive_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.Location = new System.Drawing.Point(122, 26);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(142, 24);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "Kullanıcı Girişi";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnExecutive);
            this.Controls.Add(this.lblExecutive);
            this.Controls.Add(this.txtBoxPassword2);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.lblPasswordd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBoxExecutive);
            this.Controls.Add(this.picBoxPassword);
            this.Controls.Add(this.picBoxPhone);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.buttonOkey);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPhone);
            this.Name = "Giris";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExecutive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonOkey;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox picBoxPhone;
        private System.Windows.Forms.PictureBox picBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxExecutive;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPasswordd;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword2;
        private System.Windows.Forms.Label lblExecutive;
        private System.Windows.Forms.Button btnExecutive;
        private System.Windows.Forms.Label lblUser;
    }
}