using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CurrencyConverter
{
    public partial class Form1 : MetroFramework.Forms.MetroForm //use the metroform skin
    {
        public Form1()
        {
            InitializeComponent();


            const string url = "http://api.fixer.io/latest"; //Api link

            using (var webClient = new System.Net.WebClient()) //Create new webclient
            {
                var json = webClient.DownloadString(url); //download the string from the api link e.g. json

                var stuff = JObject.Parse(json); //parse the json into a JObject

                foreach (var rate in stuff["rates"].Cast<JProperty>()) //look specifically for the rates within the json and iterate through 
                {
                    cmbCurrent.Items.Add(rate.Name); //populate the current combobox
                    cmbNew.Items.Add(rate.Name); //populate the new combobox
                }
            }

            cmbCurrent.SelectedIndex = 8; //Select first index of the dropdownlist GBP
            cmbNew.SelectedIndex = 29; //Select second index of the dropdownlist USD
            this.cmbCurrent.DropDownStyle = ComboBoxStyle.DropDownList; //make sure that the dropdownlists are not editable
            this.cmbNew.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSubmit_Click(object sender, EventArgs e) //button event
        {
            var curText = cmbCurrent.Text; //take the currently selected text in current combobox and move to variable curText
            var newText = cmbNew.Text;  //take the currently selected text in new combobox and move to variable newText
            var dtp = dtpDate.Value.Date.ToString("yyyy/MM/dd"); //Set the dateformat to conform with the api link
            var cleansed = dtp.Replace("/", "-"); //replaceing the / with - to work with api
       
            var exUrl = "http://api.fixer.io/" + cleansed + "?base=" + curText + "&symbols=" + newText; //Build api url

            using (var webClient = new System.Net.WebClient()) //Create webclient
            {
                var json = webClient.DownloadString(exUrl); //download the string from the api link e.g. json

                var stuff = JObject.Parse(json); //parse the json into a JObject

                foreach (var rate in stuff["rates"].Cast<JProperty>()) //look specifically for the rates within the json and iterate through 
                {
                    txtRate.Text = rate.Value.ToString(); //change the tstRate textbox to display the exchange rate between the current and new currency
                }
            }
        }

        private void btnCredits_Click(object sender, EventArgs e) //Display a new window with sources/frameworks/apis used
        {
            var cred = new Credits(); //new instance of Credits
            cred.Show(); //show the new instance
        }
    }
}
