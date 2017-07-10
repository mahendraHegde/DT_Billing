namespace DownTown
{
    partial class login
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rect2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rect1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rect2,
            this.rect1});
            this.shapeContainer1.Size = new System.Drawing.Size(366, 367);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // rect2
            // 
            this.rect2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.rect2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rect2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rect2.CornerRadius = 5;
            this.rect2.Location = new System.Drawing.Point(45, 186);
            this.rect2.Name = "rect2";
            this.rect2.Size = new System.Drawing.Size(271, 57);
            // 
            // rect1
            // 
            this.rect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.rect1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rect1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rect1.CornerRadius = 5;
            this.rect1.Location = new System.Drawing.Point(45, 89);
            this.rect1.Name = "rect1";
            this.rect1.Size = new System.Drawing.Size(271, 57);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.Gray;
            this.txtusername.Location = new System.Drawing.Point(58, 104);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(249, 26);
            this.txtusername.TabIndex = 1;
            this.txtusername.Text = "User Name";
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Gray;
            this.txtpassword.Location = new System.Drawing.Point(58, 199);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(249, 26);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.Text = "PassWord";
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(45, 277);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(271, 57);
            this.loginbtn.TabIndex = 3;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 367);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "login";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button loginbtn;
    }
}