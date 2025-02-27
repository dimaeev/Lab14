using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Document
{
    public string Name { get; set; }
    public string Author { get; set; }
    public string Keywords { get; set; }
    public string Topic { get; set; }
    public string FilePath { get; set; }

    public Document(string name, string author, string keywords, string topic, string filepath)
    {
        Name = name;
        Author = author;
        Keywords = keywords;
        Topic = topic;
        FilePath = filepath;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Документ: {Name}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Ключевые слова: {Keywords}");
        Console.WriteLine($"Тематика: {Topic}");
        Console.WriteLine($"Путь к файлу: {FilePath}");
    }
}