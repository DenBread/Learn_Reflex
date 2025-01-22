using System;
using Reflex.Attributes;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Inject] private EnemyManager _enemyManager;

    private void Update()
    {
        _enemyManager.MoveAllEnemies();
    }
}
