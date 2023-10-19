using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholCalculator
{
    class Drink
    {
        public static double BeerPercentage = 5;
        public static double ChampagnePercentage = 10;
        public static double WhiteWinePercentage = 15;
        public static double RedWinePercentage = 20;
        public static double LiquorPercentage = 25;
        public static double VodkaPercentage = 40;
        public static double СognacPercentage = 42;
        public static double GinPercentage = 45;
        public static double TequilaPercentage = 50;
        public static double BrandyPercentage = 55;
        public static double RumPercentage = 60;
        public static double AbsinthePercentage = 70;
        public static double DrinkingEthanolPercentage = 90;

        private double _spiritPercentage;
        private DrinkType _drinkType;

        private Dictionary<string, int> drinkData;

        public string[] FormattedData
        {
            get { return drinkData.Select(kv => $"{kv.Key} - {kv.Value}%").ToArray(); }
        }

        public Drink()
        {
            drinkData = new Dictionary<string, int>();

            drinkData.Add("Beer", 5);
            drinkData.Add("Champagne", 10);
            drinkData.Add("WhiteWine", 15);
            drinkData.Add("RedWine", 20);
            drinkData.Add("Liquor", 25);
            drinkData.Add("Vodka", 40);
            drinkData.Add("Cognac", 42);
            drinkData.Add("Gin", 45);
            drinkData.Add("Tequila", 50);
            drinkData.Add("Brandy", 55);
            drinkData.Add("Rum", 60);
            drinkData.Add("Absinthe", 70);
            drinkData.Add("DrinkingEthanol", 90);

        }



        public Dictionary<string, int> DrinkData
        {
            get
            {
                return drinkData;
            }
        }

        public Drink(double spiritPercentage)
        {
            _spiritPercentage = spiritPercentage;
            _drinkType = DrinkType.Moonshine;
        }

        public Drink(DrinkType drinkType)
        {
            _drinkType = drinkType;
            SetSpiritPercentageFromDrinkType(drinkType);
        }

        public double SpiritPercentage
        {
            get
            {
                return _spiritPercentage;
            }
        }

        public DrinkType DrinkType
        {
            get
            {
                return _drinkType;
            }
        }


        private void SetSpiritPercentageFromDrinkType(DrinkType drinkType)
        {
            switch (drinkType)
            {
                case DrinkType.Beer:
                    _spiritPercentage = BeerPercentage;
                    return;
                case DrinkType.Champagne:
                    _spiritPercentage = ChampagnePercentage;
                    return;
                case DrinkType.WhiteWine:
                    _spiritPercentage = WhiteWinePercentage;
                    return;
                case DrinkType.RedWine:
                    _spiritPercentage = RedWinePercentage;
                    return;
                case DrinkType.Liquor:
                    _spiritPercentage = LiquorPercentage;
                    return;
                case DrinkType.Vodka:
                    _spiritPercentage = VodkaPercentage;
                    return;
                case DrinkType.Сognac:
                    _spiritPercentage = СognacPercentage;
                    return;
                case DrinkType.Gin:
                    _spiritPercentage = GinPercentage;
                    return;
                case DrinkType.Tequila:
                    _spiritPercentage = TequilaPercentage;
                    return;
                case DrinkType.Brandy:
                    _spiritPercentage = BrandyPercentage;
                    return;
                case DrinkType.Rum:
                    _spiritPercentage = RumPercentage;
                    return;
                case DrinkType.Absinthe:
                    _spiritPercentage = AbsinthePercentage;
                    return;
                case DrinkType.DrinkingEthanol:
                    _spiritPercentage = DrinkingEthanolPercentage;
                    return;

            }
        }
    }

    enum DrinkType
    {
        Beer,       // 5%
        Champagne,  // 10%
        WhiteWine,  // 15%
        RedWine,    // 20%
        Liquor,     // 25%
        Vodka,      // 40%
        Сognac,     // 42%
        Gin,        // 45%
        Tequila,    // 50%
        Brandy,     // 55%
        Rum,        // 60%
        Absinthe,   // 70%
        DrinkingEthanol, // 90%
        Moonshine   // Самогон

    }
}
