namespace NguyenDinhLam_2122110509
{
    partial class Form4
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
            this.view = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.Window;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.view.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(12, 11);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(213, 22);
            this.view.TabIndex = 9;
            this.view.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 58);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(49, 23);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(67, 115);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(49, 23);
            this.btnMul.TabIndex = 2;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(122, 115);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(49, 23);
            this.btnDot.TabIndex = 3;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(177, 115);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(49, 23);
            this.btnEqual.TabIndex = 4;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(177, 58);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(49, 23);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(122, 58);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(49, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(67, 58);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(49, 23);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(12, 115);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(49, 23);
            this.btnPlus.TabIndex = 8;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 160);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.view);
            this.Name = "Form4";
            this.Text = "Basic Caculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox view;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnPlus;
    }
}