using DG.Tweening;
using UnityEngine;

public class MoveRotateScale : MonoBehaviour
{
    [SerializeField] private float _moveDuration = 2f;
    [SerializeField] private float _rotateDuration = 3f;
    [SerializeField] private float _scaleDuration = 1.5f;
    [SerializeField] private int _loops = -1;

    [SerializeField] private Vector3 _moveOffset;
    [SerializeField] private Vector3 _rotateAmount;
    [SerializeField] private Vector3 _scaleTo;

    private void Start()
    {
        Vector3 startPosition = transform.position;
        Vector3 startScale = transform.localScale;

        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMove(startPosition + _moveOffset, _moveDuration).SetEase(Ease.InOutQuad))
                .Join(transform.DORotate(_rotateAmount, _rotateDuration, RotateMode.LocalAxisAdd).SetEase(Ease.InOutQuad))
                .Join(transform.DOScale(_scaleTo, _scaleDuration).SetEase(Ease.InOutQuad));

        sequence.Append(transform.DOMove(startPosition, _moveDuration).SetEase(Ease.InOutQuad))
                .Join(transform.DORotate(-_rotateAmount, _rotateDuration, RotateMode.LocalAxisAdd).SetEase(Ease.InOutQuad))
                .Join(transform.DOScale(startScale, _scaleDuration).SetEase(Ease.InOutQuad));

        sequence.SetLoops(_loops, LoopType.Restart);
    }
}
