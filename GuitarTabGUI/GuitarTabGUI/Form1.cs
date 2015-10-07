using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using xNet.Net;
using xNet.Text;
using System.Diagnostics;
using xNet.Collections;

namespace GuitarTabGUI
{
    public partial class MainWindow : Form
    {
        Dictionary<string, string> songs = new Dictionary<string,string>();

        const string ultimateAdress = "http://tabs.ultimate-guitar.com/";

        List<string> songNames = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            songBox.Items.Clear();
            if (searchInput.TextLength != 0)
            {
                using (var rq = new HttpRequest())
                {
                    rq.UserAgent = HttpHelper.FirefoxUserAgent();

                    if (ultimate_guitarCheck.Checked)
                    {
                        try
                        {
                            //www.ultimate-guitar.com/search.php?search_type=title&value=

                            var urlParams = new RequestParams();

                            urlParams["search_type"] = "title";
                            urlParams["value"] = searchInput.Text;

                            string content = rq.Get("http://www.ultimate-guitar.com/search.php", urlParams).ToString();

                            string[] songNames;
                            string[] urls;

                            songNames = content.Substrings("class=\"song\">", "</a>", 0);
                            urls = content.Substrings("<a href=\"" + ultimateAdress, "\" class=\"song\">", 0);

                            for (int i = 0; i < songNames.Length; i++)
                            {
                                    songNames[i] = songNames[i].Replace("<b>", "");
                                    songNames[i] = songNames[i].Replace("</b>", "");
                                    songNames[i] = songNames[i].Insert(0, i + ". ");

                                    urls[i] = urls[i].Insert(0, ultimateAdress);

                                    songs.Add(songNames[i], urls[i]);

                                    songBox.Items.Add(songNames[i]);      
                            }       

                        }
                        catch
                        {
                            MessageBox.Show("Что-то пошло не так");
                        }
                    }
                }
            }

            showTabButton.Enabled = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            showTabButton.Enabled = false;
            using (var rq = new HttpRequest())
            {
                rq.UserAgent = HttpHelper.FirefoxUserAgent();

                try
                {
                    HttpResponse response = rq.Get("http://www.ultimate-guitar.com/");
                    ultimate_guitarCheck.Checked = true;
                }
                catch
                {
                    ultimate_guitarCheck.Checked = false;
                }
            }

            if (!ultimate_guitarCheck.Checked)
                searchButton.Enabled = false;

        }

        private void showTabButton_Click(object sender, EventArgs e)
        {
            if (songBox.SelectedIndex == -1)
                return;

            string curSong = songBox.SelectedItem.ToString();

            for (int i = 0; i < songs.Keys.Count; i++)
            {
                if (songs.Keys.ElementAt(i) == curSong)
                {
                    string url = songs.Values.ElementAt(i);
                    showTab(url);
                }
            }
        }

        private void showTab(string url)
        {
            using (var rq = new HttpRequest())
            {
                rq.UserAgent = HttpHelper.FirefoxUserAgent();

                try
                {
                    string content = rq.Get(url).ToString();
                    
                    string tabs = content.Substrings("<pre>", "</pre>", 0)[1];
                    tabs = tabs.Replace("<i>", "");
                    tabs = tabs.Replace("</i>", "");
                    tabs = tabs.Replace("<span>", "");
                    tabs = tabs.Replace("</span>", "");

                    Tabs tabForm = new Tabs(tabs);
                    tabForm.ShowDialog();
                }

                catch
                {
                    MessageBox.Show("Что-то пошло не так");
                }
            }
        }
    }
}
