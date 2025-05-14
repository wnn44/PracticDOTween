using DG.Tweening;
using UnityEngine;

public class RandomColorChanger : MonoBehaviour
{
    [SerializeField] private float _colorChangeDuration = 2f;

    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();

        ChangeColor();
    }

    private void ChangeColor()
    {
        Color randomColor = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );

        _renderer.material.DOColor(randomColor, _colorChangeDuration)
            .OnComplete(() => ChangeColor());
    }
}
