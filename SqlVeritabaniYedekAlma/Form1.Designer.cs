namespace SqlVeritabaniYedekAlma
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
            this.btnKopyala = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSourceDb = new System.Windows.Forms.TextBox();
            this.txtSourceTable = new System.Windows.Forms.TextBox();
            this.txtTargetDb = new System.Windows.Forms.TextBox();
            this.txtTargetTable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKopyala
            // 
            this.btnKopyala.Location = new System.Drawing.Point(179, 141);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(75, 23);
            this.btnKopyala.TabIndex = 0;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kopyalanacak Veritabanı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kopyalanacak Tablo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hedef Veritabanı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hedef Tablo";
            // 
            // txtSourceDb
            // 
            this.txtSourceDb.Location = new System.Drawing.Point(154, 11);
            this.txtSourceDb.Name = "txtSourceDb";
            this.txtSourceDb.Size = new System.Drawing.Size(100, 20);
            this.txtSourceDb.TabIndex = 5;
            // 
            // txtSourceTable
            // 
            this.txtSourceTable.Location = new System.Drawing.Point(154, 37);
            this.txtSourceTable.Name = "txtSourceTable";
            this.txtSourceTable.Size = new System.Drawing.Size(100, 20);
            this.txtSourceTable.TabIndex = 6;
            // 
            // txtTargetDb
            // 
            this.txtTargetDb.Location = new System.Drawing.Point(154, 63);
            this.txtTargetDb.Name = "txtTargetDb";
            this.txtTargetDb.Size = new System.Drawing.Size(100, 20);
            this.txtTargetDb.TabIndex = 7;
            // 
            // txtTargetTable
            // 
            this.txtTargetTable.Location = new System.Drawing.Point(154, 87);
            this.txtTargetTable.Name = "txtTargetTable";
            this.txtTargetTable.Size = new System.Drawing.Size(100, 20);
            this.txtTargetTable.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 301);
            this.Controls.Add(this.txtTargetTable);
            this.Controls.Add(this.txtTargetDb);
            this.Controls.Add(this.txtSourceTable);
            this.Controls.Add(this.txtSourceDb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKopyala);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSourceDb;
        private System.Windows.Forms.TextBox txtSourceTable;
        private System.Windows.Forms.TextBox txtTargetDb;
        private System.Windows.Forms.TextBox txtTargetTable;
    }
}

