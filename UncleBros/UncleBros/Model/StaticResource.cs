using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UncleBros.Model
{
    public class StaticResource
    {
        //BackgroundColor="{StaticResource Key=AppColorRed}"
        //Padding="{StaticResource Key=RDPaddingBig}"
        //FontAttributes="{StaticResource Key=RDFontAttributeBold}"
        //FontSize="{StaticResource Key=RDFontSizeBig}"
        //TextColor="{StaticResource Key=RDTextColorWhite}"

        public static Color BackgroundColorRed = Color.FromHex("#f00");
        public static Color BackgroundColorGreen = Color.FromHex("#0f0");
        public static Color BackgroundColorBlue = Color.FromHex("#00f");

        public static Color TextColorWhite = Color.FromHex("#fff");
        public static Color TextColorGray = Color.FromHex("#ccc");
        public static Color TextColorBlack = Color.FromHex("#000");

        public static Double PaddingBig = 30.0;
        public static Double PaddingMiddle = 20.0;
        public static Double PaddingSmall = 10.0;

        public static Double FontSizeBig = 30.0;
        public static Double FontSizeMiddle = 20.0;
        public static Double FontSizeSmall = 10.0;

        public static FontAttributes FontAttributesBold = FontAttributes.Bold;
        public static FontAttributes FontAttributesItalic = FontAttributes.Italic;
        public static FontAttributes FontAttributesBoldItalic = FontAttributes.Bold | FontAttributes.Italic;
    }
}
