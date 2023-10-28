# Kata String Calculator

## Zasady
Kierowca (osoba przy klawiaturze) pisze test (kt�ry nie przechodzi).
Pilot sprawdza czytelno��, sensowno��, korzystanie z dobrych praktyk. 
Osoby zamieniaj� si� rolami.
Kierowca pisze implementacje test�w nieprzechodz�cych i nast�pne testy
�. I tak dalej ?


## Wymagania:
1. Utw�rz klas� StringCalculator z jedn� metod� int Add(string numbers)
- Metoda mo�e przyjmowa� 0, 1 lub 2 numery i zwraca ich sum� (dla pustego �a�cucha zwr�ci 0) np.: �� lub �1� lub �1,2�
- Rozpocznij z najprostszym przypadkiem � pusty �a�cuch. Nast�pnie zaimplementuj dla jednego I dw�ch numer�w
- Pami�taj aby u�ywa� najprostszych rozwi�za� w taki spos�b by pisa� testy o kt�rych wcze�niej nie my�la�e�
- Pami�taj o refaktoringu po ka�dym przechodz�cym te�cie

2. Metoda Add mo�e przyjmowa� nieokre�lon� ilo�� numer�w np.�1,2,3,4,5,6�

3. Metoda Add mo�e przyjmowa� znaki ko�ca linii pomi�dzy numerami (zamiast przecink�w).
- Poni�szy �a�cuch jest poprawny:  �1\n2,3�  (wynik - 6)
- Poni�szy �a�cuch nie jest poprawny:  �1,\n� 

4. Wsparcie dla r�nego rodzaju znak�w podzia�u
- �eby zmieni� znak podzia�u, pocz�tek linii musi si� zaczyna� : �//[delimiter]\n[numbers�]� 
np.:  �//;\n1;2� powinno zwr�ci� 3 i ustawi� znak podzia�u na �;� .
- Pierwsza linia jest opcjonalna 

5. Je�eli numer jest licz� ujemn� to powinien by� rzucony wyj�tek o tre�ci �Liczny ujemny niedozwolone�. 
Opis powinien zawiera� liczb� kt�ra spowodowa�a b��d. Je�eli by�o wi�cej liczb ujemnych to wszystkie powinny si� znale�� w opisie

6. Liczby wi�ksze ni�  1000 powinny by� ignorowane np.: 2 + 1001  = 2

7.	Znaki podzia�u mog� by� dowolnej d�ugo�ci ale zgodne z formatem :  �//[delimiter]\n� np.: np.: �//[***]\n1***2***3� powinien zwr�ci� 6

8.	Dodaj wiele znak�w podzia�u zgodnie z formatem :  �//[delim1][delim2]\n� 
np.: �//[*][%]\n1*2%3� powinien zwr�ci� 6.

9.	Upewnij si� �e mo�na poda� wiele znak�w podzia�u ka�dy d�u�szy ni� jeden znak


