namespace Tris_Multiplayer_U
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            access1 = new Access();
            registration1 = new Registration();
            user_Info1 = new User_Info();
            connection1 = new Connection();
            game1 = new Game();
            SuspendLayout();
            // 
            // access1
            // 
            access1.Access_click = false;
            access1.Location = new System.Drawing.Point(215, 12);
            access1.Name = "access1";
            access1.Registration_click = false;
            access1.Size = new System.Drawing.Size(343, 383);
            access1.TabIndex = 0;
            // 
            // registration1
            // 
            registration1.Location = new System.Drawing.Point(215, 12);
            registration1.Name = "registration1";
            registration1.Registration_click = false;
            registration1.Size = new System.Drawing.Size(343, 394);
            registration1.TabIndex = 1;
            registration1.Visible = false;
            // 
            // user_Info1
            // 
            user_Info1.AutoSize = true;
            user_Info1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            user_Info1.Exit_click = false;
            user_Info1.Location = new System.Drawing.Point(541, 91);
            user_Info1.Name = "user_Info1";
            user_Info1.Size = new System.Drawing.Size(247, 347);
            user_Info1.TabIndex = 2;
            user_Info1.Visible = false;
            // 
            // connection1
            // 
            connection1.Connection_click = false;
            connection1.Location = new System.Drawing.Point(541, -26);
            connection1.Name = "connection1";
            connection1.Size = new System.Drawing.Size(247, 164);
            connection1.TabIndex = 3;
            connection1.Visible = false;
            // 
            // game1
            // 
            game1.Location = new System.Drawing.Point(82, 75);
            game1.Name = "game1";
            game1.Size = new System.Drawing.Size(320, 320);
            game1.TabIndex = 4;
            game1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(game1);
            Controls.Add(connection1);
            Controls.Add(registration1);
            Controls.Add(access1);
            Controls.Add(user_Info1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Access access1;
        private Registration registration1;
        private User_Info user_Info1;
        private Connection connection1;
        private Game game1;
    }
}
