using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

public class ReportGenerator
{
    private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("big Data.mdf") + ";Integrated Security=True;"; // <-- Replace this with your actual SQL Server connection string

    public void GeneratePDFReport()
    { 
        try
        {
            string folderPath = "C:\\Reports";
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, $"InstitutionalReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

            Document document = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            document.Open();

            // Font declarations
            iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16f);
            iTextSharp.text.Font tableTitleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12f);
            iTextSharp.text.Font columnHeaderFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10f);
            iTextSharp.text.Font dataCellFont = FontFactory.GetFont(FontFactory.HELVETICA, 9f);
            iTextSharp.text.Font noDataFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9f);

            // Add main title
            Paragraph title = new Paragraph("Institutional Data Report", titleFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 20f
            };
            document.Add(title);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                DataTable tables = conn.GetSchema("Tables");

                foreach (DataRow row in tables.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();

                    // Table section title
                    Paragraph tableTitle = new Paragraph($"Table: {tableName}", tableTitleFont)
                    {
                        SpacingBefore = 10f,
                        SpacingAfter = 10f
                    };
                    document.Add(tableTitle);

                    string query = $"SELECT * FROM [{tableName}]";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            PdfPTable table = new PdfPTable(dt.Columns.Count)
                            {
                                WidthPercentage = 100,
                                SpacingBefore = 5f,
                                SpacingAfter = 15f
                            };

                            // Add column headers
                            foreach (DataColumn column in dt.Columns)
                            {
                                PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName, columnHeaderFont))
                                {
                                    BackgroundColor = BaseColor.LIGHT_GRAY,
                                    HorizontalAlignment = Element.ALIGN_CENTER,
                                    BorderWidth = 1
                                };
                                table.AddCell(headerCell);
                            }

                            // Add row data
                            foreach (DataRow dataRow in dt.Rows)
                            {
                                foreach (var cell in dataRow.ItemArray)
                                {
                                    PdfPCell dataCell = new PdfPCell(new Phrase(cell.ToString(), dataCellFont))
                                    {
                                        HorizontalAlignment = Element.ALIGN_CENTER,
                                        BorderWidth = 0.5f
                                    };
                                    table.AddCell(dataCell);
                                }
                            }

                            document.Add(table);
                        }
                        else
                        {
                            document.Add(new Paragraph("No data available.", noDataFont));
                        }
                    }

                    document.Add(new Paragraph("\n"));
                }
            }

            document.Close();

            Process.Start("explorer.exe", filePath);
            MessageBox.Show("Report Generated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
