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

<<<<<<< HEAD
=======
    public virtual void GetInfo()
    {
        Console.WriteLine($"Документ: {Name}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Ключевые слова: {Keywords}");
        Console.WriteLine($"Тематика: {Topic}");
        Console.WriteLine($"Путь к файлу: {FilePath}");
    }
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

>>>>>>> 2057fa36d3d5a380462ef13c1b6c2860a3056844
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

  public WordDocument(string name, string author, string keywords, string topic, string filePath, int pageCount)
    : base(name, author, keywords, topic, filePath)
  {
    PageCount = pageCount;
  }

<<<<<<< HEAD
=======
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Количество страниц: {PageCount}");
    }
  public int PageCount { get; set; }

  public WordDocument(string name, string author, string keywords, string topic, string filePath, int pageCount)
    : base(name, author, keywords, topic, filePath)
  {
    PageCount = pageCount;
  }

>>>>>>> 2057fa36d3d5a380462ef13c1b6c2860a3056844
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

<<<<<<< HEAD
=======
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Зашифрован: {(IsEncrypted ? "Да" : "Нет")}");
    }
  public bool IsEncrypted { get; set; }

  public PDFDocument(string name, string author, string keywords, string topic, string path, bool isEncrypted)
    : base(name, author, keywords, topic, path)
  {
    IsEncrypted = isEncrypted;
  }

>>>>>>> 2057fa36d3d5a380462ef13c1b6c2860a3056844
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

<<<<<<< HEAD
=======
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Количество листов: {SheetsCount}");
    }
  public int SheetsCount { get; set; }

  public ExcelDocument(string name, string author, string keywords, string topic, string path, int sheetsCount)
    : base(name, author, keywords, topic, path)
  {
    SheetsCount = sheetsCount;
  }

>>>>>>> 2057fa36d3d5a380462ef13c1b6c2860a3056844
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

<<<<<<< HEAD
=======
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Размер файла: {FileSize} байт");
    }
  public long FileSize { get; set; }

  public TXTDocument(string name, string author, string keywords, string topic, string path, long fileSize)
    : base(name, author, keywords, topic, path)
  {
    FileSize = fileSize;
  }

>>>>>>> 2057fa36d3d5a380462ef13c1b6c2860a3056844
  public override void GetInfo()
  {
    base.GetInfo();
    Console.WriteLine($"Размер файла: {FileSize} байт");
  }
<<<<<<< HEAD
=======
>>>>>>> 0fd7980 (Changes made)
>>>>>>> 2057fa36d3d5a380462ef13c1b6c2860a3056844
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

<<<<<<< HEAD
=======
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Кодировка: {Encoding}");
    }
  public string Encoding { get; set; }

  public HTMLDocument(string name, string author, string keywords, string topic, string path, string encoding)
    : base(name, author, keywords, topic, path)
  {
    Encoding = encoding;
  }

>>>>>>> 2057fa36d3d5a380462ef13c1b6c2860a3056844
  public override void GetInfo()
  {
    base.GetInfo();
    Console.WriteLine($"Кодировка: {Encoding}");
  }
<<<<<<< HEAD
=======
>>>>>>> 0fd7980 (Changes made)
>>>>>>> 2057fa36d3d5a380462ef13c1b6c2860a3056844
}

class DocumentMenu
{
  private static DocumentMenu? instance;
  public static DocumentMenu Instance
  {
    get
    {
      if (instance == null)
        instance = new DocumentMenu();
      return instance;
    }
  }

  public void ShowMenu()
  {
    Console.WriteLine("Выберите тип документа:");
    Console.WriteLine("1. MS Word");
    Console.WriteLine("2. PDF");
    Console.WriteLine("3. MS Excel");
    Console.WriteLine("4. TXT");
    Console.WriteLine("5. HTML");
    Console.WriteLine("Введите номер документа: ");

    int choice = int.Parse(Console.ReadLine());

    Document doc = choice switch
    {
      1 => new WordDocument("Документ", "Автор", "Ключи", "Тема", "путь", 10),
      2 => new PDFDocument("Документ", "Автор", "Ключи", "Тема", "путь", true),
      3 => new ExcelDocument("Документ", "Автор", "Ключи", "Тема", "путь", 5),
      4 => new TXTDocument("Документ", "Автор", "Ключи", "Тема", "путь", 1024),
      5 => new HTMLDocument("Документ", "Автор", "Ключи", "Тема", "путь", "UTF-8"),
      _ => throw new ArgumentException("Некорректный выбор!")
    };

<<<<<<< HEAD
    Console.WriteLine("\nИнформация о документе:");
    doc.GetInfo();
  }
=======
        int choice = int.Parse(Console.ReadLine());

        Document doc = choice switch
        {
            1 => new WordDocument("Документ", "Автор", "Ключи", "Тема", "путь", 10),
            2 => new PDFDocument("Документ", "Автор", "Ключи", "Тема", "путь", true),
            3 => new ExcelDocument("Документ", "Автор", "Ключи", "Тема", "путь", 5),
            4 => new TXTDocument("Документ", "Автор", "Ключи", "Тема", "путь", 1024),
            5 => new HTMLDocument("Документ", "Автор", "Ключи", "Тема", "путь", "UTF-8"),
            _ => throw new ArgumentException("Некорректный выбор!")
        };

        Console.WriteLine("\nИнформация о документе:");
        doc.GetInfo();
    }
  private static DocumentMenu? instance;
  public static DocumentMenu Instance
  {
    get
    {
      if (instance == null)
        instance = new DocumentMenu();
      return instance;
    }
  }

  public void ShowMenu()
  {
    Console.WriteLine("Выберите тип документа:");
    Console.WriteLine("1. MS Word");
    Console.WriteLine("2. PDF");
    Console.WriteLine("3. MS Excel");
    Console.WriteLine("4. TXT");
    Console.WriteLine("5. HTML");
    Console.WriteLine("Введите номер документа: ");

    int choice = int.Parse(Console.ReadLine());

    Document doc = choice switch
    {
      1 => new WordDocument("Документ", "Автор", "Ключи", "Тема", "путь", 10),
      2 => new PDFDocument("Документ", "Автор", "Ключи", "Тема", "путь", true),
      3 => new ExcelDocument("Документ", "Автор", "Ключи", "Тема", "путь", 5),
      4 => new TXTDocument("Документ", "Автор", "Ключи", "Тема", "путь", 1024),
      5 => new HTMLDocument("Документ", "Автор", "Ключи", "Тема", "путь", "UTF-8"),
      _ => throw new ArgumentException("Некорректный выбор!")
    };

    Console.WriteLine("\nИнформация о документе:");
    doc.GetInfo();
  }
>>>>>>> 0fd7980 (Changes made)
>>>>>>> 2057fa36d3d5a380462ef13c1b6c2860a3056844
}

class Program
{
<<<<<<< HEAD
=======
    static void Main()
    {
        DocumentMenu.Instance.ShowMenu();
    }
>>>>>>> 2057fa36d3d5a380462ef13c1b6c2860a3056844
  static void Main()
  {
    DocumentMenu.Instance.ShowMenu();
  }
<<<<<<< HEAD
=======
>>>>>>> 0fd7980 (Changes made)
>>>>>>> 2057fa36d3d5a380462ef13c1b6c2860a3056844
}