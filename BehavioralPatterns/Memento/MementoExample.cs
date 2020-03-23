using DesignPatternCheatSheet.BehavioralPatterns.Memento;
using System;

namespace DesignPatternCheatSheet.Memento
{
    public class MementoExample
    {
        public void test()
        {
            GameSaver gameSaver = new GameSaver();
            Caretaker caretaker = new Caretaker();

            gameSaver.gameState = new GameState("heute");

            caretaker.addGameState(gameSaver.saveGameState());
            gameSaver.gameState = new GameState("morgen");
            caretaker.addGameState(gameSaver.saveGameState());
            gameSaver.gameState = new GameState("wochenende");

            Console.WriteLine(gameSaver.gameState.text);

            Console.WriteLine(caretaker.getGameState(1).gameState.text);
        }
    }
}
