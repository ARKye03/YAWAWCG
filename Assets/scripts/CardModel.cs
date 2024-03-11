using UnityEngine;

public class CardModel : MonoBehaviour
{
    public Material cardMaterial;

    public void SetImage(Texture2D image)
    {
        cardMaterial.mainTexture = image;
    }
}