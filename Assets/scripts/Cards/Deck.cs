using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    public class Deck : MonoBehaviour
    {
        private readonly List<Card> cards = new();

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public Card DrawCard()
        {
            if (cards.Count == 0) return null;

            Card drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }
    }
}