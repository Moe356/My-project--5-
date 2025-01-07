using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Character soldier = new Soldier();
            Character officer = new Officer("Captain", 90, new Position(10, 5, 0));

            Character[] characters = new Character[2];
            characters[0] = soldier;
            characters[1] = officer;

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }

            Debug.Log("Soldier's Health before attack: " + soldier.Health);
            officer.Attack(20, soldier, "shooting");
            Debug.Log("Soldier's Health after attack: " + soldier.Health);
        }
    }
}
