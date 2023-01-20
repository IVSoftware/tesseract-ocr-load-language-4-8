 
 
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