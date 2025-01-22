using UnityEngine;

namespace Lesson_2
{

    public class PlayerInputService : IInputService
    {
        public Vector3 GetMovementInput()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            return new Vector3(moveHorizontal, 0, moveVertical);
        }
    }
}
