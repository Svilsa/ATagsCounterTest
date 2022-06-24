using System;
using System.Collections.Generic;
using System.Net.Http;
using ATagsCounter.Models;

namespace ATagsCounter.Core;

public class ATagsCounter
{
    private readonly HttpClient _httpClient = new HttpClient();

    public void CountATags(IEnumerable<UrlItem> urlItems)
    {
        foreach (var urlItem in urlItems)
        {
            Console.WriteLine(_httpClient.GetStringAsync(urlItem.Uri));
        }
        
    }
}