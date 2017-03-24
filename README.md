# Automatičari
## Članovi Tima:

1. Mirza Hodović
2. Ahmed Ahmedić
3. Danijel Čuturić
---
## Sistem za brzu naplatu putarine
---
### Opis teme
Vremenom raste broj vozila, a samim tim rastu gužve na autoputevima i javlja se potreba za uvođenje jednostavnije ekonomski prihvatljivije naplate putarine. Također potrebna je i modernizacija usluge kako bi se išlo u korak sa vremenom i standardima koje su postavile razvijenije države. Kako bi se to ostvarilo, potrebna je aplikacija koja će istovremeno biti efikasna, jednostavna za korištenje i ekonomski isplativa. Cilj je pronaći najjednostavniji način za naplatu putarinee i smanjiti gužve na ulazima na autoputeve.

---
### Procesi

* Registracija korisnika i prijava u sistem.  
  * Korisnik pravi korisnički račun i daje podatke o sebi i vozilu.
  * Podaci se upisuju u bazu podataka.
- Korisnik predaje zahtjev za dopunu računa.
- Uplaćuje određeni iznos na račun.
  * Korisnik može nadoplatiti račun bonom tako da najprije unese broj registarske tablice a zatim unese tajni kod sa kupljenog bona.
  * Nadoplata Vašeg računa u može se izvršiti kreditnom karticom. Prvi  korak u nadoplati računa je prijava na aplikaciju. Odabirom izbornika „nadoplata računa“ morate utipkati željeni iznos nadoplate i utipkati podatke o korisniku i kreditnoj kartici (AMEX, Diners, Visa ili MasterCard) te ostale podatke koje Vas izbornik traži. Nakon što se izvrši navedena procedura, korisniku se skida iznos nadoplate s kreditne kartice.
  * Nadoplata računa putem SMS bona je vrlo jednostavna te je potrebno slijediti upute otisnute na samom bonu.
- Eksterni sistem je sistem za plaćanje - payment system.  
- Isporuka uređaja  
  * Administrator prosljeđuje uređaj dostavljaču.  
  * Dostavljač dostavlja uređaj na adresu korisnika i popunjava obrazac da je isti dostavio.      
  * Korisnik popunjava obrazac da je zaprimio uređaj i plaća ga.  
- Ukoliko je korisnički račun napravljen na licu mjesta, administrator daje uređaj službeniku koje ga proslijeđuje korisniku.
- Korisnik ulazi na autoput, približava se naplatnoj kućici i nailazi na senzor koji očitava podatke s kartice koja se nalazi u vozilu.  
- Kamera zabilježi registracijske oznake na vozilu i uporedi ih s registracijskim oznakama koji su zabilježene na kartici.  
- Senzor za težinu očitava težinu vozila i upoređuje istu s tipom vozila koju je korisnik unio prilikom registracije korisničkog računa.
- Senzor koji očitava podatke na karticu prosljeđuje podatke sistemu koji ih obrađuje i provjerava stanje na računu korisnika tj. je li stanje dovoljno za naplatu.
- Korisniku se dozvoljava  odlazak u minus jednu transakciju. Ako korisnik ima minimalna sredstva na računu, npr. 1 KM, dozvoljen mu je ulazak na autocestu te izlazak s autoceste bez obzira na iznos cestarine prijeđene dionice i ispisuje mu se poruka upozorenja na displej pokraj rampe. Navedeni sustav u funkciji je iz razloga jer ne znamo hoće li korisnik, koji na računu ima npr. 10 KM, izaći na dionici koja košta 3 KM ili na dionici koja košta 181 KM.  
- Ukoliko stanje na računu nije dovoljno za napatu prolasaka autoputom, korisnik se obavještava putem SMS-a na broj telefona koji je ostavio u podacima na korisnićkom računu da se ne može uključiti na autoput i da odmah izvrši dopunu na račun koja je dovoljna za naplatu ili izvrši uplatu gotovinom kod službenika na kućici označenoj za naplatu u ovim slučajevima.
- Ukoliko je stanje na računu dovoljno, sistem podiže rampu i korisnik se može uključiti na autoput.
- Prilikom izlaska s autoputa, skida se određena cijena u odnosu na kilometre koje je korisnik prešao od trenutka priključenja na autoput i tipa vozila.  
- Kad sistem završi transakciju, rampa se podiže i korisnik može napustiti autoput.  
--- 
### Funkcionalnosti

- Prijava korisnika na sistem.  
- Dopuna stanja na računu.  
- Kreiranje naloga za dostavljača (šta dostavlja, potvrda isporuke i potvrda da je korisnik dobio dostavu).  
- Očitavanje registarskih tablica.  
- Upoređivanje registarskih tablica.


---
### Akteri


**Korisnik** - osoba koja predaje zahtjev za korisnički račun  
**Službenik** - naplaćuje cestarinu ukoliko nema dovoljno
stanja na računu; daje uređaj korisniku ako korisnik pravi račun na licu mjesta  
**Administrator** - vrši validaciju podataka; daje urešaj službeniku ukoliko se radi na licu mjesta ili dostavljaču ukoliko račun nije napravljen na licu mjesta  
**Dostavljač** - dostavlja uređaj korisniku ukoliko nije napravio račun na licu mjesta  
