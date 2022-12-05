using JenkinsInterfaceTest.Properties;
using System;
using System.Collections.Generic; 
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Web;

//using BaseClassNameSpace.Web.BaseServices;

namespace JenkinsInterfaceTest
{
    public partial class MainForm : Form
    {
        private static Properties.Settings settings = new Properties.Settings();
        // private string clay's token = "11812367e96a53ffe4324f6a469d132a92";
        private static string HTTPResponse = "";
        public MainForm()
        {
            InitializeComponent();

            LoadSettings();

            comboBoxSiteList.SelectedIndex = 0;
            RefreshFilesFromDisk();
            comboBoxXMLFiles.SelectedIndex = 0;
            panelpassFail.BackColor = Color.Green;
           
        }

        private void LoadSettings()
        {
            try
            {
                if (File.Exists(settings.ConfigFile))
                {
                    // load configuration data to save in the application.ini
                    AppInitData aid = new AppInitData();
                    aid = aid.ReadFromDisk(settings.ConfigFile);
                    var sitelistitemstosave = aid.commandlist.Split(';').ToArray();
                    foreach (var item in sitelistitemstosave)
                    {
                        if (!string.IsNullOrEmpty(item))
                        {
                            listBoxSiteList.Items.Add(item);
                        }
                    }
                   
                    textBoxUserName.Text = aid.username;
                    textBoxToken.Text = aid.token;
                    var SitePathItemstoSave = aid.defaultsitepath.Split(';').ToArray();
                    foreach (var item in SitePathItemstoSave)
                    {
                        if (!string.IsNullOrEmpty(item))
                        {
                            comboBoxSiteList.Items.Add(item);
                        }
                    }              
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void buttonAddSite_Click(object sender, EventArgs e)
        {
            bool skipper = false;
            for (int i = 0; i < listBoxSiteList.Items.Count; i++)
            {
                if (listBoxSiteList.Items[i].Equals(textBoxSite.Text))
                {
                    skipper = true;
                }
            }
            if (!skipper)
            {
                listBoxSiteList.Items.Add(textBoxSite.Text);
            }
        }

        private  HttpWebRequest CreateHttpRequest(string URLName)
        {

            //Creating HTTP web request
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(URLName);

            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.Method = "POST";

            byte[] credentialBuffer =
                new UTF8Encoding().GetBytes(textBoxUserName.Text + ":" + textBoxToken.Text);

            httpWebRequest.Headers["Authorization"] =
               "Basic " + Convert.ToBase64String(credentialBuffer);

            httpWebRequest.PreAuthenticate = true;
            
            return httpWebRequest;
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            HTTPPOST();

        }

        private void HTTPPOST()
        {
            richTextBoxData.Clear();
            try
            {
                string uridata = textBoxFinalString.Text;
                HttpWebRequest foo = CreateHttpRequest(uridata);

                var httpResponse = (HttpWebResponse)foo.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    richTextBoxData.AppendText(responseText);
                }
            }
            catch (Exception ex)
            {
                richTextBoxData.AppendText(ex.ToString());
            }
        }

        private void HTTPPOST(string command)
        {
            richTextBoxData.Clear();
            try
            {
                string uridata = string.Format("{0}{1}",comboBoxSiteList.Text,command);
                HttpWebRequest foo = CreateHttpRequest(uridata);

                var httpResponse = (HttpWebResponse)foo.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    richTextBoxData.AppendText(responseText);
                    HTTPResponse = responseText.ToString();
                }
            }
            catch (Exception ex)
            {
                richTextBoxData.AppendText(ex.ToString());
            }
        }
        private string HTTPPOSTRunInfo(string RunName, int runId)
        {
            richTextBoxData.Clear();
           
            try
            {
                string uridata = string.Format("{0}job/{1}/{2}/", comboBoxSiteList.Text, RunName,runId);
                HttpWebRequest foo = CreateHttpRequest(uridata);

                var httpResponse = (HttpWebResponse)foo.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    string responseText = streamReader.ReadToEnd();
                    richTextBoxData.AppendText(responseText);
                    HTTPResponse = responseText.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return HTTPResponse;
        }
        private void dataGridViewValues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewValues.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                if (dataGridViewValues.CurrentCell != null && dataGridViewValues.CurrentCell.Value != null)
                {
                    //do work
                    string runname = dataGridViewValues.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    int runid = Convert.ToInt32( dataGridViewValues.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    string foobar = HTTPPOSTRunInfo(runname,runid);

                }
            }
        }
         
        private string runcommand (string command)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = string.Format("/c {0}",command);
            process.StartInfo = startInfo;
            var result = process.Start();
            string texttoadd2 = string.Format("{0}{2} {1}", richTextBoxData.Text, result.ToString(), Environment.NewLine);
            richTextBoxData.AppendText(texttoadd2);
            richTextBoxData.AppendText(result.ToString());
            return result.ToString();

        }

        private void buttonLoadSite_Click(object sender, EventArgs e)
        {
            richTextBoxData.Clear();
            string uridata  = textBoxFinalString.Text;
            string foo = string.Format("curl -X POST -L --user {0}:{1} {2} >> temp2.xml", textBoxUserName.Text, textBoxToken.Text, uridata);
            var temp = runcommand(foo);
            richTextBoxData.AppendText(foo);

        }

      
        private void buttonRemSite_Click(object sender, EventArgs e)
        {
            // int lineIndex = this.GetLineFromCharIndex(cursorPosition);
            // int linenum = richTextBoxData.GetLineFromCharIndex();
        }

        private void buttonPreLoad_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxFinalString.Text = string.Format(@"{0}{1}", comboBoxSiteList.SelectedItem.ToString(), listBoxSiteList.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "HTML Pafe|*.html|XML Page|*.xml|Text Page|*.txt";
            saveFileDialog1.Title = "Save an returned info to a File";
            saveFileDialog1.FileName = textBoxFileName.Text;
            
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory.ToString();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fp = Path.Combine(saveFileDialog1.InitialDirectory, saveFileDialog1.FileName);
                File.WriteAllText(fp, richTextBoxData.Text);
                comboBoxXMLFiles.Items.Add(fp);
            }
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            richTextBoxData.Clear();
            if (!string.IsNullOrEmpty(@comboBoxXMLFiles.Text.ToString()))
            {
                string tempLocation = @comboBoxXMLFiles.Text.ToString().ToLower();
                if (File.Exists(tempLocation))
                {
                    if (tempLocation.Contains("agent"))
                    {
                        ProcessAgentInfo(@tempLocation);
                    }
                    else if (tempLocation.Contains("project"))
                    {
                        ProcessRunData(@tempLocation);
                    }
                    else if (tempLocation.Contains("detailedjob"))
                    {
                        ProcessDetailedRunData(@tempLocation);
                    }
                    else if (tempLocation.Contains("rundetails"))
                    {
                        ProcessDetailedRunData(@tempLocation);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void ProcessAgentInfo(string filename)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            AgentStatus aas = new AgentStatus();
            XmlDocument doc = new XmlDocument();
                doc.Load(filename);
            dt.TableName = "AgentInfo";
            dt.Columns.Add("AgentName", typeof(string));
            dt.Columns.Add("OffLine", typeof(bool));
            dt.Columns.Add("AvailSwapSpc", typeof(string));
            dt.Columns.Add("AvailPhysMem", typeof(string));
            dt.Columns.Add("TtlSwapSpc", typeof(string));
            dt.Columns.Add("TtlPhysMem", typeof(string));


            // now process xml data and fill class object to display info and other options that are easy with a class
            foreach (XmlNode nod in doc.DocumentElement.ChildNodes)
            {
                switch (nod.Name.ToLower())
                {
                    case "displayname":
                        aas.DisplayName = nod.InnerText.ToString();
                        break;
                    case "result":
                        if (nod.InnerText.ToLower().Equals("false"))
                        {
                            aas.Offline = false;
                        }
                        else
                        {
                            aas.Offline = true;
                        }
                        break;
                    case "monitordata":
                        XmlNode chnode= nod.ChildNodes[0].ChildNodes[1];
                        aas.AvailableSwapSpace = chnode.InnerText.ToString();
                        XmlNode chnode2 = nod.ChildNodes[0].ChildNodes[0];
                        aas.AvailablePhysicalMemory = chnode2.InnerText.ToString();
                        XmlNode chnode3 = nod.ChildNodes[0].ChildNodes[3];
                        aas.TotalSwapSpace = chnode3.InnerText.ToString();
                        XmlNode chnode4 = nod.ChildNodes[0].ChildNodes[2];
                        aas.TotalPhysicalMemory = chnode4.InnerText.ToString();
                        break;
                    default:
                        break;
                }
            }
            
            dt.Rows.Add(aas.displayName, aas.offline, aas.availableSwapSpace, aas.availablePhysicalMemory, aas.totalSwapSpace, aas.totalPhysicalMemory);
            dataGridViewValues.DataSource = ds.Tables[0];
            if (aas.offline)
            {
                dataGridViewValues.Rows[0].Cells[2].Style.BackColor = Color.Red;
            }
            else
            {
                dataGridViewValues.Rows[0].Cells[2].Style.BackColor = Color.Green;
            }
        }

        private void ProcessRunData( string filename)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            RunResults rr = new RunResults();
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            dt.TableName = "BuildInfo";
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("RunName", typeof(string));
            dt.Columns.Add("InProgress", typeof(bool));
            dt.Columns.Add("Result", typeof(bool));
            dt.Columns.Add("Url", typeof(string));
            foreach (XmlNode nod in doc.DocumentElement.ChildNodes)
            {
                switch (nod.Name.ToLowerInvariant())
                {
                    case "id":
                        rr.BuildNumMain = nod.InnerText;
                        break;
                    case "inprogress":
                        if (nod.InnerText.ToLower().Equals("false"))
                        {
                            rr.In_Progress = false;
                        }
                        else
                        {
                            rr.In_Progress = true;
                        }
                        break;
                    case "result":
                        if (nod.InnerText.ToLower().Equals("false"))
                        {
                            rr.Result = false;
                        }
                        else
                        {
                            rr.Result = true;
                        }
                        break;
                    case "builtOn":
                        rr.BuiltOn = nod.InnerText;
                        break;
                    case "url":
                        rr.Url = nod.InnerText;
                        break;
                    case "timestamp":
                        long time = Convert.ToInt64(nod.InnerText);
                        time /= 1000;
                        DateTime result = DateTimeOffset.FromUnixTimeMilliseconds(time).DateTime;
                        rr.DT  = result;
                        break;
                    default:
                        break;
                }
            } // end for each now load line for dataset.
            dt.Rows.Add(rr.BuildNumMain, rr.BuiltOn, rr.In_Progress.ToString(), rr.Result.ToString(), rr.Url);
            dataGridViewValues.DataSource = ds.Tables[0];
            if (rr.result)
            {
                dataGridViewValues.Rows[0].Cells[3].Style.BackColor = Color.Green;
            }
            else
            {
                dataGridViewValues.Rows[0].Cells[3].Style.BackColor = Color.Red;
            }
            if (rr.in_progress)
            {
                dataGridViewValues.Rows[0].Cells[2].Style.BackColor = Color.Green;
            }
            else
            {
                dataGridViewValues.Rows[0].Cells[2].Style.BackColor = Color.Red;
            }
        }
        private void ProcessDetailedRunData(string filename)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            string runName = "";
            string fullName = "";
            List <string> runUrls = new List<string>();
            List<int> runIDs = new List<int>();
            RunResults rr = new RunResults();
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            dt.TableName = "Detailed_Build_Info";
            dt.Columns.Add("Display_Name", typeof(string));
            dt.Columns.Add("FullName", typeof(string));
            dt.Columns.Add("Run_ID", typeof(int));             
            dt.Columns.Add("Run_Url", typeof(string));
            foreach (XmlNode nod in doc.DocumentElement.ChildNodes)
            {
                switch (nod.Name.ToLowerInvariant())
                {
                    case "displayname":
                        runName = nod.InnerText;
                        break;
                    case "fullname":
                        fullName = nod.InnerText;
                        break;
                    case "build":
                        runIDs.Add(Convert.ToInt32(nod.ChildNodes[0].InnerText));
                        runUrls.Add(nod.ChildNodes[1].InnerText);
                        break;
                    default:
                        break;
                }
            } // end for each now load line for dataset.
            for (int i = 0; i < runIDs.Count; i++)
            {
                //var tetst = HttpUtility.UrlPathEncode(runIDs[i].ToString());
                //string tempwebUrl = string.Format("{0}", HttpUtility.UrlPathEncode(runIDs[i].ToString()));
                dt.Rows.Add(runName, fullName, runIDs[i], HttpUtility.UrlPathEncode(runUrls[i].ToString()));
            }
            dataGridViewValues.DataSource = ds.Tables[0];
        }
        private void ProcessDetailedProjectData(string filename)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            string runName = "";
            string fullName = "";
            List<string> runUrls = new List<string>();
            List<int> runIDs = new List<int>();
            RunResults rr = new RunResults();
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            dt.TableName = "Detailed_Project_Info";
            dt.Columns.Add("Display_Name", typeof(string));
            dt.Columns.Add("FullName", typeof(string));
            dt.Columns.Add("Run_ID", typeof(int));
            dt.Columns.Add("Run_Url", typeof(string));
            foreach (XmlNode nod in doc.DocumentElement.ChildNodes)
            {
                switch (nod.Name.ToLowerInvariant())
                {
                    case "displayname":
                        runName = nod.InnerText;
                        break;
                    case "fullname":
                        fullName = nod.InnerText;
                        break;
                    case "build":
                        runIDs.Add(Convert.ToInt32(nod.ChildNodes[0].InnerText));
                        runUrls.Add(nod.ChildNodes[1].InnerText);
                        break;
                    default:
                        break;
                }
            } // end for each now load line for dataset.
            for (int i = 0; i < runIDs.Count; i++)
            {
                //var tetst = HttpUtility.UrlPathEncode(runIDs[i].ToString());
                //string tempwebUrl = string.Format("{0}", HttpUtility.UrlPathEncode(runIDs[i].ToString()));
                dt.Rows.Add(runName, fullName, runIDs[i], HttpUtility.UrlPathEncode(runUrls[i].ToString()));
            }
            dataGridViewValues.DataSource = ds.Tables[0];
        }
        private void buttonSaveCOnfig_Click(object sender, EventArgs e)
        {
            // load configuration data to save in the application.ini
            AppInitData aid = new AppInitData();
            string sitelistitemstosave = "";
            string sitepathitemstosave = "";
            foreach (string item in listBoxSiteList.Items)
            {
                sitelistitemstosave = string.Format("{0};{1}", sitelistitemstosave,item);
            }
            aid.commandlist = sitelistitemstosave;
            aid.username = textBoxUserName.Text;
            aid.token = textBoxToken.Text;
            foreach (string item in comboBoxSiteList.Items)
            {
                sitepathitemstosave = string.Format("{0};{1}", sitepathitemstosave, item);
            }
            aid.defaultsitepath = sitepathitemstosave;
            aid.WriteToDisk(aid,settings.ConfigFile);
        }
        private void buttonGetFIles_Click(object sender, EventArgs e)
        {
            RefreshFilesFromDisk();
        }
        private void RefreshFilesFromDisk()
        {
            string thePath = Environment.CurrentDirectory.ToString();
            DirectoryInfo di = new DirectoryInfo(thePath);
            comboBoxXMLFiles.Items.Clear();
            comboBoxXMLFiles.Items.AddRange(di.GetFiles("*.xml"));
        }

     
    }

}

