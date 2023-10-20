using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholCalculator
{
    class Drink
    {
        public static int BeerPercentage = 5;
        public static int ChampagnePercentage = 10;
        public static int WhiteWinePercentage = 15;
        public static int RedWinePercentage = 20;
        public static int LiquorPercentage = 25;
        public static int VodkaPercentage = 40;
        public static int СognacPercentage = 42;
        public static int GinPercentage = 45;
        public static int TequilaPercentage = 50;
        public static int BrandyPercentage = 55;
        public static int RumPercentage = 60;
        public static int AbsinthePercentage = 70;
        public static int DrinkingEthanolPercentage = 90;

        private double _spiritPercentage;
        private DrinkType _drinkType;

        public static Dictionary<DrinkType, int> DrinkDictionary { get; private set; } = new Dictionary<DrinkType, int>
        {
            { DrinkType.Beer, BeerPercentage },
            { DrinkType.Champagne, ChampagnePercentage },
            { DrinkType.WhiteWine, WhiteWinePercentage },
            { DrinkType.RedWine, RedWinePercentage },
            { DrinkType.Liquor, LiquorPercentage },
            { DrinkType.Vodka, VodkaPercentage },
            { DrinkType.Cognac, СognacPercentage },
            { DrinkType.Gin, GinPercentage },
            { DrinkType.Tequila, TequilaPercentage },
            { DrinkType.Brandy, BrandyPercentage },        
            { DrinkType.Rum, RumPercentage },
            { DrinkType.Absinthe, AbsinthePercentage },
            { DrinkType.DrinkingEthanol, DrinkingEthanolPercentage }
        }; 

        public static string[] DrinkDictionaryToString
        {
            get { return DrinkDictionary.Select(kv => $"{kv.Key} - {kv.Value}%").ToArray(); }
        }


        public Drink(double spiritPercentage)
        {
            _spiritPercentage = spiritPercentage;
            _drinkType = DrinkType.CustomDrink;
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
            _spiritPercentage = DrinkDictionary[drinkType];
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
        Cognac,     // 42%
        Gin,        // 45%
        Tequila,    // 50%
        Brandy,     // 55%
        Rum,        // 60%
        Absinthe,   // 70%
        DrinkingEthanol, // 90%
        CustomDrink

    }
}
