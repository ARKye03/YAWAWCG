using UnityEngine;
using Cards;

public class Slot : MonoBehaviour
{
    public Card card;

    public void SetCard(Card newCard)
    {
        card = newCard;
        // Position the card at the slot
        card.transform.position = transform.position;
    }
}