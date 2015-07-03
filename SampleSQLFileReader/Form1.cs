using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InstagramBotLib.Helper;

namespace SampleSQLFileReader
{
    public partial class Form1 : Form
    {
        List<Data> lstData = new List<Data>();
        List<UserDetail> MoreThanThirty = new List<UserDetail>();
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtbox.Text = UploadTextFile(Application.StartupPath);

                List<string> data = SoftBucketFileUtillity.ReadFile(txtbox.Text.Trim());

                foreach (var item in data)
                {
                    string[] strarr = item.Split(')');

                    foreach (string EachRecord in strarr)
                    {
                        try
                        {
                            Data daTa = new Data();

                            if (!string.IsNullOrEmpty(EachRecord))
                            {
                                string datacontent = EachRecord.TrimStart(',');

                                daTa.Id = datacontent.Split(',')[0].Replace("(", "");

                                daTa.Name = datacontent.Split(',')[1].Replace("'", "");

                                daTa.Guid = datacontent.Split(',')[2].Replace("'", "");


                                lstData.Add(daTa);

                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }

                MoreThanThirty = (from D in lstData
                        group D by D.Guid into P
                        select new UserDetail { Count = P.Count(), Guid = P.Key}).OrderByDescending(T => T.Count).ToList();


                MoreThanThirty = MoreThanThirty.Where(C => C.Count > 30).ToList();

            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                int RandomGuid = rnd.Next(0, MoreThanThirty.Count);

                string RandomGuidVal = MoreThanThirty[RandomGuid].Guid;

                int GuidCount = MoreThanThirty[RandomGuid].Count;

                Data Name = lstData.FirstOrDefault(U => U.Guid == RandomGuidVal);

                lblMessage.Text = "UUID : " + RandomGuidVal + "  Name : " + Name.Name + "  Votes : " + GuidCount;

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnwinner2_Click(object sender, EventArgs e)
        {
            try
            {

                int RandomGuid = rnd.Next(0, MoreThanThirty.Count);

                string RandomGuidVal = MoreThanThirty[RandomGuid].Guid;

                int GuidCount = MoreThanThirty[RandomGuid].Count;

                Data Name = lstData.FirstOrDefault(U => U.Guid == RandomGuidVal);


                label2.Text = "UUID : " + RandomGuidVal + "  Name : " + Name.Name + "  Votes : " + GuidCount;

            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }

        private void btnwinner3_Click(object sender, EventArgs e)
        {
            try
            {

                int RandomGuid = rnd.Next(0, MoreThanThirty.Count);

                string RandomGuidVal = MoreThanThirty[RandomGuid].Guid;

                int GuidCount = MoreThanThirty[RandomGuid].Count;

                Data Name = lstData.FirstOrDefault(U => U.Guid == RandomGuidVal);

                label3.Text = "UUID : " + RandomGuidVal + "  Name : " + Name.Name + "  Votes : " + GuidCount;

            }
            catch (Exception ex)
            {
                label3.Text = ex.Message;
            }
        }

        private void btnwinner4_Click(object sender, EventArgs e)
        {
            try
            {

                int RandomGuid = rnd.Next(0, MoreThanThirty.Count);

                string RandomGuidVal = MoreThanThirty[RandomGuid].Guid;

                int GuidCount = MoreThanThirty[RandomGuid].Count;

                Data Name = lstData.FirstOrDefault(U => U.Guid == RandomGuidVal);

                label4.Text = "UUID : " + RandomGuidVal + "  Name : " + Name.Name + "  Votes : " + GuidCount;

            }
            catch (Exception ex)
            {
                label4.Text = ex.Message;
            }
        }

        private void btnwinner5_Click(object sender, EventArgs e)
        {
            try
            {

                int RandomGuid = rnd.Next(0, MoreThanThirty.Count);

                string RandomGuidVal = MoreThanThirty[RandomGuid].Guid;

                int GuidCount = MoreThanThirty[RandomGuid].Count;

                Data Name = lstData.FirstOrDefault(U => U.Guid == RandomGuidVal);

                label5.Text = "UUID : " + RandomGuidVal + "  Name : " + Name.Name + "  Votes : " + GuidCount;

            }
            catch (Exception ex)
            {
                label5.Text = ex.Message;
            }
        }

        public static string UploadTextFile(string DirectoryPath)
        {
            string FilePath = string.Empty;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = DirectoryPath;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FilePath = ofd.FileName;
                }
            }

            return FilePath;
        }
    }

    public class Data
    {
      public  string Id { get; set; }
      public string Name { get; set; }
      public string Guid { get; set; }
    }

    public class UserDetail
    {
        public int Count { get; set; }
        public string Name { get; set; }
        public string Guid { get; set; }
    }
}
