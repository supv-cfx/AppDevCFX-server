namespace ServeurManagement
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnLancerServeur;
        private System.Windows.Forms.Button btnSupprimerCache;
        private System.Windows.Forms.Button btnLancerFivem;

        private void InitializeComponent()
        {
            this.btnLancerServeur = new System.Windows.Forms.Button();
            this.btnSupprimerCache = new System.Windows.Forms.Button();
            this.btnLancerFivem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLancerServeur
            // 
            this.btnLancerServeur.Location = new System.Drawing.Point(50, 50);
            this.btnLancerServeur.Name = "btnLancerServeur";
            this.btnLancerServeur.Size = new System.Drawing.Size(150, 30);
            this.btnLancerServeur.TabIndex = 0;
            this.btnLancerServeur.Text = "Lancer le serveur";
            this.btnLancerServeur.UseVisualStyleBackColor = true;
            this.btnLancerServeur.Click += new System.EventHandler(this.btnLancerServeur_Click);
            // 
            // btnSupprimerCache
            // 
            this.btnSupprimerCache.Location = new System.Drawing.Point(50, 100);
            this.btnSupprimerCache.Name = "btnSupprimerCache";
            this.btnSupprimerCache.Size = new System.Drawing.Size(150, 30);
            this.btnSupprimerCache.TabIndex = 1;
            this.btnSupprimerCache.Text = "Supprimer le cache";
            this.btnSupprimerCache.UseVisualStyleBackColor = true;
            this.btnSupprimerCache.Click += new System.EventHandler(this.btnSupprimerCache_Click);
            // 
            // btnLancerFivem
            // 
            this.btnLancerFivem.Location = new System.Drawing.Point(50, 150);
            this.btnLancerFivem.Name = "btnLancerFivem";
            this.btnLancerFivem.Size = new System.Drawing.Size(150, 30);
            this.btnLancerFivem.TabIndex = 2;
            this.btnLancerFivem.Text = "Lancer Fivem";
            this.btnLancerFivem.UseVisualStyleBackColor = true;
            this.btnLancerFivem.Click += new System.EventHandler(this.btnLancerFivem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 246);
            this.Controls.Add(this.btnLancerFivem);
            this.Controls.Add(this.btnSupprimerCache);
            this.Controls.Add(this.btnLancerServeur);
            this.Name = "Form1";
            this.Text = "Serveur Management";
            this.ResumeLayout(false);
        }
    }
}
