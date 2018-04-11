namespace calculator
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
            this.components = new System.ComponentModel.Container();
            this.btn1 = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightGreen;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(130, 208);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(63, 40);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.click_button);
            // 
            // divideBtn
            // 
            this.divideBtn.BackColor = System.Drawing.Color.Turquoise;
            this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.Location = new System.Drawing.Point(387, 93);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(63, 40);
            this.divideBtn.TabIndex = 1;
            this.divideBtn.Text = "÷";
            this.divideBtn.UseVisualStyleBackColor = false;
            this.divideBtn.Click += new System.EventHandler(this.operator_click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightGreen;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(301, 208);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(63, 40);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.click_button);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LightGreen;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(217, 208);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(63, 40);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.click_button);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.LightGreen;
            this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.Location = new System.Drawing.Point(217, 264);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(63, 40);
            this.btnPoint.TabIndex = 7;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.click_button);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.LightGreen;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(301, 150);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(63, 40);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.click_button);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(387, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "×";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.operator_click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.LightGreen;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(130, 264);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(63, 40);
            this.btn0.TabIndex = 4;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.click_button);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.LightGreen;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(217, 150);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(63, 40);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.click_button);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(301, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 40);
            this.button6.TabIndex = 10;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.click_button);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Turquoise;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(387, 208);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 40);
            this.button7.TabIndex = 9;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.operator_click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.LightGreen;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(130, 150);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(63, 40);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.click_button);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightGreen;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(217, 93);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 40);
            this.button9.TabIndex = 15;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.click_button);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.LightGreen;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(301, 264);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(63, 40);
            this.btnEquals.TabIndex = 14;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Turquoise;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(387, 264);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(63, 40);
            this.button11.TabIndex = 13;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.operator_click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightGreen;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(130, 93);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(63, 40);
            this.button12.TabIndex = 12;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.click_button);
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(130, 23);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(320, 47);
            this.resultBox.TabIndex = 16;
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(130, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(320, 40);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(559, 376);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.btn1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.click_button);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer timer1;
    }
}

