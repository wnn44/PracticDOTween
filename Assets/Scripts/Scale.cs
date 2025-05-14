using DG.Tweening;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _scaleSize = 5.5f;
    [SerializeField] private float _duration = 1f;
    [SerializeField] private int _loops = -1;

    private void Start()
    {
        transform.DOScale(_scaleSize, _duration)
                 .SetLoops(_loops, LoopType.Yoyo)
                 .SetEase(Ease.InOutSine);
    }
}
