namespace FrmBasicCalculator
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
            this.btnCompute = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(232, 315);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(85, 28);
            this.btnCompute.TabIndex = 0;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 39);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 183);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 40);
            this.textBox2.TabIndex = 2;
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperator.Location = new System.Drawing.Point(232, 143);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(80, 21);
            this.cmbOperator.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Basic Calculator";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblTotal.Location = new System.Drawing.Point(203, 229);
            this.lblTotal.Multiline = true;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(142, 69);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Test:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 388);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCompute);
            this.Name = "Form1";
            this.Text = "FrmBasicCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblTotal;
    }
}

