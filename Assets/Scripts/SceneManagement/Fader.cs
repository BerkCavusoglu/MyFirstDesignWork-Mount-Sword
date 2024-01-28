using System.Collections;
using UnityEngine;

public class Fader : MonoBehaviour
{
    private CanvasGroup canvasGroup;

    void Start()
    {
        InitializeCanvasGroup();
    }

    private void InitializeCanvasGroup()
    {
        // CanvasGroup ��esini al�rken null kontrol� ekleyin
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            Debug.LogError("CanvasGroup not found on Fader!");
        }
    }

    public IEnumerator FadeOutIn(float fadeOutTime, float fadeInTime)
    {
        // Null kontrol� ekleyin
        if (canvasGroup == null)
        {
            Debug.LogError("CanvasGroup is null!");
            yield break; // Hata durumunda fonksiyonu burada sonland�r.
        }

        yield return StartCoroutine(FadeOut(fadeOutTime));
        yield return StartCoroutine(FadeIn(fadeInTime));
    }

    public IEnumerator FadeOut(float time)
    {
        // CanvasGroup null kontrol� ekleyin
        if (canvasGroup == null)
        {
            Debug.LogError("CanvasGroup is null!");
            yield break; // Hata durumunda fonksiyonu burada sonland�r.
        }

        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime / time;
            yield return null;
        }
    }

    public IEnumerator FadeIn(float time)
    {
        // CanvasGroup null kontrol� ekleyin
        if (canvasGroup == null)
        {
            Debug.LogError("CanvasGroup is null!");
            yield break; // Hata durumunda fonksiyonu burada sonland�r.
        }

        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / time;
            yield return null;
        }
    }
}
