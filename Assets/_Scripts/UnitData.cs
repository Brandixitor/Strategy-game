using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LP.SG.Player.Units
{
    [CreateAssetMenu(fileName = "New Unit", menuName = "New Unit")]
    public class NewBehaviourScript : ScriptableObject
    {
        public enum unitType
        {
           Worker,
           Warrior,
           TBA1,
           TBA2
        };
        
        public bool isPlayerUnit;

        public unitType type;

        public new string name;

        public GameObject unitPrefab;

        public int cost;
        public int attack;
        public int health;
        public int armor;

    }
}

