using System.Text;

namespace ConsoleApp1
{
    interface ITranslator
    {
        void translateRawData(string rawData);
    }

    class Translator : ITranslator
    {
        public void translateRawData(string rawData)
        {
            var decodedBytes = Convert.FromBase64String(rawData);
            var originalMessage = Encoding.UTF8.GetString(decodedBytes);

            Console.WriteLine(originalMessage);

        }
    }
}
