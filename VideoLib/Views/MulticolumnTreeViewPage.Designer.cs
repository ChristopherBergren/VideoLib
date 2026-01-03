using System.Drawing;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
namespace VideoLib.Views
{
    partial class MulticolumnTreeViewPage
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
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo treeNodeAdvSubItemStyleInfo1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo treeColumnAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo();
            this.multiColumnTreeView1 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnTreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // multiColumnTreeView1
            // 
            this.multiColumnTreeView1.AutoGenerateColumns = true;
            this.multiColumnTreeView1.ShowRootLines = true;
            //setting plus minus for all the nodes
           this.multiColumnTreeView1.ShowPlusMinus = true;
            //setting check boxes for all the nodes
           this. multiColumnTreeView1.ShowCheckBoxes = true;
            this.multiColumnTreeView1.LabelEdit = true;
            this.multiColumnTreeView1.SelectionMode = TreeSelectionMode.MultiSelectAll;
            // 
            // 
            // 
            this.multiColumnTreeView1.Name = "multiColumnTreeView1";
            this.multiColumnTreeView1.Margin = new System.Windows.Forms.Padding(5);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.multiColumnTreeView1);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiColumnTreeView1.Dock=System.Windows.Forms.DockStyle.Fill;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnTreeView1)).EndInit();
            this.ResumeLayout(false);
        }
        private MultiColumnTreeView multiColumnTreeView1;
        #endregion
    }
}
