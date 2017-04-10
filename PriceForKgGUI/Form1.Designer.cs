namespace PriceForKgGUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGram = new System.Windows.Forms.RadioButton();
            this.BtnKilo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.8F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "for:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnGram
            // 
            this.BtnGram.AutoSize = true;
            this.BtnGram.Location = new System.Drawing.Point(23, 48);
            this.BtnGram.Name = "BtnGram";
            this.BtnGram.Size = new System.Drawing.Size(71, 21);
            this.BtnGram.TabIndex = 2;
            this.BtnGram.TabStop = true;
            this.BtnGram.Text = "Grams";
            this.BtnGram.UseVisualStyleBackColor = true;
            // 
            // BtnKilo
            // 
            this.BtnKilo.AutoSize = true;
            this.BtnKilo.Location = new System.Drawing.Point(139, 48);
            this.BtnKilo.Name = "BtnKilo";
            this.BtnKilo.Size = new System.Drawing.Size(91, 21);
            this.BtnKilo.TabIndex = 3;
            this.BtnKilo.TabStop = true;
            this.BtnKilo.Text = "Kilograms";
            this.BtnKilo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnKilo);
            this.groupBox1.Controls.Add(this.BtnGram);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesurment Unit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "The price for kg is:";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(72, 7);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 22);
            this.TxtPrice.TabIndex = 7;
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(79, 174);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(100, 22);
            this.TxtAmount.TabIndex = 8;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(141, 259);
            this.LblResult.MinimumSize = new System.Drawing.Size(40, 20);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(40, 20);
            this.LblResult.TabIndex = 9;
            this.LblResult.Click += new System.EventHandler(this.LblResult_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton BtnGram;
        private System.Windows.Forms.RadioButton BtnKilo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button button1;
    }
}

