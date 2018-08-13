using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LockedCustomerExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ExcecuteExtraction(string lockedCustomersPath, string sourcePath, string restultPath, string reportPath)
        {
            List<string> lockedCustomersIds = readLockedCustomers(lockedCustomersPath);
            string startTime = DateTime.Now.ToString();
            int nrOfLockedCustomers = lockedCustomersIds.Count();
            if (nrOfLockedCustomers > 0)
            {
                List<string> matches = matchLockedCustomersToScource(lockedCustomersIds, sourcePath);
                int nrOfMatches = matches.Count();
                if (nrOfMatches > 0)
                {
                    var header = extractheader(sourcePath);
                    Dictionary<string, bool> customIdsWithMatchingStatus = getCustomerIdWithMatchingStatus(lockedCustomersIds, matches);
                    var printStatus = printResult(matches, header, restultPath);
                    if(printStatus)
                    {
                        string endTime = DateTime.Now.ToString();
                        var reportStatus = printReport(reportPath, startTime, endTime, nrOfLockedCustomers, nrOfMatches, customIdsWithMatchingStatus);
                        MessageBox.Show("Printing Succesfull.");
                    } else
                    {
                        MessageBox.Show("Printing Failed.");
                    }
                } else
                {
                    MessageBox.Show("No machtes found.");
                }
            } else
            {
                MessageBox.Show("No customers found in customerLock file");
            }
        }
        private Dictionary<string, bool> getCustomerIdWithMatchingStatus(List<string> lockedCustomerIds, List<string> matches)
        {
            Dictionary<string, bool> customerIdsWithMatchingStatus = new Dictionary<string, bool>();
            List<string> matchIds = new List<string>();
            foreach(string mach in matches)
            {
                matchIds.Add(mach.Split(';')[0]);
            }

            foreach(string lockedCustomer in lockedCustomerIds)
            {
                if(matchIds.Contains(lockedCustomer))
                {
                    customerIdsWithMatchingStatus.Add(lockedCustomer, true);
                } else
                {
                    customerIdsWithMatchingStatus.Add(lockedCustomer, false);
                }
            }
            return customerIdsWithMatchingStatus;
        }
        private bool printReport(string reportPath, string startTime, string endTime, int nrOfLockedCustomers, int nrOfMatches, Dictionary<string, bool> customIdsWithMatchingStatus)
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
                    if(customerwithStatus.Value)
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
        private List <string> readLockedCustomers(string path)
        {
            List<string> lockedCustomersIds = new List<string>();
            var reader = new StreamReader(path);
            try
            {
                while(!reader.EndOfStream)
                {
                    lockedCustomersIds.Add(reader.ReadLine());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                reader.Close();
            }
            return lockedCustomersIds;
        }
        private List<string> matchLockedCustomersToScource(List<string> lockedCustomerIds, string sourcePath)
        {
            List<string> matches = new List<string>();

            var reader = new StreamReader(sourcePath);
            try
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string customerNumber = line.Split(';')[0];
                    if(lockedCustomerIds.Contains(customerNumber)) {
                        matches.Add(line);
                    }
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            } finally
            {
                reader.Close();
            }

            return matches;
        }
        private string extractheader(string sourcePath)
        {
            var reader = new StreamReader(sourcePath);
            var header = "";
            try
            {
                header = reader.ReadLine();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                reader.Close();
            }

            return header;
        }
        private bool printResult(List<string> matches, string header, string resultPath)
        {
            bool succes = false;
            StreamWriter writer = new StreamWriter(resultPath);
            try
            {
                writer.WriteLine(header);
                foreach(string match in matches)
                {
                    writer.WriteLine(match);
                }
                succes = true;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } finally
            {
                writer.Close();
            }
            return succes;
        }
        private void ExtractButton_Click(object sender, EventArgs e)
        {
            ExtractButton.Text = "Extracting data.... please wait";
            ExtractButton.Enabled = false;

            try
            {
                string lockedCustomerPath = null;
                if (!String.IsNullOrEmpty(LockCustInput.Text)) {
                    lockedCustomerPath = LockCustInput.Text;
                } else
                {
                    throw new Exception("Please fill out a path to the file containing the locked customers to match.");
                }
                string sourcePath = null;
                if (!String.IsNullOrEmpty(SourceInput.Text)) {
                    sourcePath = SourceInput.Text;
                } else
                {
                    throw new Exception("Please fill out a path to the importsource.");
                }
                string resultPath = null;
                if (!String.IsNullOrEmpty(ResultPathInput.Text)) {
                    resultPath = ResultPathInput.Text;
                } else
                {
                    throw new Exception("Please fill out a path where the result will be saved.");
                }
                string reportPath = null;
                if(!String.IsNullOrEmpty(ReportFPInput.Text))
                {
                    reportPath = ReportFPInput.Text;
                } else
                {
                    throw new Exception("Please fill out a path where the report will be saved.");
                }
                ExcecuteExtraction(lockedCustomerPath, sourcePath, resultPath, reportPath);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                ExtractButton.Enabled = true;
                ExtractButton.Text = "Extract";
            } finally
            {
                ExtractButton.Enabled = true;
                ExtractButton.Text = "Extract";
            }


        }
    }
}
