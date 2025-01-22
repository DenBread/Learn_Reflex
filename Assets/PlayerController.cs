using System;
using Reflex.Attributes;
using UnityEngine;

namespace Lesson_2
{
    public class PlayerController : MonoBehaviour
    {
        [Inject] private PlayerInputService _inputService;
        [Inject] private PlayerMovementService _movementService;

        private void Update()
        {
            Vector3 input = _inputService.GetMovementInput();
            _movementService.Move(input);
        }
    }
}
