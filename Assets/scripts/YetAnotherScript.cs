using System.Collections.Generic;
using CardGenerator;
using UnityEngine;

public class YetAnotherScript : MonoBehaviour
{
    private Board board;
    private List<Card> cards;

    // Start is called before the first frame update
    private void Start()
    {
        board = new Board();
        cards = LoadCards("../Cards/Cards.json");
    }

    private List<Card> LoadCards(string path)
    {
        string json = System.IO.File.ReadAllText(path);
        List<CardData> data = JsonUtility.FromJson<List<CardData>>(json);
        List<Card> cards = new();

        foreach (CardData cardData in data)
        {
            cards.Add(new Card(cardData));
        }

        return cards;
    }

    // Update is called once per frame
    private void Update()
    {
        // Handle user input to select a card and place it on the board
        // This is just a placeholder, you'll need to implement this according to your game's requirements
        if (Input.GetMouseButtonDown(0))
        {
            // Place the first card in the melee row for player 0 at slot 0
            board.PlaceCard(cards[0], 0, 0, Section.Melee);
        }
    }
}
