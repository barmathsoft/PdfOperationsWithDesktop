
namespace PdfOpsDesktop
{
    partial class MasterForm
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
            this.btnUploadPdf = new System.Windows.Forms.Button();
            this.btnGroupPdf = new System.Windows.Forms.Button();
            this.txt_UploadPath = new System.Windows.Forms.TextBox();
            this.cmb_GroupChoices = new System.Windows.Forms.ComboBox();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.lbl_msgGroup = new System.Windows.Forms.Label();
            this.grp_ExtractAndGroup = new DevExpress.XtraEditors.GroupControl();
            this.grp_mergePdfs = new DevExpress.XtraEditors.GroupControl();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txt_folderPath = new System.Windows.Forms.TextBox();
            this.txt_mergedPdf = new System.Windows.Forms.TextBox();
            this.btnMergePdfs = new System.Windows.Forms.Button();
            this.lbl_mergePdf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grp_ExtractAndGroup)).BeginInit();
            this.grp_ExtractAndGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_mergePdfs)).BeginInit();
            this.grp_mergePdfs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUploadPdf
            // 
            this.btnUploadPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadPdf.Location = new System.Drawing.Point(5, 23);
            this.btnUploadPdf.Name = "btnUploadPdf";
            this.btnUploadPdf.Size = new System.Drawing.Size(100, 39);
            this.btnUploadPdf.TabIndex = 0;
            this.btnUploadPdf.Text = "UPLOAD PDF";
            this.btnUploadPdf.UseVisualStyleBackColor = true;
            this.btnUploadPdf.Click += new System.EventHandler(this.btnUploadPdf_Click);
            // 
            // btnGroupPdf
            // 
            this.btnGroupPdf.Location = new System.Drawing.Point(5, 99);
            this.btnGroupPdf.Name = "btnGroupPdf";
            this.btnGroupPdf.Size = new System.Drawing.Size(100, 37);
            this.btnGroupPdf.TabIndex = 1;
            this.btnGroupPdf.Text = "MAKE GROUP PDFS";
            this.btnGroupPdf.UseVisualStyleBackColor = true;
            this.btnGroupPdf.Click += new System.EventHandler(this.btnGroupPdf_Click);
            // 
            // txt_UploadPath
            // 
            this.txt_UploadPath.Location = new System.Drawing.Point(135, 23);
            this.txt_UploadPath.Multiline = true;
            this.txt_UploadPath.Name = "txt_UploadPath";
            this.txt_UploadPath.Size = new System.Drawing.Size(457, 39);
            this.txt_UploadPath.TabIndex = 2;
            // 
            // cmb_GroupChoices
            // 
            this.cmb_GroupChoices.FormattingEnabled = true;
            this.cmb_GroupChoices.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_GroupChoices.Location = new System.Drawing.Point(135, 103);
            this.cmb_GroupChoices.Name = "cmb_GroupChoices";
            this.cmb_GroupChoices.Size = new System.Drawing.Size(121, 21);
            this.cmb_GroupChoices.TabIndex = 3;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(149, 74);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 13);
            this.lbl_msg.TabIndex = 4;
            // 
            // lbl_msgGroup
            // 
            this.lbl_msgGroup.AutoSize = true;
            this.lbl_msgGroup.Location = new System.Drawing.Point(149, 137);
            this.lbl_msgGroup.Name = "lbl_msgGroup";
            this.lbl_msgGroup.Size = new System.Drawing.Size(0, 13);
            this.lbl_msgGroup.TabIndex = 5;
            // 
            // grp_ExtractAndGroup
            // 
            this.grp_ExtractAndGroup.Controls.Add(this.btnUploadPdf);
            this.grp_ExtractAndGroup.Controls.Add(this.lbl_msg);
            this.grp_ExtractAndGroup.Controls.Add(this.lbl_msgGroup);
            this.grp_ExtractAndGroup.Controls.Add(this.btnGroupPdf);
            this.grp_ExtractAndGroup.Controls.Add(this.txt_UploadPath);
            this.grp_ExtractAndGroup.Controls.Add(this.cmb_GroupChoices);
            this.grp_ExtractAndGroup.Location = new System.Drawing.Point(1, 12);
            this.grp_ExtractAndGroup.Name = "grp_ExtractAndGroup";
            this.grp_ExtractAndGroup.Size = new System.Drawing.Size(799, 161);
            this.grp_ExtractAndGroup.TabIndex = 6;
            this.grp_ExtractAndGroup.Text = "Extracting And Grouping Operations";
            // 
            // grp_mergePdfs
            // 
            this.grp_mergePdfs.Controls.Add(this.lbl_mergePdf);
            this.grp_mergePdfs.Controls.Add(this.btnMergePdfs);
            this.grp_mergePdfs.Controls.Add(this.txt_mergedPdf);
            this.grp_mergePdfs.Controls.Add(this.txt_folderPath);
            this.grp_mergePdfs.Controls.Add(this.btnSelectFolder);
            this.grp_mergePdfs.Location = new System.Drawing.Point(6, 199);
            this.grp_mergePdfs.Name = "grp_mergePdfs";
            this.grp_mergePdfs.Size = new System.Drawing.Size(794, 148);
            this.grp_mergePdfs.TabIndex = 7;
            this.grp_mergePdfs.Text = "Merging Operations";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(6, 32);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(94, 39);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "SELECT FOLDER";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txt_folderPath
            // 
            this.txt_folderPath.Location = new System.Drawing.Point(130, 32);
            this.txt_folderPath.Multiline = true;
            this.txt_folderPath.Name = "txt_folderPath";
            this.txt_folderPath.Size = new System.Drawing.Size(457, 39);
            this.txt_folderPath.TabIndex = 3;
            // 
            // txt_mergedPdf
            // 
            this.txt_mergedPdf.Location = new System.Drawing.Point(130, 90);
            this.txt_mergedPdf.Multiline = true;
            this.txt_mergedPdf.Name = "txt_mergedPdf";
            this.txt_mergedPdf.Size = new System.Drawing.Size(457, 39);
            this.txt_mergedPdf.TabIndex = 4;
            // 
            // btnMergePdfs
            // 
            this.btnMergePdfs.Location = new System.Drawing.Point(6, 90);
            this.btnMergePdfs.Name = "btnMergePdfs";
            this.btnMergePdfs.Size = new System.Drawing.Size(94, 39);
            this.btnMergePdfs.TabIndex = 5;
            this.btnMergePdfs.Text = "MERGE ITS";
            this.btnMergePdfs.UseVisualStyleBackColor = true;
            this.btnMergePdfs.Click += new System.EventHandler(this.btnMergePdfs_Click);
            // 
            // lbl_mergePdf
            // 
            this.lbl_mergePdf.AutoSize = true;
            this.lbl_mergePdf.Location = new System.Drawing.Point(144, 132);
            this.lbl_mergePdf.Name = "lbl_mergePdf";
            this.lbl_mergePdf.Size = new System.Drawing.Size(0, 13);
            this.lbl_mergePdf.TabIndex = 6;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_mergePdfs);
            this.Controls.Add(this.grp_ExtractAndGroup);
            this.Name = "MasterForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grp_ExtractAndGroup)).EndInit();
            this.grp_ExtractAndGroup.ResumeLayout(false);
            this.grp_ExtractAndGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_mergePdfs)).EndInit();
            this.grp_mergePdfs.ResumeLayout(false);
            this.grp_mergePdfs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUploadPdf;
        private System.Windows.Forms.Button btnGroupPdf;
        private System.Windows.Forms.TextBox txt_UploadPath;
        private System.Windows.Forms.ComboBox cmb_GroupChoices;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label lbl_msgGroup;
        private DevExpress.XtraEditors.GroupControl grp_ExtractAndGroup;
        private DevExpress.XtraEditors.GroupControl grp_mergePdfs;
        private System.Windows.Forms.Button btnMergePdfs;
        private System.Windows.Forms.TextBox txt_mergedPdf;
        private System.Windows.Forms.TextBox txt_folderPath;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lbl_mergePdf;
    }
}

