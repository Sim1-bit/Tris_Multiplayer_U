namespace Tris_Multiplayer_U
{
    partial class Registration
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            Registration_b = new System.Windows.Forms.Button();
            Password_tp = new System.Windows.Forms.TextBox();
            Password_label = new System.Windows.Forms.Label();
            Username_tb = new System.Windows.Forms.TextBox();
            Username_label = new System.Windows.Forms.Label();
            Password_tp1 = new System.Windows.Forms.TextBox();
            Password_label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Registration_b
            // 
            Registration_b.Location = new System.Drawing.Point(100, 307);
            Registration_b.Name = "Registration_b";
            Registration_b.Size = new System.Drawing.Size(120, 34);
            Registration_b.TabIndex = 9;
            Registration_b.Text = "Registration";
            Registration_b.UseVisualStyleBackColor = true;
            Registration_b.Click += Registration_b_Click;
            // 
            // Password_tp
            // 
            Password_tp.Location = new System.Drawing.Point(44, 200);
            Password_tp.Name = "Password_tp";
            Password_tp.Size = new System.Drawing.Size(250, 31);
            Password_tp.TabIndex = 8;
            // 
            // Password_label
            // 
            Password_label.AutoSize = true;
            Password_label.Location = new System.Drawing.Point(44, 172);
            Password_label.Name = "Password_label";
            Password_label.Size = new System.Drawing.Size(108, 25);
            Password_label.TabIndex = 7;
            Password_label.Text = "PASSWORD";
            // 
            // Username_tb
            // 
            Username_tb.Location = new System.Drawing.Point(44, 95);
            Username_tb.Name = "Username_tb";
            Username_tb.Size = new System.Drawing.Size(250, 31);
            Username_tb.TabIndex = 6;
            // 
            // Username_label
            // 
            Username_label.AutoSize = true;
            Username_label.Location = new System.Drawing.Point(44, 67);
            Username_label.Name = "Username_label";
            Username_label.Size = new System.Drawing.Size(104, 25);
            Username_label.TabIndex = 5;
            Username_label.Text = "USERNAME";
            // 
            // Password_tp1
            // 
            Password_tp1.Location = new System.Drawing.Point(44, 270);
            Password_tp1.Name = "Password_tp1";
            Password_tp1.Size = new System.Drawing.Size(250, 31);
            Password_tp1.TabIndex = 11;
            // 
            // Password_label1
            // 
            Password_label1.AutoSize = true;
            Password_label1.Location = new System.Drawing.Point(44, 242);
            Password_label1.Name = "Password_label1";
            Password_label1.Size = new System.Drawing.Size(108, 25);
            Password_label1.TabIndex = 10;
            Password_label1.Text = "PASSWORD";
            // 
            // Registration
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(Password_tp1);
            Controls.Add(Password_label1);
            Controls.Add(Registration_b);
            Controls.Add(Password_tp);
            Controls.Add(Password_label);
            Controls.Add(Username_tb);
            Controls.Add(Username_label);
            Name = "Registration";
            Size = new System.Drawing.Size(339, 371);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Registration_b;
        private System.Windows.Forms.TextBox Password_tp;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Username_tb;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.TextBox Password_tp1;
        private System.Windows.Forms.Label Password_label1;
    }
}
