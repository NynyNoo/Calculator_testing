
namespace Calculator
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
            this.firstNumber_TextBox = new System.Windows.Forms.TextBox();
            this.secondNumber_TextBox = new System.Windows.Forms.TextBox();
            this.add_Button = new System.Windows.Forms.Button();
            this.divide_Button = new System.Windows.Forms.Button();
            this.multiply_Button = new System.Windows.Forms.Button();
            this.subtrack_Button = new System.Windows.Forms.Button();
            this.result_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstNumber_TextBox
            // 
            this.firstNumber_TextBox.Location = new System.Drawing.Point(257, 84);
            this.firstNumber_TextBox.Name = "firstNumber_TextBox";
            this.firstNumber_TextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNumber_TextBox.TabIndex = 0;
            this.firstNumber_TextBox.TextChanged += new System.EventHandler(this.firstNumber_TextBox_TextChanged);
            // 
            // secondNumber_TextBox
            // 
            this.secondNumber_TextBox.Location = new System.Drawing.Point(363, 84);
            this.secondNumber_TextBox.Name = "secondNumber_TextBox";
            this.secondNumber_TextBox.Size = new System.Drawing.Size(100, 20);
            this.secondNumber_TextBox.TabIndex = 1;
            this.secondNumber_TextBox.TextChanged += new System.EventHandler(this.secondNumber_TextBox_TextChanged);
            // 
            // add_Button
            // 
            this.add_Button.Location = new System.Drawing.Point(257, 143);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(75, 23);
            this.add_Button.TabIndex = 2;
            this.add_Button.Text = "Add";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // divide_Button
            // 
            this.divide_Button.Location = new System.Drawing.Point(257, 214);
            this.divide_Button.Name = "divide_Button";
            this.divide_Button.Size = new System.Drawing.Size(75, 23);
            this.divide_Button.TabIndex = 3;
            this.divide_Button.Text = "Divide";
            this.divide_Button.UseVisualStyleBackColor = true;
            this.divide_Button.Click += new System.EventHandler(this.divide_Button_Click);
            // 
            // multiply_Button
            // 
            this.multiply_Button.Location = new System.Drawing.Point(388, 214);
            this.multiply_Button.Name = "multiply_Button";
            this.multiply_Button.Size = new System.Drawing.Size(75, 23);
            this.multiply_Button.TabIndex = 4;
            this.multiply_Button.Text = "Multiply";
            this.multiply_Button.UseVisualStyleBackColor = true;
            this.multiply_Button.Click += new System.EventHandler(this.multiply_Button_Click);
            // 
            // subtrack_Button
            // 
            this.subtrack_Button.Location = new System.Drawing.Point(388, 143);
            this.subtrack_Button.Name = "subtrack_Button";
            this.subtrack_Button.Size = new System.Drawing.Size(75, 23);
            this.subtrack_Button.TabIndex = 5;
            this.subtrack_Button.Text = "Subtract";
            this.subtrack_Button.UseVisualStyleBackColor = true;
            this.subtrack_Button.Click += new System.EventHandler(this.subtrack_Button_Click);
            // 
            // result_TextBox
            // 
            this.result_TextBox.Location = new System.Drawing.Point(573, 155);
            this.result_TextBox.Name = "result_TextBox";
            this.result_TextBox.Size = new System.Drawing.Size(100, 20);
            this.result_TextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result_TextBox);
            this.Controls.Add(this.subtrack_Button);
            this.Controls.Add(this.multiply_Button);
            this.Controls.Add(this.divide_Button);
            this.Controls.Add(this.add_Button);
            this.Controls.Add(this.secondNumber_TextBox);
            this.Controls.Add(this.firstNumber_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumber_TextBox;
        private System.Windows.Forms.TextBox secondNumber_TextBox;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Button divide_Button;
        private System.Windows.Forms.Button multiply_Button;
        private System.Windows.Forms.Button subtrack_Button;
        private System.Windows.Forms.TextBox result_TextBox;
    }
}

