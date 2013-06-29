using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using HtmlRenderer;

namespace OpenModReleaseViewer
{
    public partial class MainForm : Form
    {
        public ListViewGroup openpGroup = new ListViewGroup("OpenPeripheral");
        public ListViewGroup ocsGroup = new ListViewGroup("OpenCCSensors");
        public ListViewGroup oxpGroup = new ListViewGroup("OpenXP");
        public Dictionary<String,ListViewGroup> listViewGroups = new Dictionary<String,ListViewGroup>();
        public Dictionary<ListViewItem, String> changelogs = new Dictionary<ListViewItem, string>();

        public MainForm()
        {
            listViewGroups.Add("OpenPeripheral", openpGroup);
            listViewGroups.Add("OpenCCSensors",ocsGroup);
            listViewGroups.Add("OpenXP",oxpGroup);

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(QueryOpenMods);
            thread.Start();
        }
        public void QueryOpenMods()
        {
            WebClient client = new WebClient();
            String rawjson = client.DownloadString("http://openperipheral.info/releases");
            JArray json = JArray.Parse(rawjson);
            foreach (JObject element in json)
            {
                ListViewItem item = new ListViewItem(new String[] { element["mod"].ToString(), element["version"].ToString(), element["download_url"].ToString()}, listViewGroups[element["mod"].ToString()]);
                changelogs.Add(item, element["changelog"].ToString());
                AddItem(item);
            }
        }
        delegate void AddItem_(ListViewItem item);
        private void AddItem(ListViewItem item)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (this.mainListView.InvokeRequired)
            {
                AddItem_ d = new AddItem_(AddItem);
                this.Invoke(d, new object[] { item });
            }
            else
            {
                this.mainListView.Items.Add(item);
            }
        }

        private void mainListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Index changed!");
            changelogRenderer.Text = "<html><body>";
            foreach (ListViewItem version in mainListView.SelectedItems)
            {
                changelogRenderer.Text += "<ul><li><h1>" + version.SubItems[0].Text + " - " + version.SubItems[1].Text+"</h1>\n";
                changelogRenderer.Text += changelogs[version] + "\n";
                changelogRenderer.Text += "</li>\n</ul>\n";
            }
            changelogRenderer.Text += "</ul></body></html>";
        }
    }
}
