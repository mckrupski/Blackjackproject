﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjackproject
{
    internal class Hand
    {
        List<Card> cards = new List<Card>();
        
        public void AddCard(Card card)
        {
            cards.Add(card);

        }
        public int CountPoints()
        {

        }
    }
}
