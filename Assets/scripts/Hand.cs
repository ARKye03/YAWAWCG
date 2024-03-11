using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    public class Hand : MonoBehaviour
    {
        private readonly List<Card> cards = new();

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        // Implement methods to play a card, etc.
    }
}