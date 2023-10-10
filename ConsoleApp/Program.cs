Game game = new Game();

// Roll the balls for each frame
game.Roll(1, 4); // Frame 1
game.Roll(4, 5); // Frame 2
game.Roll(6, 4); // Frame 3 (Spare)
game.Roll(5, 5); // Frame 4 (Spare)
game.Roll(10, 0); // Frame 5 (Strike)
game.Roll(0, 1); // Frame 6
game.Roll(7, 3); // Frame 7 (Spare)
game.Roll(6, 4); // Frame 8 (Spare)
game.Roll(10, 0); // Frame 9 (Strike)
game.Roll(2, 8, 6); // Frame 10 (Spare)

// Calculate and display the final score
int score = game.Score();
Console.WriteLine("Final Score: " + score);