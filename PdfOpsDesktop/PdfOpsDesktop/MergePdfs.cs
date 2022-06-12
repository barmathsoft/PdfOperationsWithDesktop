using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfOpsDesktop
{
    class MergePdfs
    {
        private MergePdfs() { }
        private static MergePdfs instance = new MergePdfs();
        public static MergePdfs Instance
        {
            get { return instance; }
        }

        public void MergePages(string outputPath, string[] pdfFiles)
        {
            PdfDocument document = new PdfDocument();

            foreach (var pdf in pdfFiles)
            {
                var inputPdf = PdfReader.Open(pdf, PdfDocumentOpenMode.Import);
                foreach (var page in inputPdf.Pages)
                {
                    document.AddPage(page);
                }
            }

            for (int i = 0; i < document.Pages.Count; i++)
            {
                PdfPage page = document.Pages[i];
            }

            document.Save(outputPath);
        }
    }
}
