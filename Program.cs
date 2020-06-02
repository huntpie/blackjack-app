using System;
using System.Collections.Generic;
using System.Linq;

namespace blackjack_app
{
  class Program
  {
    private const string playGamePrompt = "Would you like to play this round of blackjack? {Y}es or {N}o";
    private const string noGamePrompt = "Okay then. Maybe next round!";


    static void Main(string[] args)
    {
      //Produce shuffled deck
      var deck = new Deck();
      deck.CreateCards();

      //Betting
      Console.WriteLine(playGamePrompt);
      string userAnswer = Console.ReadLine();
      var userWinnings = 0;

      if (userAnswer.ToLower() == "y")
      {
        //Begin Game
        Console.WriteLine("Please Place a Bet");
        string userInitialBet = Console.ReadLine();
        int userInitialBetInteger = int.Parse(userInitialBet);
        //userInitialBetInteger = userWinnings;
        if (userInitialBetInteger > 0)
        {
          //Confirm bet and begin game
          Console.WriteLine($"Your bet of {userInitialBetInteger} has been placed." +
          " We will now begin the game.");
          //deal one card up to each player then followed by a down a card to dealer
          //then deal a second up card to each player, followed by dealers up card
          //declare player hands and dealer hands outside of if statement?
          //add bet to user winnings as they haven't busted or lost yet
          userWinnings = userWinnings + userInitialBetInteger;
          var playerHand = new Hand();
          var dealerHand = new Hand();

          var firstCard = deck.Deal();
          playerHand.Accept(firstCard);

          var secondCard = deck.Deal();
          playerHand.Accept(secondCard);

          var firstDealerCard = deck.Deal();
          dealerHand.Accept(firstDealerCard);

          var secondDealerCard = deck.Deal();
          dealerHand.Accept(secondDealerCard);

          //reveal cards to player and one card of dealers


          Console.WriteLine("Player has the following cards");
          playerHand.ShowPlayerCards();
          Console.WriteLine($"Total Value for player with Ace as 1 : {playerHand.TotalValueAceOne()}");
          Console.WriteLine($"Total Value for player with Ace as 11 : {playerHand.TotalValueAceEleven()}");
          Console.WriteLine("Dealer's top card is");
          dealerHand.ShowDealerCards();
          //prompt players if they would like to split, double down or surrender



          if (firstCard == secondCard)
          {
            Console.WriteLine(" Would you like to Split your hand? {Y}es or {N}o?");
            var splitAnswer = Console.ReadLine();
            if (splitAnswer.ToLower() == "y" | splitAnswer.ToLower() == "yes")
            {
              //begin game as though Player split

            }
            else
            {
              Console.WriteLine("Okay, no split then");
            }
          }
          else
          {
            Console.WriteLine("Would you like to {D}ouble down or {S}urrender or {N}either? Please Enter D or S or N");
            var surrenderAnswer = Console.ReadLine();
            if (surrenderAnswer.ToLower() == "d" | surrenderAnswer.ToLower() == "double down")
            {

              //play game with double down
            }
            else if (surrenderAnswer.ToLower() == "s" | surrenderAnswer.ToLower() == "surrender")
            {
              double surrenderWinnings = .5 * userInitialBetInteger;
              string endGamePromptSurrender = $"You have decided to surrender your hand. You will receive back half your bet of {userInitialBetInteger} for a total winnings of {surrenderWinnings} ";
              Console.WriteLine(endGamePromptSurrender);
            }
            else
            {
              //Continue game here 
            }
          }



        }


      }
      else if (userAnswer.ToLower() == "yes")
      {
        Console.WriteLine("Please input Y instead of yes");
      }
      else
      {
        Console.WriteLine(noGamePrompt);
      }

    }
  }
}
