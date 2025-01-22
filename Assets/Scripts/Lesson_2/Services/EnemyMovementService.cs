using UnityEngine;

public class EnemyMovementService
{
    private readonly Transform _enemyTransform;
    private readonly Transform _target;
    private readonly float _speedMove;

    public EnemyMovementService(Transform enemyTransform, Transform target, float speedMove)
    {
        _enemyTransform = enemyTransform;
        _target = target;
        _speedMove = speedMove;
    }

    public void Move()
    {
        if(_target == null || _enemyTransform == null) return;

        // Движение врага к цели
        _enemyTransform.position = Vector3.MoveTowards(
        _enemyTransform.position,
         _target.position,
        _speedMove * Time.deltaTime
        );
        
        // Вращение к цели
        Vector3 direction = (_target.position - _enemyTransform.position).normalized;
        if (direction != Vector3.zero)
        {
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            _enemyTransform.rotation = Quaternion.Slerp(_enemyTransform.rotation, lookRotation, Time.deltaTime * 5f);
        }
    }
}
