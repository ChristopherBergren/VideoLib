using System;
using Syncfusion.Windows.Forms.Tools;
namespace VideoLib.Views
{
    partial class GroupBarPage
    {
        private System.ComponentModel.IContainer components = null;
        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
        private Syncfusion.Windows.Forms.Tools.GroupView groupView0;
        private Syncfusion.Windows.Forms.Tools.GroupView groupView1;
        private Syncfusion.Windows.Forms.Tools.GroupView groupView2;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem0;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem2;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupBarPage));
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.groupView0 = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.groupView1 = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.groupView2 = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.groupBarItem0 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBar1.BeforeTouchSize = new System.Drawing.Size(555, 682);
            this.groupBar1.BorderColor = System.Drawing.Color.White;
            this.groupBar1.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.CollapseImage")));
            this.groupBar1.Controls.Add(this.groupView0);
            this.groupBar1.Controls.Add(this.groupView2);
            this.groupBar1.Controls.Add(this.groupView1);
            this.groupBar1.ExpandButtonToolTip = "Expand Navigation Pane";
            this.groupBar1.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.ExpandImage")));
            this.groupBar1.ForeColor = System.Drawing.Color.Black;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem0,
            this.groupBarItem1,
            this.groupBarItem2});
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(462, 46);
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 0;
            this.groupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar1.Size = new System.Drawing.Size(555, 682);
            this.groupBar1.SmartSizeBox = false;
            this.groupBar1.Splittercolor = System.Drawing.SystemColors.ControlDark;
            this.groupBar1.TabIndex = 0;
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.groupBar1.StackedMode = true;
            this.groupBar1.AnimatedSelection = true;
            this.groupBar1.Text = "groupBar1";
            // 
            // groupView0
            // 
            this.groupView0.BeforeTouchSize = new System.Drawing.Size(551, 606);
            this.groupView0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupView0.CanApplyTheme = false;
            this.groupView0.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Grid", 11, true, null, "Grid"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Data Visualization", 11, true, null, "FileSystemWatcher"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Editor", 11, true, null, "EventLog"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Navigation", 11, true, null, "DirectoryEntry"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Notification", 11, true, null, "DirectorySearcher"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("MessageQueue", 11, true, null, "MessageQueue")});
            this.groupView0.Location = new System.Drawing.Point(2, 26);
            this.groupView0.Name = "groupView0";
            this.groupView0.Size = new System.Drawing.Size(551, 606);
            this.groupView0.TabIndex = 0;
            this.groupView0.UseWaitCursor = true;
            // 
            // groupView1
            // 
            this.groupView1.BeforeTouchSize = new System.Drawing.Size(551, 0);
            this.groupView1.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11, true, null, "Pointer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("FileSystemWatcher", 22, true, null, "FileSystemWatcher"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("EventLog", 23, true, null, "EventLog"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectoryEntry", 24, true, null, "DirectoryEntry"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectorySearcher", 25, true, null, "DirectorySearcher"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("MessageQueue", 26, true, null, "MessageQueue")});
            this.groupView1.Location = new System.Drawing.Point(2, 656);
            this.groupView1.Name = "groupView1";
            this.groupView1.Size = new System.Drawing.Size(551, 0);
            this.groupView1.TabIndex = 1;
            // 
            // groupView2
            // 
            this.groupView2.BeforeTouchSize = new System.Drawing.Size(238, 2);
            this.groupView2.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11, true, null, "Pointer"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 12, true, null, "Label"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 13, true, null, "LinkLabel"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Button", 14, true, null, "Button"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("TextBox", 15, true, null, "TextBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("MainMenu", 16, true, null, "MainMenu"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("CheckBox", 17, true, null, "CheckBox"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("RadioButton", 18, true, null, "RadioButton")});
            this.groupView2.Location = new System.Drawing.Point(2, 329);
            this.groupView2.Name = "groupView2";
            this.groupView2.Size = new System.Drawing.Size(238, 2);
            this.groupView2.TabIndex = 2;
            // 
            // groupBarItem0
            // 
            this.groupBarItem0.Client = this.groupView0;
            this.groupBarItem0.Text = "Windows Forms";
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.Client = this.groupView1;
            this.groupBarItem1.Text = "Component";
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.Client = this.groupView2;
            this.groupBarItem2.Text = "General";
            // 
            // Form1
            // 
            //this.ClientSize = new System.Drawing.Size(1793, 866);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(this.groupBar1);
            this.Name = "Form1";
            this.Text = "Form1";
           // this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
