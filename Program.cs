using System;

class Website
{
    private string name;
    private string url;
    private string description;
    private string ipAddress;

    public void SetName(string newName)
    {
        name = newName;
    }

    public string GetName()
    {
        return name;
    }

    public void SetUrl(string newUrl)
    {
        url = newUrl;
    }

    public string GetUrl()
    {
        return url;
    }

    public void SetDescription(string newDescription)
    {
        description = newDescription;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetIpAddress(string newIpAddress)
    {
        ipAddress = newIpAddress;
    }

    public string GetIpAddress()
    {
        return ipAddress;
    }

    public void InputData()
    {
        Console.Write("Введіть назву сайту: ");
        SetName(Console.ReadLine());

        Console.Write("Введіть шлях до сайту: ");
        SetUrl(Console.ReadLine());

        Console.Write("Введіть опис сайту: ");
        SetDescription(Console.ReadLine());

        Console.Write("Введіть ір-адресу сайту: ");
        SetIpAddress(Console.ReadLine());
    }

    public void DisplayData()
    {
        Console.WriteLine("Інформація про сайт:");
        Console.WriteLine($"Назва: {GetName()}");
        Console.WriteLine($"Шлях: {GetUrl()}");
        Console.WriteLine($"Опис: {GetDescription()}");
        Console.WriteLine($"Ір-адреса: {GetIpAddress()}");
    }
}

class Magazine
{
    private string name;
    private int foundingYear;
    private string description;
    private string contactPhone;
    private string email;

    public void SetName(string newName)
    {
        name = newName;
    }

    public string GetName()
    {
        return name;
    }

    public void SetFoundingYear(int newYear)
    {
        foundingYear = newYear;
    }

    public int GetFoundingYear()
    {
        return foundingYear;
    }

    public void SetDescription(string newDescription)
    {
        description = newDescription;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetContactPhone(string newPhone)
    {
        contactPhone = newPhone;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public void SetEmail(string newEmail)
    {
        email = newEmail;
    }

    public string GetEmail()
    {
        return email;
    }

    public void InputData()
    {
        Console.Write("Введіть назву журналу: ");
        SetName(Console.ReadLine());

        Console.Write("Введіть рік заснування: ");
        SetFoundingYear(int.Parse(Console.ReadLine()));

        Console.Write("Введіть опис журналу: ");
        SetDescription(Console.ReadLine());

        Console.Write("Введіть контактний телефон: ");
        SetContactPhone(Console.ReadLine());

        Console.Write("Введіть email: ");
        SetEmail(Console.ReadLine());
    }

    public void DisplayData()
    {
        Console.WriteLine("Інформація про журнал:");
        Console.WriteLine($"Назва: {GetName()}");
        Console.WriteLine($"Рік заснування: {GetFoundingYear()}");
        Console.WriteLine($"Опис: {GetDescription()}");
        Console.WriteLine($"Контактний телефон: {GetContactPhone()}");
        Console.WriteLine($"Email: {GetEmail()}");
    }
}

class Store
{
    private string name;
    private string address;
    private string profileDescription;
    private string contactPhone;
    private string email;

    public void SetName(string newName)
    {
        name = newName;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAddress(string newAddress)
    {
        address = newAddress;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetProfileDescription(string newDescription)
    {
        profileDescription = newDescription;
    }

    public string GetProfileDescription()
    {
        return profileDescription;
    }

    public void SetContactPhone(string newPhone)
    {
        contactPhone = newPhone;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public void SetEmail(string newEmail)
    {
        email = newEmail;
    }

    public string GetEmail()
    {
        return email;
    }

    public void InputData()
    {
        Console.Write("Введіть назву магазину: ");
        SetName(Console.ReadLine());

        Console.Write("Введіть адресу магазину: ");
        SetAddress(Console.ReadLine());

        Console.Write("Введіть опис профілю магазину: ");
        SetProfileDescription(Console.ReadLine());

        Console.Write("Введіть контактний телефон: ");
        SetContactPhone(Console.ReadLine());

        Console.Write("Введіть email: ");
        SetEmail(Console.ReadLine());
    }

    public void DisplayData()
    {
        Console.WriteLine("Інформація про магазин:");
        Console.WriteLine($"Назва: {GetName()}");
        Console.WriteLine($"Адреса: {GetAddress()}");
        Console.WriteLine($"Опис профілю: {GetProfileDescription()}");
        Console.WriteLine($"Контактний телефон: {GetContactPhone()}");
        Console.WriteLine($"Email: {GetEmail()}");
    }
}

class Program
{
    static void Main()
    {
        Website website = new Website();
        website.InputData();
        website.DisplayData();

        Magazine magazine = new Magazine();
        magazine.InputData();
        magazine.DisplayData();

        Store store = new Store();
        store.InputData();
        store.DisplayData();
    }
}
