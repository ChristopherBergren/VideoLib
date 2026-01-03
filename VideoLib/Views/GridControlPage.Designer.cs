using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
namespace VideoLib.Views
{
    partial class GridControlPage
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
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1030, 433);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            //Enable the Range Selection 
            this.gridControl1.AllowSelection = GridSelectionFlags.Any;
            // To set MultiSimple ListBox Selection Mode 
            this.gridControl1.ListBoxSelectionMode = SelectionMode.MultiExtended;
            // Begin editing after user clicks on a cell.
            this.gridControl1.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell;
            //Has 3 non-scrollable rows at the top.
            this.gridControl1.Rows.FrozenCount = 2;
            this.gridControl1.Cols.FrozenCount = 3;
            //Enable the Excel like selection frame to the GridControl
            this.gridControl1.ExcelLikeSelectionFrame = true;
            this.gridControl1.ShowRowHeaders = true;
            this.gridControl1.ShowColumnHeaders = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 556);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
    }
}
