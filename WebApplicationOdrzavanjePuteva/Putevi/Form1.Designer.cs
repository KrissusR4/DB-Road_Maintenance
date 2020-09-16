namespace Putevi
{
    partial class Form1
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
            this.btnDodajIzvrsioca = new System.Windows.Forms.Button();
            this.btnUcitajGradiliste = new System.Windows.Forms.Button();
            this.btnOneToMany = new System.Windows.Forms.Button();
            this.btnManyToOne = new System.Windows.Forms.Button();
            this.btnDuzi = new System.Windows.Forms.Button();
            this.Preduzece = new System.Windows.Forms.Button();
            this.btnVozilo = new System.Windows.Forms.Button();
            this.btnIzvrsilac = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVratiSaradnike = new System.Windows.Forms.Button();
            this.btnAngazovanjaTer = new System.Windows.Forms.Button();
            this.btnVratiAngazovaneIzvrsioce = new System.Windows.Forms.Button();
            this.btnVratiDuzenja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodajIzvrsioca
            // 
            this.btnDodajIzvrsioca.Location = new System.Drawing.Point(13, 47);
            this.btnDodajIzvrsioca.Name = "btnDodajIzvrsioca";
            this.btnDodajIzvrsioca.Size = new System.Drawing.Size(275, 31);
            this.btnDodajIzvrsioca.TabIndex = 1;
            this.btnDodajIzvrsioca.Text = "Dodaj Izvrsioca";
            this.btnDodajIzvrsioca.UseVisualStyleBackColor = true;
            this.btnDodajIzvrsioca.Click += new System.EventHandler(this.btnDodajIzvrsioca_Click);
            // 
            // btnUcitajGradiliste
            // 
            this.btnUcitajGradiliste.Location = new System.Drawing.Point(13, 12);
            this.btnUcitajGradiliste.Name = "btnUcitajGradiliste";
            this.btnUcitajGradiliste.Size = new System.Drawing.Size(275, 29);
            this.btnUcitajGradiliste.TabIndex = 2;
            this.btnUcitajGradiliste.Text = "Ucitaj gradilista";
            this.btnUcitajGradiliste.UseVisualStyleBackColor = true;
            this.btnUcitajGradiliste.Click += new System.EventHandler(this.btnUcitajGradiliste_Click);
            // 
            // btnOneToMany
            // 
            this.btnOneToMany.Location = new System.Drawing.Point(13, 85);
            this.btnOneToMany.Name = "btnOneToMany";
            this.btnOneToMany.Size = new System.Drawing.Size(275, 35);
            this.btnOneToMany.TabIndex = 3;
            this.btnOneToMany.Text = "One to Many";
            this.btnOneToMany.UseVisualStyleBackColor = true;
            this.btnOneToMany.Click += new System.EventHandler(this.btnOneToMany_Click);
            // 
            // btnManyToOne
            // 
            this.btnManyToOne.Location = new System.Drawing.Point(12, 126);
            this.btnManyToOne.Name = "btnManyToOne";
            this.btnManyToOne.Size = new System.Drawing.Size(276, 38);
            this.btnManyToOne.TabIndex = 4;
            this.btnManyToOne.Text = "Many to One";
            this.btnManyToOne.UseVisualStyleBackColor = true;
            this.btnManyToOne.Click += new System.EventHandler(this.btnManyToOne_Click);
            // 
            // btnDuzi
            // 
            this.btnDuzi.Location = new System.Drawing.Point(12, 171);
            this.btnDuzi.Name = "btnDuzi";
            this.btnDuzi.Size = new System.Drawing.Size(276, 45);
            this.btnDuzi.TabIndex = 5;
            this.btnDuzi.Text = "Dodaj Duzenje";
            this.btnDuzi.UseVisualStyleBackColor = true;
            this.btnDuzi.Click += new System.EventHandler(this.btnDuzi_Click);
            // 
            // Preduzece
            // 
            this.Preduzece.Location = new System.Drawing.Point(13, 222);
            this.Preduzece.Name = "Preduzece";
            this.Preduzece.Size = new System.Drawing.Size(275, 39);
            this.Preduzece.TabIndex = 6;
            this.Preduzece.Text = "Vrati Preduzece";
            this.Preduzece.UseVisualStyleBackColor = true;
            this.Preduzece.Click += new System.EventHandler(this.Preduzece_Click);
            // 
            // btnVozilo
            // 
            this.btnVozilo.Location = new System.Drawing.Point(12, 268);
            this.btnVozilo.Name = "btnVozilo";
            this.btnVozilo.Size = new System.Drawing.Size(276, 39);
            this.btnVozilo.TabIndex = 7;
            this.btnVozilo.Text = "Vrati vozilo";
            this.btnVozilo.UseVisualStyleBackColor = true;
            this.btnVozilo.Click += new System.EventHandler(this.btnVozilo_Click);
            // 
            // btnIzvrsilac
            // 
            this.btnIzvrsilac.Location = new System.Drawing.Point(13, 314);
            this.btnIzvrsilac.Name = "btnIzvrsilac";
            this.btnIzvrsilac.Size = new System.Drawing.Size(275, 40);
            this.btnIzvrsilac.TabIndex = 8;
            this.btnIzvrsilac.Text = "Vrati Izvrsioca";
            this.btnIzvrsilac.UseVisualStyleBackColor = true;
            this.btnIzvrsilac.Click += new System.EventHandler(this.btnIzvrsilac_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Vrati vozila izvrsioca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVratiSaradnike
            // 
            this.btnVratiSaradnike.Location = new System.Drawing.Point(12, 413);
            this.btnVratiSaradnike.Name = "btnVratiSaradnike";
            this.btnVratiSaradnike.Size = new System.Drawing.Size(276, 46);
            this.btnVratiSaradnike.TabIndex = 10;
            this.btnVratiSaradnike.Text = "Vrati Saradnike";
            this.btnVratiSaradnike.UseVisualStyleBackColor = true;
            this.btnVratiSaradnike.Click += new System.EventHandler(this.btnVratiSaradnike_Click);
            // 
            // btnAngazovanjaTer
            // 
            this.btnAngazovanjaTer.Location = new System.Drawing.Point(295, 12);
            this.btnAngazovanjaTer.Name = "btnAngazovanjaTer";
            this.btnAngazovanjaTer.Size = new System.Drawing.Size(282, 28);
            this.btnAngazovanjaTer.TabIndex = 11;
            this.btnAngazovanjaTer.Text = "Angazovana Vozila Na Deonici";
            this.btnAngazovanjaTer.UseVisualStyleBackColor = true;
            this.btnAngazovanjaTer.Click += new System.EventHandler(this.btnAngazovanjaTer_Click);
            // 
            // btnVratiAngazovaneIzvrsioce
            // 
            this.btnVratiAngazovaneIzvrsioce.Location = new System.Drawing.Point(295, 47);
            this.btnVratiAngazovaneIzvrsioce.Name = "btnVratiAngazovaneIzvrsioce";
            this.btnVratiAngazovaneIzvrsioce.Size = new System.Drawing.Size(282, 31);
            this.btnVratiAngazovaneIzvrsioce.TabIndex = 12;
            this.btnVratiAngazovaneIzvrsioce.Text = "Izvrsioci koji rade na deonici";
            this.btnVratiAngazovaneIzvrsioce.UseVisualStyleBackColor = true;
            this.btnVratiAngazovaneIzvrsioce.Click += new System.EventHandler(this.btnVratiAngazovaneIzvrsioce_Click);
            // 
            // btnVratiDuzenja
            // 
            this.btnVratiDuzenja.Location = new System.Drawing.Point(295, 85);
            this.btnVratiDuzenja.Name = "btnVratiDuzenja";
            this.btnVratiDuzenja.Size = new System.Drawing.Size(282, 34);
            this.btnVratiDuzenja.TabIndex = 13;
            this.btnVratiDuzenja.Text = "Vrati Uprvljanja";
            this.btnVratiDuzenja.UseVisualStyleBackColor = true;
            this.btnVratiDuzenja.Click += new System.EventHandler(this.btnVratiDuzenja_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 470);
            this.Controls.Add(this.btnVratiDuzenja);
            this.Controls.Add(this.btnVratiAngazovaneIzvrsioce);
            this.Controls.Add(this.btnAngazovanjaTer);
            this.Controls.Add(this.btnVratiSaradnike);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzvrsilac);
            this.Controls.Add(this.btnVozilo);
            this.Controls.Add(this.Preduzece);
            this.Controls.Add(this.btnDuzi);
            this.Controls.Add(this.btnManyToOne);
            this.Controls.Add(this.btnOneToMany);
            this.Controls.Add(this.btnUcitajGradiliste);
            this.Controls.Add(this.btnDodajIzvrsioca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodajIzvrsioca;
        private System.Windows.Forms.Button btnUcitajGradiliste;
        private System.Windows.Forms.Button btnOneToMany;
        private System.Windows.Forms.Button btnManyToOne;
        private System.Windows.Forms.Button btnDuzi;
        private System.Windows.Forms.Button Preduzece;
        private System.Windows.Forms.Button btnVozilo;
        private System.Windows.Forms.Button btnIzvrsilac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVratiSaradnike;
        private System.Windows.Forms.Button btnAngazovanjaTer;
        private System.Windows.Forms.Button btnVratiAngazovaneIzvrsioce;
        private System.Windows.Forms.Button btnVratiDuzenja;
    }
}

