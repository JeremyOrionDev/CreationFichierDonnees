namespace CreationFichierDonnees
{
    partial class FormCalcul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalcul));
            this.label1 = new System.Windows.Forms.Label();
            this.tBxDepart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBxQte = new System.Windows.Forms.TextBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.tBxFin = new System.Windows.Forms.TextBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tBxNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valeur départ";
            // 
            // tBxDepart
            // 
            this.tBxDepart.Location = new System.Drawing.Point(106, 53);
            this.tBxDepart.Name = "tBxDepart";
            this.tBxDepart.Size = new System.Drawing.Size(166, 20);
            this.tBxDepart.TabIndex = 1;
            this.tBxDepart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantité";
            // 
            // tBxQte
            // 
            this.tBxQte.Location = new System.Drawing.Point(106, 94);
            this.tBxQte.Name = "tBxQte";
            this.tBxQte.Size = new System.Drawing.Size(166, 20);
            this.tBxQte.TabIndex = 3;
            this.tBxQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Font = new System.Drawing.Font("DejaVu Serif Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculer.Location = new System.Drawing.Point(12, 133);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(75, 23);
            this.btnCalculer.TabIndex = 4;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // tBxFin
            // 
            this.tBxFin.Location = new System.Drawing.Point(106, 135);
            this.tBxFin.Name = "tBxFin";
            this.tBxFin.Size = new System.Drawing.Size(166, 20);
            this.tBxFin.TabIndex = 5;
            this.tBxFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCreer
            // 
            this.btnCreer.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreer.Location = new System.Drawing.Point(154, 176);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(118, 38);
            this.btnCreer.TabIndex = 6;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nom fichier";
            // 
            // tBxNom
            // 
            this.tBxNom.Location = new System.Drawing.Point(106, 12);
            this.tBxNom.Name = "tBxNom";
            this.tBxNom.Size = new System.Drawing.Size(166, 20);
            this.tBxNom.TabIndex = 8;
            // 
            // FormCalcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 258);
            this.Controls.Add(this.tBxNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.tBxFin);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.tBxQte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBxDepart);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalcul";
            this.Text = "Création d\'un fichier de données";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBxDepart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBxQte;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.TextBox tBxFin;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBxNom;
    }
}

