using System;
using System.Collections.Generic;

namespace blackjack_app
{
  public class Deck
  {
    //List to hold deck of cards(Card is the object)
    private List<Card> Cards = new List<Card>();

    //method to call new cards (52) and shuffle
    public void CreateCards()
    {

      //create two arrays - suit & face
      //"Heart", "Diamond", "Club", "Spade"
      //2, 3, 4, 5, 6, 7 , 8, 9, 10, Jack, Queen, King, Ace
      //By not assigning the faces values right now, the need
      //to pull from the deck and assign them will occur

      var suits = new string[] { "Hearts", "Diamonds", "Clubs", "Spades" };
      var faces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack",
      "Queen", "King", "Ace" };

      foreach (var suit in suits)
      {
        foreach (var face in faces)
        {
          var newCard = new Card()
          {
            Suit = suit,
            Face = face,
          }
          Cards.Add(newCard);
        }
      }
      //Create shuffle loop within Deck class/utilize Fisher Yates for the list

      var randomNumber = new Random();

      for (var index = Cards.Count - 1; index >= 1; index--)
      {
        var secondIndex = randomNumber.Next(index);

        var firstCard = Cards[secondIndex];
        var nextCard = Cards[secondIndex];

        Cards[index] = nextCard;
        Cards[secondIndex] = firstCard;
      }

    }
  }
}