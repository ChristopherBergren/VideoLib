using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
namespace VideoLib.Views
{
    public partial class GridControlPage : UserControl
    {
        public GridControlPage()
        {
            InitializeComponent();
            gridControl1.RowCount = 40;
            gridControl1.ColCount = 25;
             for (int row = 1; row <= gridControl1.RowCount; row++)
            {
                for (int col = 1; col <= gridControl1.ColCount; col++)
                {
                    gridControl1.Model[row, col].CellValue = string.Format("{0}/{1}", row, col);
                }
            }
            //Copy the selection to the Clipboard.
            gridControl1.CutPaste.Copy();
            // Cuts and copies the contents of selected cells to clipboard. 
            gridControl1.CutPaste.Cut();
            //Paste the contents of the clipboard to the specific selected range.
            gridControl1.CutPaste.Paste();
        }
    }
}
