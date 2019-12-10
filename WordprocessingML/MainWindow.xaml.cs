using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WordprocessingML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateWordprocessingDocument("d:\\Server\\Visual_studio\\AK\\test2.docx");

        }

        public static void CreateWordprocessingDocument(string filepath)
        {
            // Create a document by supplying the filepath. 
            using (var wordprocessingDocument = WordprocessingDocument.Create(filepath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordprocessingDocument.AddMainDocumentPart();
                mainPart.Document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                Body body = mainPart.Document.AppendChild(new Body());
                DocumentFormat.OpenXml.Wordprocessing.Paragraph para = body.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Paragraph());
                DocumentFormat.OpenXml.Wordprocessing.Run run = para.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Run());
                run.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Text("siddiq"));
                wordprocessingDocument.MainDocumentPart.Document.Save();
            }
        }
    }
}
