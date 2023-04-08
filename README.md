# Run Time Tracker

Przed wyłączeniem aplikacji uruchom program oraz podaj nazwę aplikacji, którą chcesz śledzić. Następnie po wyłączeniu śledzonej alpikacji automatycznie zostatnie zapisany czas używania śledzonej aplikacji.


## Nazwy Procesów

Aplikacja zawiera kilka wbudowanych nazw procesów.
Aby sprawdzić nazwy procesów niezawartych w programie użyj kodu poniżej:

```cs
using System.Diagnostics;

class Program
{
    public static void Main()
    {
        var processes = Process.GetProcesses();

        var processesByName = apps.Select(n => n.ProcessName).Where(n => n.Contains(" <część nazwy programu>[^1] "));
        
        foreach (var item in processesByName)
        {
            Console.WriteLine(item);
        }
    }
}
```

- [^1] Tutaj podaj część nazwy programu, kóry chcesz sprawdzić (najlepiej bez pierwszej litery)

<br>

### To Do:
- [ ] Sprawdzanie z filtrem daty (1 liniowe)
