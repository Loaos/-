namespace WindowsFormsApp1
{
    partial class Authorization
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.unhide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(230, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(215, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(215, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Логин:";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(275, 200);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 23);
            this.login.TabIndex = 33;
            this.login.Text = "Войти";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(275, 157);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(100, 20);
            this.passwordbox.TabIndex = 32;
            this.passwordbox.UseSystemPasswordChar = true;
            // 
            // loginbox
            // 
            this.loginbox.Location = new System.Drawing.Point(275, 127);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(100, 20);
            this.loginbox.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.back2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(12, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 35);
            this.button2.TabIndex = 40;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hide
            // 
            this.hide.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.free_icon_eye_6107590;
            this.hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide.Location = new System.Drawing.Point(411, 157);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(24, 22);
            this.hide.TabIndex = 38;
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // unhide
            // 
            this.unhide.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.free_icon_open_eye_829117;
            this.unhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.unhide.Location = new System.Drawing.Point(381, 157);
            this.unhide.Name = "unhide";
            this.unhide.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.unhide.Size = new System.Drawing.Size(24, 22);
            this.unhide.TabIndex = 37;
            this.unhide.UseVisualStyleBackColor = true;
            this.unhide.Click += new System.EventHandler(this.unhide_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.unhide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.loginbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authorization_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button unhide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.Button button2;
    }
}