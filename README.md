* S	Single Reponsibility principle 
	Jede Klasse sollte nur eine Aufgabe übernehmen.
* O	Open and Closed	principle 
	Klassen sollte nicht an Probleme angepasst werden, sondern nur spezifisch erweitert werden.
* L	Substitution principle 
	Ersetzen einer Vaterklasse durch eine Kinderklasse, beeinflusst nicht, ob das Programm funktioniert, sondern nur wie.
* I Interface segregation principle 
	Klassen sollte nicht Methoden von Interfaces implementieren, die sie nicht benötigen.
* D Dependency Inversion principle 
	Klassen sollten in Bezug zu Interfaces stehen und nicht Klassen.

# Behavioral Patterns
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
# Creational Patterns
1.	Builder Pattern
	Kapselt das Erstellen eines komplexen Objektes, aus mehreren einfacheren Objekten von der Benutzung des Objektes
	z.B. Erstellung eines Frame-Obejektes, welches aus mehreren UI- Component besteht, die in der richtigen Reinfolge zusammen gesetzt werden müssen.
	Vorteil: Man muss nicht jedes mal das Objekt zusammen bauen, wenn man es verwenden will und Veränderung zum Objekt müssen nur einmal durchgenommen werden.
2.	Factory Pattern
	Kapselt das Erstellen von Objekten einer bestimmten Kategorie von der Benutzung der Objekte, wobei alle Objekte immer noch zu eine Ober-Kategorie gehören
	z.B. eine Theme Factory, die Dark Themed(Kategorie) UI-Components(Ober-Kategorie) produziert oder Light Theme (Kategorie) UI Component (Ober-Kategorie) Factory 
	Vorteil: Factories vom gleichen Typ, können einfach durch andere Factories ausgetauscht werden. Kapselung vereinfacht,das Konfigurieren der Objekte.
3.	FluentInterface Pattern
	Ein Set an Interfaces, die verschiedene Möglichkeiten haben miteinander verbunden zu werden
	z.B. Von Source (Server, Datei) -> Daten bearbeiten (something...) -> Daten speichern (Server, Datei)
	Vorteil: Verkettung von Queries und Methoden, die das Ergebnis der Vorherigen Methode nehmen und weiter bearbeiten.
4.	ObjectPool Pattern
	Erstellt eine Sammlung von Objekten, die aufwendig zu erstellen sind, z.B. Texturen, welche aus dem Pool geholt werden, wenn sie benötigt werden und
	werden nach Benutzung zurück in den Pool gegeben.
	Vorteil: Aufwendige rechen Arbeit wird vor der Benutzung des Programm erledigt, um die Performance später zu erhöhen. 
	Nachteil: Kann zu unnötigem RAM verbrauch führen.
5.	Prototype Pattern
	Zum Produzieren von Kopien von Objekten, entweder als shallow copy, bei der die Attribute der neuen Kopie eine Reference auf die Attribute des Originals sind
	und oder als deep copy, bei der die Kopie und seine Attribute unabhängig vom Original sind.
	Vorteil: Kopieren von Objekten zur Laufzeit
6.	Singleton Pattern
	Beschränkt eine Klasse darauf nur eine Instance haben zu können, die im gegensatz zu statisch Klassen nicht immer existieren muss.
	Vorteil: Verhindert Konflikte, bei z.B. Zugriff auf Datei oder zu viele Verbindungen zu einem Server aufzubauen.
# Structural Patterns
1.	Adapter Pattern
	Eiene Erweiterung zu einer Klasse, um sie kompatible mit einer anderen Klasse zumachen.
	Vorteil: Macht eine Klasse mit einer andere kompatible ohne sie zu verändern.
2.	Bridge Pattern
	Eine Schnittstelle zwischen zwei Kategorien von Klassen, die dafür sorgort das alle Klasse aus einer Kategorie mit allen aus der Anderen kompatibel sind.
	Vorteil: Es können einfach neue Klasse in die Kategorien hinzugefügt werden, die mit den anderen Klassen kompatible sind. 
3.	Composite Pattern
	Strukturierung eines komplexen Objektes in eine Baumstruktur
	z.B. eine ToDo-Liste, wo Tasks (Zweige) gibs die aus mehreren ToDos bestehen und einzelnen ToDos ohne Unteraufgaben (Leafs).
	Vorteil: Schnelle und effiziente Handhabung des komplexen Objektes.
4.	Decorator Pattern
	Eine Erweiterung zu einer Klasse, die ein Grundobjekt der Klasse mit neuen oder veränderten Methoden.
	z.B. ein Auto Objekt mit verbesserten Reifen.
	Vorteil: Erweiterung von Objekten zur Laufzeit. Objekte können beliebig oft erweitert werden.
5.	Facade Pattern
	Bündelung von Objekten in eine Art Sammel Objekt, welches dann die Aufgaben weiterleitet.
	z.B. verschiendene System im Smart Home (Heizung, Strom, Alarm, Jalosie) gebündelt in einem Haus-Manager Objekt
	Vorteil: Vereinfacht die Benutzung der Objekte und komprimiert den Code.
6.	Flyweight Pattern
	Aufteilung von Attributen in veränderbare und nicht veränderbare und Speicherung jener bei Erstellung von vielen Ähnlichen Objekten.
	Veränderbare Werte werden im Objekt gespeichert, nicht veränderbare in einer Liste gewöhnlich in einer Factory, wo jeder Eintrag einzigartig ist (Dictinary in C#).
	Vorteil: Da die nicht veränderbaren Werte nur einmal gespeichert werden, sparrt dies RAM und Performance.
7.	PrivateClassData Pattern
	Trennung von Attributen und Methoden in zwei Klassen, die in Bezug stehen.
	Vorteil: unnötig extra Trennung von Methoden und Attributen, um Kapselung zu erhöhen.
8.	Proxy Pattern
	Ein Objekt, welches zwischen den Zugriff und den Lebensdauer eines anderen Objektes kontrolliert.
	Vorteil: Trennung von der Objekt Funktion und der Zugriffsmmöglichkeiten, sowie Lebensdauer des Objektes.
9.	Repository Pattern
	Eine Sonderform von Facade zum Verwalten von Collections
	Alles Arbeiten werden in ein UnitOfWork Objekt gepackt und bei abschluss commited in die entsprechenden Collections, in Bezug zu einem Repository stehen, sowie
	die Funktionalitäten eines Repositories haben (add/get/remove)
	Vorteil: Vereinfach das Verwalten von Collections, Veränderung finden nur in Paketen statt und nicht jede einzelne kleine Änderung