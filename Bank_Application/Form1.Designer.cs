namespace Bank_Application
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbCompleteness = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.btBalance = new System.Windows.Forms.Button();
            this.tbCompleteness = new System.Windows.Forms.TextBox();
            this.btCompleteness = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.rbResCompleteness = new System.Windows.Forms.TextBox();
            this.lbTransfer = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btTransfer = new System.Windows.Forms.Button();
            this.lb3 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.Location = new System.Drawing.Point(286, 18);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(60, 24);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "label1";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBalance.Location = new System.Drawing.Point(12, 79);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(228, 24);
            this.lbBalance.TabIndex = 1;
            this.lbBalance.Text = "Хотите узнать баланс";
            // 
            // lbCompleteness
            // 
            this.lbCompleteness.AutoSize = true;
            this.lbCompleteness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCompleteness.Location = new System.Drawing.Point(271, 150);
            this.lbCompleteness.Name = "lbCompleteness";
            this.lbCompleteness.Size = new System.Drawing.Size(192, 24);
            this.lbCompleteness.TabIndex = 2;
            this.lbCompleteness.Text = "Пополнить баланс";
            // 
            // tbBalance
            // 
            this.tbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBalance.Location = new System.Drawing.Point(260, 79);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(205, 29);
            this.tbBalance.TabIndex = 4;
            // 
            // btBalance
            // 
            this.btBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBalance.Location = new System.Drawing.Point(492, 79);
            this.btBalance.Name = "btBalance";
            this.btBalance.Size = new System.Drawing.Size(164, 31);
            this.btBalance.TabIndex = 5;
            this.btBalance.Text = "Запросить";
            this.btBalance.UseVisualStyleBackColor = true;
            this.btBalance.Click += new System.EventHandler(this.btBalance_Click);
            // 
            // tbCompleteness
            // 
            this.tbCompleteness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCompleteness.Location = new System.Drawing.Point(262, 186);
            this.tbCompleteness.Name = "tbCompleteness";
            this.tbCompleteness.Size = new System.Drawing.Size(203, 29);
            this.tbCompleteness.TabIndex = 6;
            // 
            // btCompleteness
            // 
            this.btCompleteness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCompleteness.Location = new System.Drawing.Point(481, 186);
            this.btCompleteness.Name = "btCompleteness";
            this.btCompleteness.Size = new System.Drawing.Size(164, 31);
            this.btCompleteness.TabIndex = 7;
            this.btCompleteness.Text = "Пополнить";
            this.btCompleteness.UseVisualStyleBackColor = true;
            this.btCompleteness.Click += new System.EventHandler(this.btCompleteness_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2.Location = new System.Drawing.Point(255, 266);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(266, 29);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "Перевести средства";
            // 
            // tbSum
            // 
            this.tbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSum.Location = new System.Drawing.Point(290, 309);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(205, 29);
            this.tbSum.TabIndex = 9;
            // 
            // rbResCompleteness
            // 
            this.rbResCompleteness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbResCompleteness.Location = new System.Drawing.Point(101, 234);
            this.rbResCompleteness.Name = "rbResCompleteness";
            this.rbResCompleteness.Size = new System.Drawing.Size(544, 29);
            this.rbResCompleteness.TabIndex = 10;
            // 
            // lbTransfer
            // 
            this.lbTransfer.AutoSize = true;
            this.lbTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTransfer.Location = new System.Drawing.Point(12, 312);
            this.lbTransfer.Name = "lbTransfer";
            this.lbTransfer.Size = new System.Drawing.Size(261, 24);
            this.lbTransfer.TabIndex = 11;
            this.lbTransfer.Text = "Укажите сумму перевода";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbId.Location = new System.Drawing.Point(2, 365);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(536, 24);
            this.lbId.TabIndex = 12;
            this.lbId.Text = "Укажите ID которому вы хотите перевести средства";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbId.Location = new System.Drawing.Point(554, 360);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(91, 29);
            this.tbId.TabIndex = 13;
            // 
            // btTransfer
            // 
            this.btTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTransfer.Location = new System.Drawing.Point(6, 412);
            this.btTransfer.Name = "btTransfer";
            this.btTransfer.Size = new System.Drawing.Size(164, 34);
            this.btTransfer.TabIndex = 14;
            this.btTransfer.Text = "Перевести";
            this.btTransfer.UseVisualStyleBackColor = true;
            this.btTransfer.Click += new System.EventHandler(this.btTransfer_Click);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3.Location = new System.Drawing.Point(12, 187);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(241, 20);
            this.lb3.TabIndex = 15;
            this.lb3.Text = "Укажите сумму пополнения";
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult.Location = new System.Drawing.Point(203, 414);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(535, 72);
            this.tbResult.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.btTransfer);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbTransfer);
            this.Controls.Add(this.rbResCompleteness);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btCompleteness);
            this.Controls.Add(this.tbCompleteness);
            this.Controls.Add(this.btBalance);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.lbCompleteness);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "SmallBank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbCompleteness;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Button btBalance;
        private System.Windows.Forms.TextBox tbCompleteness;
        private System.Windows.Forms.Button btCompleteness;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.TextBox rbResCompleteness;
        private System.Windows.Forms.Label lbTransfer;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btTransfer;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox tbResult;
    }
}

