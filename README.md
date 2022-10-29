# OOP Lab 8 – Collection generics
# Vad du ska göra

## Del 1 – Stack

- [ ]  Skapa en klass som heter `Employee`
    - [ ]  Denna klass ska ha flera egenskaper: Id, Name, Gender, Salary.

- [ ]  Skapa en Stack med objekten:
    - [ ]  I `Main()`-metoden ska du skapa fem objekt av klassen med olika Id, Name, Gender och Salary.
    - [ ]  Sedan ska du skapa en `Stack` och lägga till de fem objekten du skapat med `Push()` i Stacken.
- [ ]  Skriv ut alla objekt i din Stack:
    - [ ]  Skriv ut alla objekt i din Stack.
    - [ ]  Du kan använda en foreach-loop för att skriva ut alla element i stacken
    - [ ]  Efter varje rad eller element ska du skriva ut hur många objekt som finns kvar i Stacken.
- [ ]  Hämta alla genom Pop-metoden:
    - [ ]  Hämta alla objekt i stacken genom `POP()`-metoden och skriv ut dem
    - [ ]  Efter varje rad eller element ska du skriva ut hur många items som finns kvar i stacken.
    - [ ]  Lägg till alla objekt igen genom `Push()-`metoden
- [ ]  Hämta alla objekt igen med Peek-metoden
    - [ ]  Hämta två objekt genom `Peek()-`metoden.
    - [ ]  Efter varje rad eller element ska du skriva ut hur många items som finns kvar i stacken.
- [ ]  Kolla om objekt nummer 3 finns i stacken eller inte och skriv ut resultatet.

![Output av Del 1 - Stack](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/7adac547-4fbd-4b1e-b983-a0663c6fff19/Capturegsgrg.png)

Output av Del 1 - Stack

## Del 2 – List

- [ ]  Skapa en List
- [ ]  Lägg in fem objekt av klassen `Employee` i din List
- [ ]  Skapa ett villkor för att kolla om ett visst item finns i listan genom `Contains()-`metoden. Om den finns så skriv ut "Employee2 object exists in the list" i konsollen, else "Employee2 object does not exist in the list". (Employee2 är ett namn exempel ifall du söker efter det)
- [ ]  Använd sedan `Find()-`metoden för att hitta och skriva ut det första objektet i listan som har `Gender = "Male"`.
- [ ]  Använd sedan `FindAll()-`metoden för att hitta och skriva ut alla items i listan som har `Gender = "Male"`
