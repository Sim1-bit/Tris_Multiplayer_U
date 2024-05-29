namespace Tris_Multiplayer_U
{
    partial class User_Info
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
            Username_l = new System.Windows.Forms.Label();
            name_l = new System.Windows.Forms.Label();
            Win_l = new System.Windows.Forms.Label();
            win_label = new System.Windows.Forms.Label();
            lose_labe = new System.Windows.Forms.Label();
            Lose_l = new System.Windows.Forms.Label();
            tie_label = new System.Windows.Forms.Label();
            Tie_l = new System.Windows.Forms.Label();
            Exit_b = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Username_l
            // 
            Username_l.AutoSize = true;
            Username_l.BackColor = System.Drawing.SystemColors.ControlLightLight;
            Username_l.Location = new System.Drawing.Point(72, 78);
            Username_l.Name = "Username_l";
            Username_l.Size = new System.Drawing.Size(104, 25);
            Username_l.TabIndex = 0;
            Username_l.Text = "USERNAME";
            // 
            // name_l
            // 
            name_l.AutoSize = true;
            name_l.Location = new System.Drawing.Point(92, 112);
            name_l.Name = "name_l";
            name_l.Size = new System.Drawing.Size(59, 25);
            name_l.TabIndex = 1;
            name_l.Text = "label1";
            // 
            // Win_l
            // 
            Win_l.AutoSize = true;
            Win_l.Location = new System.Drawing.Point(50, 172);
            Win_l.Name = "Win_l";
            Win_l.Size = new System.Drawing.Size(51, 25);
            Win_l.TabIndex = 2;
            Win_l.Text = "WIN:";
            // 
            // win_label
            // 
            win_label.AutoSize = true;
            win_label.Location = new System.Drawing.Point(126, 172);
            win_label.Name = "win_label";
            win_label.Size = new System.Drawing.Size(59, 25);
            win_label.TabIndex = 3;
            win_label.Text = "label2";
            // 
            // lose_labe
            // 
            lose_labe.AutoSize = true;
            lose_labe.Location = new System.Drawing.Point(126, 210);
            lose_labe.Name = "lose_labe";
            lose_labe.Size = new System.Drawing.Size(59, 25);
            lose_labe.TabIndex = 5;
            lose_labe.Text = "label3";
            // 
            // Lose_l
            // 
            Lose_l.AutoSize = true;
            Lose_l.Location = new System.Drawing.Point(50, 210);
            Lose_l.Name = "Lose_l";
            Lose_l.Size = new System.Drawing.Size(56, 25);
            Lose_l.TabIndex = 4;
            Lose_l.Text = "LOSE:";
            // 
            // tie_label
            // 
            tie_label.AutoSize = true;
            tie_label.Location = new System.Drawing.Point(126, 251);
            tie_label.Name = "tie_label";
            tie_label.Size = new System.Drawing.Size(59, 25);
            tie_label.TabIndex = 7;
            tie_label.Text = "label5";
            // 
            // Tie_l
            // 
            Tie_l.AutoSize = true;
            Tie_l.Location = new System.Drawing.Point(50, 251);
            Tie_l.Name = "Tie_l";
            Tie_l.Size = new System.Drawing.Size(39, 25);
            Tie_l.TabIndex = 6;
            Tie_l.Text = "TIE:";
            // 
            // Exit_b
            // 
            Exit_b.Location = new System.Drawing.Point(72, 293);
            Exit_b.Name = "Exit_b";
            Exit_b.Size = new System.Drawing.Size(112, 34);
            Exit_b.TabIndex = 8;
            Exit_b.Text = "Exit";
            Exit_b.UseVisualStyleBackColor = true;
            Exit_b.Click += Exit_b_Click;
            // 
            // User_Info
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            Controls.Add(Exit_b);
            Controls.Add(tie_label);
            Controls.Add(Tie_l);
            Controls.Add(lose_labe);
            Controls.Add(Lose_l);
            Controls.Add(win_label);
            Controls.Add(Win_l);
            Controls.Add(name_l);
            Controls.Add(Username_l);
            Name = "User_Info";
            Size = new System.Drawing.Size(235, 359);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Username_l;
        private System.Windows.Forms.Label name_l;
        private System.Windows.Forms.Label Win_l;
        private System.Windows.Forms.Label win_label;
        private System.Windows.Forms.Label lose_labe;
        private System.Windows.Forms.Label Lose_l;
        private System.Windows.Forms.Label tie_label;
        private System.Windows.Forms.Label Tie_l;
        private System.Windows.Forms.Button Exit_b;
    }
}
