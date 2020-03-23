1.	Chain Pattern
	Aufteilung einer Aufgabe in mehrere Unteraufagaben, die mit einander verkettet sind.
	z.B. ein Login in Service auf geteilt in checking for Spam, dann checking ob die Email Addresse existiert,
	dann ob das Password korrekt ist und dann ein Token returnen. 
	Vorteil: jede Unteraufgabe kann auch anderwalting benutzt werden z.B. Email checking und 
	der Service kann erweitert werden ohne das die anderen Unteraufgaben beeinflusst werden.
2.	Command Pattern
	Kapselung einer Methode in ein Object, 
	welches an andere Klassen weitergegeben kann, sowie Databinding und es z.B. in einer Liste gespeichert werden kann
	um den Befehl rückgangig zumachen
	Vorteil: Databinding Buttons und Undo Funktion
3.	Interpreter Pattern
	Kapselung von einer Funktion, die User Input in Daten umwandelt,
	z.B. einen String, der ein Datum darstellen so in ein Datums Object umwandeln
	Vorteil: man kann entscheiden, welche Möglichkeit man verwenden möchte z.B. DD-MM-YYYY oder MM-DD-YYYY, ohne das Programm
	zu Modifizieren und nur zu erweitern
4.	Iterator Pattern
	Zum Durchlaufen von Custom Collections,
	durch die Erstellung eines Iterators mit getObject, hasNext und gotoNext oder einer Varriation jener
	Vorteil: Kann unendlich große oder circulare Listen durchlaufen, da nie die ganze Liste geladen wird, 
	kann beim durchlaufen pausiert und später weiter durchlaufen werden
5.	Mediator Pattern 
	Erstellung einer Klasse, die Kommunikation zwischen Objekten einer anderen Klasse ermöglicht,
	z.B. ein Game Server, der die Kommunikation zwischen Clients herstellt
	Vorteil: Kommunizierende Objecte müssen nichts über andere Objekte wissen oder wieviele anderes es gibt
6.	Memento Patter
	Zum Speichern und Laden von Zuständen eines Objektes
	z.B. der Zustand, in dem sich ein Spiel befindet, werden in ein Memento Objekt verpackt, welche dann von einem Caretaker, z.B.
	Filemanager gespeichert und geladen werden.
	Vorteil: Objekte müssen nicht wissen, wie und wo sie gespeicert werden. Memento Objekte können auch von meherern Caretakern behandelt werden
	z.B. QuickSave im Ram oder in einer Datei.
7.	NullObject Pattern
	Wenn ein Objekt einen null Zustand haben soll, man aber trotzdem noch darauf zugreifen möchte.
	z.B. eine Lücke in eine Liste
	Vorteil: vermeidet NullPoiterException, Nachteil: Verursacht Fehler,wenn das Objekt im Nullzustand ist, obwohl es nicht sein sollte.
8.	Observer Pattern
	Wenn ein Objekt, andere Objekte informiert, dass sich sein Zustand geändert hat.
	z.B. ein Kanal, ein Observable hat ein Update und informiert alle seine Subscriber, Observer.
	Vorteil: Beziehungen werden zur können zur Laufzeit erstellt werden.
9.	State Pattern
	Funktionen eines Objektes ändern sich an Hand des Zustandes des Objektes.
	z.B. eine Online Bestellung, vom Shopping Cart canceln (kein Problem), Bestellt cancel (braucht bearbeitung)und versand cancel (nicht möglich)
	Vorteil: Neue Zustände können hinzugefügt werden ohne die alten zu beiflussen, Optimisierung durch Vermeidung von if statements
10.	Strategy Pattern
	Wenn eine Lösung zu einem Problem zur Laufzeit entschieden werden soll oder einfach austauschbar sein soll
	z.B. Daten speichern (Problem), mögliche Lösungen MongoDB, SQLServer, Lokale Datei
	Vorteil: Lösungen sind gekapselt vom Problem und können zur Laufzeit entschieden werden, neue Lösung können hinzugefügt werden ohne das Programm zubeeinflussen
11.	Template Pattern
	Wenn bei einer Methode sich ein Teil ändert und ein anderer Teil gleich bleibt, abhängig vom User zur Laufzeit
	z.B. Chat Nachricht mit einem verlinktem Image oder eimen statischen Image, der Nachrichten teil bleibt, aber wie das Bild zustande kommt ändert sich.
	Vorteil: der Code, der gleich bleibt wird nicht neugeschrieben und bleibt somit einzigartig, so das Veränderung nur einmal durch geführt werden müssen, 
	falls diese nötig sind.
12.	Visitor Pattern
	Zum temporären Erweitern von Methoden zur Laufzeit
	z.B. eine Methode, die den Preis eines Produktes berechnet, könnte mit einem Gutschein Visitor erweitert werden.
	Vorteil: Erweiterung von Objekten zur Laufzeit ohne die Klasse mit unnötigen Methoden zufüllen. 
	Methoden von verschiedenen Klassen können die gleiche Erweiterung haben.
