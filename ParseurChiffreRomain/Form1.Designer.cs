namespace ParseurChiffreRomain
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textChiffreRomain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConvertisseur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textChiffreRomain
            // 
            this.textChiffreRomain.Location = new System.Drawing.Point(100, 33);
            this.textChiffreRomain.Name = "textChiffreRomain";
            this.textChiffreRomain.Size = new System.Drawing.Size(141, 20);
            this.textChiffreRomain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chiffre Romain :";
            // 
            // BtnConvertisseur
            // 
            this.BtnConvertisseur.Location = new System.Drawing.Point(263, 33);
            this.BtnConvertisseur.Name = "BtnConvertisseur";
            this.BtnConvertisseur.Size = new System.Drawing.Size(89, 23);
            this.BtnConvertisseur.TabIndex = 2;
            this.BtnConvertisseur.Text = "Convertisseur";
            this.BtnConvertisseur.UseVisualStyleBackColor = true;
            this.BtnConvertisseur.Click += new System.EventHandler(this.BtnConvertisseur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultat :";
            // 
            // resultat
            // 
            this.resultat.AutoSize = true;
            this.resultat.Location = new System.Drawing.Point(165, 84);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(0, 13);
            this.resultat.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 131);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnConvertisseur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textChiffreRomain);
            this.Name = "Form1";
            this.Text = "Parseur chiffre Romain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textChiffreRomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConvertisseur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultat;
    }
}

