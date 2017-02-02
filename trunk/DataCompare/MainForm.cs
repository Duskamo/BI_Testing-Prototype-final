﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DataCompare.Controls;
using DataCompare.Enums;
using Google.Cloud.BigQuery.V2;
using DataCompare.Managers;
using DataCompare.Models;
using DataCompare.Utils;

namespace DataCompare
{
    public partial class MainForm : Form
    {
        #region Private fields
        private List<Control> _srcControls;
        private List<Control> _trgControls;
        private List<Control> _compControls;

        private CompareStatus _srcStatus;
        private CompareStatus _trgStatus;
        private bool _refresh;

        private DataTable _dtResult;
        private bool[] _diffColValue;
        private bool[] _diffColType;
        private int _keyNumber;
        private int _columnCount = 6;
        #endregion

        #region Construct
        public MainForm()
        {
            InitializeComponent();
            CollectControls();
            SetLayout(CompareType.Source, CompareStatus.Init);
            SetLayout(CompareType.Target, CompareStatus.Init);
        }
        #endregion

        #region Layout
        private void CollectControls()
        {
            CollectSrcControls();
            CollectTrgControls();
            CollectCompControls();
        }

        private void CollectSrcControls()
        {
            _srcControls = new List<Control> 
            {
                rbtnSrcSql,
                rbtnSrcOracle,
                txtSrcServer,
                chkSrcWinAuth,
                txtSrcUser,
                txtSrcPwd,
                txtSrcSID,
                cboSrcDB,
                btnSrcRfs,
                cboSrcTable,
                btnSrcRfst,
                lblSrcServer, 
                lblSrcDB, 
                rbtnSrcNetezza,
                rbtnSrcGoogle,
                lblSrcUser, 
                lblSrcPwd, 
                lblSrcTable, 
                lblSrcTableSelect,
                cboSrcTableSelect,
                btnSrcUse
            };
        }

        private void CollectTrgControls()
        {
            _trgControls = new List<Control>
            {
                rbtnTrgSql,
                rbtnTrgOracle,
                txtTrgServer,
                chkTrgWinAuth,
                txtTrgUser,
                txtTrgPwd,
                txtTrgSID,
                cboTrgDB,
                btnTrgRfs,
                cboTrgTable,
                btnTrgRfst,
                lblTrgServer,
                lblTrgDB,
                rbtnTrgNetezza,
                rbtnTrgGoogle,
                lblTrgUser,
                lblTrgPwd,
                lblTrgTable,
                lblTrgTableSelect,
                cboTrgTableSelect,
                btnTrgUse
            };
        }

        private void CollectCompControls()
        {
            _compControls = new List<Control> { btnEditMapping, btnCompare, chkShowDiff, btnExport };
        }

        private void SetLayout(CompareType type, CompareStatus status)
        {
            List<Control> oper = null;
            switch (type)
            {
                case CompareType.Source:
                    oper = _srcControls;
                    _srcStatus = status;
                    break;
                case CompareType.Target:
                    oper = _trgControls;
                    _trgStatus = status;
                    break;
                case CompareType.Other:
                    oper = _compControls;
                    break;
            }

            switch (status)
            {
                case CompareStatus.Init:
                    SetLayoutInit(oper);
                    break;
                case CompareStatus.Connected:
                    SetLayoutConnected(oper);
                    break;
                case CompareStatus.Selected:
                    SetLayoutSelected(oper);
                    break;
                case CompareStatus.Used:
                    SetLayoutSelected(oper);
                    break;
                case CompareStatus.Mapped:
                    SetLayoutMapped(oper);
                    break;
                case CompareStatus.Compared:
                    SetLayoutCompared(oper);
                    break;
            }

            _compControls[0].Enabled = (_srcStatus == CompareStatus.Used && _trgStatus == CompareStatus.Used);
        }

        private void SetLayoutInit(List<Control> oper)
        {
            int[] enable = { 0, 1, 2, 4, 8, 13, 19 };
            int[] disable = { 7, 9, 10};

            int[] enableSql = { 3, 4, 5, 15, 16 };
            int[] disableGBQ = { 3, 4, 5, 15, 16 };
            int[] enableOther = { 4, 5, 15, 16 };
            int[] disableOther = { 3 };

            foreach (int i in enable)
            {
                oper[i].Enabled = true;
            }

            foreach (int i in disable)
            {
                oper[i].Enabled = false;
            }

            oper[12].Text = "Database";

            if (((RadioButton)oper[0]).Checked)
            {
                int[] moveSQL = { 7, 9, 8, 10, 12, 17, 15, 16, 4, 5, 3, 18, 19, 20 };
                int[] SQLLocation = { 129, 156, 128, 156, 129, 156, 77, 103, 77, 103, 54, 183, 183, 183, 183 };

                int c = 0;
                foreach (int i in moveSQL)
                {
                    oper[i].Location = new System.Drawing.Point(oper[i].Location.X, SQLLocation[c]);
                    c++;
                }

                oper[11].Text = "Server";

                foreach (int i in enableSql)
                {
                    oper[i].Enabled = true;
                    oper[i].Visible = true;
                }
            }
            else if (((RadioButton)oper[14]).Checked)
            {
                int[] moveGBQ = { 7, 9, 8, 10, 12, 17, 18, 19, 20 };
                int[] GBQLocation = { 54, 81, 53, 81, 54, 81, 108, 108, 108, 108 };

                int c = 0;
                foreach (int i in moveGBQ)
                {
                    oper[i].Location = new System.Drawing.Point(oper[i].Location.X, GBQLocation[c]);
                    c++;
                }

                oper[11].Text = "Project ID";
                oper[12].Text = "Data Set";

                foreach (int i in disableGBQ)
                {
                    oper[i].Enabled = false;
                    oper[i].Visible = false;
                }
            }
            else
            {
                int[] moveOther = { 7, 9, 8, 10, 12, 17, 15, 16, 4, 5, 6, 18, 19, 20 };
                int[] OtherLocation = { 106, 133, 105, 133, 106, 133, 54, 80, 54, 80, 106, 160, 160, 160, 160 };

                int c = 0;
                foreach (int i in moveOther)
                {
                    oper[i].Location = new System.Drawing.Point(oper[i].Location.X, OtherLocation[c]);
                    c++;
                }

                oper[11].Text = "Host:Port";

                foreach (int i in enableOther)
                {
                    oper[i].Enabled = true;
                    oper[i].Visible = true;
                }

                foreach (int i in disableOther)
                {
                    oper[i].Enabled = false;
                    oper[i].Visible = false;
                }
            }

            oper[4].Enabled = !((CheckBox)oper[3]).Checked || ((RadioButton)oper[1]).Checked;
            oper[5].Enabled = !((CheckBox)oper[3]).Checked || ((RadioButton)oper[1]).Checked;
            oper[11].Text = ((RadioButton)oper[0]).Checked ? "Server" : "Host:Port";

            oper[6].Visible = ((RadioButton)oper[1]).Checked;
            oper[6].Enabled = ((RadioButton)oper[1]).Checked;
            oper[7].Visible = !((RadioButton)oper[1]).Checked;

            oper[8].Text = "Connect";
        }

        private void SetLayoutConnected(List<Control> oper)
        {
            int[] enable = { 7, 8, 10 };
            int[] disable = { 0, 1, 2, 3, 4, 5, 6, 9, 13 };
            foreach (int i in enable)
            {
                oper[i].Enabled = true;
            }

            foreach (int i in disable)
            {
                oper[i].Enabled = false;
            }

            oper[8].Text = "Connected";
            oper[10].Text = "Select";
        }

        private void SetLayoutSelected(List<Control> oper)
        {
            int[] enable = { 9, 10 };
            int[] disable = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 13 };

            foreach (int i in enable)
            {
                oper[i].Enabled = true;
            }

            foreach (int i in disable)
            {
                oper[i].Enabled = false;
            }

            _compControls[1].Enabled = false;
            _compControls[2].Enabled = false;
            _compControls[3].Enabled = false;

            oper[10].Text = "Selected";
            _compControls[0].Text = "Edit Mapping";
        }

        private void SetLayoutMapped(List<Control> oper)
        {
            oper[1].Enabled = true;
            int[] disable3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13 };
            foreach (int i in disable3)
            {
                _srcControls[i].Enabled = false;
                _trgControls[i].Enabled = false;
            }

            oper[0].Text = "Update Source/Target";
        }

        private void SetLayoutCompared(List<Control> oper)
        {
            oper[2].Enabled = true;
            oper[3].Enabled = true;
        }

        private void RefreshProgress()
        {
            while (true)
            {
                Thread.Sleep(500);
                _refresh = false;
            }
        }

        private void AdjustComboBoxWidth(ComboBox control)
        {
            try
            {
                using (var graphics = control.CreateGraphics())
                {
                    int width = control.Width;
                    int verticalScrollBarWidth = (control.Items.Count > control.MaxDropDownItems)
                        ? SystemInformation.VerticalScrollBarWidth
                        : 0;

                    width = (from object item in control.Items
                             select item as DataRowView into rowView
                             where rowView != null && rowView.Row.ItemArray.Any()
                             select (int)graphics.MeasureString(rowView.Row.ItemArray[0].ToString(), control.Font).Width + verticalScrollBarWidth)
                             .Concat(new[] { width })
                             .Max();

                    control.DropDownWidth = width;
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void HighlightCells()
        {
            EnableCompControl(false);

            foreach (DataGridViewColumn col in dgvResult.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewRow row in dgvResult.Rows)
            {
                for (int i = 0; i < _columnCount; i++)
                {
                    if (row.Cells[_columnCount-1].Value.Equals("Pass"))
                    {
                        HighlightCell(row, i, Color.LightGreen);
                    } else if (row.Cells[_columnCount - 1].Value.Equals("Fail"))
                    {
                        HighlightCell(row, i, Color.LightPink);
                    } else
                    {
                        HighlightCell(row, i, Color.LightYellow);
                    }
                }

                if (row.Index % 500 == 0)
                {
                    Application.DoEvents();
                }
            }

            EnableCompControl(true);
        }

        private void HighlightCell(DataGridViewRow row, int index, Color color)
        {
            row.Cells[index].Style.BackColor = color;
        }

        private void EnableCompControl(bool isEnable)
        {
            foreach (var c in _compControls)
            {
                c.Enabled = isEnable;
            }
        }

        private void AdjustCellWidth()
        {
            foreach (DataGridViewRow row in dgvResult.Rows)
            {
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    //row.Cells[j]
                }
            }
        }
        #endregion

        #region Event
        private void rbtnSrcDatabase_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                SetLayout(CompareType.Source, CompareStatus.Init);
            }
        }

        private void rbtnTrgDatabase_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                SetLayout(CompareType.Target, CompareStatus.Init);
            }
        }

        private void btnTrgRfst_Click(object sender, EventArgs e)
        {
            btnRfst_Click(sender, CompareType.Target);
        }

        private void btnSrcRfst_Click(object sender, EventArgs e)
        {
            btnRfst_Click(sender, CompareType.Source);
        }

        private void btnRfst_Click(object sender, CompareType type)
        {
            var btn = sender as Button;
            var cboTables = (type == CompareType.Source) ? _srcControls[9] as ComboBox : _trgControls[9] as ComboBox;
            cboTables.DataSource = null;

            try
            {
                if (btn.Text.Equals("Select"))
                {
                    bwTable.RunWorkerAsync(type);
                }
                else
                {
                    SetLayout(type, CompareStatus.Connected);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTrgRfs_Click(object sender, EventArgs e)
        {
            btnRfs_Click(sender, CompareType.Target);
        }

        private void btnSrcRfs_Click(object sender, EventArgs e)
        {
            btnRfs_Click(sender, CompareType.Source);
        }

        private void btnRfs_Click(object sender, CompareType type)
        {
            var btn = sender as Button;
            var cboDBs = ((type == CompareType.Source) ? _srcControls[7] : _trgControls[7]) as ComboBox;
            cboDBs.DataSource = null;

            try
            {
                if (btn.Text.Equals("Connect"))
                {
                    bwDatabase.RunWorkerAsync(type);
                }
                else
                {
                    SetLayout(type, CompareStatus.Init);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSrcUse_Click(object sender, EventArgs e)
        {
            btnUse_Click(sender,CompareType.Source);
        }

        private void btnTrgUse_Click(object sender, EventArgs e)
        {
            btnUse_Click(sender, CompareType.Target);
        }

        private void btnUse_Click(object sender, CompareType type)
        {
            var btn = sender as Button;
            var cboTablesSelect = (type == CompareType.Source) ? _srcControls[19] as ComboBox : _trgControls[19] as ComboBox;
            
            try
            {
                if (btn.Text.Equals("Use"))
                {
                    bwTableSelect.RunWorkerAsync(type);
                }
                else
                {
                    SetLayout(type, CompareStatus.Connected);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkSrcWinAuth_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void chkTrgWinAuth_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEditMapping_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            dgvMappings.Rows.Clear();

            if (btn.Text.Equals("Edit Mapping"))
            {
                bwMapping.RunWorkerAsync();
            }
            else
            {
                dgvResult.DataSource = null;
                SetLayout(CompareType.Source, CompareStatus.Selected);
                SetLayout(CompareType.Target, CompareStatus.Selected);
            }
        }

        private void btnCompare_Click(object sender, EventArgs e) // ************** here **************
        {
            // set Result Column Headers in datatable format
            DataTable testResultDT = setResultColumnHeaders();

            // get list of paired source and target tables to be compared 
            List<TestResult> testResultList = RetrieveComparedTableList();

            // go through each paired item and run all three tests, load in datatable format
            testResultList = CompareTables(testResultList);
            testResultDT = ReadResultsToDataTable(testResultList,testResultDT); 

            // output datatable results to data grid view
            dgvResult.DataSource = null;
            dgvResult.DataSource = testResultDT;
            dgvResult.Refresh();

            HighlightCells();
            dgvResult.AutoResizeColumns();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void chkShowDiff_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region SQL
        private DataTable RetrieveDatabases(CompareType type)
        {
            var result = new DataTable();

            if (type == CompareType.Source)
            {
                result = DBManager.RetrieveSourceDatabases();
            } else
            {
                result = DBManager.RetrieveTargetDatabases();
            }

            return result;
        }

        private DataTable RetrieveTables(CompareType type)
        {
            var result = new DataTable();

            if (type == CompareType.Source)
            {
                result = DBManager.RetrieveSourceTables();
            }
            else
            {
                result = DBManager.RetrieveTargetTables();
            }

            return result;
        }

        private DataTable RetrieveColumns(CompareType type, string tableName)
        {
            var cboTablesSelect = (type == CompareType.Source) ? _srcControls[19] as ComboBox : _trgControls[19] as ComboBox;
            string comparingTableName = GetSelectedValueFromCombobox(cboTablesSelect);

            return DBManager.RetrieveColumns(comparingTableName, tableName);
        }

        private List<TestResult> RetrieveComparedTableList()
        {
            var cbSource = _srcControls[19] as ComboBox;
            var cbTarget = _trgControls[19] as ComboBox;

            List<TestResult> testResults = new List<TestResult>();
            List<string> sourceValues = GetAllValuesFromCombobox(cbSource);
            List<string> targetValues = GetAllValuesFromCombobox(cbTarget);

            for (int i = 0; i < sourceValues.Count; i++)
            {
                TestResult tr = new TestResult();
                tr.SourceTableName = sourceValues[i];
                tr.TargetTableName = targetValues[i];

                testResults.Add(tr);
            }

            return testResults;
        }

        private List<TestResult> CompareTables(List<TestResult> testResultList)
        {
            List<TestResult> finalResults = new List<TestResult>();

            for (int i = 0; i < testResultList.Count; i++)
            {
                finalResults.Add(TestCaseRunner.RunRowCountTestCase(testResultList[i]));
                finalResults.Add(TestCaseRunner.RunSchemaTestCase(testResultList[i]));
                finalResults.Add(TestCaseRunner.RunEqualityTestCase(testResultList[i]));
            }

            return finalResults;
        }

        private DataTable ReadResultsToDataTable(List<TestResult> testResultList, DataTable testResultDT) 
        {
            foreach (TestResult tr in testResultList)
            {
                DataRow row = testResultDT.NewRow();

                row["TestDate"] = tr.TestDate;
                row["TestCaseName"] = tr.TestCaseName;
                row["SourceTableName"] = tr.SourceTableName;
                row["TargetTableName"] = tr.TargetTableName;
                row["TestCaseDescription"] = tr.TestCaseDescription;
                row["Result"] = tr.Result;

                testResultDT.Rows.Add(row);
            }

            return testResultDT;
        }

        private DataTable setResultColumnHeaders()
        {
            DataTable resultsDT = new DataTable();

            resultsDT.Columns.Add("TestDate");
            resultsDT.Columns.Add("TestCaseName");
            resultsDT.Columns.Add("SourceTableName");
            resultsDT.Columns.Add("TargetTableName");
            resultsDT.Columns.Add("TestCaseDescription");
            resultsDT.Columns.Add("Result");

            return resultsDT;
        }

        private DataTable UseTables(CompareType type)
        {
            var cboTables = ((type == CompareType.Source) ? _srcControls[9] : _trgControls[9]) as ComboBox;
            var result = new DataTable();
            var currentUsedTable = GetUsedTable(type);
            string value = GetSelectedValueFromCombobox(cboTables);

            if (type == CompareType.Source)
            {
                result = DBManager.UseSourceTable(currentUsedTable, value); 
            }
            else
            {
                result = DBManager.UseTargetTable(currentUsedTable, value);
            }

            return result;
        }

        

        private DataTable GetUsedTable(CompareType type)
        {
            var cboTablesSelect = (type == CompareType.Source) ? _srcControls[19] as ComboBox : _trgControls[19] as ComboBox;
            var result = new DataTable();
            result.Columns.Add("Name");

            for (int i = 0; i < cboTablesSelect.Items.Count; i++)
            {
                
                DataRow row = result.NewRow();
                row["Name"] = cboTablesSelect.GetItemText(cboTablesSelect.Items[i]);
                result.Rows.Add(row);
            }

            return result;
        }

        private bool isConnected(CompareType type)
        {
            var dbType = GetDatabaseType(type);
            var oper = (type == CompareType.Source) ? _srcControls : _trgControls;

            string server = (oper[2] as TextBox).Text.Trim();
            string username = (oper[4] as TextBox).Text.Trim();
            string password = (oper[5] as TextBox).Text.Trim();

            if (dbType == DatabaseType.SqlServer)
            {
                return (!String.IsNullOrEmpty(server) && !String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password));
            } else if (dbType == DatabaseType.BigQuery)
            {
                return !String.IsNullOrEmpty(server);
            }
            
            return false;
        }
        #endregion

        #region BackgroundWorker
        private void bwDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            var type = (CompareType)e.Argument;
            var dbType = GetDatabaseType(type);
            var result = new DataTable();

            result = RetrieveDatabases(type);

            e.Result = new KeyValuePair<CompareType, DataTable>(type, result);
            backgroundWorker.ReportProgress(100, "Done");
        }

        private void bwDatabase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = (KeyValuePair<CompareType, DataTable>)e.Result;

                if (isConnected(result.Key))
                {
                    var cboDBs = ((result.Key == CompareType.Source) ? _srcControls[7] : _trgControls[7]) as ComboBox;
                    cboDBs.DisplayMember = "Name";
                    cboDBs.ValueMember = "Name";
                    cboDBs.DataSource = result.Value;
                    AdjustComboBoxWidth(cboDBs);
                    SetLayout(result.Key, CompareStatus.Connected);
                } else
                {
                    SetLayout(result.Key, CompareStatus.Init);
                }
            }
        }

        private void bwTable_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            var type = (CompareType)e.Argument;
            var dbType = GetDatabaseType(type);
            var result = new DataTable();

            result = RetrieveTables(type);

            e.Result = new KeyValuePair<CompareType, DataTable>(type, result);
            backgroundWorker.ReportProgress(100, "Done");
        }

        private void bwTable_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = (KeyValuePair<CompareType, DataTable>)e.Result;
                var cboTables = ((result.Key == CompareType.Source) ? _srcControls[9] : _trgControls[9]) as ComboBox;
                cboTables.DisplayMember = "Name";
                cboTables.ValueMember = "Name";
                cboTables.DataSource = result.Value;
                AdjustComboBoxWidth(cboTables);
                SetLayout(result.Key, CompareStatus.Selected);
            }
        }

        private void bwTableSelect_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            var type = (CompareType)e.Argument;
            var dbType = GetDatabaseType(type);
            var result = new DataTable();

            result = UseTables(type);

            e.Result = new KeyValuePair<CompareType, DataTable>(type, result);
            backgroundWorker.ReportProgress(100, "Done");
        }

        private void bwTableSelect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = (KeyValuePair<CompareType, DataTable>)e.Result;
                var cboTablesSelected = ((result.Key == CompareType.Source) ? _srcControls[19] : _trgControls[19]) as ComboBox;
                cboTablesSelected.DisplayMember = "Name";
                cboTablesSelected.ValueMember = "Name";
                cboTablesSelected.DataSource = result.Value;
                AdjustComboBoxWidth(cboTablesSelected);
                SetLayout(result.Key, CompareStatus.Used);
            }
        }

        private void bwMapping_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = (BackgroundWorker)sender;
   
            var ds = new DataSet();
            ds.Tables.Add(RetrieveColumns(CompareType.Source, "SrcCols").Copy());
            ds.Tables.Add(RetrieveColumns(CompareType.Target, "TrgCols").Copy());

            e.Result = ds;
            backgroundWorker.ReportProgress(100, "Done");
        }

        private void bwMapping_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var ds = e.Result as DataSet;
                ((DataGridViewComboBoxColumn)dgvMappings.Columns[2]).DataSource = ds.Tables["TrgCols"];
                ((DataGridViewComboBoxColumn)dgvMappings.Columns[2]).DisplayMember = "NAME";
                ((DataGridViewComboBoxColumn)dgvMappings.Columns[2]).ValueMember = "NAME";

                MappingColumns(ds, "SrcCols", "TrgCols");
                dgvMappings.Refresh();

                SetLayout(CompareType.Other, CompareStatus.Mapped);
            }
        }
        #endregion

        #region HelperMethods
        private DatabaseType GetDatabaseType(CompareType type)
        {
            var rbtnSqlServer = (type == CompareType.Source) ? rbtnSrcSql : rbtnTrgSql;
            var rbtnOracle = (type == CompareType.Source) ? rbtnSrcOracle : rbtnTrgOracle;
            var rbtnNetezza = (type == CompareType.Source) ? rbtnSrcNetezza : rbtnTrgNetezza;
            var rbtnGBQ = (type == CompareType.Source) ? rbtnSrcGoogle : rbtnTrgGoogle;

            if (rbtnSqlServer.Checked)
            {
                return DatabaseType.SqlServer;
            }
            if (rbtnOracle.Checked)
            {
                return DatabaseType.Oracle;
            }
            if (rbtnNetezza.Checked)
            {
                return DatabaseType.Netezza;
            }
            if (rbtnGBQ.Checked)
            {
                return DatabaseType.BigQuery;
            }

            return DatabaseType.SqlServer;
        }

        private string GetSelectedValueFromCombobox(ComboBox cb)
        {
            string value = "";

            if (this.InvokeRequired)
            {
                this.Invoke(new System.Action(() =>
                {
                    value = cb.SelectedValue.ToString();
                }
                ));
            }

            return value;
        }

        private List<string> GetAllValuesFromCombobox(ComboBox cb)
        {
            List<string> cbValues = new List<string>();

            for (int i = 0; i < cb.Items.Count; i++)
            {
                cbValues.Add(cb.GetItemText(cb.Items[i]));
            }

            return cbValues;
        }

        private void MappingColumns(DataSet ds, string src, string trg)
        {
            var mapping = new DataTable();
            mapping.Columns.Add("Selected", Type.GetType("System.Boolean"));
            mapping.Columns.Add("SourceColumns", ds.Tables[src].Columns["NAME"].DataType);
            mapping.Columns.Add("TargetColumns", ds.Tables[trg].Columns["NAME"].DataType);
            mapping.Columns.Add("Keys", Type.GetType("System.Boolean"));
            mapping.BeginLoadData();
            for (int i = 0; i < ds.Tables[src].Rows.Count; i++)
            {
                bool isTypeDiff = false;

                var newRow = mapping.NewRow();
                newRow[0] = false;
                newRow[1] = ds.Tables[src].Rows[i]["NAME"];
                newRow[3] = false;

                for (int j = 0; j < ds.Tables[trg].Rows.Count; j++)
                {
                    string srcCol = ds.Tables[src].Rows[i].ItemArray[0].ToString().Trim().ToLower();
                    string trgCol = ds.Tables[trg].Rows[j].ItemArray[0].ToString().Trim().ToLower();

                    if (srcCol == trgCol)
                    {
                        newRow[0] = true;
                        newRow[2] = ds.Tables[trg].Rows[j]["NAME"];
                        break;
                    }
                    if (srcCol.Split('[')[0] == trgCol.Split('[')[0] && trgCol.Split('[')[1].Contains("gbq"))
                    {
                        newRow[0] = true;
                        newRow[2] = ds.Tables[trg].Rows[j]["NAME"];
                        break;
                    }
                    if (srcCol.Split('[')[0] == trgCol.Split('[')[0] && !trgCol.Split('[')[1].Contains("gbq"))
                    {
                        newRow[0] = true;
                        newRow[2] = ds.Tables[trg].Rows[j]["NAME"];
                        isTypeDiff = true;
                        break;
                    }
                }
                mapping.Rows.Add(newRow);
                dgvMappings.Rows.Add(newRow[0], newRow[1], newRow[2], newRow[3]);

                var cboCell = dgvMappings.Rows[dgvMappings.Rows.Count - 1].Cells[2] as DataGridViewComboBoxCell;
                cboCell.FlatStyle = FlatStyle.Flat;
                if (isTypeDiff)
                {
                    cboCell.Style.BackColor = Color.LightPink;
                }
            }

            mapping.EndLoadData();
        }
        #endregion
    }
}