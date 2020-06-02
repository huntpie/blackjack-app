using System;
using System.Collections.Generic;
using System.Text;

namespace blackjack_app
{
  public class Card
  {
    public string Face { get; set; }
    public string Suit { get; set; }

    public int ValueAceOne()
    {
      if (Face == "2")
      {
        return 2;
      }
      if (Face == "3")
      {
        return 3;
      }
      if (Face == "4")
      {
        return 4;
      }
      if (Face == "5")
      {
        return 5;
      }
      if (Face == "6")
      {
        return 6;
      }
      if (Face == "7")
      {
        return 7;
      }
      if (Face == "8")
      {
        return 8;
      }
      if (Face == "9")
      {
        return 9;
      }
      if (Face == "10")
      {
        return 10;
      }
      if (Face == "Jack")
      {
        return 10;
      }
      if (Face == "Queen")
      {
        return 10;
      }
      if (Face == "King")
      {
        return 10;
      }
      if (Face == "Ace")
      {
        return 1;
      }
      return 0;
    }
    public int ValueAceEleven()
    {
      if (Face == "2")
      {
        return 2;
      }
      if (Face == "3")
      {
        return 3;
      }
      if (Face == "4")
      {
        return 4;
      }
      if (Face == "5")
      {
        return 5;
      }
      if (Face == "6")
      {
        return 6;
      }
      if (Face == "7")
      {
        return 7;
      }
      if (Face == "8")
      {
        return 8;
      }
      if (Face == "9")
      {
        return 9;
      }
      if (Face == "10")
      {
        return 10;
      }
      if (Face == "Jack")
      {
        return 10;
      }
      if (Face == "Queen")
      {
        return 10;
      }
      if (Face == "King")
      {
        return 10;
      }
      if (Face == "Ace")
      {
        return 11;
      }
      return 0;


    }

  }
}