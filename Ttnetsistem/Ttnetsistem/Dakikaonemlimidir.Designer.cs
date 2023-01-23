
namespace Ttnetsistem
{
    partial class Dakikaonemlimidir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dakikaonemlimidir));
            this.telefonpaketi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // telefonpaketi
            // 
            this.telefonpaketi.BackColor = System.Drawing.Color.Chartreuse;
            this.telefonpaketi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.telefonpaketi.Location = new System.Drawing.Point(418, 315);
            this.telefonpaketi.Name = "telefonpaketi";
            this.telefonpaketi.Size = new System.Drawing.Size(238, 123);
            this.telefonpaketi.TabIndex = 1;
            this.telefonpaketi.Text = "EVET ÖNEMLİDİR";
            this.telefonpaketi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.telefonpaketi.UseVisualStyleBackColor = false;
            this.telefonpaketi.Click += new System.EventHandler(this.telefonpaketi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(47, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 123);
            this.button1.TabIndex = 2;
            this.button1.Text = "HAYIR ÖNEMLİ DEĞİLDİR";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "TELEFONLA KONUŞMAK SİZİN İÇİN ÖNEMLİ MİDİR? ";
            // 
            // Dakikaonemlimidir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telefonpaketi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dakikaonemlimidir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAKİKA ÖNEMLİ MİDİR?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button telefonpaketi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}