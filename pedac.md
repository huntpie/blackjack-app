Program Objective: Mimic the game of Blackjack

Rules of Blackjack

-Game Played between Dealer and Player

- Dealer and Player Hand are empty at beginning of game
  -Dealer is deal two cards from deck and hand gains this value
  -Player is dealt two cards from deck and Player hand gains this value

-The value of a hand is the sum of the values of the cards

The value of Jack, Queen, King is 10
The numbered cards are the same value as their face
Ace is valued at 11 and 1 for adventure mode, just 11 for now

When the game begins, Player can Hit or Stand

Hit means a card is dealt from deck and placed into players hand

Repeat process Hit or Stand until Player stands or until hand value exceeds 21 and player result is bust

When player stands, and player has not busted then the dealer plays(dealt cards)

Dealer is dealt cards until hand value is over 17

Dealer hand is more than 21, busted. Player wins.

Once dealer reaches value over 17 we compare players hand value to dealers and higher value wins as along as the value is not more than 21.

Needed for this program:

-Deck
52 cards. Need to shuffle. Ability to deal a single card a time.
-Card
Face and Suit. Value of card is determined by face. Shuffle helps with suit.
-Hand
The list of cards. sum of individual cards is the total value of hand.
-Dealer
maybe can use hand
-Player
maybe can use hand

Algorithm

Create a new deck of cards
Shuffle deck of cards
betting begins
open player hand
open dealer hand
place card from deck into player hand (reveal)
place card from deck into dealer hand (reveal)
place another card from deck open into player hand(reveal)
place another card from deck concealed into dealer hand (closed)
reveal one card of dealer to player
Player sees sum of cards in hand (total)
Reveal sum with ace as 11 or 1
give option to double down, split or surrender for player
if no double down, split, or surrender is played, then all that is left is hit or stand
if player busts, go to BUSTEDplayer step
if player hits, deal card and check for bust. if no bust, repeat hit or stand
if stand, go to next player until all players bust or stand
go to dealer and reveal dealers cards/total
if 21 dealer wins with blackjack
check for other players with 21
if other player with 21, result is push. if no other players with 21, result is house wins
if dealer is less than 21 but more han or equal to 17, compare value with all players values, highest value wins

if dealer is less than 17, dealer is automatically dealt another card, repeat steps above. 17-21 , compare to other players scores. 21, compare to other players scores, either a push or a likely win for the house. if still less than 17, deal another card, etc.

BUSTEDplayer : Dealer wins

Does player want to play again?
