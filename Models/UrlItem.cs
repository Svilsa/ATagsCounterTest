using System;

namespace ATagsCounter.Models;

public enum LoadingStatus
{
    Processing,
    Loaded,
    Error
}

public class UrlItem
{
    private LoadingStatus _loadingStatus = LoadingStatus.Processing;

    public UrlItem(Uri uri)
    {
        Uri = uri;
    }

    public Uri Uri { get; } 
    
    public uint ATagsCount { get; set; }
}