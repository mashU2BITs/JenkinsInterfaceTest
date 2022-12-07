namespace JenkinsInterfaceTest
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddSite = new System.Windows.Forms.Button();
            this.listBoxSiteList = new System.Windows.Forms.ListBox();
            this.buttonRemSite = new System.Windows.Forms.Button();
            this.buttonLoadSite = new System.Windows.Forms.Button();
            this.textBoxSite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxData = new System.Windows.Forms.RichTextBox();
            this.comboBoxSiteList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelpassFail = new System.Windows.Forms.Panel();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.textBoxFinalString = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPreLoad = new System.Windows.Forms.Button();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewValues = new System.Windows.Forms.DataGridView();
            this.comboBoxXMLFiles = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSaveCOnfig = new System.Windows.Forms.Button();
            this.buttonGetFIles = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSaveToSQL = new System.Windows.Forms.Button();
            this.buttonReadSql = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddSite
            // 
            this.buttonAddSite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSite.Location = new System.Drawing.Point(12, 306);
            this.buttonAddSite.Name = "buttonAddSite";
            this.buttonAddSite.Size = new System.Drawing.Size(160, 31);
            this.buttonAddSite.TabIndex = 0;
            this.buttonAddSite.Text = "Add Data";
            this.buttonAddSite.UseVisualStyleBackColor = true;
            this.buttonAddSite.Click += new System.EventHandler(this.buttonAddSite_Click);
            // 
            // listBoxSiteList
            // 
            this.listBoxSiteList.FormattingEnabled = true;
            this.listBoxSiteList.ItemHeight = 15;
            this.listBoxSiteList.Location = new System.Drawing.Point(12, 73);
            this.listBoxSiteList.Name = "listBoxSiteList";
            this.listBoxSiteList.Size = new System.Drawing.Size(703, 229);
            this.listBoxSiteList.TabIndex = 1;
            // 
            // buttonRemSite
            // 
            this.buttonRemSite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemSite.Location = new System.Drawing.Point(13, 340);
            this.buttonRemSite.Name = "buttonRemSite";
            this.buttonRemSite.Size = new System.Drawing.Size(97, 26);
            this.buttonRemSite.TabIndex = 0;
            this.buttonRemSite.Text = "Remove Data";
            this.buttonRemSite.UseVisualStyleBackColor = true;
            this.buttonRemSite.Click += new System.EventHandler(this.buttonRemSite_Click);
            // 
            // buttonLoadSite
            // 
            this.buttonLoadSite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoadSite.Location = new System.Drawing.Point(935, 18);
            this.buttonLoadSite.Name = "buttonLoadSite";
            this.buttonLoadSite.Size = new System.Drawing.Size(94, 55);
            this.buttonLoadSite.TabIndex = 0;
            this.buttonLoadSite.Text = "Command line option";
            this.buttonLoadSite.UseVisualStyleBackColor = true;
            this.buttonLoadSite.Click += new System.EventHandler(this.buttonLoadSite_Click);
            // 
            // textBoxSite
            // 
            this.textBoxSite.Location = new System.Drawing.Point(177, 318);
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.Size = new System.Drawing.Size(470, 23);
            this.textBoxSite.TabIndex = 2;
            this.textBoxSite.Text = "job/Job_Build_Master_calc/api/xml";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Put link of site to add or remove here";
            // 
            // richTextBoxData
            // 
            this.richTextBoxData.Location = new System.Drawing.Point(8, 407);
            this.richTextBoxData.Name = "richTextBoxData";
            this.richTextBoxData.Size = new System.Drawing.Size(1021, 344);
            this.richTextBoxData.TabIndex = 4;
            this.richTextBoxData.Text = "";
            // 
            // comboBoxSiteList
            // 
            this.comboBoxSiteList.FormattingEnabled = true;
            this.comboBoxSiteList.Location = new System.Drawing.Point(63, 45);
            this.comboBoxSiteList.Name = "comboBoxSiteList";
            this.comboBoxSiteList.Size = new System.Drawing.Size(652, 23);
            this.comboBoxSiteList.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Site List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // panelpassFail
            // 
            this.panelpassFail.Location = new System.Drawing.Point(749, 85);
            this.panelpassFail.Name = "panelpassFail";
            this.panelpassFail.Size = new System.Drawing.Size(62, 55);
            this.panelpassFail.TabIndex = 7;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(790, 188);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(239, 23);
            this.textBoxUserName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "UserName";
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(790, 215);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(239, 23);
            this.textBoxToken.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "User Token";
            // 
            // buttonAuth
            // 
            this.buttonAuth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAuth.Location = new System.Drawing.Point(818, 85);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(211, 55);
            this.buttonAuth.TabIndex = 8;
            this.buttonAuth.Text = "Run Http";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // textBoxFinalString
            // 
            this.textBoxFinalString.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFinalString.Location = new System.Drawing.Point(73, 9);
            this.textBoxFinalString.Name = "textBoxFinalString";
            this.textBoxFinalString.Size = new System.Drawing.Size(753, 29);
            this.textBoxFinalString.TabIndex = 2;
            this.textBoxFinalString.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Edit Here";
            // 
            // buttonPreLoad
            // 
            this.buttonPreLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPreLoad.Location = new System.Drawing.Point(825, 8);
            this.buttonPreLoad.Name = "buttonPreLoad";
            this.buttonPreLoad.Size = new System.Drawing.Size(79, 30);
            this.buttonPreLoad.TabIndex = 0;
            this.buttonPreLoad.Text = "PreLoad";
            this.buttonPreLoad.UseVisualStyleBackColor = true;
            this.buttonPreLoad.Click += new System.EventHandler(this.buttonPreLoad_Click);
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoadFile.Location = new System.Drawing.Point(840, 323);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(189, 25);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "Load XML into gridview -->";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Set File Name here -->\r\n";
            this.label8.Click += new System.EventHandler(this.label7_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.InitialDirectory = "C:\\temp";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(338, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Result ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(143, 385);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(196, 23);
            this.textBoxFileName.TabIndex = 11;
            this.textBoxFileName.Text = "Jkns";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridViewValues
            // 
            this.dataGridViewValues.AllowUserToAddRows = false;
            this.dataGridViewValues.AllowUserToDeleteRows = false;
            this.dataGridViewValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValues.Location = new System.Drawing.Point(1033, 9);
            this.dataGridViewValues.Name = "dataGridViewValues";
            this.dataGridViewValues.ReadOnly = true;
            this.dataGridViewValues.RowTemplate.Height = 25;
            this.dataGridViewValues.Size = new System.Drawing.Size(842, 745);
            this.dataGridViewValues.TabIndex = 12;
            this.dataGridViewValues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewValues_CellClick);
            // 
            // comboBoxXMLFiles
            // 
            this.comboBoxXMLFiles.FormattingEnabled = true;
            this.comboBoxXMLFiles.Items.AddRange(new object[] {
            "C:\\temp\\33TestFile.xml"});
            this.comboBoxXMLFiles.Location = new System.Drawing.Point(180, 349);
            this.comboBoxXMLFiles.Name = "comboBoxXMLFiles";
            this.comboBoxXMLFiles.Size = new System.Drawing.Size(849, 23);
            this.comboBoxXMLFiles.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(698, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "List of XML files";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // buttonSaveCOnfig
            // 
            this.buttonSaveCOnfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveCOnfig.Location = new System.Drawing.Point(790, 153);
            this.buttonSaveCOnfig.Name = "buttonSaveCOnfig";
            this.buttonSaveCOnfig.Size = new System.Drawing.Size(137, 29);
            this.buttonSaveCOnfig.TabIndex = 0;
            this.buttonSaveCOnfig.Text = "Save Config";
            this.buttonSaveCOnfig.UseVisualStyleBackColor = true;
            this.buttonSaveCOnfig.Click += new System.EventHandler(this.buttonSaveCOnfig_Click);
            // 
            // buttonGetFIles
            // 
            this.buttonGetFIles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGetFIles.Location = new System.Drawing.Point(689, 307);
            this.buttonGetFIles.Name = "buttonGetFIles";
            this.buttonGetFIles.Size = new System.Drawing.Size(137, 25);
            this.buttonGetFIles.TabIndex = 0;
            this.buttonGetFIles.Text = "Refresh Files in List";
            this.buttonGetFIles.UseVisualStyleBackColor = true;
            this.buttonGetFIles.Click += new System.EventHandler(this.buttonGetFIles_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(717, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(310, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "File Name must contain \'agent,run,detailedjob,rundetails\'";
            this.label9.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Saves the info below into a file of any type.";
            this.label10.Click += new System.EventHandler(this.label7_Click);
            // 
            // buttonSaveToSQL
            // 
            this.buttonSaveToSQL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveToSQL.Location = new System.Drawing.Point(869, 288);
            this.buttonSaveToSQL.Name = "buttonSaveToSQL";
            this.buttonSaveToSQL.Size = new System.Drawing.Size(137, 29);
            this.buttonSaveToSQL.TabIndex = 0;
            this.buttonSaveToSQL.Text = "Sql Write";
            this.buttonSaveToSQL.UseVisualStyleBackColor = true;
            this.buttonSaveToSQL.Click += new System.EventHandler(this.buttonSaveToSQL_Click);
            // 
            // buttonReadSql
            // 
            this.buttonReadSql.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReadSql.Location = new System.Drawing.Point(869, 244);
            this.buttonReadSql.Name = "buttonReadSql";
            this.buttonReadSql.Size = new System.Drawing.Size(137, 29);
            this.buttonReadSql.TabIndex = 0;
            this.buttonReadSql.Text = "Sql Read";
            this.buttonReadSql.UseVisualStyleBackColor = true;
            this.buttonReadSql.Click += new System.EventHandler(this.buttonReadSql_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 811);
            this.Controls.Add(this.dataGridViewValues);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxToken);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonAuth);
            this.Controls.Add(this.panelpassFail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxXMLFiles);
            this.Controls.Add(this.comboBoxSiteList);
            this.Controls.Add(this.richTextBoxData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFinalString);
            this.Controls.Add(this.textBoxSite);
            this.Controls.Add(this.listBoxSiteList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLoadSite);
            this.Controls.Add(this.buttonReadSql);
            this.Controls.Add(this.buttonSaveToSQL);
            this.Controls.Add(this.buttonSaveCOnfig);
            this.Controls.Add(this.buttonGetFIles);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.buttonPreLoad);
            this.Controls.Add(this.buttonRemSite);
            this.Controls.Add(this.buttonAddSite);
            this.Name = "MainForm";
            this.Text = "Jenkins Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddSite;
        private System.Windows.Forms.ListBox listBoxSiteList;
        private System.Windows.Forms.Button buttonRemSite;
        private System.Windows.Forms.Button buttonLoadSite;
        private System.Windows.Forms.TextBox textBoxSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxData;
        private System.Windows.Forms.ComboBox comboBoxSiteList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelpassFail;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.TextBox textBoxFinalString;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonPreLoad;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridViewValues;
        private System.Windows.Forms.ComboBox comboBoxXMLFiles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSaveCOnfig;
        private System.Windows.Forms.Button buttonGetFIles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSaveToSQL;
        private System.Windows.Forms.Button buttonReadSql;
    }
}
