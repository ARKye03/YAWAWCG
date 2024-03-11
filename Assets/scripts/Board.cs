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
    private readonly GameObject[,] meleeSlots;
    private readonly GameObject[,] rangedSlots;
    private readonly GameObject[,] siegeSlots;
    private readonly GameObject[] buffSpots;
    private readonly GameObject[] leaderSpots;
    private readonly GameObject[] cemeteries;
    private readonly GameObject[] deckSpots;

    public Board()
    {
        meleeSlots = new GameObject[2, 5];
        rangedSlots = new GameObject[2, 5];
        siegeSlots = new GameObject[2, 5];
        buffSpots = new GameObject[2];
        leaderSpots = new GameObject[2];
        cemeteries = new GameObject[2];
        deckSpots = new GameObject[2];

        for (int player = 0; player < 2; player++)
        {
            for (int slot = 0; slot < 5; slot++)
            {
                meleeSlots[player, slot] = new GameObject();
                rangedSlots[player, slot] = new GameObject();
                siegeSlots[player, slot] = new GameObject();
            }

            buffSpots[player] = new GameObject();
            leaderSpots[player] = new GameObject();
            cemeteries[player] = new GameObject();
            deckSpots[player] = new GameObject();
        }
    }

    public void PlaceCard(Card card, int player, int slot, Section section, GameObject slotObject)
    {
        // Check if the Model property of the Card class is null
        if (card.Model == null)
        {
            Debug.LogError("Card model is null");
            return;
        }
        GameObject model = Object.Instantiate(card.Model, slotObject.transform.position, Quaternion.identity);
        model.transform.SetParent(slotObject.transform);

        if (!slotObject.TryGetComponent<Slot>(out var slotComponent))
        {
            Debug.LogError("Slot object does not have a Slot component");
            return;
        }

        switch (section)
        {
            case Section.Melee:
                PlaceInSlots(meleeSlots, card, player, slot, slotComponent);
                break;
            case Section.Ranged:
                PlaceInSlots(rangedSlots, card, player, slot, slotComponent);
                break;
            case Section.Siege:
                PlaceInSlots(siegeSlots, card, player, slot, slotComponent);
                break;
            case Section.Buff:
                PlaceInSpot(buffSpots, card, player, slotComponent);
                break;
            case Section.Leader:
                PlaceInSpot(leaderSpots, card, player, slotComponent);
                break;
            case Section.Cemetery:
                PlaceInSpot(cemeteries, card, player, slotComponent);
                break;
            case Section.Deck:
                PlaceInSpot(deckSpots, card, player, slotComponent);
                break;
        }
    }

    private void PlaceInSlots(GameObject[,] slots, Card card, int player, int slot, Slot slotComponent)
    {
        if (slots[player, slot] == null)
        {
            // Create a new GameObject instance and assign it to the slot
            GameObject newSlot = new()
            {
                name = "Slot " + slot
            };
            slots[player, slot] = newSlot;

            // Add the card to the GameObject slot
            slotComponent.PlaceCard(card);
        }
        else
        {
            Debug.Log("Slot is already occupied");
        }
    }

    private void PlaceInSpot(GameObject[] spots, Card card, int player, Slot slotComponent)
    {
        if (spots[player] == null)
        {
            // Create a new GameObject instance and assign it to the spot
            GameObject newSpot = new()
            {
                name = "Spot " + player
            };
            spots[player] = newSpot;

            // Add the card to the GameObject spot
            slotComponent.PlaceCard(card);
        }
        else
        {
            Debug.Log("Spot is already occupied");
        }
    }
    public GameObject GetMeleeSlot(int player, int slot)
    {
        if (player < 0 || player >= 2 || slot < 0 || slot >= 5)
        {
            Debug.LogError("Invalid player or slot index");
            return null;
        }

        return meleeSlots[player, slot];
    }
    public GameObject GetRangedSlot(int player, int slot)
    {
        if (player < 0 || player >= 2 || slot < 0 || slot >= 5)
        {
            Debug.LogError("Invalid player or slot index");
            return null;
        }

        return rangedSlots[player, slot];
    }

    public GameObject GetSiegeSlot(int player, int slot)
    {
        if (player < 0 || player >= 2 || slot < 0 || slot >= 5)
        {
            Debug.LogError("Invalid player or slot index");
            return null;
        }

        return siegeSlots[player, slot];
    }
}
