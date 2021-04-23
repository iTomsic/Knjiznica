
namespace Knjiznica.Forme
{
    partial class Knjižnica
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Posudi = new System.Windows.Forms.Button();
            this.Izmjeni = new System.Windows.Forms.Button();
            this.Vrati = new System.Windows.Forms.Button();
            this.Učenici = new System.Windows.Forms.Button();
            this.Knjige = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(618, 287);
            this.textBox1.TabIndex = 0;
            // 
            // Posudi
            // 
            this.Posudi.Location = new System.Drawing.Point(652, 87);
            this.Posudi.Name = "Posudi";
            this.Posudi.Size = new System.Drawing.Size(100, 39);
            this.Posudi.TabIndex = 1;
            this.Posudi.Text = "Posudi";
            this.Posudi.UseVisualStyleBackColor = true;
            this.Posudi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Izmjeni
            // 
            this.Izmjeni.Location = new System.Drawing.Point(652, 146);
            this.Izmjeni.Name = "Izmjeni";
            this.Izmjeni.Size = new System.Drawing.Size(100, 37);
            this.Izmjeni.TabIndex = 2;
            this.Izmjeni.Text = "Izmjeni";
            this.Izmjeni.UseVisualStyleBackColor = true;
            // 
            // Vrati
            // 
            this.Vrati.Location = new System.Drawing.Point(652, 213);
            this.Vrati.Name = "Vrati";
            this.Vrati.Size = new System.Drawing.Size(100, 37);
            this.Vrati.TabIndex = 3;
            this.Vrati.Text = "Vrati";
            this.Vrati.UseVisualStyleBackColor = true;
            // 
            // Učenici
            // 
            this.Učenici.Location = new System.Drawing.Point(123, 53);
            this.Učenici.Name = "Učenici";
            this.Učenici.Size = new System.Drawing.Size(83, 28);
            this.Učenici.TabIndex = 4;
            this.Učenici.Text = "Učenici";
            this.Učenici.UseVisualStyleBackColor = true;
            // 
            // Knjige
            // 
            this.Knjige.Location = new System.Drawing.Point(212, 53);
            this.Knjige.Name = "Knjige";
            this.Knjige.Size = new System.Drawing.Size(83, 28);
            this.Knjige.TabIndex = 5;
            this.Knjige.Text = "Knjige";
            this.Knjige.UseVisualStyleBackColor = true;
            this.Knjige.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Posuđene knjige:";
            // 
            // Knjižnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Knjige);
            this.Controls.Add(this.Učenici);
            this.Controls.Add(this.Vrati);
            this.Controls.Add(this.Izmjeni);
            this.Controls.Add(this.Posudi);
            this.Controls.Add(this.textBox1);
            this.Name = "Knjižnica";
            this.Text = "Knjiznica";
            this.Load += new System.EventHandler(this.Knjižnica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Posudi;
        private System.Windows.Forms.Button Izmjeni;
        private System.Windows.Forms.Button Vrati;
        private System.Windows.Forms.Button Učenici;
        private System.Windows.Forms.Button Knjige;
        private System.Windows.Forms.Label label1;
    }
}