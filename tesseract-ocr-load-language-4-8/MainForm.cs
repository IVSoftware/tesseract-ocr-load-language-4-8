using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tesseract_ocr_load_language_4_8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonLoadLanguage.Click += onClickLoadLanguages;
            buttonOpenFolder.Click += onOpenFolder;
            _path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                GetType().Assembly.GetName().Name,
                "tesseract-ocr");
            Directory.CreateDirectory(_path);
        }

        private readonly string _path;
        // https://github.com/tesseract-ocr/tessdata/
        private void onClickLoadLanguages(object sender, EventArgs e)
        {
            LoadLanguage(_path, "eng");
        }
        public void LoadLanguage(string folderName, string language)
        {
            Enabled = false;
            try
            {            
                Uri uri = new Uri($"https://github.com/tesseract-ocr/tessdata/raw/main/{language}.traineddata");
                using (var client = new HttpClient())
                {
                    using (var response =
                        client
                        .GetAsync(uri)
                        .Result)
                    {
                        var bytes = response.Content.ReadAsByteArrayAsync().Result;
                        File.WriteAllBytes(Path.Combine(folderName, $"{language}.traineddata"), bytes);
                    }
                }
            }
            finally
            {
                Enabled = true;
            }
        }

        private void onOpenFolder(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", _path);
        }
    }
}
