using System.Collections.Generic;
using CardGenerator;
using UnityEngine;

/// <summary>
/// Represents a script that manages the game logic for placing cards on a board.
/// </summary>
public class YetAnotherScript : MonoBehaviour
{
    private Board board;
    private List<Card> cards;

    private void Start()
    {
        board = new Board();
        cards = LoadCards("Assets/Cards/Cards.json");
        board.PlaceCard(cards[0], 0, 0, Section.Melee, board.GetMeleeSlot(0, 0));
    }

    [System.Serializable]
    public class CardDataList
    {
        public List<CardData> cards;
    }

    private List<Card> LoadCards(string path)
    {
        string json = System.IO.File.ReadAllText(path);
        CardDataList data = JsonUtility.FromJson<CardDataList>(json);
        List<Card> cards = new();

        foreach (CardData cardData in data.cards)
        {
            cards.Add(new Card(cardData));
            Debug.Log(cardData.image);
            Debug.Log(cardData.name);
            Debug.Log(cardData.strength);
        }

        return cards;
    }

    private void Update()
    {
        // Handle user input to select a card and place it on the board
        if (Input.GetMouseButtonDown(0))
        {
            // Get the selected card
            Card selectedCard = cards[0];

            // Get the slot where the card should be placed
            GameObject slotObject;
            Section section;
            switch (selectedCard.CombatRow)
            {
                case "melee":
                    slotObject = board.GetMeleeSlot(0, 0);
                    section = Section.Melee;
                    break;
                case "ranged":
                    slotObject = board.GetRangedSlot(0, 0);
                    section = Section.Ranged;
                    break;
                case "siege":
                    slotObject = board.GetSiegeSlot(0, 0);
                    section = Section.Siege;
                    break;
                default:
                    Debug.LogError("Invalid card type");
                    return;
            }

            if (slotObject == null)
            {
                Debug.LogError("Slot object is null");
                return;
            }

            // Place the selected card in the appropriate row for player 0 at slot 0
            board.PlaceCard(selectedCard, 0, 0, section, slotObject);
        }
    }
}
