using UnityEngine;

namespace Cards
{
    [System.Serializable]
    public class CardData
    {
        public string name;
        public int strength;
        public string combatRow;
        public string ability;
        public string typeOfUnit;
    }

    public class Card : MonoBehaviour
    {
        public GameObject model;
        public string Name { get; private set; }
        public int Strength { get; private set; }
        public string CombatRow { get; private set; }
        public string Ability { get; private set; }
        public string TypeOfUnit { get; private set; }

        public Card(CardData data)
        {
            Name = data.name;
            Strength = data.strength;
            CombatRow = data.combatRow;
            Ability = data.ability;
            TypeOfUnit = data.typeOfUnit;
        }
        public void SetData(CardData data)
        {
            Name = data.name;
            Strength = data.strength;
            CombatRow = data.combatRow;
            Ability = data.ability;
            TypeOfUnit = data.typeOfUnit;
        }
    }
}