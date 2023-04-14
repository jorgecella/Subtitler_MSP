using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Subtitler_MSP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //fill combobox
            string[] languages = { "English", "French", "Spanish", "German", "Italian", "Portuguese", "Russian", "Chinese", "Japanese", "Korean" };


            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Afrikaans", ToolTip = "af" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Albanian", ToolTip = "sq" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Amharic", ToolTip = "am" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Arabic", ToolTip = "ar" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Armenian", ToolTip = "hy" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Assamese", ToolTip = "as" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Azerbaijani (Latin)", ToolTip = "az" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Bangla", ToolTip = "bn" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Bashkir", ToolTip = "ba" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Basque", ToolTip = "eu" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Bosnian (Latin)", ToolTip = "bs" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Bulgarian", ToolTip = "bg" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Cantonese (Traditional)", ToolTip = "yue" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Catalan", ToolTip = "ca" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Chinese (Literary)", ToolTip = "lzh" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Chinese Simplified", ToolTip = "zh-Hans" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Chinese Traditional", ToolTip = "zh-Hant" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Croatian", ToolTip = "hr" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Czech", ToolTip = "cs" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Danish", ToolTip = "da" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Dari", ToolTip = "prs" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Divehi", ToolTip = "dv" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Dutch", ToolTip = "nl" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "English", ToolTip = "en" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Estonian", ToolTip = "et" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Faroese", ToolTip = "fo" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Fijian", ToolTip = "fj" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Filipino", ToolTip = "fil" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Finnish", ToolTip = "fi" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "French", ToolTip = "fr" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "French (Canada)", ToolTip = "fr-ca" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Galician", ToolTip = "gl" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Georgian", ToolTip = "ka" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "German", ToolTip = "de" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Greek", ToolTip = "el" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Gujarati", ToolTip = "gu" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Haitian Creole", ToolTip = "ht" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Hebrew", ToolTip = "he" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Hindi", ToolTip = "hi" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Hmong Daw (Latin)", ToolTip = "mww" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Hungarian", ToolTip = "hu" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Icelandic", ToolTip = "is" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Indonesian", ToolTip = "id" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Inuinnaqtun", ToolTip = "ikt" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Inuktitut", ToolTip = "iu" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Inuktitut (Latin)", ToolTip = "iu-Latn" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Irish", ToolTip = "ga" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Italian", ToolTip = "it" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Japanese", ToolTip = "ja" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Kannada", ToolTip = "kn" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Kazakh", ToolTip = "kk" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Khmer", ToolTip = "km" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Klingon", ToolTip = "tlh-Latn" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Klingon (plqaD)", ToolTip = "tlh-Piqd" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Korean", ToolTip = "ko" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Kurdish (Central)", ToolTip = "ku" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Kurdish (Northern)", ToolTip = "kmr" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Kyrgyz (Cyrillic)", ToolTip = "ky" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Lao", ToolTip = "lo" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Latvian", ToolTip = "lv" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Lithuanian", ToolTip = "lt" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Macedonian", ToolTip = "mk" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Malagasy", ToolTip = "mg" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Malay (Latin)", ToolTip = "ms" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Malayalam", ToolTip = "ml" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Maltese", ToolTip = "mt" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Maori", ToolTip = "mi" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Marathi", ToolTip = "mr" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Mongolian (Cyrillic)", ToolTip = "mn-Cyrl" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Mongolian (Traditional)", ToolTip = "mn-Mong" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Myanmar", ToolTip = "my" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Nepali", ToolTip = "ne" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Norwegian", ToolTip = "nb" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Odia", ToolTip = "or" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Pashto", ToolTip = "ps" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Persian", ToolTip = "fa" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Polish", ToolTip = "pl" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Portuguese (Brazil)", ToolTip = "pt" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Portuguese (Portugal)", ToolTip = "pt-pt" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Punjabi", ToolTip = "pa" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Queretaro Otomi", ToolTip = "otq" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Romanian", ToolTip = "ro" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Russian", ToolTip = "ru" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Samoan (Latin)", ToolTip = "sm" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Serbian (Cyrillic)", ToolTip = "sr-Cyrl" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Serbian (Latin)", ToolTip = "sr-Latn" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Slovak", ToolTip = "sk" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Slovenian", ToolTip = "sl" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Somali (Arabic)", ToolTip = "so" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Spanish", ToolTip = "es" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Swahili (Latin)", ToolTip = "sw" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Swedish", ToolTip = "sv" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Tahitian", ToolTip = "ty" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Tamil", ToolTip = "ta" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Tatar (Latin)", ToolTip = "tt" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Telugu", ToolTip = "te" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Thai", ToolTip = "th" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Tibetan", ToolTip = "bo" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Tigrinya", ToolTip = "ti" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Tongan", ToolTip = "to" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Turkish", ToolTip = "tr" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Turkmen (Latin)", ToolTip = "tk" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Ukrainian", ToolTip = "uk" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Upper Sorbian", ToolTip = "hsb" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Urdu", ToolTip = "ur" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Uyghur (Arabic)", ToolTip = "ug" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Uzbek (Latin", ToolTip = "uz" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Vietnamese", ToolTip = "vi" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Welsh", ToolTip = "cy" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Yucatec Maya", ToolTip = "yua" });
            Languages_ComboBox.Items.Add(new ComboBoxItem { Content = "Zulu", ToolTip = "zu" });



            //   foreach (string language in languages)
            //   {
            //       Languages_ComboBox.Items.Add(language);
            //   }

            //refer to combobox toolip to get language code
        Languages_ComboBox.SelectionChanged += (s, e) =>
        {
            var item = (ComboBoxItem)Languages_ComboBox.SelectedItem;
            string languageCode = (string)item.ToolTip;
            Label1.Content ="";
            Label1.Content = "Selected Language: " + item.Content;
               
        };
    

        }

        //get file directory
       private void GetFile_Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                
                FileDirectory_TextBox.Text = filename;

                //get file name from filename
                string[] words = filename.Split('\\');
                string lastWord = words[words.Length - 1];
                //remove the file extension
                lastWord = lastWord.Substring(0, lastWord.Length - 4);
                TextBoxName.Text = lastWord;

                //get filename path
                string[] words2 = filename.Split(lastWord);
                string lastWord2 = words2[0];
               
                TextBoxPath.Text = lastWord2;

                TextBorrar.Text = lastWord2 + lastWord ;

                Label1.Content = Label1.Content +Environment.NewLine+ "Video File: " + lastWord;


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //execute console script
            Label1.Content = Label1.Content +Environment.NewLine+ "Getting English Subtitles";
           System.Diagnostics.Process.Start("cmd.exe", "/c C:\\Users\\jorgec\\source\\repos\\Subtitler_MSP\\cap\\captioning.exe --key 57756965b6af4d04a5ef265bd88d109d --region eastus --input "+ FileDirectory_TextBox.Text +" --format any --output "+ TextBorrar.Text +".srt --srt --realTime --threshold 5 --delay 0 --profanity mask " );




            
        }
        private static readonly string key = "696bd263477246d5a5db7749cd415aba";
        private static readonly string endpoint = "https://api.cognitive.microsofttranslator.com/";
        
       

        // location, also known as region.
        // required if you're using a multi-service or regional (not global) resource. It can be found in the Azure portal on the Keys and Endpoint page.
        private static readonly string location = "eastus";
        public async Task Translate_SRT(string LanguageCode)
        {
            
            //get text from file
            string textToTranslate = File.ReadAllText(TextBorrar.Text + ".srt");
            string textToNewSRT = TextBorrar.Text + " "+LanguageCode+".srt";



            // Input and output languages are defined as parameters.

            Label1.Content = Label1.Content +Environment.NewLine+ "Translating Subtitles to: " + LanguageCode;

            string route = "/translate?api-version=3.0&from=en&to="+LanguageCode;
            //string textToTranslate = "1\r\n00:00:00,590 --> 00:00:00,870\r\nSearch\r\n\r\n2\r\n00:00:00,870 --> 00:00:01,230\r\nSearch engines\r\n\r\n3\r\n00:00:01,230 --> 00:00:01,390\r\nSearch engines are\r\n\r\n4\r\n00:00:01,390 --> 00:00:01,890\r\nSearch engines are designed to\r\n\r\n5\r\n00:00:01,890 --> 00:00:02,120\r\nSearch engines are designed to\r\nprovide\r\n\r\n6\r\n00:00:02,120 --> 00:00:02,430\r\nSearch engines are designed to\r\nprovide you";
            object[] body = new object[] { new { Text = textToTranslate } };
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Build the request.
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(endpoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", key);
                // location required if you're using a multi-service or regional (not global) resource.
                request.Headers.Add("Ocp-Apim-Subscription-Region", location);

                // Send the request and get response.
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                // Read response as a string.
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);

                //convert a json to text

                dynamic jsonObj = JsonConvert.DeserializeObject(result);

                string text = string.Empty;

                foreach (var item in jsonObj)
                {
                    foreach (var item2 in item.translations)
                    {
                        //add text to a string

                        text = text + item2.text;
                        
                    }
                }

                File.WriteAllText(textToNewSRT, text);

                //var json = JsonConvert.DeserializeObject(result);
                //var text = JsonConvert.SerializeObject(result, Formatting.Indented);
            }

           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var item = (ComboBoxItem)Languages_ComboBox.SelectedItem;
            string languageCode = (string)item.ToolTip;

            _=Translate_SRT(languageCode);
        }
    }




}

