using DG.Tweening;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _rotationDuration = 2f;
    [SerializeField] private Vector3 _rotationAxis = new Vector3(0, 360,360);
    [SerializeField] private int _loops = -1;

    private void Start()
    {
        transform.DORotate(_rotationAxis, _rotationDuration, RotateMode.LocalAxisAdd)
            .SetLoops(_loops, LoopType.Restart)
            .SetEase(Ease.Linear);
    }
}