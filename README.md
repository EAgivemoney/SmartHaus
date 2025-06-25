# 🏡 SmartHaus

Een C# OOP-project dat een slim huis stimuleert met apparaten zoals lampen, thermostaten en slimme stekkers. Het project demonstreet **Inheritance, Composition, Aggregation, Interfaces, Abstract Classes** en houdt zich aan de **SOLID principles**.

---

## 📦 Projectstructuur

```
SmartHaus/
|
├── Devices/          # Concrete apparaten (Light, Thermostat, etc.)
├── Controllers/      # Beheerlogica (DeviceController)
├── Rooms/            # Aggregatie van apparaten in kamers
├── Interfaces/       # Interfaces zoals ISwitchable, IConnectable
├── Program.cs        # Entry point voor de app
└── README.md
```

---

## 🔧 Functionaliteiten

- Schakel apparaten in/uit (ISwitchable)
- Verbind apparaten met netwerk (IConnectable)
- Run zelftests op apparaten (via abstract base class)
- Gropeer apparaten per kamer (Aggregation)
- Centrale controller beheert apparaten (Composition)
- Console output simuleert systeemgedrag

---

## 🧠 Toegepaste OOP Principes

| Principe         | Implementatie                                                                 |
|------------------|-------------------------------------------------------------------------------|
| Inheritance      | `Light`, `Thermostat` erven van `DeviceBase`                                 |
| Abstract Classes | `DeviceBase` definieert gedeeld gedrag en verplicht `PerformSelfTest()`       |
| Interfaces       | `ISwitchable`, `IConnectable` voor gedragscontracten                         |
| Composition      | `DeviceController` bevat en beheert meerdere apparaten                        |
| Aggregation      | `Room` bevat apparaten zonder er eigendom van te zijn                         |

---

## 🧱 SOLID Toegepast

- **S**: Elke class heeft één duidelijke verantwoordelijkheid
- **O**: Apparaten kunnen worden uitgebreid zonder bestaande logica aan te passen
- **L**: Subclasses kunnen zonder problemen de base class vervangen
- **I**: Kleine, gerichte interfaces (`ISwitchable`, `IConnectable`)
- **D**: Controller gebruikt abstractie (`DeviceBase`), geen afhankelijkehd van concrete classes

---

## 🚀 Installatie & Uitvoeren

1. Open `SmartHaus.sln in **Visual Studio 2022**
2. Zorg dat het op `.NET 6` of `.NET 8` draait
3. Build het project (`Ctrl + Shift + B`)
4. Run de applicatie (`F5` of `Ctrl + F5`)
5. Bekijk de console output voor systeemstatus

---

## 📌 Voorbeeldoutput

```
Devices in room Living Room:
- Living Room Light
- Nest Thermostat
Testing light 'Living Room Light'... Passed.
Testing thermostat 'Nest Thermostat'... Passed.
Testing smart plug 'Coffee Maker Plug'... Passed.
Light is on: True
Plug conencted: True, Plug on: True
```

---

## 📚 Toekomstige uitbreidingen

- GUI met WPF of Blazor
- Cloud-integratie (IoT-simulatie)
- Logging & Device-statusmonitoring
- Testproject met unit tests (MSTest / xUnit)

---

## 👨‍💻 Auteur

**Thomas Meijer**
Smart Software Developer 🧠
> Gemaakt als oefening in geadvanceerde OOP & SOLID in C#
