
namespace SaleApplication2
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
            this.yeniButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.SaleButton = new System.Windows.Forms.Button();
            this.HesabatButton = new System.Windows.Forms.Button();
            this.listView1_mehsul = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yeniButton
            // 
            this.yeniButton.Location = new System.Drawing.Point(601, 36);
            this.yeniButton.Name = "yeniButton";
            this.yeniButton.Size = new System.Drawing.Size(75, 23);
            this.yeniButton.TabIndex = 0;
            this.yeniButton.Text = "+ Yeni";
            this.yeniButton.UseVisualStyleBackColor = true;
            this.yeniButton.Click += new System.EventHandler(this.yeniButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(682, 36);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Sil";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ProductButton
            // 
            this.ProductButton.Location = new System.Drawing.Point(39, 13);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(75, 23);
            this.ProductButton.TabIndex = 2;
            this.ProductButton.Text = "Məhsullar";
            this.ProductButton.UseVisualStyleBackColor = true;
            // 
            // SaleButton
            // 
            this.SaleButton.Location = new System.Drawing.Point(134, 13);
            this.SaleButton.Name = "SaleButton";
            this.SaleButton.Size = new System.Drawing.Size(75, 23);
            this.SaleButton.TabIndex = 3;
            this.SaleButton.Text = "Satış";
            this.SaleButton.UseVisualStyleBackColor = true;
            // 
            // HesabatButton
            // 
            this.HesabatButton.Location = new System.Drawing.Point(233, 12);
            this.HesabatButton.Name = "HesabatButton";
            this.HesabatButton.Size = new System.Drawing.Size(75, 23);
            this.HesabatButton.TabIndex = 4;
            this.HesabatButton.Text = "Hesabat";
            this.HesabatButton.UseVisualStyleBackColor = true;
            // 
            // listView1_mehsul
            // 
            this.listView1_mehsul.GridLines = true;
            this.listView1_mehsul.HideSelection = false;
            this.listView1_mehsul.Location = new System.Drawing.Point(12, 180);
            this.listView1_mehsul.Name = "listView1_mehsul";
            this.listView1_mehsul.Size = new System.Drawing.Size(745, 314);
            this.listView1_mehsul.TabIndex = 5;
            this.listView1_mehsul.UseCompatibleStateImageBehavior = false;
            this.listView1_mehsul.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "--- ---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(615, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kayit Sayi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1_mehsul);
            this.Controls.Add(this.HesabatButton);
            this.Controls.Add(this.SaleButton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.yeniButton);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yeniButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button SaleButton;
        private System.Windows.Forms.Button HesabatButton;
        private System.Windows.Forms.ListView listView1_mehsul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

