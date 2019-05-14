# SOLID - principi dobrog dizajna
 
1. **Single responsiblity principle**: :white_check_mark:
    * Princip je zadovoljen jer sve klase obavljaju jednu dužnost.
 
2. **Open-closed principle**: :white_check_mark:
     * Princip je zadovoljen jer su klase otvorene za ekstenzije, ali zatvorene za modifikacije. (Npr. moguće je naslijediti
  još klasa iz klase Nekretnina i bez potrebe za modificiranjem drugih dijelova koda).
 
3. **Liskov substitution principle** :white_check_mark:
   * Princip je zadovoljen jer je moguće u svim slučajevima zamijeniti baznu klasu sa naslijeđenim. (Stvari koje može raditi
  generalni Korisnik logički mogu raditi i Kupac i Prodavač, isto vrijedi i za nekretnine).
 
4. **Interface segregation principle** :white_check_mark:
   * Princip je zadovoljen jer interfejsi imaju specifične i jedinstvene uloge te nisu pretjerano generalni.
 
5. **Dependency inversion principle** :white_check_mark:
   * Princip je zadovoljen jer izvedene klase ovise o apstraktnim klasama,  te ne  postoji naslijeđivanje iz već naslijeđene
  klase. Klase ne ovise o implementaciji objekata koji ih sačinjavaju.
