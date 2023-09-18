namespace NguyenDinhLam_2122110509
{
    partial class Form3
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lbx = new System.Windows.Forms.Label();
            this.lby = new System.Windows.Forms.Label();
            this.lbkq = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(504, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbx
            // 
            this.lbx.AutoSize = true;
            this.lbx.Location = new System.Drawing.Point(185, 119);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(28, 13);
            this.lbx.TabIndex = 1;
            this.lbx.Text = "Số x";
            // 
            // lby
            // 
            this.lby.AutoSize = true;
            this.lby.Location = new System.Drawing.Point(185, 172);
            this.lby.Name = "lby";
            this.lby.Size = new System.Drawing.Size(28, 13);
            this.lby.TabIndex = 2;
            this.lby.Text = "Số y";
            // 
            // lbkq
            // 
            this.lbkq.AutoSize = true;
            this.lbkq.Location = new System.Drawing.Point(185, 224);
            this.lbkq.Name = "lbkq";
            this.lbkq.Size = new System.Drawing.Size(44, 13);
            this.lbkq.TabIndex = 3;
            this.lbkq.Text = "Kết quả";
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(339, 119);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(240, 20);
            this.txtx.TabIndex = 4;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(339, 217);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(240, 20);
            this.txtkq.TabIndex = 5;
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(339, 169);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(240, 20);
            this.txty.TabIndex = 6;
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(339, 320);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 7;
            this.btnMulti.Text = "Nhân";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(188, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Cộng";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.lbkq);
            this.Controls.Add(this.lby);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.btnExit);
            this.Name = "Form3";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbx;
        private System.Windows.Forms.Label lby;
        private System.Windows.Forms.Label lbkq;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnAdd;
    }
}