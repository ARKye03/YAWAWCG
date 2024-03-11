using UnityEngine;
using Cards;

public class Slot : MonoBehaviour
{
    public Card card;

    public void SetCard(Card newCard)
    {
        card = newCard;
        // Instantiate the 3D model and position it at the slot
        GameObject modelInstance = Instantiate(card.model);
        modelInstance.transform.position = transform.position;
    }
}