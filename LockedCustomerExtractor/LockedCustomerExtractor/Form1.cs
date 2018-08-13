using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;


namespace LockedCustomerExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        DataHelper dataHelper = new DataHelper();

        private readonly string MainFolderPath = ConfigurationSettings.AppSettings["MainFolderPath"];
        private readonly string ResultFilesPath = ConfigurationSettings.AppSettings["ResultFilesPath"] + "Result.csv";
        private readonly string ReportFilesPath = ConfigurationSettings.AppSettings["ReportFilesPath"] + "Report.txt";
        public void ExcecuteExtraction(string sourcePath, string restultPath, string reportPath)
        {
            ListBoxForInvalidClientNumber.Items.Clear();
            List<string> lockedCustomersIds = new List<string>();

            var inputsAndValues = dataHelper.GetTheInputs(LockCustInput);

            foreach (var input in inputsAndValues)
            {
                if (input.Value)
                {
                    lockedCustomersIds.Add(input.Key);
                }
                else if (!ListBoxForInvalidClientNumber.Items.Contains(input.Key) && input.Key != String.Empty)
                {

                    ListBoxForInvalidClientNumber.Items.Add("wrong input ----" + input.Key);
                }
            }

            string startTime = DateTime.Now.ToString();
            int nrOfLockedCustomers = lockedCustomersIds.Count();
            if (nrOfLockedCustomers > 0)
            {
                List<string> matches = dataHelper.MatchLockedCustomersToScource(lockedCustomersIds, sourcePath);
                int nrOfMatches = matches.Count();
                if (nrOfMatches > 0)
                {
                    var header = dataHelper.Extractheader(sourcePath);
                    Dictionary<string, bool> customIdsWithMatchingStatus = dataHelper.GetCustomerIdWithMatchingStatus(lockedCustomersIds, matches);
                    var printStatus = dataHelper.PrintResult(matches, restultPath);
                    if (printStatus)
                    {
                        string endTime = DateTime.Now.ToString();
                        var reportStatus = dataHelper.PrintReport(reportPath, startTime, endTime, nrOfLockedCustomers, nrOfMatches, customIdsWithMatchingStatus);
                        LinkToTheMainFolder.Visible = true;
                        MessageBox.Show("Printing Succesfull.");

                    }
                    else
                    {
                        MessageBox.Show("Printing Failed.");
                    }
                }
                else
                {
                    MessageBox.Show("No machtes found.");
                }
            }
            else
            {
                MessageBox.Show("No customers found in customerLock file");
            }
        }




        private void ExtractButton_Click(object sender, EventArgs e)
        {
            ExtractButton.Text = "Extracting data.... please wait";
            ExtractButton.Enabled = false;

            try
            {

                string lockedCustomerPath = null;
                if (!String.IsNullOrEmpty(LockCustInput.Text))
                {
                    lockedCustomerPath = LockCustInput.Text;
                }
                else
                {
                    throw new Exception("Please fill out a path to the file containing the locked customers to match.");
                }
                string sourcePath = null;
                if (!String.IsNullOrEmpty(SourceInput.Text))
                {
                    sourcePath = SourceInput.Text;
                }
                else
                {
                    throw new Exception("Please fill out a path to the importsource.");
                }
                string resultPath = null;
                if (!String.IsNullOrEmpty(ResultPathInput.Text))
                {
                    FileInfo file = new FileInfo(ResultPathInput.Text);
                    file.Directory.Create(); // If the directory already exists, this method does nothing.


                    resultPath = file.FullName;
                }
                else
                {
                    throw new Exception("Please fill out a path where the result will be saved.");
                }
                string reportPath = null;
                if (!String.IsNullOrEmpty(ReportFPInput.Text))
                {
                    FileInfo file = new FileInfo(ReportFPInput.Text);
                    file.Directory.Create(); // If the directory already exists, this method does nothing.


                    reportPath = file.FullName;
                }
                else
                {
                    throw new Exception("Please fill out a path where the report will be saved.");
                }
                ExcecuteExtraction(sourcePath, resultPath, reportPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                ExtractButton.Enabled = true;
                ExtractButton.Text = "Extract";
            }
            finally
            {
                ExtractButton.Enabled = true;
                ExtractButton.Text = "Extract";
            }
        }



        private void SourceFilePathButton_Click(object sender, EventArgs e)
        {
            SourceInput.Text = dataHelper.GetFileName();
        }

        private void ResultFilePathButton_Click(object sender, EventArgs e)
        {
            ResultPathInput.Text = dataHelper.OpenFolder();
        }
        private void ReportFilePathButton_Click(object sender, EventArgs e)
        {
            ReportFPInput.Text = dataHelper.OpenFolder();

        }

        private void CB_ResultFile_CheckedChanged(object sender, EventArgs e)
        {
            if (!CB_ResultFile.Checked)
            {
                ResultFilePathButton.Enabled = true;
                ResultPathInput.Text = "";
            }
            else
            {
                ResultPathInput.Text = ResultFilesPath;
                ResultFilePathButton.Enabled = false;
            }
        }

        private void CB_ReportFile_CheckedChanged(object sender, EventArgs e)
        {
            if (!CB_ReportFile.Checked)
            {
                ReportFPInput.Text = "";
                ReportFilePathButton.Enabled = true;
            }
            else
            {
                ReportFPInput.Text = ReportFilesPath;
                ReportFilePathButton.Enabled = false;
            }

        }

        private void LinkToTheMainFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(MainFolderPath);

        }


    }
}
