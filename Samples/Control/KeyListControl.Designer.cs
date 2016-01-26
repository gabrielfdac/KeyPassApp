namespace KeyPassUserInterface
{
	partial class KeyListControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._tspTool = new System.Windows.Forms.ToolStrip();
			this._tsbEntryAdd = new System.Windows.Forms.ToolStripButton();
			this._tsbEntryEdit = new System.Windows.Forms.ToolStripButton();
			this._tsbEntryDelete = new System.Windows.Forms.ToolStripButton();
			this._ttsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this._tspEditFind = new System.Windows.Forms.ToolStripButton();
			this._ttsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this._tsbSearch = new System.Windows.Forms.ToolStripComboBox();
			this._lvwKeys = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._mnuEntryAdd = new System.Windows.Forms.ToolStripMenuItem();
			this._mnuEntryEdit = new System.Windows.Forms.ToolStripMenuItem();
			this._mnuEntryDuplicate = new System.Windows.Forms.ToolStripMenuItem();
			this._mnuEntryDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this._rtbKeyDetails = new System.Windows.Forms.RichTextBox();
			this._tspTool.SuspendLayout();
			this._cmsMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tspTool
			// 
			this._tspTool.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this._tspTool.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._tspTool.ImageScalingSize = new System.Drawing.Size(32, 32);
			this._tspTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsbEntryAdd,
            this._tsbEntryEdit,
            this._tsbEntryDelete,
            this._ttsSeparator1,
            this._tspEditFind,
            this._ttsSeparator2,
            this._tsbSearch});
			this._tspTool.Location = new System.Drawing.Point(0, 0);
			this._tspTool.Name = "_tspTool";
			this._tspTool.Size = new System.Drawing.Size(816, 39);
			this._tspTool.TabIndex = 4;
			this._tspTool.Text = "toolStrip1";
			// 
			// _tsbEntryAdd
			// 
			this._tsbEntryAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tsbEntryAdd.Image = global::KeyPassUserInterface.Properties.Resources.Entry;
			this._tsbEntryAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tsbEntryAdd.Name = "_tsbEntryAdd";
			this._tsbEntryAdd.Size = new System.Drawing.Size(36, 36);
			this._tsbEntryAdd.Text = "New Entry";
			this._tsbEntryAdd.Click += new System.EventHandler(this.OnKeyAdd);
			// 
			// _tsbEntryEdit
			// 
			this._tsbEntryEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tsbEntryEdit.Image = global::KeyPassUserInterface.Properties.Resources.Edit;
			this._tsbEntryEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tsbEntryEdit.Name = "_tsbEntryEdit";
			this._tsbEntryEdit.Size = new System.Drawing.Size(36, 36);
			this._tsbEntryEdit.Text = "Edit Entry";
			this._tsbEntryEdit.Click += new System.EventHandler(this.OnKeyEdit);
			// 
			// _tsbEntryDelete
			// 
			this._tsbEntryDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tsbEntryDelete.Image = global::KeyPassUserInterface.Properties.Resources.Delete;
			this._tsbEntryDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tsbEntryDelete.Name = "_tsbEntryDelete";
			this._tsbEntryDelete.Size = new System.Drawing.Size(36, 36);
			this._tsbEntryDelete.Text = "Delete Entry";
			this._tsbEntryDelete.Click += new System.EventHandler(this.OnKeyDelete);
			// 
			// _ttsSeparator1
			// 
			this._ttsSeparator1.Name = "_ttsSeparator1";
			this._ttsSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// _tspEditFind
			// 
			this._tspEditFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tspEditFind.Image = global::KeyPassUserInterface.Properties.Resources.Find;
			this._tspEditFind.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tspEditFind.Name = "_tspEditFind";
			this._tspEditFind.Size = new System.Drawing.Size(36, 36);
			this._tspEditFind.Text = "Find";
			// 
			// _ttsSeparator2
			// 
			this._ttsSeparator2.Name = "_ttsSeparator2";
			this._ttsSeparator2.Size = new System.Drawing.Size(6, 39);
			// 
			// _tsbSearch
			// 
			this._tsbSearch.Name = "_tsbSearch";
			this._tsbSearch.Size = new System.Drawing.Size(140, 39);
			// 
			// _lvwKeys
			// 
			this._lvwKeys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this._lvwKeys.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lvwKeys.FullRowSelect = true;
			this._lvwKeys.GridLines = true;
			this._lvwKeys.HideSelection = false;
			this._lvwKeys.Location = new System.Drawing.Point(0, 0);
			this._lvwKeys.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this._lvwKeys.Name = "_lvwKeys";
			this._lvwKeys.Size = new System.Drawing.Size(812, 260);
			this._lvwKeys.TabIndex = 5;
			this._lvwKeys.UseCompatibleStateImageBehavior = false;
			this._lvwKeys.View = System.Windows.Forms.View.Details;
			this._lvwKeys.SelectedIndexChanged += new System.EventHandler(this.OnKeySelected);
			this._lvwKeys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
			this._lvwKeys.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseDoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Title";
			this.columnHeader1.Width = 172;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "User Name";
			this.columnHeader2.Width = 139;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Password";
			this.columnHeader3.Width = 116;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "URL";
			this.columnHeader4.Width = 269;
			// 
			// _cmsMain
			// 
			this._cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuEntryAdd,
            this._mnuEntryEdit,
            this._mnuEntryDuplicate,
            this._mnuEntryDelete});
			this._cmsMain.Name = "_cmsMain";
			this._cmsMain.Size = new System.Drawing.Size(157, 114);
			this._cmsMain.Opening += new System.ComponentModel.CancelEventHandler(this.OnKeyMenuOpening);
			// 
			// _mnuEntryAdd
			// 
			this._mnuEntryAdd.Image = global::KeyPassUserInterface.Properties.Resources.Entry;
			this._mnuEntryAdd.Name = "_mnuEntryAdd";
			this._mnuEntryAdd.Size = new System.Drawing.Size(156, 22);
			this._mnuEntryAdd.Text = "Add Entry...";
			// 
			// _mnuEntryEdit
			// 
			this._mnuEntryEdit.Image = global::KeyPassUserInterface.Properties.Resources.Edit;
			this._mnuEntryEdit.Name = "_mnuEntryEdit";
			this._mnuEntryEdit.Size = new System.Drawing.Size(156, 22);
			this._mnuEntryEdit.Text = "Edit Entry...";
			// 
			// _mnuEntryDuplicate
			// 
			this._mnuEntryDuplicate.Image = global::KeyPassUserInterface.Properties.Resources.DuplicateKey;
			this._mnuEntryDuplicate.Name = "_mnuEntryDuplicate";
			this._mnuEntryDuplicate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this._mnuEntryDuplicate.ShowShortcutKeys = false;
			this._mnuEntryDuplicate.Size = new System.Drawing.Size(156, 22);
			this._mnuEntryDuplicate.Text = "Duplicate Entry...";
			this._mnuEntryDuplicate.Click += new System.EventHandler(this.OnEntryDuplicate);
			// 
			// _mnuEntryDelete
			// 
			this._mnuEntryDelete.Image = global::KeyPassUserInterface.Properties.Resources.Delete;
			this._mnuEntryDelete.Name = "_mnuEntryDelete";
			this._mnuEntryDelete.Size = new System.Drawing.Size(156, 22);
			this._mnuEntryDelete.Text = "Delete Entry...";
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 39);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this._lvwKeys);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this._rtbKeyDetails);
			this.splitContainer1.Size = new System.Drawing.Size(816, 432);
			this.splitContainer1.SplitterDistance = 264;
			this.splitContainer1.TabIndex = 6;
			// 
			// _rtbKeyDetails
			// 
			this._rtbKeyDetails.BackColor = System.Drawing.SystemColors.Info;
			this._rtbKeyDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this._rtbKeyDetails.Location = new System.Drawing.Point(0, 0);
			this._rtbKeyDetails.Name = "_rtbKeyDetails";
			this._rtbKeyDetails.ReadOnly = true;
			this._rtbKeyDetails.Size = new System.Drawing.Size(812, 160);
			this._rtbKeyDetails.TabIndex = 0;
			this._rtbKeyDetails.Text = "";
			// 
			// KeyListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ContextMenuStrip = this._cmsMain;
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this._tspTool);
			this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "KeyListControl";
			this.Size = new System.Drawing.Size(816, 471);
			this.Load += new System.EventHandler(this.OnLoad);
			this._tspTool.ResumeLayout(false);
			this._tspTool.PerformLayout();
			this._cmsMain.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip _tspTool;
		private System.Windows.Forms.ToolStripButton _tsbEntryDelete;
		private System.Windows.Forms.ToolStripButton _tsbEntryAdd;
		private System.Windows.Forms.ToolStripButton _tsbEntryEdit;
		private System.Windows.Forms.ToolStripSeparator _ttsSeparator1;
		private System.Windows.Forms.ToolStripButton _tspEditFind;
		private System.Windows.Forms.ToolStripSeparator _ttsSeparator2;
		private System.Windows.Forms.ToolStripComboBox _tsbSearch;
		private System.Windows.Forms.ListView _lvwKeys;
		private System.Windows.Forms.ContextMenuStrip _cmsMain;
		private System.Windows.Forms.ToolStripMenuItem _mnuEntryAdd;
		private System.Windows.Forms.ToolStripMenuItem _mnuEntryEdit;
		private System.Windows.Forms.ToolStripMenuItem _mnuEntryDuplicate;
		private System.Windows.Forms.ToolStripMenuItem _mnuEntryDelete;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.RichTextBox _rtbKeyDetails;
	}
}
