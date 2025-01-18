using UnityEngine;

namespace Lesson_1
{
    public class Player
    {
        private readonly Weapon _weapon;

        public Player(Weapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            Debug.Log($"Player attacks with {_weapon.Name}!");
        }
    }
}