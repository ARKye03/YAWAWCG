using CardGenerator;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public GameObject cardPrefab;

    public void PlaceCard(Card card)
    {
        GameObject cardObject = Instantiate(cardPrefab, transform.position, Quaternion.identity);
        Renderer renderer = cardObject.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.mainTexture = card.Image.texture;
        }
    }
}