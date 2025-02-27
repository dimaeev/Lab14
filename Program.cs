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

    public Document(string name, string author, string keywords, string topic, string filePath)
    {
        Name = name;
        Author = author;
        Keywords = keywords;
        Topic = topic;
        FilePath = filePath;
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

// Класс-наследник MS Word
class WordDocument : Document
{
    public int PageCount { get; set; }

    public WordDocument(string name, string author, string keywords, string topic, string filePath, string pageCount)
        : base(name, author, keywords, topic, filePath)
    {
        PageCount = pageCount;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Количество страниц: {PageCount}");
    }
}

// Класс - наследник PDF
class PDFDocument : Document
{
    public bool IsEncrypted { get; set; }

    public PDFDocument(string name, string author, string keywords, string topic, string path, bool isEncrypted)
        : base(name, author, keywords, topic, path)
    {
        IsEncrypted = isEncrypted;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Зашифрован: {(IsEncrypted ? "Да" : "Нет")}");
    }
}

// Класс - наследник MS Excel
class ExcelDocument : Document
{
    public int SheetsCount { get; set; }

    public ExcelDocument(string name, string author, string keywords, string topic, string path, int sheetsCount)
        : base(name, author, keywords, topic, path)
    {
        SheetsCount = sheetsCount;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Количество листов: {SheetsCount}");
    }
}

// Класс - наследник TXT
class TXTDocument : Document
{
    public long FileSize { get; set; }

    public TXTDocument(string name, string author, string keywords, string topic, string path, long fileSize)
        : base(name, author, keywords, topic, path)
    {
        FileSize = fileSize;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Размер файла: {FileSize} байт");
    }
}

// Класс - наследник HTML
class HTMLDocument : Document
{
    public string Encoding { get; set; }

    public HTMLDocument(string name, string author, string keywords, string topic, string path, string encoding)
        : base(name, author, keywords, topic, path)
    {
        Encoding = encoding;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Кодировка: {Encoding}");
    }
}