using System;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PDFBatchprint.Common
{
    public class PrinterHandler
    {
        public static void PrintPDF(string PrinterName, string FilePath, string PrintFormat, bool ColorBool)
        {
            try
            {
                //// Alter default printing settings
                PrintDocument pdoc = new PrintDocument();
                var StoreDefaultSettings = pdoc.DefaultPageSettings.PrinterSettings;
                pdoc.DefaultPageSettings.PrinterSettings.PrinterName = PrinterName;

                // Get page sizes
                PaperSize sizeA4 = new PaperSize
                {
                    RawKind = (int)PaperKind.A4
                };
                PaperSize sizeA3 = new PaperSize
                {
                    RawKind = (int)PaperKind.A3
                };

                // Set page size setting
                if (PrintFormat == "A3")
                {
                    pdoc.DefaultPageSettings.PaperSize = sizeA3;
                }
                else
                {
                    pdoc.DefaultPageSettings.PaperSize = sizeA4;
                }

                // Set color settings
                if (ColorBool && pdoc.PrinterSettings.SupportsColor)
                {
                    pdoc.DefaultPageSettings.Color = true;
                }
                else
                {
                    pdoc.PrinterSettings.DefaultPageSettings.Color = false;
                    pdoc.DefaultPageSettings.Color = false;
                }

                // Initiate print process
                PrintProcess(pdoc.DefaultPageSettings.PrinterSettings.PrinterName, FilePath);

                // Reset default printing settings
                pdoc.DefaultPageSettings.PrinterSettings = StoreDefaultSettings;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}",
               "Foutmelding",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void PrintProcess(string PrinterName, string FilePath)
        {
            try
            {
                ProcessStartInfo gsProcessInfo;
                Process gsProcess;

                // Create process settings
                gsProcessInfo = new ProcessStartInfo(FilePath)
                {
                    Verb = "PrintTo",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = FilePath,
                    Arguments = "\"" + PrinterName + "\"",
                    UseShellExecute = true,
                    CreateNoWindow = true
                };

                // Start process
                gsProcess = Process.Start(gsProcessInfo);
                gsProcess.EnableRaisingEvents = true;

                // Close process
                gsProcess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}",
              "Foutmelding",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
