﻿
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
            this.btnElso = new System.Windows.Forms.Button();
            this.btnMasodik = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.lbKiiras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBeolvas
            // 
            this.btnBeolvas.Location = new System.Drawing.Point(13, 30);
            this.btnBeolvas.Margin = new System.Windows.Forms.Padding(4);
            this.btnBeolvas.Name = "btnBeolvas";
            this.btnBeolvas.Size = new System.Drawing.Size(105, 31);
            this.btnBeolvas.TabIndex = 0;
            this.btnBeolvas.Text = "Beolvasás";
            this.btnBeolvas.UseVisualStyleBackColor = true;
            this.btnBeolvas.Click += new System.EventHandler(this.btnBeolvas_Click);
            // 
            // btnElso
            // 
            this.btnElso.Location = new System.Drawing.Point(13, 68);
            this.btnElso.Name = "btnElso";
            this.btnElso.Size = new System.Drawing.Size(105, 31);
            this.btnElso.TabIndex = 1;
            this.btnElso.Text = "1. feladat";
            this.btnElso.UseVisualStyleBackColor = true;
            this.btnElso.Click += new System.EventHandler(this.btnElso_Click);
            // 
            // btnMasodik
            // 
            this.btnMasodik.Location = new System.Drawing.Point(12, 105);
            this.btnMasodik.Name = "btnMasodik";
            this.btnMasodik.Size = new System.Drawing.Size(105, 31);
            this.btnMasodik.TabIndex = 2;
            this.btnMasodik.Text = "2. feladat";
            this.btnMasodik.UseVisualStyleBackColor = true;
            this.btnMasodik.Click += new System.EventHandler(this.btnMasodik_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 253);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 31);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 290);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 31);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // lbKiiras
            // 
            this.lbKiiras.FormattingEnabled = true;
            this.lbKiiras.ItemHeight = 16;
            this.lbKiiras.Location = new System.Drawing.Point(195, 35);
            this.lbKiiras.Name = "lbKiiras";
            this.lbKiiras.Size = new System.Drawing.Size(358, 276);
            this.lbKiiras.TabIndex = 8;
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lbKiiras);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMasodik);
            this.Controls.Add(this.btnElso);
            this.Controls.Add(this.btnBeolvas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cukrászda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBeolvas;
        private System.Windows.Forms.Button btnElso;
        private System.Windows.Forms.Button btnMasodik;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox lbKiiras;
    }
}

