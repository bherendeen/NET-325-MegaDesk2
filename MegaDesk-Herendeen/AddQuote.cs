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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            Desk desk = new Desk();
            DeskQuote deskQuote = new DeskQuote();
            InitializeComponent();
            // Show current date
            currentDate.Text = deskQuote.currentDate;

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

        // -----------------------------------------------------
        // Validating customer name
        // -----------------------------------------------------

        public void validateCustomerName(string input)
        {
            bool inputCheckEmpty = string.IsNullOrEmpty(input); // check input to see if empty
            bool inputCheckAllAlpha = input.All(c => char.IsLetter(c) || c == ' ');// check input to see if all char are letters

            if (inputCheckEmpty)
            {
                errorLabel.Text = "ERROR: Customer name cannot be empty";
                errorLabel.ForeColor = Color.Tomato;
                customerNameBox.BackColor = Color.Tomato;
                this.ActiveControl = customerNameBox;

            }
            else if (!inputCheckAllAlpha)
            {
                errorLabel.Text = "ERROR: Customer name must only include letters";
                errorLabel.ForeColor = Color.Tomato;
                customerNameBox.BackColor = Color.Tomato;
                this.ActiveControl = customerNameBox;

            }
            else
            {
                errorLabel.Text = ""; // empty the errorLabel
                customerNameBox.BackColor = default(Color); // reset the background color to the default
            }
        }

        private void customerNameBox_Validating(object sender, CancelEventArgs e)
        {
            customerNameBox.BackColor = default(Color); // set backgrounf color to default
            string value = customerNameBox.Text; // get the value in the deskWidthBox
            validateCustomerName(value); // call validateWidth and pass the value of value
        }

        // -----------------------------------------------------
        // Validating desk - width
        // -----------------------------------------------------

        public void validateWidth(string input)
        {
            Desk desk = new Desk();
            int minWidth = desk.deskMinWidth; // get min width value from Desk class
            int maxWidth = desk.deskMaxWidth; // get max width value from Desk class
            bool inputCheckEmpty = string.IsNullOrEmpty(input); // check input to see if empty
            bool inputCheckAllNum = input.All(char.IsDigit); // check input to see if all char are digits

            if (inputCheckEmpty)
            {
                errorLabel.Text = "ERROR: Width value cannot be empty";
                errorLabel.ForeColor = Color.Tomato;
                deskWidthBox.BackColor = Color.Tomato;
                this.ActiveControl = deskWidthBox;

            } else if (!inputCheckAllNum)
            {
                errorLabel.Text = "ERROR: Width value must only include numaric values";
                errorLabel.ForeColor = Color.Tomato;
                deskWidthBox.BackColor = Color.Tomato;
                this.ActiveControl = deskWidthBox;

            } else if (inputCheckAllNum)
            {
                int parseValue = Int32.Parse(input); // parse input from string to int 
                bool correctValue = parseValue >= minWidth && parseValue <= maxWidth; // check parseValue if within correct rage
                if (!correctValue)
                {
                    errorLabel.Text = $"ERROR: Width value must be between {minWidth} and {maxWidth} inches";
                    errorLabel.ForeColor = Color.Tomato;
                    deskWidthBox.BackColor = Color.Tomato;
                    this.ActiveControl = deskWidthBox;
                }
                else
                {
                    errorLabel.Text = ""; // empty the errorLabel
                    deskWidthBox.BackColor = default(Color); // reset the background color to the default
                }
            }
            else
            {
                errorLabel.Text = ""; // empty the errorLabel
                deskWidthBox.BackColor = default(Color); // reset the background color to the default
            }
        }

        private void deskWidthBox_Validating(object sender, CancelEventArgs e)
        {
            deskWidthBox.BackColor = default(Color); // set backgrounf color to default
            string value = deskWidthBox.Text; // get the value in the deskWidthBox
            validateWidth(value); // call validateWidth and pass the value of value
        }

        // -----------------------------------------------------
        // Validating desk - depth
        // -----------------------------------------------------

        private void deskDepthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = char.IsDigit(e.KeyChar);
            bool isControl = char.IsControl(e.KeyChar);
            if (!isDigit || isControl)
            {
                errorLabel.Text = "ERROR: Please enter a valid number";
                errorLabel.ForeColor = Color.Tomato;
                deskDepthBox.BackColor = Color.Tomato;
                this.ActiveControl = deskDepthBox;
            }
            else
            {
                errorLabel.Text = "";
            }
        }

        public void validateDepth(string input)
        {
            Desk desk = new Desk();
            int minWidth = desk.deskMinDepth; // get min width value from Desk class
            int maxWidth = desk.deskMaxDepth; // get max width value from Desk class
            bool inputCheckEmpty = string.IsNullOrEmpty(input); // check input to see if empty
            bool inputCheckAllNum = input.All(char.IsDigit); // check input to see if all char are digits

            if (inputCheckEmpty)
            {
                errorLabel.Text = "ERROR: Depth value cannot be empty";
                errorLabel.ForeColor = Color.Tomato;
                deskDepthBox.BackColor = Color.Tomato;
                this.ActiveControl = deskDepthBox;

            }
            else if (!inputCheckAllNum)
            {
                errorLabel.Text = "ERROR: Depth value must only include numaric values";
                errorLabel.ForeColor = Color.Tomato;
                deskDepthBox.BackColor = Color.Tomato;
                this.ActiveControl = deskDepthBox;

            }
            else if (inputCheckAllNum)
            {
                int parseValue = Int32.Parse(input); // parse input from string to int 
                bool correctValue = parseValue >= minWidth && parseValue <= maxWidth; // check parseValue if within correct rage
                if (!correctValue)
                {
                    errorLabel.Text = $"ERROR: Depth value must be between {minWidth} and {maxWidth} inches";
                    errorLabel.ForeColor = Color.Tomato;
                    deskDepthBox.BackColor = Color.Tomato;
                    this.ActiveControl = deskDepthBox;
                }
                else
                {
                    errorLabel.Text = ""; // empty the errorLabel
                    deskDepthBox.BackColor = default(Color); // reset the background color to the default
                }
            }
            else
            {
                errorLabel.Text = ""; // empty the errorLabel
                deskDepthBox.BackColor = default(Color); // reset the background color to the default
            }
        }

        private void deskDepthBox_Validating(object sender, CancelEventArgs e)
        {
            deskDepthBox.BackColor = default(Color); // set backgrounf color to default
            string value = deskDepthBox.Text; // get the value in the deskWidthBox
            validateDepth(value); // call validateWidth and pass the value of value
        }

        // -----------------------------------------------------
        // Validating desk - number of drawers
        // -----------------------------------------------------
        public void validateNumDrawers(string input)
        {
            if (numDrawersBox.SelectedIndex < 0 || numDrawersBox.SelectedIndex > 8 || String.IsNullOrEmpty(input))
            {
                errorLabel.Text = "Please select one of the drawer options";
                errorLabel.ForeColor = Color.Tomato;
                numDrawersBox.BackColor = Color.Tomato;
                this.ActiveControl = numDrawersBox;
            }
            else
            {
                numDrawersBox.BackColor = default(Color);
                errorLabel.Text = "";
            }

        }

        private void numDrawersBox_Validating(object sender, CancelEventArgs e)
        {
            numDrawersBox.BackColor = default(Color); // set backgrounf color to default
            string value = numDrawersBox.Text; // get the value in the deskWidthBox
            validateNumDrawers(value); // call validateWidth and pass the value of value
        }

        // -----------------------------------------------------
        // Validating desk - material type
        // -----------------------------------------------------
        public void validateMaterialType(string input)
        {
            if (materialTypeBox.SelectedIndex < 1 || materialTypeBox.SelectedIndex > 5 || materialTypeBox.SelectedIndex == -1 || String.IsNullOrEmpty(input))
            {
                errorLabel.Text = "Please select one of the material type options";
                errorLabel.ForeColor = Color.Tomato;
                materialTypeBox.BackColor = Color.Tomato;
                this.ActiveControl = materialTypeBox;
            }
            else
            {
                materialTypeBox.BackColor = default(Color);
                errorLabel.Text = "";
            }

        }
        private void materialTypeBox_Validating(object sender, CancelEventArgs e)
        {
            materialTypeBox.BackColor = default(Color);
            string value = materialTypeBox.Text;
            validateMaterialType(value);
        }

        // -----------------------------------------------------
        // Validating desk - shipping
        // -----------------------------------------------------
        public void validateShipping(string input)
        {
            if (shippingBox.SelectedIndex < 0 || shippingBox.SelectedIndex > 4 || shippingBox.SelectedIndex == -1 || String.IsNullOrEmpty(input))
            {
                errorLabel.Text = "Please select a shipping option";
                errorLabel.ForeColor = Color.Tomato;
                shippingBox.BackColor = Color.Tomato;
                this.ActiveControl = shippingBox;
            }
            else
            {
                shippingBox.BackColor = default(Color);
                errorLabel.Text = "";
            }
        }

        private void shippingBox_Validating(object sender, CancelEventArgs e)
        {
            shippingBox.BackColor = default(Color);
            string value = shippingBox.Text;
            validateShipping(value);
        }

        // -----------------------------------------------------
        // Get Quote
        // -----------------------------------------------------
        public void getQuoteBtn_Click(object sender, EventArgs e)
        {
            DeskQuote deskQuote = new DeskQuote();
            Desk desk = new Desk();

            try
            {
                deskQuote.currentDate = deskQuote.getCurrentDate();

                deskQuote.customerName = customerNameBox.Text;

                desk.deskWidth = Convert.ToInt32(deskWidthBox.Text);
                desk.deskDepth = Convert.ToInt32(deskDepthBox.Text);
                deskQuote.totalArea = deskQuote.getTotalSurfaceArea(desk.deskWidth, desk.deskDepth);
                deskQuote.totalSurfaceCost = deskQuote.getTotalSurfaceCost(desk.deskWidth, desk.deskDepth);

                desk.deskNumDrawers = Convert.ToInt32(numDrawersBox.Text);
                deskQuote.totalDrawerCost = deskQuote.getTotalDrawerCost(desk.deskNumDrawers);

                desk.surfaceMaterial = (DesktopMaterial)materialTypeBox.SelectedIndex;
                deskQuote.totalSurfaceMaterialCost = deskQuote.getTotalSurfaceMaterialCost(materialTypeBox.SelectedIndex + 1);

                deskQuote.shippingType = deskQuote.getShippingType(shippingBox.SelectedIndex + 1);
                deskQuote.totalShippingCost = deskQuote.getTotalShippingCost(shippingBox.SelectedIndex + 1);

                deskQuote.totalCost = deskQuote.getTotalCost();


                //------------------------------------------------------------------------------
                //--Writing to Json - file 
                //------------------------------------------------------------------------------

                try
                {

                    string fileQuotes = @"quotes.json";

                    List<DeskQuote> deskQuotes = new List<DeskQuote>();

                    //checks if the file "quotes.json" exists in the current directory
                    if (File.Exists(fileQuotes))
                    {
                        // created to read the contents of the file
                        using (StreamReader reader = new StreamReader(fileQuotes))
                        {
                            //reads the quotes.json if it exists
                            string JSONquotes = reader.ReadToEnd();

                            if (JSONquotes.Length > 0)
                            {
                                //deserialize quotes
                                deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(JSONquotes);
                            }

                        }
                        //add quotes to list
                        deskQuotes.Add(deskQuote);
                    }


                    var writeQuotes = JsonConvert.SerializeObject(deskQuotes);
                    using (var writer = new StreamWriter(fileQuotes))
                    {
                        writer.Write(writeQuotes);
                        writer.Close();
                    }
                }
                catch(Exception ex)
                {

                    errorLabel.Text = "ERROR SAVING USER";

                }
                        

                //-END JSON -------------------------------------------------------------------------------


                DisplayQuote viewDisplayQuote = new DisplayQuote(desk, deskQuote);
                viewDisplayQuote.Tag = this;
                viewDisplayQuote.Show(this);
                Hide();
            }
            catch (Exception ex)
            {
                errorLabel.Text = "ERROR: Please make sure all fields are filled or selected";
                errorLabel.ForeColor = Color.Tomato;
            }
        }
    }
}
