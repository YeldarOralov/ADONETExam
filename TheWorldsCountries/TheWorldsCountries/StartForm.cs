using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheWorldCountries.DataAccess;

namespace TheWorldsCountries
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            using (var context = new DataContext())
            {
                foreach (var country in context.Countries.ToList())
                {
                    countriesList.Items.Add($"{country.Name}");
                }
            }
            countriesList.SelectedIndex = 1;
            using(var context = new DataContext())
            {
                var country = context.Countries.Where(c => c.Name == countriesList.SelectedItem.ToString()).FirstOrDefault().Cities.ToList();
                foreach (var city in country.ToList())
                {
                    citiesList.Items.Add($"{city.Name}");
                }
            }
            citiesList.SelectedIndex = 1;
            using (var context = new DataContext())
            {
                var city = context.Cities.Where(c => c.Name == citiesList.SelectedItem.ToString()).FirstOrDefault().Streets.ToList();
                foreach (var street in city.ToList())
                {
                    streetsList.Items.Add($"{street.Name}");
                }
            }
        }

        private void countriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            citiesList.Items.Clear();
            streetsList.Items.Clear();
            using (var context = new DataContext())
            {
                var country = context.Countries.Where(c => c.Name == countriesList.SelectedItem.ToString()).FirstOrDefault().Cities.ToList();
                foreach (var city in country.ToList())
                {
                    citiesList.Items.Add($"{city.Name}");
                }
            }
            citiesList.SelectedIndex = 1;
            using (var context = new DataContext())
            {
                var city = context.Cities.Where(c => c.Name == citiesList.SelectedItem.ToString()).FirstOrDefault().Streets.ToList();
                foreach (var street in city.ToList())
                {
                    streetsList.Items.Add($"{street.Name}");
                }
            }
        }
    }
}
