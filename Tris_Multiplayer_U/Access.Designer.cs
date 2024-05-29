namespace Tris_Multiplayer_U
{
    partial class Access
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
            Username_label = new System.Windows.Forms.Label();
            Username_tb = new System.Windows.Forms.TextBox();
            Password_tp = new System.Windows.Forms.TextBox();
            Password_label = new System.Windows.Forms.Label();
            Access_b = new System.Windows.Forms.Button();
            Registration_b = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Username_label
            // 
            Username_label.AutoSize = true;
            Username_label.Location = new System.Drawing.Point(45, 81);
            Username_label.Name = "Username_label";
            Username_label.Size = new System.Drawing.Size(104, 25);
            Username_label.TabIndex = 0;
            Username_label.Text = "USERNAME";
            // 
            // Username_tb
            // 
            Username_tb.Location = new System.Drawing.Point(45, 109);
            Username_tb.Name = "Username_tb";
            Username_tb.Size = new System.Drawing.Size(250, 31);
            Username_tb.TabIndex = 1;
            // 
            // Password_tp
            // 
            Password_tp.Location = new System.Drawing.Point(45, 214);
            Password_tp.Name = "Password_tp";
            Password_tp.Size = new System.Drawing.Size(250, 31);
            Password_tp.TabIndex = 3;
            // 
            // Password_label
            // 
            Password_label.AutoSize = true;
            Password_label.Location = new System.Drawing.Point(45, 186);
            Password_label.Name = "Password_label";
            Password_label.Size = new System.Drawing.Size(108, 25);
            Password_label.TabIndex = 2;
            Password_label.Text = "PASSWORD";
            // 
            // Access_b
            // 
            Access_b.Location = new System.Drawing.Point(104, 284);
            Access_b.Name = "Access_b";
            Access_b.Size = new System.Drawing.Size(112, 34);
            Access_b.TabIndex = 4;
            Access_b.Text = "Access";
            Access_b.UseVisualStyleBackColor = true;
            Access_b.Click += Access_b_Click;
            // 
            // Registration_b
            // 
            Registration_b.Location = new System.Drawing.Point(100, 324);
            Registration_b.Name = "Registration_b";
            Registration_b.Size = new System.Drawing.Size(120, 34);
            Registration_b.TabIndex = 10;
            Registration_b.Text = "Registration";
            Registration_b.UseVisualStyleBackColor = true;
            Registration_b.Click += Registration_b_Click;
            // 
            // Access
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(Registration_b);
            Controls.Add(Access_b);
            Controls.Add(Password_tp);
            Controls.Add(Password_label);
            Controls.Add(Username_tb);
            Controls.Add(Username_label);
            Name = "Access";
            Size = new System.Drawing.Size(339, 371);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.TextBox Username_tb;
        private System.Windows.Forms.TextBox Password_tp;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button Access_b;
        private System.Windows.Forms.Button Registration_b;
    }
}
