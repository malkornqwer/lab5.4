using System.Collections.Generic;

class ErrorDictionary
{
    public static Dictionary<string, List<string>> GetDictionary()
    {
        var dictionary = new Dictionary<string, List<string>>();
        dictionary.Add("привет", new List<string> { "првиет" });
        dictionary.Add("Привет", new List<string> { "Првиет" });
        dictionary.Add("перец", new List<string> { "перце" });
        dictionary.Add("лось", new List<string> { "лоьс" });
        dictionary.Add("ого", new List<string> { "гоо" });
        dictionary.Add("гадзила", new List<string> { "гадзлиа" });
        dictionary.Add("крушить", new List<string> { "куршить" });
        dictionary.Add("звонЯт", new List<string> { "звОнят" });
        dictionary.Add("двестидвадцать", new List<string> { "двестидвацать", "двистидвацать" });
        dictionary.Add("сем", new List<string> { "шесть" });
        dictionary.Add("шалтайболтайболталболтая", new List<string> { "шалтайболтайболталболтайа" });
        return dictionary;
    }
}