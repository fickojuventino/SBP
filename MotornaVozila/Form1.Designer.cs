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
            this.SuspendLayout();
            // 
            // cmdRead
            // 
            this.cmdRead.Location = new System.Drawing.Point(13, 13);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.Size = new System.Drawing.Size(271, 23);
            this.cmdRead.TabIndex = 0;
            this.cmdRead.Text = "Read Data";
            this.cmdRead.UseVisualStyleBackColor = true;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // cmdCreate
            // 
            this.cmdCreate.Location = new System.Drawing.Point(13, 43);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(271, 23);
            this.cmdCreate.TabIndex = 1;
            this.cmdCreate.Text = "Dodavanje nove prodavnice";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // cmdManytoOne
            // 
            this.cmdManytoOne.Location = new System.Drawing.Point(13, 73);
            this.cmdManytoOne.Name = "cmdManytoOne";
            this.cmdManytoOne.Size = new System.Drawing.Size(271, 23);
            this.cmdManytoOne.TabIndex = 2;
            this.cmdManytoOne.Text = "Veza Many-to-One";
            this.cmdManytoOne.UseVisualStyleBackColor = true;
            this.cmdManytoOne.Click += new System.EventHandler(this.cmdManytoOne_Click);
            // 
            // cmdOneToMany
            // 
            this.cmdOneToMany.Location = new System.Drawing.Point(13, 103);
            this.cmdOneToMany.Name = "cmdOneToMany";
            this.cmdOneToMany.Size = new System.Drawing.Size(271, 23);
            this.cmdOneToMany.TabIndex = 3;
            this.cmdOneToMany.Text = "Veza One-to-Many";
            this.cmdOneToMany.UseVisualStyleBackColor = true;
            this.cmdOneToMany.Click += new System.EventHandler(this.cmdOneToMany_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 345);
            this.Controls.Add(this.cmdOneToMany);
            this.Controls.Add(this.cmdManytoOne);
            this.Controls.Add(this.cmdCreate);
            this.Controls.Add(this.cmdRead);
            this.Name = "Form1";
            this.Text = "Motorna Vozila";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRead;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.Button cmdManytoOne;
        private System.Windows.Forms.Button cmdOneToMany;
    }
}

