namespace StockExtract
{
    partial class Extractor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extractor));
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txbProductCode = new System.Windows.Forms.TextBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbSearchItems = new System.Windows.Forms.GroupBox();
            this.grbData = new System.Windows.Forms.GroupBox();
            this.dtStockGrid = new System.Windows.Forms.DataGridView();
            this.msSave = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.grbSearchItems.SuspendLayout();
            this.grbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStockGrid)).BeginInit();
            this.msSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(246, 33);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 25);
            this.dtpStartDate.TabIndex = 0;
            this.dtpStartDate.Value = new System.DateTime(2017, 1, 1, 15, 4, 0, 0);
            // 
            // txbProductCode
            // 
            this.txbProductCode.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductCode.Location = new System.Drawing.Point(40, 33);
            this.txbProductCode.Name = "txbProductCode";
            this.txbProductCode.Size = new System.Drawing.Size(200, 25);
            this.txbProductCode.TabIndex = 1;
            this.txbProductCode.Text = "10087 SIEMENS";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(452, 33);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 25);
            this.dtpEndDate.TabIndex = 2;
            this.dtpEndDate.Value = new System.DateTime(2017, 1, 10, 15, 4, 0, 0);
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(39, 17);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(78, 14);
            this.lblProductCode.TabIndex = 3;
            this.lblProductCode.Text = "Product Code:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(243, 17);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(62, 14);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(449, 17);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(56, 14);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(658, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grbSearchItems
            // 
            this.grbSearchItems.Controls.Add(this.lblProductCode);
            this.grbSearchItems.Controls.Add(this.btnSearch);
            this.grbSearchItems.Controls.Add(this.dtpStartDate);
            this.grbSearchItems.Controls.Add(this.lblEndDate);
            this.grbSearchItems.Controls.Add(this.txbProductCode);
            this.grbSearchItems.Controls.Add(this.lblStartDate);
            this.grbSearchItems.Controls.Add(this.dtpEndDate);
            this.grbSearchItems.Location = new System.Drawing.Point(12, 33);
            this.grbSearchItems.Name = "grbSearchItems";
            this.grbSearchItems.Size = new System.Drawing.Size(770, 82);
            this.grbSearchItems.TabIndex = 7;
            this.grbSearchItems.TabStop = false;
            // 
            // grbData
            // 
            this.grbData.Controls.Add(this.dtStockGrid);
            this.grbData.Location = new System.Drawing.Point(12, 121);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(776, 416);
            this.grbData.TabIndex = 8;
            this.grbData.TabStop = false;
            // 
            // dtStockGrid
            // 
            this.dtStockGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtStockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStockGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtStockGrid.Location = new System.Drawing.Point(6, 19);
            this.dtStockGrid.Name = "dtStockGrid";
            this.dtStockGrid.Size = new System.Drawing.Size(764, 391);
            this.dtStockGrid.TabIndex = 0;
            // 
            // msSave
            // 
            this.msSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.msSave.Location = new System.Drawing.Point(0, 0);
            this.msSave.Name = "msSave";
            this.msSave.Size = new System.Drawing.Size(801, 24);
            this.msSave.TabIndex = 9;
            this.msSave.Text = "msSave";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsExcelFileToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsExcelFileToolStripMenuItem
            // 
            this.saveAsExcelFileToolStripMenuItem.Name = "saveAsExcelFileToolStripMenuItem";
            this.saveAsExcelFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsExcelFileToolStripMenuItem.Text = "Save as Excel file";
            this.saveAsExcelFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsExcelFileToolStripMenuItem_Click);
            // 
            // Extractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(801, 686);
            this.Controls.Add(this.grbData);
            this.Controls.Add(this.grbSearchItems);
            this.Controls.Add(this.msSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msSave;
            this.MaximizeBox = false;
            this.Name = "Extractor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extractor";
            this.Load += new System.EventHandler(this.Extractor_Load);
            this.grbSearchItems.ResumeLayout(false);
            this.grbSearchItems.PerformLayout();
            this.grbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtStockGrid)).EndInit();
            this.msSave.ResumeLayout(false);
            this.msSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txbProductCode;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grbSearchItems;
        private System.Windows.Forms.GroupBox grbData;
        private System.Windows.Forms.DataGridView dtStockGrid;
        private System.Windows.Forms.MenuStrip msSave;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsExcelFileToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

