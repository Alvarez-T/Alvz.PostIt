using System;

namespace Alvz.PostIt.Model;

public class PostItModel
{
    public PostItModel(string title, string content, PostItWindowConfig windowConfig)
    {
        Title = title;
        Content = content;
        WindowConfig = windowConfig;
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime LastEdit { get; set; }
    public PostItWindowConfig WindowConfig { get; set; }

}
