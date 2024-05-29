namespace Tris_Multiplayer_U
{
    partial class Connection
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
            name_tb = new System.Windows.Forms.TextBox();
            connection_b = new System.Windows.Forms.Button();
            name_l = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // name_tb
            // 
            name_tb.Location = new System.Drawing.Point(47, 81);
            name_tb.Name = "name_tb";
            name_tb.Size = new System.Drawing.Size(150, 31);
            name_tb.TabIndex = 0;
            // 
            // connection_b
            // 
            connection_b.Location = new System.Drawing.Point(67, 118);
            connection_b.Name = "connection_b";
            connection_b.Size = new System.Drawing.Size(112, 34);
            connection_b.TabIndex = 1;
            connection_b.Text = "Connection";
            connection_b.UseVisualStyleBackColor = true;
            connection_b.Click += connection_b_Click;
            // 
            // name_l
            // 
            name_l.AutoSize = true;
            name_l.Location = new System.Drawing.Point(49, 41);
            name_l.Name = "name_l";
            name_l.Size = new System.Drawing.Size(111, 25);
            name_l.TabIndex = 2;
            name_l.Text = "Player Name";
            // 
            // Connection
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(name_l);
            Controls.Add(connection_b);
            Controls.Add(name_tb);
            Name = "Connection";
            Size = new System.Drawing.Size(235, 185);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Button connection_b;
        private System.Windows.Forms.Label name_l;
    }
}
