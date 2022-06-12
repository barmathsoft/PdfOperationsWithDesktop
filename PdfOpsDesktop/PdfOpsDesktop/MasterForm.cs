using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using System.IO;

namespace PdfOpsDesktop
{
    public partial class MasterForm : Form
    {
        ExtractPdfs extractpdf = ExtractPdfs.Instance;
        MergePdfs mergePdf = MergePdfs.Instance;
        string extractPDFs = Application.StartupPath + @"\extractedPdfs";
        string mergePDFs = Application.StartupPath + @"\mergedPdfs" + @"\Sample.pdf";
        string folderPath;
        public MasterForm()
        {
            InitializeComponent();
        }
        private void MasterForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(extractPDFs))
                Directory.CreateDirectory(extractPDFs);
            if (!Directory.Exists(mergePDFs))
                Directory.CreateDirectory(mergePDFs);

            cmb_GroupChoices.SelectedIndex = 0;
        }
        private void btnUploadPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "(*.pdf)|*.pdf";
            fileDialog.Multiselect = false;
            fileDialog.Title = "Select PDF Which Will Extract";
            
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_UploadPath.Text = fileDialog.FileName;
                var filePath = txt_UploadPath.Text;
                
                var document = PdfReader.Open(filePath,PdfDocumentOpenMode.ReadOnly);
                for (int i = 0; i < document.PageCount; i++)
                {
                    extractpdf.ExtractPages(filePath, extractPDFs + "\\" + i.ToString() + ".pdf", i);
                }

                lbl_msg.Text = Messages.MSG_LABEL_EXT;
                lbl_msg.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show(Messages.MSG_PDF_WARNING,"Cancelled",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void btnGroupPdf_Click(object sender, EventArgs e)
        {
            int choice = int.Parse(cmb_GroupChoices.SelectedItem.ToString());
            string[] extractedPdfs = Directory.GetFiles(extractPDFs);
            string[] groupedPdf = new string[choice];

            if (extractedPdfs.Length % groupedPdf.Length == 0)
            {
                for (int i = 0; i < extractedPdfs.Length; i += choice)
                {
                    PdfDocument document = new PdfDocument();
                   
                    Array.Copy(extractedPdfs, i, groupedPdf, 0, choice);
                    
                    foreach (var pdf in groupedPdf)
                    {
                        var inputPdf = PdfReader.Open(pdf, PdfDocumentOpenMode.Import);
                        foreach (var page in inputPdf.Pages)
                        {
                            document.AddPage(page);
                        }
                        extractedPdfs.Skip(choice);
                    }

                    for (int j = 0; j < document.Pages.Count; j++)
                    {
                        PdfPage page = document.Pages[j];
                    }

                    document.Save(extractPDFs + "\\" + i.ToString() + ".pdf");

                    foreach (var pdf in extractedPdfs)
                    {
                        if (pdf == extractedPdfs[i + 1])
                        {
                            File.Delete(pdf);
                        }
                    }
                }
            }
            lbl_msgGroup.Text = Messages.MSG_LABEL_GROUP;
            lbl_msgGroup.ForeColor = Color.Green;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = true;
            DialogResult result = folderDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
            {
                txt_folderPath.Text = folderDialog.SelectedPath;
                folderPath = txt_folderPath.Text;
                Environment.SpecialFolder root = folderDialog.RootFolder;
            }
            else
            {
                MessageBox.Show(Messages.MSG_PDF_WARNING, "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnMergePdfs_Click(object sender, EventArgs e)
        {
            string[] pdfFiles = Directory.GetFiles(folderPath);
           
            mergePdf.MergePages(mergePDFs, pdfFiles);
            txt_mergedPdf.Text = mergePDFs;
            lbl_mergePdf.Text = Messages.MSG_LABEL_MERGE;
            lbl_mergePdf.ForeColor = Color.Green;
        }
    }
}
