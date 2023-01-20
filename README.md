Your post states
>have a synchronous method [...] that calls an asynchronous method to download language files

If the caller is synchronous anyway, why not make the downloader synchronous, too?

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

I tested this and it seems to work [[clone](https://github.com/IVSoftware/tesseract-ocr-load-language-4-8.git)]. Does this get you any closer?