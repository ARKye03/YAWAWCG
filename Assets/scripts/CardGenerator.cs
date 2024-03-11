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
        public string Name { get; private set; }
        public int Strength { get; private set; }
        public Sprite Image { get; private set; }
        public string CombatRow { get; private set; }
        public string Ability { get; private set; }
        public string TypeOfUnit { get; private set; }

        public Card(CardData data)
        {
            Name = data.name;
            Strength = data.strength;
            Image = Resources.Load<Sprite>(data.image);
            CombatRow = data.combatRow;
            Ability = data.ability;
            TypeOfUnit = data.typeOfUnit;
        }
    }
}