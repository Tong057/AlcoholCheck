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

        public Glass(double volume)
        {
            _volume = volume;
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
            switch (glassType)
            {
                case GlassType.LittleCup: 
                    _volume = LittleCupVolume;
                    return;
                case GlassType.MiddleCup: 
                    _volume = MiddleCupVolume;
                    return;
                case GlassType.BigCup: 
                    _volume = BigCupVolume;
                    return;
                case GlassType.Shot: 
                    _volume = ShotVolume;
                    return;
                case GlassType.CoctailGlass: 
                    _volume = CoctailGlassVolume;
                    return;
                case GlassType.OldFashioned: 
                    _volume = OldFashionedVolume;
                    return;
                case GlassType.ChampagneFlute: 
                    _volume = ChampagneFluteVolume;
                    return;
                case GlassType.ArmagnacGlass:
                    _volume = ArmagnacGlassVolume;
                    return;
                case GlassType.WhiteWineGlass:
                    _volume = WhiteWineGlassVolume;
                    return;
                case GlassType.RedWineGlass:
                    _volume = RedWineGlassVolume;
                    return;
                case GlassType.CognacBalloon:
                    _volume = CognacBalloonVolume;
                    return;
                case GlassType.Collins: 
                    _volume = CollinsVolume;
                    return;
                case GlassType.BeerMug: 
                    _volume = BeerMugVolume;
                    return;

            }
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
        Default

    }
}
