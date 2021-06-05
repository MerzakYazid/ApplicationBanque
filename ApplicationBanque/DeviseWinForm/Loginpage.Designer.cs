
namespace DeviseWinForm
{
    partial class Loginpage
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
            this.login = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.remember = new MaterialSkin.Controls.MaterialCheckBox();
            this.button1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Depth = 0;
            this.login.Hint = "";
            this.login.Location = new System.Drawing.Point(53, 123);
            this.login.MouseState = MaterialSkin.MouseState.HOVER;
            this.login.Name = "login";
            this.login.PasswordChar = '\0';
            this.login.SelectedText = "";
            this.login.SelectionLength = 0;
            this.login.SelectionStart = 0;
            this.login.Size = new System.Drawing.Size(212, 23);
            this.login.TabIndex = 5;
            this.login.Text = "Username";
            this.login.UseSystemPasswordChar = false;
            // 
            // passwd
            // 
            this.passwd.Depth = 0;
            this.passwd.Hint = "";
            this.passwd.Location = new System.Drawing.Point(53, 182);
            this.passwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwd.Name = "passwd";
            this.passwd.PasswordChar = '\0';
            this.passwd.SelectedText = "";
            this.passwd.SelectionLength = 0;
            this.passwd.SelectionStart = 0;
            this.passwd.Size = new System.Drawing.Size(212, 23);
            this.passwd.TabIndex = 6;
            this.passwd.Text = "Password";
            this.passwd.UseSystemPasswordChar = false;
            this.passwd.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // remember
            // 
            this.remember.AutoSize = true;
            this.remember.Depth = 0;
            this.remember.Font = new System.Drawing.Font("Roboto", 10F);
            this.remember.Location = new System.Drawing.Point(53, 225);
            this.remember.Margin = new System.Windows.Forms.Padding(0);
            this.remember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.remember.MouseState = MaterialSkin.MouseState.HOVER;
            this.remember.Name = "remember";
            this.remember.Ripple = true;
            this.remember.Size = new System.Drawing.Size(120, 30);
            this.remember.TabIndex = 7;
            this.remember.Text = "Remember me";
            this.remember.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Depth = 0;
            this.button1.Location = new System.Drawing.Point(190, 290);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = true;
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(23, 339);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(270, 2);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            this.materialDivider1.Click += new System.EventHandler(this.materialDivider1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(19, 367);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(152, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Lost your password ?";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(229, 367);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Register";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // Loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 407);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.remember);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.login);
            this.Name = "Loginpage";
            this.Text = "Loginpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField login;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwd;
        private MaterialSkin.Controls.MaterialCheckBox remember;
        private MaterialSkin.Controls.MaterialRaisedButton button1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}