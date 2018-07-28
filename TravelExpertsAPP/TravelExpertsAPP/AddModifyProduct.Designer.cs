namespace TravelExpertsAPP
{
    partial class AddModifyProduct
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label label1;
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtProdID = new System.Windows.Forms.TextBox();
            prodNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Location = new System.Drawing.Point(20, 52);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(63, 13);
            prodNameLabel.TabIndex = 1;
            prodNameLabel.Text = "Prod Name:";
            // 
            // txtProdName
            // 
            this.txtProdName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.txtProdName.Location = new System.Drawing.Point(89, 49);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(100, 20);
            this.txtProdName.TabIndex = 2;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(TravelExpertsLibrary.Product);
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(36, 93);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(142, 93);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtProdID
            // 
            this.txtProdID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.txtProdID.Location = new System.Drawing.Point(89, 23);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.ReadOnly = true;
            this.txtProdID.Size = new System.Drawing.Size(100, 20);
            this.txtProdID.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 13);
            label1.TabIndex = 8;
            label1.Text = "Prod ID:";
            // 
            // AddModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(265, 137);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.txtProdName);
            this.Name = "AddModifyProduct";
            this.Text = "AddModifyProduct";
            this.Load += new System.EventHandler(this.AddModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtProdID;
    }
}