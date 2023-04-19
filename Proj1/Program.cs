// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

namespace LanguageTranslator
{
    public partial class Form1 : Forms
    {
        private TranslationServiceClient translationClient;

        public Form1()
        {
            InitializeComponent();
            translationClient = TranslationServiceClient.Create();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void EnglishButton_Click(object sender, EventArgs e)
        {
            TranslateText(LanguageCodes.English);
        }

        private void FrenchButton_Click(object sender, EventArgs e)
        {
            TranslateText(LanguageCodes.French);
        }

        private void SpanishButton_Click(object sender, EventArgs e)
        {
            TranslateText(LanguageCodes.Spanish);
        }

        private async void TranslateText(LanguageCodes targetLanguageCode)
        {
            var request = new TranslateTextRequest
            {
                Contents = { textBox1.Text },
                TargetLanguageCode = targetLanguageCode.ToString()
            };
            var response = await translationClient.TranslateTextAsync(request);
            textBox1.Text = response.TranslatedText;
        }

        private class TranslationServiceClient
        {
            internal static TranslationServiceClient? Create()
            {
                throw new NotImplementedException();
            }
        }
    }

    public enum LanguageCodes
    {
        English = "en",
        French = "fr",
        Spanish = "es"
    }
}