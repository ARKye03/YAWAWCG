using CardGenerator;
using UnityEngine;

public enum Section
{
    Melee,
    Ranged,
    Siege,
    Buff,
    Leader,
    Cemetery,
    Deck
}

public class Board
{
    private readonly Card[,] meleeSlots;
    private readonly Card[,] rangedSlots;
    private readonly Card[,] siegeSlots;
    private readonly Card[] buffSpots;
    private readonly Card[] leaderSpots;
    private readonly Card[] cemeteries;
    private readonly Card[] deckSpots;

    public Board()
    {
        meleeSlots = new Card[2, 5];
        rangedSlots = new Card[2, 5];
        siegeSlots = new Card[2, 5];
        buffSpots = new Card[2];
        leaderSpots = new Card[2];
        cemeteries = new Card[2];
        deckSpots = new Card[2];
    }

    public void PlaceCard(Card card, int player, int slot, Section section)
    {
        switch (section)
        {
            case Section.Melee:
                PlaceInSlots(meleeSlots, card, player, slot);
                break;
            case Section.Ranged:
                PlaceInSlots(rangedSlots, card, player, slot);
                break;
            case Section.Siege:
                PlaceInSlots(siegeSlots, card, player, slot);
                break;
            case Section.Buff:
                PlaceInSpot(buffSpots, card, player);
                break;
            case Section.Leader:
                PlaceInSpot(leaderSpots, card, player);
                break;
            case Section.Cemetery:
                PlaceInSpot(cemeteries, card, player);
                break;
            case Section.Deck:
                PlaceInSpot(deckSpots, card, player);
                break;
        }
    }

    private void PlaceInSlots(Card[,] slots, Card card, int player, int slot)
    {
        if (slots[player, slot] == null)
        {
            slots[player, slot] = card;
        }
        else
        {
            Debug.Log("Slot is already occupied");
        }
    }

    private void PlaceInSpot(Card[] spots, Card card, int player)
    {
        if (spots[player] == null)
        {
            spots[player] = card;
        }
        else
        {
            Debug.Log("Spot is already occupied");
        }
    }
}
