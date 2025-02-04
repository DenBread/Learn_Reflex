using Reflex.Attributes;
using UnityEngine;

namespace Lesson_1
{
    public class GameController : MonoBehaviour
    {
        [Inject] private Player _player;
    
        private void Start()
        {
            if (_player != null)
            {
                _player.Attack();
            }
            else
            {
                Debug.LogError("Player dependency was not resolved!");
            }
        }
    }
}


