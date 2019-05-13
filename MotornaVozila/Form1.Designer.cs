namespace MotornaVozila
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
            this.cmdRead = new System.Windows.Forms.Button();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.cmdManytoOne = new System.Windows.Forms.Button();
            this.cmdOneToMany = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbZaposleni = new System.Windows.Forms.GroupBox();
            this.btnAzurirajZaposlenog = new System.Windows.Forms.Button();
            this.btnUkloniZaposlenog = new System.Windows.Forms.Button();
            this.btnDodajZaposlenog = new System.Windows.Forms.Button();
            this.btnPregledZaposleni = new System.Windows.Forms.Button();
            this.gbZaposleni.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdRead
            // 
            this.cmdRead.Location = new System.Drawing.Point(10, 194);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.Size = new System.Drawing.Size(271, 23);
            this.cmdRead.TabIndex = 0;
            this.cmdRead.Text = "Read Data";
            this.cmdRead.UseVisualStyleBackColor = true;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // cmdCreate
            // 
            this.cmdCreate.Location = new System.Drawing.Point(13, 223);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(271, 23);
            this.cmdCreate.TabIndex = 1;
            this.cmdCreate.Text = "Dodavanje nove prodavnice";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // cmdManytoOne
            // 
            this.cmdManytoOne.Location = new System.Drawing.Point(13, 252);
            this.cmdManytoOne.Name = "cmdManytoOne";
            this.cmdManytoOne.Size = new System.Drawing.Size(271, 23);
            this.cmdManytoOne.TabIndex = 2;
            this.cmdManytoOne.Text = "Veza Many-to-One";
            this.cmdManytoOne.UseVisualStyleBackColor = true;
            this.cmdManytoOne.Click += new System.EventHandler(this.cmdManytoOne_Click);
            // 
            // cmdOneToMany
            // 
            this.cmdOneToMany.Location = new System.Drawing.Point(10, 281);
            this.cmdOneToMany.Name = "cmdOneToMany";
            this.cmdOneToMany.Size = new System.Drawing.Size(271, 23);
            this.cmdOneToMany.TabIndex = 3;
            this.cmdOneToMany.Text = "Veza One-to-Many";
            this.cmdOneToMany.UseVisualStyleBackColor = true;
            this.cmdOneToMany.Click += new System.EventHandler(this.cmdOneToMany_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbZaposleni
            // 
            this.gbZaposleni.Controls.Add(this.btnAzurirajZaposlenog);
            this.gbZaposleni.Controls.Add(this.btnUkloniZaposlenog);
            this.gbZaposleni.Controls.Add(this.btnDodajZaposlenog);
            this.gbZaposleni.Controls.Add(this.btnPregledZaposleni);
            this.gbZaposleni.Location = new System.Drawing.Point(10, 13);
            this.gbZaposleni.Name = "gbZaposleni";
            this.gbZaposleni.Size = new System.Drawing.Size(131, 140);
            this.gbZaposleni.TabIndex = 5;
            this.gbZaposleni.TabStop = false;
            this.gbZaposleni.Text = "Zaposleni";
            // 
            // btnAzurirajZaposlenog
            // 
            this.btnAzurirajZaposlenog.Location = new System.Drawing.Point(6, 78);
            this.btnAzurirajZaposlenog.Name = "btnAzurirajZaposlenog";
            this.btnAzurirajZaposlenog.Size = new System.Drawing.Size(114, 23);
            this.btnAzurirajZaposlenog.TabIndex = 3;
            this.btnAzurirajZaposlenog.Text = "Azuriraj Zaposlenog";
            this.btnAzurirajZaposlenog.UseVisualStyleBackColor = true;
            this.btnAzurirajZaposlenog.Click += new System.EventHandler(this.btnAzurirajZaposlenog_Click);
            // 
            // btnUkloniZaposlenog
            // 
            this.btnUkloniZaposlenog.Location = new System.Drawing.Point(7, 107);
            this.btnUkloniZaposlenog.Name = "btnUkloniZaposlenog";
            this.btnUkloniZaposlenog.Size = new System.Drawing.Size(114, 23);
            this.btnUkloniZaposlenog.TabIndex = 2;
            this.btnUkloniZaposlenog.Text = "Ukloni Zaposlenog";
            this.btnUkloniZaposlenog.UseVisualStyleBackColor = true;
            this.btnUkloniZaposlenog.Click += new System.EventHandler(this.btnUkloniZaposlenog_Click);
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.Location = new System.Drawing.Point(7, 49);
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(114, 23);
            this.btnDodajZaposlenog.TabIndex = 1;
            this.btnDodajZaposlenog.Text = "Dodaj Zaposlenog";
            this.btnDodajZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenog.Click += new System.EventHandler(this.btnDodajZaposlenog_Click);
            // 
            // btnPregledZaposleni
            // 
            this.btnPregledZaposleni.Location = new System.Drawing.Point(7, 19);
            this.btnPregledZaposleni.Name = "btnPregledZaposleni";
            this.btnPregledZaposleni.Size = new System.Drawing.Size(114, 23);
            this.btnPregledZaposleni.TabIndex = 0;
            this.btnPregledZaposleni.Text = "Pregled Zaposlenog";
            this.btnPregledZaposleni.UseVisualStyleBackColor = true;
            this.btnPregledZaposleni.Click += new System.EventHandler(this.btnPregledZaposleni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 345);
            this.Controls.Add(this.gbZaposleni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdOneToMany);
            this.Controls.Add(this.cmdManytoOne);
            this.Controls.Add(this.cmdCreate);
            this.Controls.Add(this.cmdRead);
            this.Name = "Form1";
            this.Text = "Motorna Vozila";
            this.gbZaposleni.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRead;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.Button cmdManytoOne;
        private System.Windows.Forms.Button cmdOneToMany;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbZaposleni;
        private System.Windows.Forms.Button btnPregledZaposleni;
        private System.Windows.Forms.Button btnDodajZaposlenog;
        private System.Windows.Forms.Button btnUkloniZaposlenog;
        private System.Windows.Forms.Button btnAzurirajZaposlenog;
    }
}

