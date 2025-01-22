using Lesson_2;
using Reflex.Core;
using UnityEngine;

public class GameInstallerLessonTwo : MonoBehaviour, IInstaller
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _plauerMoveSpeed = 5f;

    public void InstallBindings(ContainerBuilder builder)
    {
        builder.AddSingleton<IInputService>(container => new PlayerInputService());
        builder.AddSingleton<IMovementService>(concrete => new PlayerMovementService(_playerTransform, _plauerMoveSpeed));
    }
}
