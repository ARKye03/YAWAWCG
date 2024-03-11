using UnityEngine;
using Cards;

public class Player : MonoBehaviour
{
    public Deck deck;
    public Hand hand;
    public Board board;

    void Start()
    {
        // Create a new CardData instance
        CardData cardData = new CardData
        {
            name = "Card Name",
            strength = 10,
            combatRow = "Melee",
            ability = "Ability Description",
            typeOfUnit = "Unit Type"
        };

        // Create a new GameObject
        GameObject cardObject = new GameObject("Card");

        // Add the Card component to the GameObject
        Card card = cardObject.AddComponent<Card>();

        // Load the card model
        GameObject model = Resources.Load<GameObject>("Assets/Cards/CardModel.prefab");

        // Set the card model
        card.model = model;

        // Set the card data
        card.SetData(cardData);

        // Add the card to the first row on the board
        board.AddCard(card, 0);
    }
}