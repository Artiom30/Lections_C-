// Задача 7: Структура директории в терминале.
/*
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalogs = new DirectoryInfo(path);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + " ");
    }
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
}
string path = @"C:/Users/37544/OneDrive/Рабочий стол/C#/Seminars_C_Sharp/Seminars_C#/Seminar_9";
CatalogInfo(path);
*/