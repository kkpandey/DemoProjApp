using DemoProjApp.Model;
using DemoProjApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<PricingRules> pricingRulesList = new List<PricingRules>();
            PriceingItems priceingItems = new PriceingItems();
            pricingRulesList = priceingItems.GetPricingRules();
            ProductCheckOutService storeCheckoutObj = new ProductCheckOutService(pricingRulesList);

            storeCheckoutObj.scan("ipd");
            storeCheckoutObj.scan("ipd");
            storeCheckoutObj.scan("ipd");
            storeCheckoutObj.scan("ipd");
            storeCheckoutObj.scan("ipd");
            //Bye 3 Apple Tv
            storeCheckoutObj.scan("atv");
            storeCheckoutObj.scan("atv");
            storeCheckoutObj.scan("atv");
          
            storeCheckoutObj.scan("mbp");
            storeCheckoutObj.scan("mbp");
            //Amount Payed to users
            storeCheckoutObj.total();
        }
    }
}
