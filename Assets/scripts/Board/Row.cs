using System.Collections.Generic;
using UnityEngine;
using Cards;

public class Row : MonoBehaviour
{
    public List<Slot> slots = new List<Slot>();

    public void AddCard(Card card)
    {
        // Find the first empty slot
        foreach (Slot slot in slots)
        {
            Debug.Log("Slot: " + slot);
            Debug.Log("Slot card: " + slot.card);
            if (slot.card == null)
            {
                slot.SetCard(card);
                break;
            }
        }
    }
}