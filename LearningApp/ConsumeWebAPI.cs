using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace LearningApp
{
    public class ConsumeWebApi
    {
        public void CallApi()
        {
            WebClient client = new System.Net.WebClient();
            string url = string.Empty;
            string accountNumber = "1706005";//"0432050020010",
            string fips = "48085";//"48201";//http://localhost:61432 ///Inedtest:1000/
            url = "http://localhost:61432/api/Report/GetPropertyPDF?accountNumber=" + accountNumber + "&fips=" + fips + "";
            string token = "ctU/9Q1sueE8pZi65bRqTVHADtmOOZBhd7tHkBLLsnGYJQDMxY7bfXpWN4XGVxVAUURKvLQWf6nWXnrHimV+NMqb7UBDVR7NEyG45WaX1TxRO0aD9WWrZVFobxWyEVMxnNWH92OVAataKuF6Cx1XScdHa/I6++sAFIdXTiYCj3LyUPul3Tt52EYxdw/dmK0vTEcPCkCjkRDhv9kHsdnb2bJHqygd4a723GbeMnGG4g8ZbXmpuSnIMb4VDs/vBOO0ZYHEmxI5rOmC8zZkQnPrdV9Xa+mOgwY1BA4Bbu1vxWBfhhJ4tO/bmjNcWU1JtnTL";
            string apptoken = "7KBkttLA/5BdL7izn8WtKb8wVtCMcmut2cDBssBlFlM=";

            client.Headers.Add("apptoken", apptoken);
            client.Headers.Add("token", token);
            var data = client.DownloadData(url);
            File.WriteAllBytes(@"D:\Downloaded Files\" + accountNumber + "_" + fips + ".pdf", data);
        }
    }
}

public class CrystalReports
{
    public void GenerateCrystalReport()
    {
        ReportDocument report = new ReportDocument();
        report.Load("Sample.rpt");
        DataTable dataTable = new DataTable();

        report.ExportToDisk(ExportFormatType.PortableDocFormat, "Report.pdf");
    }
}