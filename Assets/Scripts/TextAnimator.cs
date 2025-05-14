using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimator : MonoBehaviour
{
    [SerializeField] private Text _textComponent;
    [SerializeField] private float _duration = 2f;

    private void Start()
    {
        _textComponent.DOText("Новый текст", _duration);
    }
}
