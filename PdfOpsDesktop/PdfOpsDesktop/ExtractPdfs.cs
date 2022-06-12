using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PdfOpsDesktop
{
    class ExtractPdfs
    {   
        private ExtractPdfs() { }

        private static ExtractPdfs instance = new ExtractPdfs();
        public static ExtractPdfs Instance 
        {
            get { return instance; }
        }

        public void ExtractPages(string uploadPath, string outputPath, int pageNumber) 
        {
            PdfDocument output = new PdfDocument();
            var document = PdfReader.Open(uploadPath, PdfDocumentOpenMode.Import);

            var pageCount = document.PageCount;
            output.AddPage(document.Pages[pageNumber]);
            output.Save(outputPath);
        }
   
    
    }
}
