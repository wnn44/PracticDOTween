using DG.Tweening;
using UnityEngine;

public class RandomJump : MonoBehaviour
{
    [SerializeField] private float _jumpRadius = 5f;
    [SerializeField] private float _jumpDuration = 1f;
    [SerializeField] private float _jumpPower = 1f;
    [SerializeField] private int _numJumps = 1;
    [SerializeField] private float _rotationDuration = 2f;
    [SerializeField] private int _loops = -1;
    [SerializeField] private Vector3 _rotationAxis = new Vector3(0, 360, 360);

    private void Start()
    {
        transform.DORotate(_rotationAxis, _rotationDuration, RotateMode.LocalAxisAdd)
            .SetLoops(_loops, LoopType.Restart)
            .SetEase(Ease.Linear);

        JumpToRandomPoint();
    }

    private void JumpToRandomPoint()
    {
        Vector3 randomPos = transform.position + Random.insideUnitSphere * _jumpRadius;
        randomPos.y = transform.position.y;

        transform.DOJump(randomPos, _jumpPower, _numJumps, _jumpDuration).OnComplete(JumpToRandomPoint);
    }
}
