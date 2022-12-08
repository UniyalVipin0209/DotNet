using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMap
{
    public partial class MapForm : Form
    {
        public MapForm()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = tbxStreet.Text.Trim();
            string city = tbxCity.Text.Trim();
            string state = tbxState.Text.Trim();
            string zip = tbxZip.Text.Trim();

            try
            {
                StringBuilder query = new StringBuilder();
                query.Append("http://google.com/maps?q=");

                if (street.Length > 0)
                    query.Append(street + ", " + "+");
                if (city.Length > 0)
                    query.Append(city + ", " + " + ");
                if (state.Length > 0)
                    query.Append(state + ", " + " + ");
                if (zip.Length > 0)
                    query.Append(zip + ", " + " + ");

                webBrowser1.Navigate(query.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while executing the code " + ex, "Error");
            }
        }       
    }
}
