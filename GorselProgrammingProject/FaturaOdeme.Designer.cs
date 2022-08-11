
namespace GorselProgrammingProject
{
    partial class FaturaOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaOdeme));
            this.btnInternet = new System.Windows.Forms.Button();
            this.btnElectric = new System.Windows.Forms.Button();
            this.btnWater = new System.Windows.Forms.Button();
            this.btnGas = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblNewTotal = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInternet
            // 
            this.btnInternet.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInternet.Location = new System.Drawing.Point(12, 155);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(152, 87);
            this.btnInternet.TabIndex = 0;
            this.btnInternet.Text = "İnternet Faturası";
            this.btnInternet.UseVisualStyleBackColor = true;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // btnElectric
            // 
            this.btnElectric.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnElectric.Location = new System.Drawing.Point(12, 295);
            this.btnElectric.Name = "btnElectric";
            this.btnElectric.Size = new System.Drawing.Size(152, 87);
            this.btnElectric.TabIndex = 1;
            this.btnElectric.Text = "Elektrik Faturası";
            this.btnElectric.UseVisualStyleBackColor = true;
            this.btnElectric.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWater
            // 
            this.btnWater.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWater.Location = new System.Drawing.Point(636, 295);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(152, 87);
            this.btnWater.TabIndex = 2;
            this.btnWater.Text = "Su Faturası";
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGas
            // 
            this.btnGas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGas.Location = new System.Drawing.Point(636, 155);
            this.btnGas.Name = "btnGas";
            this.btnGas.Size = new System.Drawing.Size(152, 87);
            this.btnGas.TabIndex = 3;
            this.btnGas.Text = "Doğalgaz Faturası";
            this.btnGas.UseVisualStyleBackColor = true;
            this.btnGas.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInformation.Location = new System.Drawing.Point(317, 76);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(0, 18);
            this.lblInformation.TabIndex = 5;
            this.lblInformation.Visible = false;
            // 
            // lblNewTotal
            // 
            this.lblNewTotal.AutoSize = true;
            this.lblNewTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewTotal.Location = new System.Drawing.Point(287, 249);
            this.lblNewTotal.Name = "lblNewTotal";
            this.lblNewTotal.Size = new System.Drawing.Size(0, 18);
            this.lblNewTotal.TabIndex = 8;
            this.lblNewTotal.Visible = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(320, 118);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(155, 79);
            this.pictureBoxLogo.TabIndex = 15;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FaturaOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblNewTotal);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnGas);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.btnElectric);
            this.Controls.Add(this.btnInternet);
            this.Name = "FaturaOdeme";
            this.Text = "FaturaOdeme";
            this.Load += new System.EventHandler(this.FaturaOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInternet;
        private System.Windows.Forms.Button btnElectric;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnGas;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblNewTotal;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}