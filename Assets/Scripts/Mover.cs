using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveDistance = 5f;
    [SerializeField] private float _duration = 2f;
    [SerializeField] private int _loops = -1;

    private void Start()
    {
        transform.DOMoveZ(transform.position.z + _moveDistance, _duration)
                 .SetEase(Ease.InOutSine)
                 .SetLoops(_loops, LoopType.Yoyo);
    }
}
