namespace Counter
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
            this.label3 = new System.Windows.Forms.Label();
            this.startInput = new System.Windows.Forms.TextBox();
            this.endInput = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.Label();
            this.valueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "In Between??";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Starting Number:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 56);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Ending Number:";
            // 
            // startInput
            // 
            this.startInput.Location = new System.Drawing.Point(423, 100);
            this.startInput.Name = "startInput";
            this.startInput.Size = new System.Drawing.Size(100, 20);
            this.startInput.TabIndex = 3;
            // 
            // endInput
            // 
            this.endInput.Location = new System.Drawing.Point(423, 166);
            this.endInput.Name = "endInput";
            this.endInput.Size = new System.Drawing.Size(100, 20);
            this.endInput.TabIndex = 4;
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.ForeColor = System.Drawing.Color.Red;
            this.outputBox.Location = new System.Drawing.Point(12, 203);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(776, 350);
            this.outputBox.TabIndex = 5;
            // 
            // valueButton
            // 
            this.valueButton.BackColor = System.Drawing.Color.Silver;
            this.valueButton.Font = new System.Drawing.Font("ROG Fonts", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueButton.Location = new System.Drawing.Point(561, 96);
            this.valueButton.Name = "valueButton";
            this.valueButton.Size = new System.Drawing.Size(189, 99);
            this.valueButton.TabIndex = 6;
            this.valueButton.Text = "Show Values";
            this.valueButton.UseVisualStyleBackColor = false;
            this.valueButton.Click += new System.EventHandler(this.valueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.valueButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.endInput);
            this.Controls.Add(this.startInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startInput;
        private System.Windows.Forms.TextBox endInput;
        private System.Windows.Forms.Label outputBox;
        private System.Windows.Forms.Button valueButton;
    }
}

