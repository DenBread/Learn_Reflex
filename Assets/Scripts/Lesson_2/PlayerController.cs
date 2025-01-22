using System;
using Reflex.Attributes;
using UnityEngine;

namespace Lesson_2
{
    [DisallowMultipleComponent]
    public class PlayerController : MonoBehaviour
    {
        [Inject] private IInputService _inputService;
        [Inject] private IMovementService _movementService;
        
        
        private void Update()
        {
            Vector3 input = _inputService.GetMovementInput();
            _movementService.Move(input);
        }
    }
}
