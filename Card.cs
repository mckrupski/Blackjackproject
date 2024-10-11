using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjackproject
{
    internal class Card
    {
        //wartoscc karty(2,3,4,J,Q,K,A)
        string value;
        //wartoscc karty(Kier, Trefl, Pik, Karo)
        string color;

        public Card(string value, string color)
        {
            this.value = value;
            this.color = color;
        }

        public int GetValue()
        {
            int result;
            if (int.TryParse(value, out result))
            
                return result;
                switch (value)
                {
                    case "J":
                    case "Q":
                    case "K":
                        return 10;
                    case "A":
                    return 11;
                        default:
                    return 0;
                }
        }

        public string GetCardImageURL()
        {
            return value + color + "png";
        }
    }

}
