using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Reflex.Attributes;

public class Fader : MonoBehaviour
{
    private CanvasGroup _canvasGroup;

    [Inject]
    private void Init(CanvasGroup canvasGroup)
    {
        _canvasGroup = canvasGroup;
        if (_canvasGroup == null)
            Debug.LogWarning("CanvasGroup не установлен в Fader!");

        _canvasGroup.alpha = 1f; // Делаем объект видимым
    }

    public void FadeIn(float duration = 0.5f)
    {
        if (_canvasGroup == null)
        {
            Debug.LogError("Fader: CanvasGroup не установлен!");
            return;
        }
        _canvasGroup.DOFade(1f, duration);
    }

    public void FadeOut(float duration = 0.5f)
    {
        if (_canvasGroup == null)
        {
            Debug.LogError("Fader: CanvasGroup не установлен!");
            return;
        }
        _canvasGroup.DOFade(0f, duration);
    }
}