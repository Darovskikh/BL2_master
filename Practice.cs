using System;
using System.ComponentModel;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            //CONVERSION (explicit, implicit, Convert)

            //1. CHAR CONVERSION 
            char sex = 'М';//to string
            string sex1 = Convert.ToString(sex); //"M"

            char place = '3';//to int
            int placeInt = place;  // 51
            char hasFingerPrints = '0';//to boolean
           // bool hasFingerPrintsBool = Convert.ToBoolean(  hasFingerPrints); красиво преобразовать не получается

            //2. STRING CONVERSION           
            string hasPhotoString = "True";//to bolean
            bool hasPhotoBool = Boolean.Parse(hasPhotoString); // true

            string flatNumber = "34";//to int
            int flatNumberInt = Int32.Parse(flatNumber); // 34

            string visaPriceString = "34,23";//to float
            float visaPriceFloat = float.Parse(visaPriceString); // 34.23

            string photoPriceString = "7.23";//to float
            photoPriceString = photoPriceString.Replace(".", ",");
            float photoPriceFloat = float.Parse(photoPriceString); //  7.23

            //3. BOOL CONVERSION
            bool hasFree2Pages = false;//to string, to char, to int
            string hasFree2PagesString = Convert .ToString( hasFree2Pages); // "False"
            //char hasFree2PagesChar = Convert.ToChar(hasFree2Pages);  нет такого символа 'False'
            int hasFree2PagesInt = Convert.ToInt32(hasFree2Pages); // 0
            
            //4. DECIMAL CONVERSION
            double visaPrice = 60;//to int, to string
            int visaPriceInt32 = (int)visaPrice;  // 60
            string visaPriceString1 = Convert.ToString(visaPrice); // "60"
            
            double finterPrintsPrice = 55.2;//to int, to string
            int fingerPrintsPriceInt = (int) finterPrintsPrice; // 55
            string fingerPrintsPriceString = Convert.ToString(finterPrintsPrice);  // "55,2"

            //4. INT CONVERSION
            int birthYear = 2000;//to string, to double, to char
            string birthYearString = Convert.ToString( birthYear); // "2000"
            double birthYearDouble = birthYear;  // 2000.0
            char birhtYearChar = (char)birthYear; // 'ߐ'

            int hasPhotoInt = 1;//to boolean
            bool hasPhotoBool1 = Convert.ToBoolean(hasPhotoInt); // true
        }
    }
}
