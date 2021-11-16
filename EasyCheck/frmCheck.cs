using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCheck
{
    public partial class frmCheck : Form
    {
        Bitmap bmp_sr_top;
        Bitmap bmp_sr_center;
        Bitmap bmp_sr_bottom;
        Bitmap bmp_sr;

        int srHeight = 0;
        string fontName = "Segoe Script";
        string fontNorm = "Arial";

        private float total = 0;
        private string printerName = "";

        private List<string[]> rows;

        public frmCheck()
        {
            InitializeComponent();
            if (EasyCheck.SelfRef != null)
            {
                total = EasyCheck.SelfRef.total;
                rows = EasyCheck.SelfRef.rows;
            }
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {
            bmp_sr_top = new Bitmap(sr_top.Image);
            bmp_sr_center = new Bitmap(sr_center.Image);
            bmp_sr_bottom = new Bitmap(sr_bottom.Image);

            printerName = GetDefaultPrinterName();
            if (printerName != "")
            {
                lbPrinter.Text = printerName;
            }
            else
            {
                lbPrinter.Text = "Не выбран принтер по умолчанию!";
            }

            SRDraw();
        }

        private void tbCopy_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number)) && (number != 8))
            {
                e.Handled = true;
            }
        }

        private void tbCopy_TextChanged(object sender, EventArgs e)
        {
            if ((tbCopy.Text == "00") || (tbCopy.Text == "0") || (tbCopy.Text == "01"))
            {
                tbCopy.Text = "1";
            }
            else if ((tbCopy.Text == "02"))
            {
                tbCopy.Text = "2";
            }
            else if ((tbCopy.Text == "03"))
            {
                tbCopy.Text = "3";
            }
            else if ((tbCopy.Text == "04"))
            {
                tbCopy.Text = "4";
            }
            else if ((tbCopy.Text == "05"))
            {
                tbCopy.Text = "5";
            }
            else if ((tbCopy.Text == "06"))
            {
                tbCopy.Text = "6";
            }
            else if ((tbCopy.Text == "07"))
            {
                tbCopy.Text = "7";
            }
            else if ((tbCopy.Text == "08"))
            {
                tbCopy.Text = "8";
            }
            else if ((tbCopy.Text == "09"))
            {
                tbCopy.Text = "9";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(printerName);
            this.Close();
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            printerName = GetDefaultPrinterName();
            if (printerName != "")
            {
                lbPrinter.Text = printerName;
            }
            else
            {
                lbPrinter.Text = "Не выбран принтер по умолчанию!";
            }
        }

        void SRDraw()
        {
            int rowsCount = 8;
            int numRows = rows.Count;
            if (numRows > rowsCount)
            {
                rowsCount = numRows;
            }

            bmp_sr = new Bitmap(2480, 480 + 254 + (rowsCount * 58));
            StringFormat stringFormatFar = new StringFormat();
            stringFormatFar.Alignment = StringAlignment.Far;
            StringFormat stringFormatCenter = new StringFormat();
            stringFormatCenter.Alignment = StringAlignment.Center;

            using (var graphics = Graphics.FromImage(bmp_sr))
            {
                int offset = rowsCount * 58;
                graphics.DrawImage(bmp_sr_top, 0, 0, 2480, 480);

                string customer = EasyCheck.SelfRef.Customer;
                RectangleF rec_customer = new RectangleF(3, 60, 1520, 50);
                graphics.DrawString(customer, new Font(fontNorm, 26, FontStyle.Bold), Brushes.Black, rec_customer);

                for (int i = 0; i < rowsCount; i++)
                {
                    graphics.DrawImage(bmp_sr_center, 0, 480 + i * 58, 2480, 58);
                    RectangleF rec_num = new RectangleF(60, 480 + i * 58 - 4, 100, 50);
                    graphics.DrawString((i + 1).ToString(), new Font(fontName, 32, FontStyle.Bold), Brushes.Black, rec_num, stringFormatFar);
                    if ((i + 1) <= numRows)
                    {
                        string[] row = rows[i];
                        string name = row[0];
                        string price = row[1];
                        string count = row[2];
                        string sum = (float.Parse(price, CultureInfo.InvariantCulture.NumberFormat) * int.Parse(count)).ToString("0.00");

                        RectangleF rec_name = new RectangleF(217, 480 + i * 58 - 4, 820, 90);
                        graphics.DrawString(name, new Font(fontName, 32, FontStyle.Bold), Brushes.Black, rec_name);
                        RectangleF rec_price = new RectangleF(1060, 480 + i * 58 - 4, 595, 90);
                        string prc = "";
                        float prcf = float.Parse(price, CultureInfo.InvariantCulture.NumberFormat);
                        prc = prcf.ToString("0.00");
                        prc = prc.Replace(".", ",");
                        graphics.DrawString(prc, new Font(fontName, 32, FontStyle.Bold), Brushes.Black, rec_price, stringFormatCenter);
                        RectangleF rec_count = new RectangleF(1675, 480 + i * 58 - 4, 182, 90);
                        graphics.DrawString(count, new Font(fontName, 32, FontStyle.Bold), Brushes.Black, rec_count, stringFormatCenter);
                        RectangleF rec_sum = new RectangleF(1892, 480 + i * 58 - 4, 533, 90);
                        graphics.DrawString(sum, new Font(fontName, 32, FontStyle.Bold), Brushes.Black, rec_sum, stringFormatCenter);
                    }
                }

                if ((numRows < rowsCount) && (numRows > 0))
                {
                    bool delimiter = true;
                    if (numRows > 5)
                    {
                        delimiter = false;
                    }
                    DrawZ(graphics, 270, 480 + 29 + (numRows * 58), 2100, 58 * (7 - numRows), delimiter);
                }

                graphics.DrawImage(bmp_sr_bottom, 0, 480 + offset, 2480, 254);

                if (total > 0)
                {
                    RectangleF rec_itog = new RectangleF(1900, 480 + offset - 4, 530, 60);
                    graphics.DrawString(total.ToString("0.00"), new Font(fontName, 32, FontStyle.Bold), Brushes.Black, rec_itog, stringFormatCenter);
                }
                RectangleF rec_sum_text = new RectangleF(275, 480 + offset + 76, 2178, 60);
                graphics.DrawString(PriceToString(total), new Font(fontName, 32, FontStyle.Bold), Brushes.Black, rec_sum_text);
                RectangleF rec_year = new RectangleF(1990, 480 + offset + 160, 530, 60);
                graphics.DrawString(DateTime.Now.ToString("HH:mm dd.MM.yy"), new Font(fontName, 32, FontStyle.Bold), Brushes.Black, rec_year, stringFormatCenter);

                Graphics g = Graphics.FromImage(bmp_sr);
                g.Flush();
            }
            SR.Image = bmp_sr;
            SR.Width = 800;
            srHeight = (480 + 254 + (rowsCount * 58)) / 3;
            SR.Height = srHeight;
            this.Height = SR.Height + 30 * 2 + btnPrint.Height;
            this.Width = SR.Width + 40;
            btnPrint.Top = srHeight + 10;
            btnPrinter.Top = srHeight + 10;
            lbDefaultPrinter.Top = srHeight + 10;
            lbPrinter.Top = srHeight + 27;
            lbCopy.Top = srHeight + 15;
            tbCopy.Top = srHeight + 14;
        }

        private void DrawZ(Graphics graphics, int x, int y, int w, int h, bool delimiter)
        {
            Pen pen = new Pen(Color.Gray, 6);
            Point[] points = {
                               new Point(),
                               new Point(),
                               new Point(),
                               new Point()
                           };

            points[0].X = x;
            points[0].Y = y;
            points[1].X = x + w;
            points[1].Y = y;
            points[2].X = x;
            points[2].Y = y + h;
            points[3].X = x + w;
            points[3].Y = y + h;

            graphics.DrawLines(pen, points);
            if (delimiter) graphics.DrawLine(pen, new Point(x, y + h / 2 + 15), new Point(x + w, y + h / 2 - 15));
        }

        private string PriceToString(float price)
        {
            double dbl_left = Math.Floor(Convert.ToDouble(price));
            int num_left = Convert.ToInt32(dbl_left);
            int num_right = Convert.ToInt32((price - num_left) * 100);
            int number = num_left;
            int[] array_int = new int[4];
            string[,] array_string = new string[4, 3] {{" миллиард", " миллиарда", " миллиардов"},
                {" миллион", " миллиона", " миллионов"},
                {" тысяча", " тысячи", " тысяч"},
                {"", "", ""}};
            array_int[0] = (number - (number % 1000000000)) / 1000000000;
            array_int[1] = ((number % 1000000000) - (number % 1000000)) / 1000000;
            array_int[2] = ((number % 1000000) - (number % 1000)) / 1000;
            array_int[3] = number % 1000;
            string result = "";
            for (int i = 0; i < 4; i++)
            {
                if (array_int[i] != 0)
                {
                    if (((array_int[i] - (array_int[i] % 100)) / 100) != 0)
                        switch (((array_int[i] - (array_int[i] % 100)) / 100))
                        {
                            case 1: result += " сто"; break;
                            case 2: result += " двести"; break;
                            case 3: result += " триста"; break;
                            case 4: result += " четыреста"; break;
                            case 5: result += " пятьсот"; break;
                            case 6: result += " шестьсот"; break;
                            case 7: result += " семьсот"; break;
                            case 8: result += " восемьсот"; break;
                            case 9: result += " девятьсот"; break;
                        }
                    if (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10 != 1)
                    {
                        switch (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10)
                        {
                            case 2: result += " двадцать"; break;
                            case 3: result += " тридцать"; break;
                            case 4: result += " сорок"; break;
                            case 5: result += " пятьдесят"; break;
                            case 6: result += " шестьдесят"; break;
                            case 7: result += " семьдесят"; break;
                            case 8: result += " восемьдесят"; break;
                            case 9: result += " девяносто"; break;
                        }
                    }
                    switch (array_int[i] % 10)
                    {
                        case 1: if (i == 2) result += " одна"; else result += " один"; break;
                        case 2: if (i == 2) result += " две"; else result += " два"; break;
                        case 3: result += " три"; break;
                        case 4: result += " четыре"; break;
                        case 5: result += " пять"; break;
                        case 6: result += " шесть"; break;
                        case 7: result += " семь"; break;
                        case 8: result += " восемь"; break;
                        case 9: result += " девять"; break;
                    }
                }
                else switch (array_int[i] % 100)
                    {
                        case 10: result += " десять"; break;
                        case 11: result += " одиннадцать"; break;
                        case 12: result += " двенадцать"; break;
                        case 13: result += " тринадцать"; break;
                        case 14: result += " четырнадцать"; break;
                        case 15: result += " пятнадцать"; break;
                        case 16: result += " шестнадцать"; break;
                        case 17: result += " семнадцать"; break;
                        case 18: result += " восемннадцать"; break;
                        case 19: result += " девятнадцать"; break;
                    }
                if (array_int[i] % 100 >= 10 && array_int[i] % 100 <= 19) result += " " + array_string[i, 2] + " ";
                else switch (array_int[i] % 10)
                    {
                        case 1: result += " " + array_string[i, 0] + " "; break;
                        case 2:
                        case 3:
                        case 4: result += " " + array_string[i, 1] + " "; break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9: result += " " + array_string[i, 2] + " "; break;
                    }
            }

            return result + " руб.  " + num_right.ToString() + " коп.";
        }

        private static string GetDefaultPrinterName()
        {
            String[] printers = PrinterSettings.InstalledPrinters.Cast<string>().ToArray();
            for (int i = 0; i < printers.Length; i++)
            {
                if (new PrinterSettings() { PrinterName = printers[i] }.IsDefaultPrinter)
                {
                    return printers[i];
                }
            }

            return "";
        }

        void Print(string prntName)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrinterSettings.PrinterName = prntName;
            if (tbCopy.Text == "")
            {
                tbCopy.Text = "1";
            }
            doc.PrinterSettings.Copies = short.Parse(tbCopy.Text);
            doc.PrintPage += new PrintPageEventHandler(PrintHandler);

            doc.Print();
        }

        private void PrintHandler(object sender, PrintPageEventArgs ppeArgs)
        {
            ppeArgs.Graphics.DrawImage(bmp_sr, 0, 0, 800, srHeight);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F12)
            {
                btnPrint.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
