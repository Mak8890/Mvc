using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BsiApplicationMvc.Models
{
    public class PageEventFooter : PdfPageEventHelper
    {
        PdfContentByte cb;
        PdfTemplate template;
        BaseFont bf = null;
        string PrintTime;
        public string FooterText { get; set; }
        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            PrintTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            cb = writer.DirectContent;
            bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            template = cb.CreateTemplate(50, 50);
        }


        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);
            int pageN = writer.PageNumber;
            String text = "Page " + pageN + " of ";
            float len = bf.GetWidthPoint(text, 8);
            iTextSharp.text.Rectangle pageSize = document.PageSize;
            cb.SetRGBColorFill(100, 100, 100);
            cb.BeginText();
            cb.SetFontAndSize(bf, 8);
            cb.SetTextMatrix(pageSize.GetLeft(40), pageSize.GetBottom(30));
            cb.ShowText(text);
            cb.EndText();
            cb.AddTemplate(template, pageSize.GetLeft(40) + len, pageSize.GetBottom(30));

            cb.BeginText();
            cb.SetFontAndSize(bf, 8);
            cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT,
            "Printed By: " + FooterText,
            //"Printed On " + PrintTime.ToString(),
            pageSize.GetRight(40),
            pageSize.GetBottom(30), 0);
            cb.EndText();
        }
        //public override void OnEndPage(PdfWriter writer, Document document)
        //{
        //    base.OnEndPage(writer, document);

        //    int pageN = writer.PageNumber;
        //    //String text = "Page " + pageN.ToString() + " of ";
        //    String text = " ";
        //    cb.SetFontAndSize(bf, 9);
        //    cb.SetRGBColorFill(100, 100, 100);
        //    iTextSharp.text.Rectangle pageSize = document.PageSize;



        //    cb.BeginText();

        //    //cb.SetRGBColorFill(50, 50, 200);
        //    cb.SetTextMatrix(document.LeftMargin, pageSize.GetBottom(document.BottomMargin));
        //    cb.ShowText(text);

        //    cb.EndText();

        //    cb.AddTemplate(template, document.LeftMargin, pageSize.GetBottom(document.BottomMargin));
        //}

        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);

            template.BeginText();
            template.SetFontAndSize(bf, 8);
            template.SetTextMatrix(0, 0);
            template.ShowText("" + (writer.PageNumber));
            template.EndText();
        }
    }
}
