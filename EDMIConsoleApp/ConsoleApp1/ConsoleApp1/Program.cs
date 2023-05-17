// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

namespace TestingEnum
{

    enum TypeDescription
    {
        NullData = 0,
        Array = 1,
        Structure = 2,
        Boolean = 3,
        BitString = 4,
        DoubleLong = 5,
        DoubleLongUnsigned = 6,
        OctetString = 9,
        VisibleString = 10,
        UTF8String = 12,
        BCD = 13,
        Integer = 0xF,
        Long = 0x10,
        Unsigned = 17,
        LongUnsigned = 18,
        CompactArray = 19,
        Long64 = 20,
        Long64Unsigned = 21,
        Enum = 22,
        Float = 23,
        Double = 24,
        DateTime = 25,
        Date = 26,
        Time = 27
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ITranslator translator = new Translator();

            var rawData1 = "020909060000010000FF090C07E7020F03031D1000FE20001001E01100090C000003FE07020000008000FF090C00000AFE07030000008000FF0F3C03001601";

            var rawData2 = "020209060000830008FF02090300030103000420FFFFFFFE0420FFFFFFF9111E110A1101111E";

            translator.translateRawData(rawData1);

            translator.translateRawData(rawData2);


        }
    }
}