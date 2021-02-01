
namespace productCategoryModel
{
    partial class StartPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonSelectInsert = new System.Windows.Forms.Button();
            this.buttonSelectDelete = new System.Windows.Forms.Button();
            this.labelSelectOperation = new System.Windows.Forms.Label();
            this.buttonSelectShow = new System.Windows.Forms.Button();
            this.buttonSelectUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kontrol Sistemi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonCategory
            // 
            this.buttonCategory.Location = new System.Drawing.Point(206, 79);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(75, 47);
            this.buttonCategory.TabIndex = 1;
            this.buttonCategory.Text = "Kategoriler";
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(61, 79);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(75, 47);
            this.buttonProducts.TabIndex = 2;
            this.buttonProducts.Text = "Ürünler";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonSelectInsert
            // 
            this.buttonSelectInsert.Enabled = false;
            this.buttonSelectInsert.Location = new System.Drawing.Point(12, 189);
            this.buttonSelectInsert.Name = "buttonSelectInsert";
            this.buttonSelectInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectInsert.TabIndex = 3;
            this.buttonSelectInsert.Text = "Ekle";
            this.buttonSelectInsert.UseVisualStyleBackColor = true;
            this.buttonSelectInsert.Visible = false;
            this.buttonSelectInsert.Click += new System.EventHandler(this.buttonSelectInsert_Click);
            // 
            // buttonSelectDelete
            // 
            this.buttonSelectDelete.Enabled = false;
            this.buttonSelectDelete.Location = new System.Drawing.Point(251, 189);
            this.buttonSelectDelete.Name = "buttonSelectDelete";
            this.buttonSelectDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectDelete.TabIndex = 4;
            this.buttonSelectDelete.Text = "Sil";
            this.buttonSelectDelete.UseVisualStyleBackColor = true;
            this.buttonSelectDelete.Visible = false;
            this.buttonSelectDelete.Click += new System.EventHandler(this.buttonSelectDelete_Click);
            // 
            // labelSelectOperation
            // 
            this.labelSelectOperation.AutoSize = true;
            this.labelSelectOperation.Location = new System.Drawing.Point(80, 151);
            this.labelSelectOperation.Name = "labelSelectOperation";
            this.labelSelectOperation.Size = new System.Drawing.Size(180, 15);
            this.labelSelectOperation.TabIndex = 5;
            this.labelSelectOperation.Text = "Yapmak istediğiniz işlemi seçiniz.";
            this.labelSelectOperation.Visible = false;
            // 
            // buttonSelectShow
            // 
            this.buttonSelectShow.Enabled = false;
            this.buttonSelectShow.Location = new System.Drawing.Point(91, 189);
            this.buttonSelectShow.Name = "buttonSelectShow";
            this.buttonSelectShow.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectShow.TabIndex = 6;
            this.buttonSelectShow.Text = "Göster";
            this.buttonSelectShow.UseVisualStyleBackColor = true;
            this.buttonSelectShow.Visible = false;
            this.buttonSelectShow.Click += new System.EventHandler(this.buttonSelectShow_Click);
            // 
            // buttonSelectUpdate
            // 
            this.buttonSelectUpdate.Enabled = false;
            this.buttonSelectUpdate.Location = new System.Drawing.Point(170, 189);
            this.buttonSelectUpdate.Name = "buttonSelectUpdate";
            this.buttonSelectUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectUpdate.TabIndex = 7;
            this.buttonSelectUpdate.Text = "Güncelle";
            this.buttonSelectUpdate.UseVisualStyleBackColor = true;
            this.buttonSelectUpdate.Visible = false;
            this.buttonSelectUpdate.Click += new System.EventHandler(this.buttonSelectUpdate_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 238);
            this.Controls.Add(this.buttonSelectUpdate);
            this.Controls.Add(this.buttonSelectShow);
            this.Controls.Add(this.labelSelectOperation);
            this.Controls.Add(this.buttonSelectDelete);
            this.Controls.Add(this.buttonSelectInsert);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonCategory);
            this.Controls.Add(this.label1);
            this.Name = "StartPage";
            this.Text = "Ürün Kontrol Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonSelectInsert;
        private System.Windows.Forms.Button buttonSelectDelete;
        private System.Windows.Forms.Label labelSelectOperation;
        private System.Windows.Forms.Button buttonSelectShow;
        private System.Windows.Forms.Button buttonSelectUpdate;
    }
}