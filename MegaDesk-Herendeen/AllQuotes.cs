using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2
{
    public partial class AllQuotes : Form
    {
        public AllQuotes()
        {
            InitializeComponent();
            LoadDataViewGrid();
        }

        private void LoadDataViewGrid()
        {

            string quotesJsonFile;
            using (var reader = new StreamReader(@"quotes.json"))
            {
                quotesJsonFile = reader.ReadToEnd();
            }
            List<DeskQuote> showQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotesJsonFile);
            Desk desk = new Desk();

            var transformedQuotes = showQuotes.Select(listQuotes => new
            {
                listQuotes.customerName,
                listQuotes.desk.deskWidth,
                listQuotes.desk.deskDepth,
                listQuotes.desk.surfaceMaterial,
                listQuotes.desk.deskNumDrawers,
                listQuotes.shippingType,
                listQuotes.baseCost,
                QuoteAmount = listQuotes.getTotalCost().ToString("c")
            }).ToList();

            dataGridView1.DataSource = transformedQuotes;
        }

        private void AllQuotes_ReturnBtn_Click(object sender, EventArgs e)
        {
            // -- Go to another form (page)
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();
        }
    }
}
