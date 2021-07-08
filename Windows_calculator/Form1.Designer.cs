namespace Windows_calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CALCULATOR = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.symbol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CALCULATOR
            // 
            this.CALCULATOR.AutoSize = true;
            this.CALCULATOR.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CALCULATOR.ForeColor = System.Drawing.Color.Blue;
            this.CALCULATOR.Location = new System.Drawing.Point(196, 31);
            this.CALCULATOR.Name = "CALCULATOR";
            this.CALCULATOR.Size = new System.Drawing.Size(411, 81);
            this.CALCULATOR.TabIndex = 0;
            this.CALCULATOR.Text = "CALCULATOR";
            this.CALCULATOR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.AliceBlue;
            this.num1.Cursor = System.Windows.Forms.Cursors.Default;
            this.num1.ForeColor = System.Drawing.Color.Black;
            this.num1.Location = new System.Drawing.Point(177, 147);
            this.num1.Name = "num1";
            this.num1.PlaceholderText = "Enter first number";
            this.num1.Size = new System.Drawing.Size(155, 27);
            this.num1.TabIndex = 1;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.AliceBlue;
            this.num2.Cursor = System.Windows.Forms.Cursors.Default;
            this.num2.ForeColor = System.Drawing.Color.Black;
            this.num2.Location = new System.Drawing.Point(397, 147);
            this.num2.Name = "num2";
            this.num2.PlaceholderText = "Enter second number";
            this.num2.Size = new System.Drawing.Size(155, 27);
            this.num2.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(177, 242);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(155, 29);
            this.add.TabIndex = 2;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(177, 280);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(155, 29);
            this.sub.TabIndex = 2;
            this.sub.Text = "SUBSTRACT";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(177, 322);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(155, 29);
            this.multiply.TabIndex = 2;
            this.multiply.Text = "MULTIPLY";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(177, 366);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(155, 29);
            this.divide.TabIndex = 2;
            this.divide.Text = "DIVIDE";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // symbol
            // 
            this.symbol.AutoSize = true;
            this.symbol.Location = new System.Drawing.Point(361, 148);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(17, 20);
            this.symbol.TabIndex = 3;
            this.symbol.Text = "  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(595, 149);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(45, 20);
            this.result.TabIndex = 5;
            this.result.Text = "result";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.symbol);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.CALCULATOR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CALCULATOR;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Label symbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
    }
}

