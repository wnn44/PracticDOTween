using DG.Tweening;
using UnityEngine;

public class RandomJump : MonoBehaviour
{
    [SerializeField] private float _jumpRadius = 5f;
    [SerializeField] private float _jumpDuration = 1f;
    [SerializeField] private float _jumpPower = 1f;
    [SerializeField] private int _numJumps = 1;

    private void Start()
    {
        JumpToRandomPoint();
    }

    private void JumpToRandomPoint()
    {
        Vector3 randomPos = transform.position + Random.insideUnitSphere * _jumpRadius;
        randomPos.y = transform.position.y;

        transform.DOJump(randomPos, _jumpPower, _numJumps, _jumpDuration).OnComplete(JumpToRandomPoint);
    }
}
