using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2
{
    public partial class DisplayQuote : Form
    {
        
        public DisplayQuote(Desk desk, DeskQuote deskQuote)
        {
            InitializeComponent();
            currentDate.Text = deskQuote.currentDate;

            customerName.Text = deskQuote.customerName;

            deskWidth.Text = $"{Convert.ToString(desk.deskWidth)}\"";
            deskDepth.Text = $"{Convert.ToString(desk.deskDepth)}\"";
            totalArea.Text = $"{Convert.ToString(deskQuote.totalArea)}\"";
            totalSurfaceCost.Text = $"${Convert.ToString(deskQuote.totalSurfaceCost)}";

            numDrawers.Text = Convert.ToString(desk.deskNumDrawers);
            totalDrawerCost.Text = $"${Convert.ToString(deskQuote.totalDrawerCost)}";

            materialType.Text = Convert.ToString(desk.surfaceMaterial);
            totalMaterialCost.Text = $"${Convert.ToString(deskQuote.totalSurfaceMaterialCost)}";

            shippingType.Text = deskQuote.shippingType;
            totalShippingCost.Text = $"${Convert.ToString(deskQuote.totalShippingCost)}";

            baseCost.Text = $"${Convert.ToString(deskQuote.baseCost)}";

            totalCost.Text = $"${Convert.ToString(deskQuote.totalCost)}";
             
        }

        // -----------------------------------------------------
        // Return to main menu - btn
        // -----------------------------------------------------

        private void mainMenu_Click(object sender, EventArgs e)
        {
            // -- Go to another form (page)
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();
        }
    }
}