using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholCalculator
{
    class Glass
    {
        public static double LittleCupVolume = 100;
        public static double MiddleCupVolume = 250;
        public static double BigCupVolume = 400;
        public static double ShotVolume = 50;
        public static double CoctailGlassVolume = 90;
        public static double OldFashionedVolume = 130;
        public static double ChampagneFluteVolume = 140;
        public static double ArmagnacGlassVolume = 160;
        public static double WhiteWineGlassVolume = 180;
        public static double RedWineGlassVolume = 200;
        public static double CognacBalloonVolume = 240;
        public static double CollinsVolume = 280;
        public static double BeerMugVolume = 500;

        private double _volume;
        private GlassType _glassType;

        public static Dictionary<GlassType, int> GlassDictionary { get; private set; } = new Dictionary<GlassType, int>
        {
            {GlassType.Shot, 50},
            {GlassType.CoctailGlass, 90},
            {GlassType.LittleCup, 100},
            {GlassType.OldFashioned, 130},
            {GlassType.ChampagneFlute, 140},
            {GlassType.ArmagnacGlass, 160},
            {GlassType.WhiteWineGlass, 180},
            {GlassType.RedWineGlass, 200},
            {GlassType.CognacBalloon, 240},
            {GlassType.MiddleCup, 250},
            {GlassType.Collins, 280},
            {GlassType.BigCup, 400},
            {GlassType.BeerMug, 500}
        };

        public static string[] GlassDictionaryToString
        {
            get { return GlassDictionary.Select(kv => $"{kv.Key} - {kv.Value}ml").ToArray(); }
        }


        public Glass(double volume)
        {
            _volume = volume;
            _glassType = GlassType.CustomGlass;
        }

        public Glass(GlassType glassType)
        {
            _glassType = glassType;
            SetVolumeFromGlassType(glassType);
        }

        public double Volume
        {
            get
            {
                return _volume;
            }
        }

        public GlassType GlassType
        {
            get
            {
                return _glassType;
            }
        }

        private void SetVolumeFromGlassType(GlassType glassType)
        {
            _volume = GlassDictionary[glassType];
        }


    }


    enum GlassType
    {
        LittleCup, // 100
        MiddleCup, // 250
        BigCup,    // 400
        Shot,      // 50
        CoctailGlass,   // 90
        OldFashioned,   // 130
        ChampagneFlute, // 140
        ArmagnacGlass,  // 160
        WhiteWineGlass, // 180
        RedWineGlass,   // 200
        CognacBalloon,  // 240
        Collins,   // 280
        BeerMug,   // 500
        CustomGlass

    }
}
