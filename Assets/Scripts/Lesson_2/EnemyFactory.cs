using Reflex.Core;
using UnityEngine;

public class EnemyFactory 
{
    private readonly Container _container;

    public EnemyFactory(Container container)
    {
        _container = container;
    }

    public EnemyMovementService Create(Transform enemyTransform, Transform targetTransform, float speed)
    {
        return new EnemyMovementService(enemyTransform, targetTransform, speed);
    }
}
