using HtmlRenderer;
namespace OpenModReleaseViewer
{
    partial class MainForm
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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("OpenPeripheral", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("OpenCCSensors", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("OpenXP", System.Windows.Forms.HorizontalAlignment.Left);
            this.mainListView = new System.Windows.Forms.ListView();
            this.modColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.versionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downloadColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.changelogRenderer = new HtmlRenderer.HtmlPanel();
            this.SuspendLayout();
            // 
            // mainListView
            // 
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.modColumn,
            this.versionColumn,
            this.downloadColumn});
            this.mainListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainListView.FullRowSelect = true;
            listViewGroup4.Header = "OpenPeripheral";
            listViewGroup4.Name = "openpGroup";
            listViewGroup5.Header = "OpenCCSensors";
            listViewGroup5.Name = "ocsGroup";
            listViewGroup6.Header = "OpenXP";
            listViewGroup6.Name = "oxpGroup";
            this.mainListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.mainListView.Location = new System.Drawing.Point(0, 0);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(294, 424);
            this.mainListView.TabIndex = 0;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            this.mainListView.SelectedIndexChanged += new System.EventHandler(this.mainListView_SelectedIndexChanged);
            // 
            // modColumn
            // 
            this.modColumn.Text = "Mod Name";
            this.modColumn.Width = 80;
            // 
            // versionColumn
            // 
            this.versionColumn.Text = "Version";
            // 
            // downloadColumn
            // 
            this.downloadColumn.Text = "Download Link";
            this.downloadColumn.Width = 87;
            // 
            // changelogRenderer
            // 
            this.changelogRenderer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changelogRenderer.AutoScroll = true;
            this.changelogRenderer.AutoScrollMinSize = new System.Drawing.Size(677, 61);
            this.changelogRenderer.BackColor = System.Drawing.SystemColors.Window;
            this.changelogRenderer.BaseStylesheet = null;
            this.changelogRenderer.Location = new System.Drawing.Point(302, 0);
            this.changelogRenderer.Name = "changelogRenderer";
            this.changelogRenderer.Size = new System.Drawing.Size(677, 424);
            this.changelogRenderer.TabIndex = 1;
            this.changelogRenderer.Text = "<html><body><p>Hello World</p></body></html>";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 424);
            this.Controls.Add(this.changelogRenderer);
            this.Controls.Add(this.mainListView);
            this.Name = "MainForm";
            this.Text = "OpenModReleaseViewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.ColumnHeader modColumn;
        private System.Windows.Forms.ColumnHeader versionColumn;
        private System.Windows.Forms.ColumnHeader downloadColumn;

        private HtmlPanel changelogRenderer;
    }
}