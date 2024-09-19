namespace WindowsFormsAppTestUserControl
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
            this.ucIdentification2 = new FControlLesMiens.UCIdentification();
            this.ucIdentification1 = new FControlLesMiens.UCIdentification();
            this.SuspendLayout();
            // 
            // ucIdentification2
            // 
            this.ucIdentification2.Location = new System.Drawing.Point(410, 295);
            this.ucIdentification2.MessageDErreur = null;
            this.ucIdentification2.Name = "ucIdentification2";
            this.ucIdentification2.Size = new System.Drawing.Size(260, 143);
            this.ucIdentification2.TabIndex = 1;
            // 
            // ucIdentification1
            // 
            this.ucIdentification1.Location = new System.Drawing.Point(109, 70);
            this.ucIdentification1.MessageDErreur = "L\'identifiant ou le mot de passe incorrect";
            this.ucIdentification1.Name = "ucIdentification1";
            this.ucIdentification1.Size = new System.Drawing.Size(260, 143);
            this.ucIdentification1.TabIndex = 0;
    
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucIdentification2);
            this.Controls.Add(this.ucIdentification1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private FControlLesMiens.UCIdentification ucIdentification1;
        private FControlLesMiens.UCIdentification ucIdentification2;
    }
}

