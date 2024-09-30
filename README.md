# Simulace bojleru

## O projektu
- Aplikace slouží k simulování ohřevu vody v bojleru. Simulace znázorňuje v reálném čase jak se bude chovat tempota vody v bojleru válcovitého tvaru o rozměrech 200x50 cm se spirálou o výkonu 4 kw. Dále projekt jakožto zátěž pro bojler využívá dva kohouty. Jeden s průtokem 15 a druhý s průrokem 30 litrů za minutu. Projekt je napsán v jazyce C# za pomoci Windows Forms. 

## Popis funkce programu
- Hlavní třídou celé aplikace je třída Simulation. V té je hlavní timer, který zajišťuje pravidelné updaty simulace. Update probíhá následujícím způsobem. Za prvé se spočítá, zda nějaká voda vytéká z bojleru. Následně se aplikuje tepelná ztráta 100w. Poté se voda v bojleru ochladí v případě, že nějaká vody vytéká. Jako předposlední krok se zkontroluje zda je možné zapnout spirálu a ohřát vodu na základě několika kritérií. Na závěr po vyhodnocení včech proměnných a aplikaci vnějších vlivů zapne spirála a provede se výpočet pro ohřátí vody.
- Simulace využívá několika modelů pro lepší organizaci dat a provádění výpočtů. Tyto modely jsou Bathroom, Valve a Bojler. 
- Bathroom obsahuje instanci Bojleru a 2x modely Valve, které reprezentují dva kohoutky v koupelně. Dále obsahuje konstantu udávající teplotu studené vody a atribut udávající celkový výstupní proud z bojleru.
- Bojler udržuje informace o jeho teplotě a hladině vody. Dále pak zda je spínán manuálně a zda je spirála v provozu.
- Valve obsahuje informace o průtoku což je celkový objem vody výtékající kohoutkem ven. Dále pak proud studené a teplé vody, teplotu výstupní vody a v procentech uloženou informaci o poměru teplé a studené vody. Tyto informace se využívají k výpočtům kolik vody vytéká z bojleru ven.

## Autor: Jaroslav Němec T3 SSAKHK 2023/2024
