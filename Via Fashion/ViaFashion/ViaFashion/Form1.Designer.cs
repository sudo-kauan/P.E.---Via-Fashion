namespace ViaFashion
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_helloworld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_helloworld
            // 
            this.lbl_helloworld.AutoSize = true;
            this.lbl_helloworld.Location = new System.Drawing.Point(227, 99);
            this.lbl_helloworld.Name = "lbl_helloworld";
            this.lbl_helloworld.Size = new System.Drawing.Size(62, 13);
            this.lbl_helloworld.TabIndex = 0;
            this.lbl_helloworld.Text = "Hello World";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 233);
            this.Controls.Add(this.lbl_helloworld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_helloworld;
    }
}

