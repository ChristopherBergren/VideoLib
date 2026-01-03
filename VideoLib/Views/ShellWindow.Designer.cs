using System.Drawing;
using System.Resources;

using VideoLib;
using VideoLib.Properties;

namespace VideoLib.Views
{
    partial class ShellWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShellWindow));
            ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            toolStripTabItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            toolStripTabItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            toolStripTabItem4 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripCheckBox1 = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            toolStripCheckBox2 = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripComboBox2 = new ToolStripComboBox();
            toolStripComboBox3 = new ToolStripComboBox();
            toolStripComboBox4 = new ToolStripComboBox();
            toolStripButton1 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            backStageView1 = new Syncfusion.Windows.Forms.BackStageView(components);
            backStage1 = new Syncfusion.Windows.Forms.BackStage();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ribbonControlAdv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backStage1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            ribbonControlAdv1.CaptionFont = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ribbonControlAdv1.Font = new Font("Segoe UI", 8.25F);
            ribbonControlAdv1.Location = new Point(1, 0);
            ribbonControlAdv1.Margin = new Padding(2, 3, 2, 3);
            ribbonControlAdv1.MenuButtonFont = new Font("Segoe UI", 8.25F);
            ribbonControlAdv1.MenuButtonText = "";
            ribbonControlAdv1.MenuButtonWidth = 56;
            ribbonControlAdv1.MenuColor = Color.FromArgb(0, 114, 198);
            ribbonControlAdv1.Name = "ribbonControlAdv1";
            ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // 
            // 
            ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            ribbonControlAdv1.OfficeMenu.Site = null;
            ribbonControlAdv1.OfficeMenu.Size = new Size(12, 65);
            ribbonControlAdv1.QuickPanelImageLayout = PictureBoxSizeMode.StretchImage;
            ribbonControlAdv1.QuickPanelVisible = false;
            ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            ribbonControlAdv1.SelectedTab = null;
            ribbonControlAdv1.ShowMinimizeButton = false;
            ribbonControlAdv1.ShowRibbonDisplayOptionButton = true;
            ribbonControlAdv1.Size = new Size(703, 177);
            ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            ribbonControlAdv1.TabIndex = 0;
            ribbonControlAdv1.Text = "ribbonControlAdv1";
            ribbonControlAdv1.ThemeName = "Office2016";
            ribbonControlAdv1.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = Color.FromArgb(171, 171, 171);
            ribbonControlAdv1.TitleColor = Color.Black;
            // 
            // toolStripTabItem1
            // 
            toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // 
            // 
            toolStripTabItem1.Panel.Margin = new Padding(3, 0, 3, 0);
            toolStripTabItem1.Panel.Name = "ribbonPanel1";
            toolStripTabItem1.Panel.Padding = new Padding(0, 1, 30, 0);
            toolStripTabItem1.Panel.ScrollPosition = 0;
            toolStripTabItem1.Panel.TabIndex = 2;
            toolStripTabItem1.Panel.Text = "Home";
            toolStripTabItem1.Position = 0;
            toolStripTabItem1.Size = new Size(53, 30);
            toolStripTabItem1.Tag = "1";
            toolStripTabItem1.Text = "Home";
            // 
            // toolStripTabItem2
            // 
            toolStripTabItem2.Name = "toolStripTabItem2";
            // 
            // 
            // 
            toolStripTabItem2.Panel.Margin = new Padding(3, 0, 3, 0);
            toolStripTabItem2.Panel.Name = "ribbonPanel2";
            toolStripTabItem2.Panel.Padding = new Padding(0, 1, 30, 0);
            toolStripTabItem2.Panel.ScrollPosition = 0;
            toolStripTabItem2.Panel.TabIndex = 3;
            toolStripTabItem2.Panel.Text = "Send/Receive";
            toolStripTabItem2.Position = 0;
            toolStripTabItem2.Size = new Size(91, 30);
            toolStripTabItem2.Tag = "2";
            toolStripTabItem2.Text = "Send/Receive";
            // 
            // toolStripTabItem3
            // 
            toolStripTabItem3.Name = "toolStripTabItem3";
            // 
            // 
            // 
            toolStripTabItem3.Panel.Margin = new Padding(3, 0, 3, 0);
            toolStripTabItem3.Panel.Name = "ribbonPanel3";
            toolStripTabItem3.Panel.Padding = new Padding(0, 1, 30, 0);
            toolStripTabItem3.Panel.ScrollPosition = 0;
            toolStripTabItem3.Panel.TabIndex = 4;
            toolStripTabItem3.Panel.Text = "Folder";
            toolStripTabItem3.Position = 0;
            toolStripTabItem3.Size = new Size(56, 30);
            toolStripTabItem3.Tag = "3";
            toolStripTabItem3.Text = "Folder";
            // 
            // toolStripTabItem4
            // 
            toolStripTabItem4.Name = "toolStripTabItem4";
            // 
            // 
            // 
            toolStripTabItem4.Panel.Margin = new Padding(3, 0, 3, 0);
            toolStripTabItem4.Panel.Name = "ribbonPanel4";
            toolStripTabItem4.Panel.Padding = new Padding(0, 1, 30, 0);
            toolStripTabItem4.Panel.ScrollPosition = 0;
            toolStripTabItem4.Panel.TabIndex = 5;
            toolStripTabItem4.Panel.Text = "View";
            toolStripTabItem4.Position = 0;
            toolStripTabItem4.Size = new Size(48, 30);
            toolStripTabItem4.Tag = "4";
            toolStripTabItem4.Text = "View";
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(85, 103);
            toolStripButton4.Text = "New Mail";
            toolStripButton4.TextAlign = ContentAlignment.BottomCenter;
            toolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton5
            // 
            toolStripButton5.AutoToolTip = false;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Margin = new Padding(0, 1, 0, 0);
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(73, 107);
            toolStripButton5.Text = "Copy";
            // 
            // toolStripButton6
            // 
            toolStripButton6.AutoToolTip = false;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Margin = new Padding(0, 1, 0, 0);
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(61, 107);
            toolStripButton6.Text = "Cut";
            // 
            // toolStripCheckBox1
            // 
            toolStripCheckBox1.Name = "toolStripCheckBox1";
            toolStripCheckBox1.Size = new Size(157, 103);
            toolStripCheckBox1.Text = "MinimizeButton";
            // 
            // toolStripCheckBox2
            // 
            toolStripCheckBox2.Name = "toolStripCheckBox2";
            toolStripCheckBox2.Size = new Size(183, 103);
            toolStripCheckBox2.Text = "MenuButtonEnable";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(136, 108);
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(136, 33);
            // 
            // toolStripComboBox3
            // 
            toolStripComboBox3.Name = "toolStripComboBox3";
            toolStripComboBox3.Size = new Size(136, 33);
            // 
            // toolStripComboBox4
            // 
            toolStripComboBox4.Name = "toolStripComboBox4";
            toolStripComboBox4.Size = new Size(136, 33);
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(85, 47);
            toolStripButton1.Text = "New Mail";
            toolStripButton1.TextAlign = ContentAlignment.BottomCenter;
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            toolStripButton3.AutoToolTip = false;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Margin = new Padding(0, 1, 0, 0);
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(73, 27);
            toolStripButton3.Text = "Copy";
            // 
            // toolStripButton2
            // 
            toolStripButton2.AutoToolTip = false;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Margin = new Padding(0, 1, 0, 0);
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(61, 27);
            toolStripButton2.Text = "Cut";
            // 
            // backStageView1
            // 
            backStageView1.BackStage = backStage1;
            backStageView1.HostControl = null;
            backStageView1.HostForm = this;
            // 
            // backStage1
            // 
            backStage1.AllowDrop = true;
            backStage1.BackStagePanelWidth = 160;
            backStage1.BeforeTouchSize = new Size(698, 374);
            backStage1.BorderStyle = BorderStyle.None;
            backStage1.ChildItemSize = new Size(80, 140);
            backStage1.Font = new Font("Segoe UI", 8.25F);
            backStage1.ItemSize = new Size(160, 40);
            backStage1.Location = new Point(0, 0);
            backStage1.Margin = new Padding(2, 3, 2, 3);
            backStage1.MinimumSize = new Size(100, 20);
            backStage1.Name = "backStage1";
            backStage1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            backStage1.Size = new Size(698, 374);
            backStage1.TabIndex = 7;
            backStage1.TabStyle = typeof(Syncfusion.Windows.Forms.BackStageRenderer);
            backStage1.ThemeName = "BackStage2016Renderer";
            backStage1.Visible = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 177);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 245);
            panel1.TabIndex = 8;
            // 
            // ShellWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 421);
            Controls.Add(panel1);
            Controls.Add(backStage1);
            Controls.Add(ribbonControlAdv1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "ShellWindow";
            Padding = new Padding(1, 0, 1, 1);
            Text = "VideoLib";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            SizeChanged += Form1_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)ribbonControlAdv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backStage1).EndInit();
            ResumeLayout(false);

        }

        private void Form1_SizeChanged(object sender, System.EventArgs e)
        {
            this.panel1.Height = this.Height - 200;
            this.panel1.Width = this.Width - 200;
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem4;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx New;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx Delete;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx Respond;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx Move;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx3;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox toolStripCheckBox1;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox toolStripCheckBox2;
        private Syncfusion.Windows.Forms.BackStageView backStageView1;
        private Syncfusion.Windows.Forms.BackStage backStage1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx5;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx6;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx7;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx8;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox4;
        private System.Windows.Forms.Panel panel1;
    }
}

