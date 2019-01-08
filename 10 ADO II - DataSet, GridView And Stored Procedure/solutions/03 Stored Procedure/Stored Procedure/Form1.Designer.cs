namespace Stored_Procedure
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ds1 = new System.Data.DataSet();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnUpdateDB = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearchTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ds1
            // 
            this.ds1.DataSetName = "NewDataSet";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 174);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 157);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(525, 13);
            this.Label1.TabIndex = 36;
            this.Label1.Text = "___________STORED PROCEDURE (NEED TO INSERT ID)__________________________________" +
    "___";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(178, 44);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(187, 23);
            this.Button1.TabIndex = 35;
            this.Button1.Text = "UPDATE USING PARAMETER";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Location = new System.Drawing.Point(16, 124);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(156, 23);
            this.btnUpdateDB.TabIndex = 34;
            this.btnUpdateDB.Text = "UPDATE DS TO DB";
            this.btnUpdateDB.UseVisualStyleBackColor = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridView1.Location = new System.Drawing.Point(0, 252);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(572, 150);
            this.DataGridView1.TabIndex = 33;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(178, 98);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(75, 20);
            this.txtFamily.TabIndex = 32;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(175, 82);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(45, 13);
            this.Label9.TabIndex = 31;
            this.Label9.Text = "FAMILY";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(75, 20);
            this.txtName.TabIndex = 30;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(94, 82);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(38, 13);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "NAME";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(16, 98);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 20);
            this.txtID.TabIndex = 28;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(13, 82);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(18, 13);
            this.Label7.TabIndex = 27;
            this.Label7.Text = "ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(97, 44);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(97, 15);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 24;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(16, 15);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 23;
            this.btnSelect.Text = "LOAD";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSearchTable
            // 
            this.btnSearchTable.Location = new System.Drawing.Point(113, 174);
            this.btnSearchTable.Name = "btnSearchTable";
            this.btnSearchTable.Size = new System.Drawing.Size(163, 23);
            this.btnSearchTable.TabIndex = 38;
            this.btnSearchTable.Text = "SEARCH TABLE";
            this.btnSearchTable.UseVisualStyleBackColor = true;
            this.btnSearchTable.Click += new System.EventHandler(this.btnSearchTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 402);
            this.Controls.Add(this.btnSearchTable);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btnUpdateDB);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "DataReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Data.DataSet ds1;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btnUpdateDB;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.TextBox txtFamily;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnInsert;
        internal System.Windows.Forms.Button btnSelect;
        internal System.Windows.Forms.Button btnSearchTable;
    }
}

