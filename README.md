# Automaticari
## Clanovi Tima:

1. Mirza Hodovic
2. Ahmed Ahmedic
3. Danijel Cuturic

Sistem za brzu naplatu cestarine

### Opis teme
Vremenom raste broj automobila samim tim rastu gužve na autocestama i javlja se potreba za uvođenje jednostavnije ekonomski prihvatljivije naplate cestarine. Također potrebna je i modernizacija usluge kako bi se išlo u korak sa vremenom i standardima koje su postavile razvijenije države. Da bi se to ostvarilo, potrebna je aplikacija koja će istovremeno biti efikasna,  jednostavna za korištenje i ekonomski isplativa. Cilj je da se pronađe najjednostavniji način za naplatu  cestarine i da se samim tim smanje gužve na ulazima.


### Procesi

Korisnik pravi korisnički račun i daje podatke o sebi i automobilu.

Podaci se upisuju u bazu podataka.
Korisnik predaje zahtjev za dopunu računa.
Uplaćuje određeni iznos na račun.
Administrator obrađuje unesene podatke i provjerava ispravnost transakcije i odobrava   transakciju ukoliko je kartično plaćanje.
Administrator šalje odgovarajući uređaj na adresu korisnika ukoliko je isti putem intereneta napravio korisnički račun. Ukoliko je korisnički račun napravljen na licu mjesta, administrator daje uređaj službeniku koje ga proslijeđuje korisniku.
Korisnik ulazi na autoput, približava se naplatnoj kućici i nailazi na senzor koji očitava podatke s kartice koja se nalazi kod korisnika.
(Pitati za kameru koja bi slikala registracijske oznake i upoređivala s registracijskim oznakama koje se nalaze na kartici).
Senzor prosljeđuje podatke sistemu koji ih obrađuje i provjerava stanje na računu korisnika tj. je li stanje dovoljno za naplatu.
Ukoliko stanje na računu nije dovoljno za napatu prolasaka autoputom, korisnik se obavještava putem SMS-a da se ne može uključiti na autoput i da odmah izvrši dopunu na račun koja je dovoljna za naplatu ili izvrši uplatu gotovinom kod službenika na kućici označenoj za naplatu u ovim slučajevima.
Ukoliko je stanje na računu dovoljno, sistem podiđe rampu i korsnik se može uključiti na autoput.
Prilikom izlaska s autoputa, skida se određena cijena u odnosu na kilometre koje je korsnik prešao od trenutka priključenja na autoput (1km - 0,10 KM ). i tipa vozila (1km - nx0,10 KM)  
Kad sistem završi transakciju, rampa se podiže i korisnik može napustiti autoput.  
 
 
### Funkcionalnosti





### Akteri


Korisnik - osoba koja predaje zahtjev za korisnički račun

Službenik - naplaćuje cestarinu ukoliko nema dovoljno stanja na računu; daje uređaj korisniku ako korisnik pravi račun na licu mjesta

Administrator - vrši validaciju podataka; daje urešaj službeniku ukoliko se radi na licu mjesta ili dostavljaču ukoliko račun nije napravljen na licu mjesta

Dostavljač - dostavlja uređaj korisniku ukoliko nije napravio račun na licu mjesta
