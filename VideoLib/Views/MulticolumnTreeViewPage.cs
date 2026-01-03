using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
namespace VideoLib.Views
{
    public partial class MulticolumnTreeViewPage : UserControl
    {
        public MulticolumnTreeViewPage()
        {
            InitializeComponent();
            // Adding Column
            TreeColumnAdv countryColumn = new TreeColumnAdv();
            TreeColumnAdv capitalColumn = new TreeColumnAdv();
            countryColumn = new TreeColumnAdv();
            capitalColumn = new TreeColumnAdv();
            countryColumn.Text = "Country";
            capitalColumn.Text = "Capital";
            countryColumn.Width = 150;
            capitalColumn.Width = 150;
            multiColumnTreeView1.Columns.AddRange(new TreeColumnAdv[] { countryColumn, capitalColumn });
            TreeNodeAdv asiaNode = new TreeNodeAdv();
            TreeNodeAdv europeNode = new TreeNodeAdv();
            TreeNodeAdv northAmericaNode = new TreeNodeAdv();
            TreeNodeAdv australiaNode = new TreeNodeAdv();
            TreeNodeAdv southAmericaNode = new TreeNodeAdv();
            TreeNodeAdv africaNode = new TreeNodeAdv();
            asiaNode.Text = "Asia";
            europeNode.Text = "Europe";
            northAmericaNode.Text = "North America";
            australiaNode.Text = "Australia";
            southAmericaNode.Text = "South America";
            africaNode.Text = "Africa";
            multiColumnTreeView1.Nodes.AddRange(new TreeNodeAdv[] { asiaNode, europeNode, northAmericaNode, australiaNode, southAmericaNode, africaNode });
            TreeNodeAdv indiaNode = new TreeNodeAdv();
            TreeNodeAdv chinaNode = new TreeNodeAdv();
            TreeNodeAdv britainNode = new TreeNodeAdv();
            TreeNodeAdv franceNode = new TreeNodeAdv();
            TreeNodeAdv unitedStatesNode = new TreeNodeAdv();
            TreeNodeAdv CanadaNode = new TreeNodeAdv();
            TreeNodeAdv australiaChildNode = new TreeNodeAdv();
            TreeNodeAdv newZealandNode = new TreeNodeAdv();
            TreeNodeAdv brazilNode = new TreeNodeAdv();
            TreeNodeAdv argentinaNode = new TreeNodeAdv();
            TreeNodeAdv southAfricaNode = new TreeNodeAdv();
            TreeNodeAdv zimbabweNode = new TreeNodeAdv();
            indiaNode.Text = "India";
            chinaNode.Text = "China";
            britainNode.Text = "Britain";
            franceNode.Text = "France";
            unitedStatesNode.Text = "United States";
            CanadaNode.Text = "Canada";
            australiaChildNode.Text = "Australia";
            newZealandNode.Text = "New Zealand";
            brazilNode.Text = "Brazil";
            argentinaNode.Text = "Argentina";
            southAfricaNode.Text = "South Africa";
            zimbabweNode.Text = "Zimbabwe";
            asiaNode.Nodes.AddRange(new TreeNodeAdv[] { indiaNode, chinaNode });
            europeNode.Nodes.AddRange(new TreeNodeAdv[] { britainNode, franceNode });
            northAmericaNode.Nodes.AddRange(new TreeNodeAdv[] { unitedStatesNode, CanadaNode });
            australiaNode.Nodes.AddRange(new TreeNodeAdv[] { australiaChildNode, newZealandNode });
            southAmericaNode.Nodes.AddRange(new TreeNodeAdv[] { brazilNode, argentinaNode });
            africaNode.Nodes.AddRange(new TreeNodeAdv[] { southAfricaNode, zimbabweNode });
            TreeNodeAdvSubItem delhiSubItem = new TreeNodeAdvSubItem();
            TreeNodeAdvSubItem beijingSubItem = new TreeNodeAdvSubItem();
            TreeNodeAdvSubItem londonSubItem = new TreeNodeAdvSubItem();
            TreeNodeAdvSubItem parisSubItem = new TreeNodeAdvSubItem();
            TreeNodeAdvSubItem washingtonSubItem = new TreeNodeAdvSubItem();
            TreeNodeAdvSubItem ottawaSubItem = new TreeNodeAdvSubItem();
            TreeNodeAdvSubItem canberraSubItem = new TreeNodeAdvSubItem();
            TreeNodeAdvSubItem wellingtonSubItem = new TreeNodeAdvSubItem();
            TreeNodeAdvSubItem brasiliaSubItem = new TreeNodeAdvSubItem();
            TreeNodeAdvSubItem buenosSubItem = new TreeNodeAdvSubItem();
            TreeNodeAdvSubItem capeTownSubItem = new TreeNodeAdvSubItem();
            TreeNodeAdvSubItem harereSubItem = new TreeNodeAdvSubItem();
            delhiSubItem.Text = "New Delhi";
            beijingSubItem.Text = "Beijing";
            londonSubItem.Text = "London";
            parisSubItem.Text = "Paris";
            washingtonSubItem.Text = "Washington,D.C";
            ottawaSubItem.Text = "Ottawa";
            canberraSubItem.Text = "Canberra";
            wellingtonSubItem.Text = "Wellington";
            brasiliaSubItem.Text = "Brasilia";
            buenosSubItem.Text = "Buenos Aires";
            capeTownSubItem.Text = "Cape Town";
            harereSubItem.Text = "Harere";
            indiaNode.SubItems.Add(delhiSubItem);
            chinaNode.SubItems.Add(beijingSubItem);
            britainNode.SubItems.Add(londonSubItem);
            franceNode.SubItems.Add(parisSubItem);
            unitedStatesNode.SubItems.Add(washingtonSubItem);
            CanadaNode.SubItems.Add(ottawaSubItem);
            australiaChildNode.SubItems.Add(canberraSubItem);
            newZealandNode.SubItems.Add(wellingtonSubItem);
            brazilNode.SubItems.Add(brasiliaSubItem);
            argentinaNode.SubItems.Add(buenosSubItem);
            southAfricaNode.SubItems.Add(capeTownSubItem);
            zimbabweNode.SubItems.Add(harereSubItem);
            // Sort method with Descending order as argument
            multiColumnTreeView1.Nodes.Sort(SortOrder.Descending);
        }
    }
}
