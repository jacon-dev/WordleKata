# Condle Inc.
Hello engineer, welcome to Condle Kata Inc.

As you're probably aware, some online game called _**Wordle**_ recently skyrocketed in popularity
and has taken the world by storm! Well we've found a lucrative loop hole in their application
and we intend to take advantage of it!

The silly folk over at _**Wordle**_ limit the number of time's people can play their game. Those
fools haven't seen the opportunity there to really draw players into the game! So we're making
our own version of the game, _**Condle**_ that people can play over and over again with absolutely 
no limits!

Our first developer started doing the work, they said they got things up and running nicely with
tests that passed too! Our testers tried the game and it ran really badly, so we fired the
developer. Now we need you to get the game up and running as soon as possible!

## Game Requirements
 - Random word generated should be no more than 5 characters long
 - Guesses should be limited to no more than 5 characters long
 - Guessing the word should compare all the letters to check for:
   - correct letters in the correct place should show the letter in upper case (i.e. "A")
   - correct letters in the wrong place should show the letter in lower case (i.e. "a")
   - wrong letters should be marked as "."
 - You should only get six attempts at guessing the word
 - When you complete the game you should be able to restart it

## Company Requirements
 - External auditors are demanding we have test coverage for as much code as possible
 - You need to follow SOLID and DRY principles where possible

## Nice To Have
 - Statistic tracking while playing:
   - Total games played
   - Total words guessed correctly
   - Total words guessed incorrectly
   - Average attempts per game

# Purpose of this Kata
This Kata was designed by me, James Conlin, as a way to help developers of all levels learn 
to build up software requirements on top of badly written legacy code.

Encouraging Test Driven Development, this Kata will expose you to various principles from both 
SOLID and DRY as well as how to iterate over arrays of characters, comparing their positions
and more.

The idea here is that you start with the basics, some of the games fundamental features dont
actually work, so you need to get them up and running.

From there you should continually iterate over the game code, improving the code itself, finding
better ways of doing things, separating concerns, etc.

As a final note, this Kata and its code is not in any way affiliated with _**Wordle**_ which is 
in fact a pretty fun daily brain exercise and can be found here: https://www.nytimes.com/games/wordle/index.html