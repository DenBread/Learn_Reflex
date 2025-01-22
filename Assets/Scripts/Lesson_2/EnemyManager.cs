using System.Collections.Generic;
using UnityEngine;

public class EnemyManager
{
    private readonly List<EnemyMovementService> _enemies = new();

    public void RegisterEnemy(Transform enemyTransform, Transform targetTransform, float speed)
    {
        var enemyService = new EnemyMovementService(enemyTransform, targetTransform, speed);
        _enemies.Add(enemyService);
    }

    public void MoveAllEnemies()
    {
        foreach (var enemy in _enemies)
        {
            enemy.Move();
        }
    }
}
