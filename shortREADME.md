# Behavioral Patterns
1.	Chain Pattern
	Aufteilung einer Aufgabe in mehrere Unteraufagaben, die mit einander verkettet sind.
2.	Command Pattern
	Kapselung einer Methode in ein Object, 
3.	Interpreter Pattern
	Kapselung von einer Funktion, die User Input in Daten umwandelt
4.	Iterator Pattern
	Zum Durchlaufen von Custom Collections
5.	Mediator Pattern 
	Erstellung einer Klasse, die Kommunikation zwischen Objekten einer anderen Klasse ermöglicht
6.	Memento Patter
	Zum Speichern und Laden von Zuständen eines Objektes
7.	NullObject Pattern
	Wenn ein Objekt einen null Zustand haben soll, man aber trotzdem noch darauf zugreifen möchte.
8.	Observer Pattern
	Wenn ein Objekt, andere Objekte informiert, dass sich sein Zustand geändert hat.
9.	State Pattern
	Funktionen eines Objektes ändern sich an Hand des Zustandes des Objektes.
10.	Strategy Pattern
	Wenn eine Lösung zu einem Problem zur Laufzeit entschieden werden soll oder einfach austauschbar sein soll
11.	Template Pattern
	Wenn bei einer Methode sich ein Teil ändert und ein anderer Teil gleich bleibt, abhängig vom User zur Laufzeit
12.	Visitor Pattern
	Zum temporären Erweitern von Methoden zur Laufzeit
# Creational Patterns
1.	Builder Pattern
	Kapselt das Erstellen eines komplexen Objektes, aus mehreren einfacheren Objekten von der Benutzung des Objektes
2.	Factory Pattern
	Kapselt das Erstellen von Objekten einer bestimmten Kategorie (e.g. Theme) von der Benutzung der Objekte, wobei alle Objekte immer noch zu 
	eine Ober-Kategorie (UIcomponent) gehören
3.	FluentInterface Pattern
	Ein Set an Interfaces, die verschiedene Möglichkeiten haben miteinander verbunden zu werden
	z.B. Von Source (Server, Datei) -> Daten bearbeiten (something...) -> Daten speichern (Server, Datei)
4.	ObjectPool Pattern
	Erstellt eine Sammlung von Objekten, die aufwendig zu erstellen sind, z.B. Texturen, welche aus dem Pool geholt werden, wenn sie benötigt werden und
5.	Prototype Pattern
	Zum Produzieren von Kopien von Objekten
6.	Singleton Pattern
	Beschränkt eine Klasse darauf nur eine Instance haben zu können, die im gegensatz zu statisch Klassen nicht immer existieren muss.
# Structural Patterns
1.	Adapter Pattern
	Eiene Erweiterung zu einer Klasse, um sie kompatible mit einer anderen Klasse zumachen.
2.	Bridge Pattern
	Eine Schnittstelle zwischen zwei Kategorien von Klassen, die dafür sorgort das alle Klasse aus einer Kategorie mit allen aus der Anderen kompatibel sind.
3.	Composite Pattern
	Strukturierung eines komplexen Objektes in eine Baumstruktur
4.	Decorator Pattern
	Eine Erweiterung zu einer Klasse, die ein Grundobjekt der Klasse mit neuen oder veränderten Methoden.
5.	Facade Pattern
	Bündelung von Objekten in eine Art Sammel Objekt, welches dann die Aufgaben weiterleitet.
6.	Flyweight Pattern
	Aufteilung von Attributen in veränderbare und nicht veränderbare und Speicherung jener bei Erstellung von vielen Ähnlichen Objekten.
7.	PrivateClassData Pattern
	Trennung von Attributen und Methoden in zwei Klassen, die in Bezug stehen.
8.	Proxy Pattern
	Ein Objekt, welches zwischen den Zugriff und den Lebensdauer eines anderen Objektes kontrolliert.
9.	Repository Pattern
	Eine Sonderform von Facade zum Verwalten von Collections
	Änderung