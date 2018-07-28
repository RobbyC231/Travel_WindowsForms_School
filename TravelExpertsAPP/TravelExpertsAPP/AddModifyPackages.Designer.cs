﻿namespace TravelExpertsAPP
{
    partial class AddModifyPackages
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
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.txtPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtPkgDescription = new System.Windows.Forms.TextBox();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            packageIdLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(80, 57);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(65, 13);
            packageIdLabel.TabIndex = 1;
            packageIdLabel.Text = "Package Id:";
            // 
            // txtPackageId
            // 
            this.txtPackageId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.txtPackageId.Location = new System.Drawing.Point(212, 54);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.ReadOnly = true;
            this.txtPackageId.Size = new System.Drawing.Size(200, 20);
            this.txtPackageId.TabIndex = 2;
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(80, 83);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(126, 13);
            pkgAgencyCommissionLabel.TabIndex = 3;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(212, 80);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(200, 20);
            this.txtPkgAgencyCommission.TabIndex = 4;
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(80, 109);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(83, 13);
            pkgBasePriceLabel.TabIndex = 5;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.txtBasePrice.Location = new System.Drawing.Point(212, 106);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(200, 20);
            this.txtBasePrice.TabIndex = 6;
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(80, 135);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(57, 13);
            pkgDescLabel.TabIndex = 7;
            pkgDescLabel.Text = "Pkg Desc:";
            // 
            // txtPkgDescription
            // 
            this.txtPkgDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.txtPkgDescription.Location = new System.Drawing.Point(212, 132);
            this.txtPkgDescription.Name = "txtPkgDescription";
            this.txtPkgDescription.Size = new System.Drawing.Size(200, 20);
            this.txtPkgDescription.TabIndex = 8;
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(80, 162);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(77, 13);
            pkgEndDateLabel.TabIndex = 9;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.dtpPkgEndDate.Location = new System.Drawing.Point(212, 158);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPkgEndDate.TabIndex = 10;
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(80, 187);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(60, 13);
            pkgNameLabel.TabIndex = 11;
            pkgNameLabel.Text = "Pkg Name:";
            // 
            // txtPkgName
            // 
            this.txtPkgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.txtPkgName.Location = new System.Drawing.Point(212, 184);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(200, 20);
            this.txtPkgName.TabIndex = 12;
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(80, 214);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(80, 13);
            pkgStartDateLabel.TabIndex = 13;
            pkgStartDateLabel.Text = "Pkg Start Date:";
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.dtpPkgStartDate.Location = new System.Drawing.Point(212, 210);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPkgStartDate.TabIndex = 14;
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(131, 265);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(322, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(TravelExpertsLibrary.Package);
            // 
            // AddModifyPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 325);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(packageIdLabel);
            this.Controls.Add(this.txtPackageId);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.txtPkgAgencyCommission);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.txtPkgDescription);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.dtpPkgEndDate);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.txtPkgName);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.dtpPkgStartDate);
            this.Name = "AddModifyPackages";
            this.Text = "AddModifyPackages";
            this.Load += new System.EventHandler(this.AddModifyPackages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.TextBox txtPkgAgencyCommission;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtPkgDescription;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}