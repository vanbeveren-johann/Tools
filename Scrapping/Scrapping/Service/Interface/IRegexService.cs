﻿
namespace Scrapping.Service.Interface
{
    public interface IRegexService
    {
        string ReplaceContentWithPostText(string textContent, string replacement, string pattern, string postText = ".html");
        string ReplaceContentWithPreText(string textContent, string replacement, string pattern, string preText = "page ");
        string ReplaceContent(string textContent, string replace, string pattern);
    }
}
