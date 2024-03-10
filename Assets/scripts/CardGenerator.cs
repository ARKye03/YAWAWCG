using UnityEngine;

namespace CardGenerator
{

    [System.Serializable]
    public class CardData
    {
        public string name;
        public int strength;
        public string image;
        public string combatRow;
        public string ability;
        public string typeOfUnit;
    }

    public class Card
    {
        public string name;
        public int strength;
        public Sprite image;
        public string combatRow;
        public string ability;
        public string typeOfUnit;

        public Card(CardData data)
        {
            name = data.name;
            strength = data.strength;
            image = Resources.Load<Sprite>(data.image);
            combatRow = data.combatRow;
            ability = data.ability;
            typeOfUnit = data.typeOfUnit;
        }
    }
}