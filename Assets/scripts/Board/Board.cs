using System.Collections.Generic;
using UnityEngine;
using Cards;
public class Board : MonoBehaviour
{
    public List<Row> rows = new();

    public void AddCard(Card card, int rowIndex)
    {
        rows[rowIndex].AddCard(card);
    }
}