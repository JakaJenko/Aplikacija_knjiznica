using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;
using MySql.Data.MySqlClient;

namespace Knjiznica_zaposlen
{
    public partial class Izpis_podatkov : Form
    {
        public Izpis_podatkov()
        {
            InitializeComponent();
        }

        private void izpisi_vse_Click(object sender, EventArgs e)
        {
            vsi_podatki();

            var titleFont = FontFactory.GetFont("Courier", 18, BaseColor.BLACK);
            var dataFont = FontFactory.GetFont("Calibri", 8, BaseColor.BLACK);
            //Creating iTextSharp Table from the DataTable data

            PdfPTable pdfTable = new PdfPTable(11);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                //cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            PdfPCell data;
            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        data = new PdfPCell(new Phrase(cell.Value.ToString(), dataFont));
                        //pdfTable.AddCell(cell.Value.ToString());
                        pdfTable.AddCell(data);
                    }
                }
                catch
                { }
            }

            //Exporting to PDF
            string folderPath = "H:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            FileStream stream;

            for (int x = 1; ; x++)
            {
                if (x == 1)
                {
                    try
                    {
                        stream = new FileStream(folderPath + "Vse_knjige_v_knjiznici_" + funkcije.date_time() + ".pdf", FileMode.CreateNew);
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }
                else
                {
                    try
                    {
                        stream = new FileStream(folderPath + "Vse_knjige_v_knjiznici_" + funkcije.date_time() + "_v" + x + ".pdf", FileMode.CreateNew);
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }

            Document pdfDoc = new Document(PageSize.A4_LANDSCAPE, 10f, 10f, 10f, 0f);
            PdfWriter.GetInstance(pdfDoc, stream);
            pdfDoc.Open();
            pdfDoc.Add(new Paragraph("Vse knjige v knjižnici", titleFont));
            pdfDoc.Add(new Paragraph(" ", titleFont));
            pdfDoc.Add(pdfTable);
            pdfDoc.Close();
            stream.Close();
        }

        private void Izpis_podatkov_Load(object sender, EventArgs e)
        {/*
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();


            dataAdapter = baza_data.Select_vse_knjige_iz_knjiznice();

            dataAdapter.Fill(table);
            bindingSource1.DataSource = table;

            dataGridView1.DataSource = bindingSource1;*/
        }

        private void vsi_podatki()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();


            dataAdapter = baza_data.Select_vse_knjige_iz_knjiznice();

            dataAdapter.Fill(table);
            bindingSource1.DataSource = table;

            dataGridView1.DataSource = bindingSource1;
        }

        private void izposojeno()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();


            dataAdapter = baza_data.Select_vse_izposojene_knjige_iz_knjiznice();

            dataAdapter.Fill(table);
            bindingSource1.DataSource = table;

            dataGridView1.DataSource = bindingSource1;
        }

        private void izpisi_izp_Click(object sender, EventArgs e)
        {
            izposojeno();

            var titleFont = FontFactory.GetFont("Courier", 18, BaseColor.BLACK);
            var dataFont = FontFactory.GetFont("Calibri", 8, BaseColor.BLACK);
            //Creating iTextSharp Table from the DataTable data

            PdfPTable pdfTable = new PdfPTable(9);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                //cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            PdfPCell data;
            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        data = new PdfPCell(new Phrase(cell.Value.ToString(), dataFont));
                        //pdfTable.AddCell(cell.Value.ToString());
                        pdfTable.AddCell(data);
                    }
                }
                catch
                { }
            }

            //Exporting to PDF
            string folderPath = "H:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            FileStream stream;

            for (int x = 1; ; x++)
            {
                if (x == 1)
                {
                    try
                    {
                        stream = new FileStream(folderPath + "Izposojene_knjige_" + funkcije.date_time() + ".pdf", FileMode.CreateNew);
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }
                else
                {
                    try
                    {
                        stream = new FileStream(folderPath + "Izposojene_knjige_" + funkcije.date_time() + "_v" + x + ".pdf", FileMode.CreateNew);
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }

            Document pdfDoc = new Document(PageSize.A4_LANDSCAPE, 10f, 10f, 10f, 0f);
            PdfWriter.GetInstance(pdfDoc, stream);
            pdfDoc.Open();
            pdfDoc.Add(new Paragraph("Izposojene knjige", titleFont));
            pdfDoc.Add(new Paragraph(" ", titleFont));
            pdfDoc.Add(pdfTable);
            pdfDoc.Close();
            stream.Close();
        }
    }
}
