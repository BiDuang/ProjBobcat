﻿using ProjBobcat.Interface;

namespace ProjBobcat.Class.Model.GameResource;

public class LibraryDownloadInfo : IGameResource
{
    public string FileName { get; set; }
    public string Path { get; set; }
    public string Title { get; set; }
    public ResourceType Type { get; set; }
    public string Url { get; set; }
    public long FileSize { get; set; }
    public string CheckSum { get; set; }
}