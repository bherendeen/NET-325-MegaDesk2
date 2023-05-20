using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace MegaDesk2
{
    public class DeskQuote : Desk
    {
        // DeskQuote variables
        public Desk desk { get; set; }
        public string currentDate { get; set; }
        public string customerName { get; set; }
        public int totalArea { get; set; }
        public int totalSurfaceCost { get; set; }
        public int totalDrawerCost { get; set; }
        public const int COST_PER_DRAWER = 50;
        public const int BASE_PRICE = 200;
        public int baseCost { get { return BASE_PRICE; } }
        public int totalSurfaceMaterialCost { get; set; }
        public string shippingType { get; set; }
        public int totalShippingCost { get; set; }
        public int totalCost { get; set; }

        public string rushOrderPriceFile = "C:\\Users\\foxtr\\Source\\Repos\\NET-325-MegaDesk2\\MegaDesk-Herendeen\\data\\rushOrderPrices.txt";

       
        public DeskQuote()
        {
             
        }


        // -----------------------------------------------------
        // Get total surface area
        // -----------------------------------------------------
        public int getTotalSurfaceArea(int deskWidth, int deskDepth)
        {
            return deskWidth * deskDepth;
        }

        // -----------------------------------------------------
        // Get surface area cost
        // -----------------------------------------------------
        public int getTotalSurfaceCost(int deskWidth, int deskDepth)
        {
            int totalArea = getTotalSurfaceArea(deskWidth, deskDepth);
            int chargableArea;
            if (totalArea > 1000)
            {
                chargableArea = totalArea - 1000;
                return chargableArea;
            }
            else
            {
                chargableArea = 0;
                return chargableArea;
            }
        }

        // -----------------------------------------------------
        // Get drawer cost
        // -----------------------------------------------------
        public int getTotalDrawerCost(int numDrawers)
        {
            int drawerCost = numDrawers * COST_PER_DRAWER;
            return drawerCost;
        }

        // -----------------------------------------------------
        // Get surface material cost
        // -----------------------------------------------------
        public int getTotalSurfaceMaterialCost(int materialTypeIndex)
        {
            int materialCost;
            switch (materialTypeIndex)
            {
                case 1:
                    materialCost = 100;
                    return materialCost;
                case 2:
                    materialCost = 200;
                    return materialCost;
                case 3:
                    materialCost = 50;
                    return materialCost;
                case 4:
                    materialCost = 300;
                    return materialCost;
                case 5:
                    materialCost = 125;
                    return materialCost;
                default:
                    materialCost = 0;
                    return materialCost;
            }
        }

        // -----------------------------------------------------
        // Get shipping type
        // -----------------------------------------------------
        public string getShippingType(int shippingTypeIndex)
        {
            switch (shippingTypeIndex)
            {
                case 1:
                    shippingType = "3 Day";
                    return shippingType;
                case 2:
                    shippingType = "5 Day";
                    return shippingType;
                case 3:
                    shippingType = "7 Day";
                    return shippingType;
                default:
                    shippingType = "14 Day";
                    return shippingType;
            }
        }

        // -----------------------------------------------------
        // Get shipping prices - rushOrderPrices.txt
        // -----------------------------------------------------
        public string[,] GetRushOrder()
        {
            string[] prices = File.ReadAllLines(rushOrderPriceFile);
            
            string[,] rushOrderPrices = new string[3, 3];
            int row = 0;
            int column = 0;
            int priceIndex = 0;

            for (; row < 3; row++)
            {
                for (; column < 3; column++)
                {
                    rushOrderPrices[row, column] = prices[priceIndex];
                    priceIndex++;
                }

                column = 0;
            }
            return rushOrderPrices;

        }

        // -----------------------------------------------------
        // Get shipping cost
        // -----------------------------------------------------
        public int getTotalShippingCost(int shippingTypeIndex)
        {
            string[,] rushOrderPrices = GetRushOrder();
            int shippingCost = 0;

            switch (shippingTypeIndex)
            {
                case 1:
                    if (totalArea > 2000)
                    {
                        shippingCost = Int32.Parse(rushOrderPrices[0,2]);
                    }
                    else if (totalArea >= 1000)
                    {
                        shippingCost = Int32.Parse(rushOrderPrices[0, 1]);
                    } 
                    else
                    {
                        shippingCost = Int32.Parse(rushOrderPrices[0, 0]);
                    }
                    break;
                case 2:
                    if (totalArea > 2000)
                    {
                        shippingCost = Int32.Parse(rushOrderPrices[1, 2]);
                    }
                    else if (totalArea >= 1000)
                    {
                        shippingCost = Int32.Parse(rushOrderPrices[1, 1]);
                    }
                    else
                    {
                        shippingCost = Int32.Parse(rushOrderPrices[1, 0]);
                    }
                    break;
                case 3:
                    if (totalArea > 2000)
                    {
                        shippingCost = Int32.Parse(rushOrderPrices[2, 2]);
                    }
                    else if (totalArea >= 1000)
                    {
                        shippingCost = Int32.Parse(rushOrderPrices[2, 1]);
                    }
                    else
                    {
                        shippingCost = Int32.Parse(rushOrderPrices[2, 0]);
                    }
                    break;
                default:
                    shippingCost = 0;
                    break;
            }

            return shippingCost;
        }

        // -----------------------------------------------------
        // Get total cost
        // -----------------------------------------------------
        public int getTotalCost()
        {
            int cost;
            cost = BASE_PRICE + totalSurfaceMaterialCost + totalDrawerCost + totalSurfaceCost + totalShippingCost;
            return cost;
        }


        // -----------------------------------------------------
        // Get current date
        // -----------------------------------------------------
        public string getCurrentDate()
        {
            String date = DateTime.Now.ToString("dd MMMM yyyy");
            return date;
        }
    }
}
