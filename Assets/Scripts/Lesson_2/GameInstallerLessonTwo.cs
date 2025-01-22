using Lesson_2;
using Reflex.Core;
using UnityEngine;

public class GameInstallerLessonTwo : MonoBehaviour, IInstaller
{
    [Header("Player")]
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _plauerMoveSpeed = 5f;

    [Header("Enemies")]
    [SerializeField] private Transform[] _enemyTransforms; // Все враги на сцене
    [SerializeField] private Transform _targetTransform; // Цель для всех врагов
    [SerializeField] private float _enemySpeed = 3f;

    public void InstallBindings(ContainerBuilder builder)
    {
        builder.AddSingleton<IInputService>(container => new PlayerInputService());
        
        builder.AddSingleton<IMovementService>(concrete => 
            new PlayerMovementService(_playerTransform, _plauerMoveSpeed));
        
        //builder.AddSingleton<EnemyMovementService>(container => new EnemyMovementService(_enemyTransform, _targetTransform, _enemySpeed));
        builder.AddSingleton<EnemyManager>(container =>
        {
            var enemyManager = new EnemyManager();
            foreach (var enemyTransform in _enemyTransforms)
            {
                enemyManager.RegisterEnemy(enemyTransform, _targetTransform, _enemySpeed);
            }
            return enemyManager;
        });
    }
}
