# Dizajn paterni :art:

## Strukturalni

- **FACADE**:
Ovaj patern pravi poveznicu između korisničkih interfejsa (formi) i logičkog pogleda sistema. Za implementaciju ovog 
paterna je potrebno napraviti klasu Facade koja bi objedinjavala sve logičke dijelove sistema. ViewModeli predstavljaju
logički dio sistema, te bi bilo potrebno napraviti jednu klasu bi koja sadržavala ViewModele i koja bi navigirala njima
zavisno od korisničke interakcije sa sistemom. Na ovaj način će se klijentu pojednostaviti korištenje kompleksnih sistema.

- **PROXY**:
Klasa Admin se treba deklarisati kao privatna, te je potrebno napraviti novu Proxy klasu koja će izvršiti kreiranje instance
klase Admin. Kada korisnik unese korisničke podatke, pozvat će se metoda za autentifikaciju koja će instancirati klasu samo 
ukoliko su uneseni ispravni korisnički podaci. Time se vrši dodatno osiguravanje objekata od pogrešne ili zlonamjerne upotrebe.

## Kreacijski

- **SINGLETON**:
Aplikaciji je potrebna jedna i samo jedna instanca određene klase. Pored toga, toj klasi se treba moći pristupiti sa 
globalnog nivoa. Projekat sadrži klasu *Bluestate* koja predstavlja cjelokupni sistem i potrebna je samo jedna instanca te
klase.


## Behavioralni

- **OBSERVER**:
Observer pattern se koristi ukoliko postoje jedan-na-više veze između objekata takve da ako se jedan objekat modifikuje, 
ostali će biti obavješteni automatski. Observer koristi tri actor klase: subjekat, observer i objekat. 
Observer nadzire subjekat i svaki put kad se on promijeni obavještavaju se objekti. Primjer ovoga je aukcija: 
svako ima malu palicu koju diže da bi dao svoju ponudu, a kada neko digne palicu, cijena na aukciji se diže i o tome se 
obavještavaju ostali učesnici aukcije. Naravno, u projektu se aukcija odvija online putem.

- **INTERPRETER**:
Interpreter patern služi za evaluiranje gramatike nekog jezika i jezičkih izraza. U projektu se može koristiti za provjeru
validnosti šifre pri registraciji korisnika (npr. da li je uneseno dovoljno znakova, da li su velika i mala slova, 
da li ima brojeva i drugih znakova).
