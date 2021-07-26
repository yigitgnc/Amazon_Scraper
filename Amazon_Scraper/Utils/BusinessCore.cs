using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon_Scraper.Helpers;
using Amazon_Scraper.Models;
using WebScraper.Utils;
using WebScraper.Utils.Clients;

namespace Amazon_Scraper.Utils
{
    public static class BusinessCore
    {
        public static int MaxThread = 1;
        public static bool AsyncMode = false;
        public static bool UseRndDelay = false;
        public static int RndDelayMin = 1;
        public static int RndDelayMax = 1;
        public static List<ProductTest> ProductList = new List<ProductTest>();

        private static CustomWebBrowser _browser = new CustomWebBrowser();
        private static Random _random = new Random();

        private static string _previousHtml = "";
        public static async Task<HtmlDocument> GetDocumentAsync(string url)
        {
            $"{url} adresine WebBrowser ile istek atılıyor...".WriteLog();
            int delay = 0;
            if (UseRndDelay)
            {
                delay = _random.Next(RndDelayMin, RndDelayMax);
                delay = delay * 1000;
                $"İstek Atılmadan Önce {delay} ms bekleniyor...".WriteLog();
            }

            await Task.Delay(delay);

            HtmlDocument document = await _browser.GetDocumentAsync(url);

            if (document.Body.OuterHtml.Length == _previousHtml.Length)
            {
                "Gelen Sayfa Bir Önceki İstekle Aynı olabilir ürünlere göre kontrol edilmeli eğer aynı ürünlerse browser cache temizlenmeli...".WriteLog();
            }

            if (document.Body.OuterHtml.Contains("captcha"))
            {
                "Opss... sanırım captcha'ya takıldık".WriteLog();
            }
            _previousHtml = document.Body.OuterHtml;

            return document;
        }

        public static async void GetProductsAsync(string supplierUrl)
        {
            $"{supplierUrl} için TÜm Ürünlerin Çekilmesi İşlemi Başlatılıyor...".WriteLog();
            //ilk sayfa için istek atılsın
            "ilk sayfa için istek atılıyor.".WriteLog();
            HtmlDocument firstDoc = await GetDocumentAsync(supplierUrl);

            int totalPAgeNumber = firstDoc.GetTotalPageNumber();
            $"Supplier için toplam sayfa sayısı {totalPAgeNumber} olarak belirlendi.".WriteLog();
            firstDoc.GetProductsInPageFromHtmlDocument();
            "ilk sayfa için ürünler çekiliyor".WriteLog();

            for (int i = 1; i < totalPAgeNumber; i++)
            {
                $"{i}. Sayfa için ürünler çekiliyor...".WriteLog();
                string pageIUrl = $"";
                HtmlDocument doc = await GetDocumentAsync(pageIUrl);



                doc.GetProductsInPageFromHtmlDocument();
            }

        }

        private static void GetProductsInPageFromHtmlDocument(this HtmlDocument document)
        {

        }

        private static int GetTotalPageNumber(this HtmlDocument document)
        {
            "Toplam Sayfa Sayısı Belirleniyor...".WriteLog();
            var spans = document.GetElementsByTagName("span");
            List<HtmlElement> possiblePaginationSpanElements = new List<HtmlElement>();

            HtmlElement lastPageSpan = null;

            foreach (HtmlElement element in spans)
            {
                if (element.GetAttribute("className").Contains("s-pagination-item"))
                {
                    possiblePaginationSpanElements.Add(element);
                }
            }

            lastPageSpan = possiblePaginationSpanElements.LastOrDefault();


            if (lastPageSpan == null)
            {
                "Kritik Hata Son Sayda Spanı Bulunamadı Program Doğru Çalışmayacak".WriteLog();
                //throw new Exception("Aha Sikİ tUTTUK");
            }

            string innerText = lastPageSpan.InnerText;
            int pageNumber;
            if (int.TryParse(innerText.Trim(),out pageNumber))
            {
                return pageNumber;
            }
            else
            {
                $"innerText'i ({innerText}) inte parse edemedim burda bir sıkıntı var".WriteLog();
            }
            return 0;
        }
    }
}
