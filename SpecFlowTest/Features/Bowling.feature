Feature: Bowling

@Strike
Scenario: Strike
	Given a new bowling game
	When the player rolls the ball and hits 10 pins
	And the player then rolls the ball twice and hits 3 pins and 4 pins
	Then the score should be 24
	
@Spare
Scenario: Spare
	Given another new bowling game
	When the player rolls the balls twice and hits 5 pins each time
	And the player then rolls the ball once and hits 3 pins
	Then the final score should be 16

@GutterGame
Scenario: Gutter Game
	Given yet another new bowling game
	When the player rolls 20 times and hits 0 pins each time
	Then the final game score should be 0
	
@PerfectGame
Scenario: Perfect Game
	Given yet again another new bowling game
	When the player rolls 12 times and hits 10 pins each times
	Then the final bowling game score should be 300	