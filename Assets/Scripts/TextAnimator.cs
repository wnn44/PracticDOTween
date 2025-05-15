using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimator : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration = 3f;
    [SerializeField] private float _interval = 2f;
    [SerializeField] private int _loops = -1;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.AppendInterval(_interval);
        sequence.Append(_text.DOText("������ ���������� ������ ������. ", _duration));

        sequence.AppendInterval(_interval);
        sequence.Append(_text.DOText("��� ���������� � ������.", _duration).SetRelative());

        sequence.AppendInterval(_interval);
        sequence.Append(_text.DOText("������ ����� ������ � ���������.", _duration, true, ScrambleMode.All));  
        
        sequence.SetLoops(_loops, LoopType.Restart);
    }
}


