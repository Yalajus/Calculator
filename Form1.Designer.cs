
namespace Calculator
{
    partial class Calculator
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
            this.Result = new System.Windows.Forms.TextBox();
            this.numberOne = new System.Windows.Forms.TextBox();
            this.numberTwo = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(32, 12);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(305, 22);
            this.Result.TabIndex = 0;
            // 
            // numberOne
            // 
            this.numberOne.Location = new System.Drawing.Point(32, 111);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(100, 22);
            this.numberOne.TabIndex = 1;
            // 
            // numberTwo
            // 
            this.numberTwo.Location = new System.Drawing.Point(237, 111);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(100, 22);
            this.numberTwo.TabIndex = 2;
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(147, 66);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 23);
            this.addition.TabIndex = 3;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(147, 96);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(75, 23);
            this.subtraction.TabIndex = 4;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(147, 126);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 5;
            this.multiplication.Text = "x";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(147, 156);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 204);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.numberTwo);
            this.Controls.Add(this.numberOne);
            this.Controls.Add(this.Result);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox numberOne;
        private System.Windows.Forms.TextBox numberTwo;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
    }
}

