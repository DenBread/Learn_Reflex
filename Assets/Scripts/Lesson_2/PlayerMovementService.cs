using UnityEngine;

namespace Lesson_2
{
    public class PlayerMovementService: IMovementService
    {
        private readonly Transform _playerTransform;
        private readonly float _moveSpeed;

        public PlayerMovementService(Transform playerTransform, float moveSpeed)
        {
            _playerTransform = playerTransform;
            _moveSpeed = moveSpeed;
        }

        public void Move(Vector3 direction)
        {
            _playerTransform.Translate(direction * _moveSpeed * Time.deltaTime, Space.World);

            if (direction != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);
                _playerTransform.rotation = Quaternion.RotateTowards(_playerTransform.rotation, toRotation, _moveSpeed *10* Time.deltaTime);
            }
        }
    }
}