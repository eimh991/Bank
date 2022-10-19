namespace Bank_Application
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.pbRegHide = new System.Windows.Forms.PictureBox();
            this.pbRegShow = new System.Windows.Forms.PictureBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbPasswordReg = new System.Windows.Forms.TextBox();
            this.tbLoginReg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegShow)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRegHide
            // 
            this.pbRegHide.Image = ((System.Drawing.Image)(resources.GetObject("pbRegHide.Image")));
            this.pbRegHide.Location = new System.Drawing.Point(329, 116);
            this.pbRegHide.Name = "pbRegHide";
            this.pbRegHide.Size = new System.Drawing.Size(30, 29);
            this.pbRegHide.TabIndex = 27;
            this.pbRegHide.TabStop = false;
            this.pbRegHide.Click += new System.EventHandler(this.pbRegHide_Click);
            // 
            // pbRegShow
            // 
            this.pbRegShow.Image = ((System.Drawing.Image)(resources.GetObject("pbRegShow.Image")));
            this.pbRegShow.Location = new System.Drawing.Point(329, 116);
            this.pbRegShow.Name = "pbRegShow";
            this.pbRegShow.Size = new System.Drawing.Size(30, 29);
            this.pbRegShow.TabIndex = 26;
            this.pbRegShow.TabStop = false;
            this.pbRegShow.Click += new System.EventHandler(this.pbRegShow_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.Location = new System.Drawing.Point(104, 163);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(219, 36);
            this.btnEnter.TabIndex = 24;
            this.btnEnter.Text = "Зарегистрироватся";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbPasswordReg
            // 
            this.tbPasswordReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordReg.Location = new System.Drawing.Point(104, 116);
            this.tbPasswordReg.Name = "tbPasswordReg";
            this.tbPasswordReg.Size = new System.Drawing.Size(219, 29);
            this.tbPasswordReg.TabIndex = 23;
            // 
            // tbLoginReg
            // 
            this.tbLoginReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLoginReg.Location = new System.Drawing.Point(104, 71);
            this.tbLoginReg.Name = "tbLoginReg";
            this.tbLoginReg.Size = new System.Drawing.Size(219, 29);
            this.tbLoginReg.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Регистрация";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 239);
            this.Controls.Add(this.pbRegHide);
            this.Controls.Add(this.pbRegShow);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbPasswordReg);
            this.Controls.Add(this.tbLoginReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbRegHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRegHide;
        private System.Windows.Forms.PictureBox pbRegShow;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbPasswordReg;
        private System.Windows.Forms.TextBox tbLoginReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}