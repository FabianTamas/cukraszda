
namespace cukraszda
{
    partial class frmFo
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
            this.btnBeolvas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBeolvas
            // 
            this.btnBeolvas.Location = new System.Drawing.Point(13, 13);
            this.btnBeolvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBeolvas.Name = "btnBeolvas";
            this.btnBeolvas.Size = new System.Drawing.Size(105, 31);
            this.btnBeolvas.TabIndex = 0;
            this.btnBeolvas.Text = "Beolvasás";
            this.btnBeolvas.UseVisualStyleBackColor = true;
            this.btnBeolvas.Click += new System.EventHandler(this.btnBeolvas_Click);
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnBeolvas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cukrászda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBeolvas;
    }
}

