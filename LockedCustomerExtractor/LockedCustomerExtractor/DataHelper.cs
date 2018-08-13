using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockedCustomerExtractor
{
    public class DataHelper
    {
        internal Dictionary<string, bool> GetTheInputs(RichTextBox richTextBox)
        {
            Dictionary<string, bool> lockedCustomersIds = new Dictionary<string, bool>();

            foreach (var input in richTextBox.Text.Split(new[] { '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (!lockedCustomersIds.ContainsKey(input))
                    lockedCustomersIds.Add(input, int.TryParse(input, out int res));
            }

            return lockedCustomersIds;
        }
        internal Dictionary<string, bool> GetCustomerIdWithMatchingStatus(List<string> lockedCustomerIds, List<string> matches)
        {
            Dictionary<string, bool> customerIdsWithMatchingStatus = new Dictionary<string, bool>();
            List<string> matchIds = new List<string>();
            foreach (string mach in matches)
            {
                matchIds.Add(mach.Split(';')[0]);
            }

            foreach (string lockedCustomer in lockedCustomerIds)
            {
                if (matchIds.Contains(lockedCustomer))
                {
                    customerIdsWithMatchingStatus.Add(lockedCustomer, true);
                }
                else
                {
                    customerIdsWithMatchingStatus.Add(lockedCustomer, false);
                }
            }
            return customerIdsWithMatchingStatus;
        }
        internal bool PrintResult(List<string> matches, string resultPath)
        {
            bool succes = false;

            StreamWriter writer = new StreamWriter(resultPath);
            try
            {

                foreach (string match in matches)
                {
                    writer.WriteLine(match);

                }
                succes = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                writer.Close();
            }
            return succes;
        }
        internal bool PrintReport(string reportPath, string startTime, string endTime, int nrOfLockedCustomers, int nrOfMatches, Dictionary<string, bool> customIdsWithMatchingStatus)
        {
            bool succes = false;
            StreamWriter writer = new StreamWriter(reportPath);
            try
            {
                writer.WriteLine("StartDateTime: {0}", startTime);
                writer.WriteLine("EndDateTimeTime: {0}", endTime);
                writer.WriteLine("Number of locked customers in LockedCustomeSource: {0}", nrOfLockedCustomers);
                writer.WriteLine("Number of matches: {0}", nrOfMatches);
                writer.WriteLine();
                writer.WriteLine("Succesfully extracted customers:");
                foreach (KeyValuePair<string, bool> customerwithStatus in customIdsWithMatchingStatus)
                {
                    if (customerwithStatus.Value)
                    {
                        writer.WriteLine(customerwithStatus.Key);
                    }
                }
                writer.WriteLine();
                writer.WriteLine("Customers not found in sourcefile:");
                foreach (KeyValuePair<string, bool> customerwithStatus in customIdsWithMatchingStatus)
                {
                    if (!customerwithStatus.Value)
                    {
                        writer.WriteLine(customerwithStatus.Key);
                    }
                }

                succes = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                writer.Close();
            }
            return succes;

        }
        internal List<string> MatchLockedCustomersToScource(List<string> lockedCustomerIds, string sourcePath)
        {
            List<string> matches = new List<string>();

            var reader = new StreamReader(sourcePath);
            try
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string customerNumber = line.Split(';')[0];
                    if (lockedCustomerIds.Contains(customerNumber))
                    {
                        matches.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                reader.Close();
            }

            return matches;
        }
        internal string Extractheader(string sourcePath)
        {
            var reader = new StreamReader(sourcePath);
            var header = "";
            try
            {
                header = reader.ReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                reader.Close();
            }

            return header;
        }
        internal string GetFileName()
        {
            string fileToOpen = "";
            var FD = new OpenFileDialog();


            if (FD.ShowDialog() == DialogResult.OK)
            {
                fileToOpen = FD.FileName;
                FileInfo File = new FileInfo(FD.FileName);
                StreamReader reader = new StreamReader(fileToOpen);               //etc
            }
            return fileToOpen;
        }
        internal string OpenFolder()
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };
            return folderDlg.ShowDialog() == DialogResult.OK ? folderDlg.SelectedPath : null;

        }
    }
}
