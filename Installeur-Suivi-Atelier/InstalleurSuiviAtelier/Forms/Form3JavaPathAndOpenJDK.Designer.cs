﻿namespace InstalleurSuiviAtelier.Forms
{
    partial class Form3JavaPathAndOpenJDK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3JavaPathAndOpenJDK));
            this.buttonParcourir = new System.Windows.Forms.Button();
            this.labelJAVA_HOME = new System.Windows.Forms.Label();
            this.textBoxJAVA_HOME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInfoEtape = new System.Windows.Forms.Label();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonParcourir
            // 
            this.buttonParcourir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParcourir.Location = new System.Drawing.Point(378, 174);
            this.buttonParcourir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonParcourir.Name = "buttonParcourir";
            this.buttonParcourir.Size = new System.Drawing.Size(64, 25);
            this.buttonParcourir.TabIndex = 7;
            this.buttonParcourir.Text = "Parcourir";
            this.buttonParcourir.UseVisualStyleBackColor = true;
            // 
            // labelJAVA_HOME
            // 
            this.labelJAVA_HOME.AutoSize = true;
            this.labelJAVA_HOME.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJAVA_HOME.Location = new System.Drawing.Point(152, 155);
            this.labelJAVA_HOME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJAVA_HOME.Name = "labelJAVA_HOME";
            this.labelJAVA_HOME.Size = new System.Drawing.Size(145, 15);
            this.labelJAVA_HOME.TabIndex = 6;
            this.labelJAVA_HOME.Text = "Répertoire principal JAVA :";
            // 
            // textBoxJAVA_HOME
            // 
            this.textBoxJAVA_HOME.Location = new System.Drawing.Point(154, 177);
            this.textBoxJAVA_HOME.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxJAVA_HOME.Name = "textBoxJAVA_HOME";
            this.textBoxJAVA_HOME.Size = new System.Drawing.Size(220, 20);
            this.textBoxJAVA_HOME.TabIndex = 5;
            this.textBoxJAVA_HOME.Text = "C:\\Program Files\\Java";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(151, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 63);
            this.label1.TabIndex = 9;
            // 
            // labelInfoEtape
            // 
            this.labelInfoEtape.AutoSize = true;
            this.labelInfoEtape.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelInfoEtape.Location = new System.Drawing.Point(148, 9);
            this.labelInfoEtape.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoEtape.Name = "labelInfoEtape";
            this.labelInfoEtape.Size = new System.Drawing.Size(321, 35);
            this.labelInfoEtape.TabIndex = 12;
            this.labelInfoEtape.Text = "Installation du JDK Zulu";
            // 
            // buttonSkip
            // 
            this.buttonSkip.Enabled = false;
            this.buttonSkip.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkip.Location = new System.Drawing.Point(248, 214);
            this.buttonSkip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(75, 23);
            this.buttonSkip.TabIndex = 13;
            this.buttonSkip.Text = "Passer >";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "L\'application Suivi Atelier fonctionne à l\'aide \r\ndu JDK open source zulu";
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(240, 323);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(75, 23);
            this.buttonPrecedent.TabIndex = 20;
            this.buttonPrecedent.Text = "< Précédent";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(317, 323);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(75, 23);
            this.buttonSuivant.TabIndex = 19;
            this.buttonSuivant.Text = "Suivant >";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.ButtonSuivant_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(402, 323);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 18;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-6, -5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(141, 367);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // Form3JavaPathAndOpenJDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 358);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.labelInfoEtape);
            this.Controls.Add(this.buttonParcourir);
            this.Controls.Add(this.labelJAVA_HOME);
            this.Controls.Add(this.textBoxJAVA_HOME);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(505, 397);
            this.MinimumSize = new System.Drawing.Size(505, 397);
            this.Name = "Form3JavaPathAndOpenJDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4CAD - Installeur suivi atelier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonParcourir;
        private System.Windows.Forms.Label labelJAVA_HOME;
        private System.Windows.Forms.TextBox textBoxJAVA_HOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfoEtape;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}