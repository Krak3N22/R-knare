# 🧮 Räknare – En multifunktionell konsolräknare i C#

Detta är ett enkelt men kraftfullt C#-konsolprogram som låter dig räkna på allt från grundläggande matematik till Ohms lag och Effektens lag.  
Perfekt för dig som vill öva på programmering, elsystem eller bara ha en snabb kalkylator direkt i terminalen.

---

## 🚀 Funktioner

Programmet stöder följande beräkningar:

| Typ av beräkning | Kommando | Beskrivning |
|------------------|-----------|--------------|
| Multiplikation  | `m` | Räknar ut produkten av två tal |
| Addition        | `a` | Lägger ihop två tal |
| Subtraktion     | `s` | Beräknar skillnaden mellan två tal |
| Division        | `d` | Dividerar två tal |
| Ohms lag        | `o` | Beräknar spänning (U), resistans (R) eller ström (I) |
| Effektens lag   | `e` | Beräknar effekt (P), spänning (U) eller ström (I) |

---

## ⚙️ Installation & körning

### Förutsättningar
- **.NET SDK 6.0 eller senare** installerad  
  (Ladda ner från [dotnet.microsoft.com](https://dotnet.microsoft.com/))

### Körning via terminal
1. Klona eller ladda ner projektet.  
   ```bash
   git clone https://github.com/Krak3N22/R-knare.git
   cd R-knare
   ```

2. Bygg projektet:  
   ```bash
   dotnet build
   ```

3. Kör programmet:  
   ```bash
   dotnet run
   ```

---

## 🧩 Användning

När du startar programmet möts du av:

```
Hej!
Vad vill du räkna ut? [m/a/s/d/o/e]
```

Exempel på användning:

### 🔹 Multiplikation
```
Vad vill du räkna ut? m
Vilka två tal vill du multiplicera?
tal 1: 5
tal 2: 7
Ditt tal blir 35
```

### 🔹 Ohms lag (U = R * I)
```
Vad vill du räkna ut? o
Vad vill du räkna ut? [U/R/I]
U
vad är resistansen? (R) 10
och vad är strömmen? (I) 2
Spänningen är: 20 V
```

### 🔹 Effektens lag (P = U * I)
```
Vad vill du räkna ut? e
Vad vill du räkna ut? [P/U/I]
P
vad är spänningen? (U) 230
och vad är strömmen? (I) 0.5
Effekten är: 115 W
```

---

## 🧠 Formelöversikt

| Lag | Formel | Variabler |
|------|---------|------------|
| Ohms lag | `U = R * I` | Spänning (V), Resistans (Ω), Ström (A) |
| Effektens lag | `P = U * I` | Effekt (W), Spänning (V), Ström (A) |

---

## 💡 Tips
- Använd **små bokstäver** när du skriver kommandon (`m`, `a`, `s`, `d`, `o`, `e`).
- Programmet körs i en loop tills du svarar `n` på frågan:  
  `Vill du fortsätta? [y/n]`

---

## 🧰 Kodstruktur

```text
Program.cs
│
├── Grundläggande räknefunktioner:
│   ├── Totm() – Multiplikation
│   ├── Tota() – Addition
│   ├── Tots() – Subtraktion
│   └── Totd() – Division
│
├── Ohms lag:
│   ├── U(R, I)
│   ├── R(U, I)
│   └── I(U, R)
│
└── Effektens lag:
    ├── Pe(Ue, Ie)
    ├── Ue(Pe, Ie)
    └── Ie(Pe, Ue)
```

---

## 🧑‍💻 Författare
**[Krak3N22](https://github.com/Krak3N22)**  

---

## 🪪 Licens
Detta projekt är licensierat under [MIT License](LICENSE).
