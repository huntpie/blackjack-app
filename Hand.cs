using System;
using System.Collections.Generic;
using System.Linq;

namespace blackjack_app
{
  public class Hand
  {
    public List<Card> CardsinHand = new List<Card>();

    public void Accept(Card cardGivenToPlayer)
    {
      CardsinHand.Add(cardGivenToPlayer);
    }
    //new method to reveal cards to console. dealer reveal different than players
    public void ShowPlayerCards()
    {
      foreach (var card in CardsinHand)
      {
        Console.WriteLine($"{card.Face} of {card.Suit}");
      }
    }

    public void ShowDealerCards()
    {
      //foreach (var card in CardsinHand)
      //{
      var dealerRevealCard = CardsinHand[0];
      //foreach (var dealearRevealCard in CardsinHand)
      //{
      Console.WriteLine($"{dealerRevealCard.Face} of {dealerRevealCard.Suit}");
      // }
      //}
    }




    public int TotalValueAceOne()
    {
      var total = 0;
      foreach (var card in CardsinHand)
      {
        var cardValue = card.ValueAceOne();
        total = total + cardValue;
      }
      return total;
    }

    public int TotalValueAceEleven()
    {
      var total = 0;
      foreach (var card in CardsinHand)
      {
        var cardValue = card.ValueAceEleven();
        total = total + cardValue;
      }
      return total;


    }
  }
}



