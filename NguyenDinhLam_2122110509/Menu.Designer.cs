namespace NguyenDinhLam_2122110509
{
    partial class Menu
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
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(154, 79);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(75, 23);
            this.btn01.TabIndex = 0;
            this.btn01.Text = "Bai01";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(290, 79);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(75, 23);
            this.btn02.TabIndex = 1;
            this.btn02.Text = "Bai02";
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btn02_Click);
            // 
            // btn03
            // 
            this.btn03.Location = new System.Drawing.Point(434, 79);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(75, 23);
            this.btn03.TabIndex = 2;
            this.btn03.Text = "Bai03";
            this.btn03.UseVisualStyleBackColor = true;
            this.btn03.Click += new System.EventHandler(this.btn03_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(352, 213);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn04
            // 
            this.btn04.Location = new System.Drawing.Point(572, 79);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(75, 23);
            this.btn04.TabIndex = 4;
            this.btn04.Text = "Bai04";
            this.btn04.UseVisualStyleBackColor = true;
            this.btn04.Click += new System.EventHandler(this.btn04_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn04);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn04;
    }
}