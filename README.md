# Automatičari
## Članovi Tima:

1. Mirza Hodović
2. Ahmed Ahmedić
3. Danijel Cuturić

Sistem za brzu naplatu putarine

### Opis teme
Vremenom raste broj vozila, a samim tim rastu gužve na autoputevima i javlja se potreba za uvođenje jednostavnije ekonomski prihvatljivije naplate putarine. Također potrebna je i modernizacija usluge kako bi se išlo u korak sa vremenom i standardima koje su postavile razvijenije države. Kako bi se to ostvarilo, potrebna je aplikacija koja će istovremeno biti efikasna, jednostavna za korištenje i ekonomski isplativa. Cilj je pronaći najjednostavniji način za naplatu putarinee i smanjiti gužve na ulazima na autoputeve.


### Procesi

Korisnik pravi korisnički račun i daje podatke o sebi i vozilu.

Podaci se upisuju u bazu podataka.

Korisnik predaje zahtjev za dopunu računa.

Uplaćuje određeni iznos na račun.

Eksterni sistem je sistem za plaćanje - payment system.

Administrator šalje odgovarajući uređaj na adresu korisnika ukoliko je isti putem interneta napravio korisnički račun. 

Ukoliko je korisnički račun napravljen na licu mjesta, administrator daje uređaj službeniku koje ga proslijeđuje korisniku.

Korisnik ulazi na autoput, približava se naplatnoj kućici i nailazi na senzor koji očitava podatke s kartice koja se nalazi kod korisnika.

Kamera zabilježi registracijske oznake na vozilu i upoređuje ih s registracijskim oznakama koji su zabilježeni na kartici.

Senzor koji očitava podatke na karticu prosljeđuje podatke sistemu koji ih obrađuje i provjerava stanje na računu korisnika tj. je li stanje dovoljno za naplatu.

Ukoliko stanje na računu nije dovoljno za napatu prolasaka autoputom, korisnik se obavještava putem SMS-a na broj telefona koji je ostavio u podacima na korisnićkom računu da se ne može uključiti na autoput i da odmah izvrši dopunu na račun koja je dovoljna za naplatu ili izvrši uplatu gotovinom kod službenika na kućici označenoj za naplatu u ovim slučajevima.

Ukoliko je stanje na računu dovoljno, sistem podiže rampu i korisnik se može uključiti na autoput.

Prilikom izlaska s autoputa, skida se određena cijena u odnosu na kilometre koje je korisnik prešao od trenutka priključenja na autoput (1km - 0,10 KM ) i tipa vozila (1km - nx0,10 KM).  

Kad sistem završi transakciju, rampa se podiže i korisnik može napustiti autoput.  
 
 
### Funkcionalnosti





### Akteri


Korisnik - osoba koja predaje zahtjev za korisnički račun

Službenik - naplaćuje cestarinu ukoliko nema dovoljno stanja na računu; daje uređaj korisniku ako korisnik pravi račun na licu mjesta

Administrator - vrši validaciju podataka; daje urešaj službeniku ukoliko se radi na licu mjesta ili dostavljaču ukoliko račun nije napravljen na licu mjesta

Dostavljač - dostavlja uređaj korisniku ukoliko nije napravio račun na licu mjesta
