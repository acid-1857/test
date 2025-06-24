using UnityEngine;

public class FadeInScript : MonoBehaviour
{
    bool endFadeIn = false;
    [SerializeField] float fadeDuration = 1f;
    CanvasGroup canvasGroup;
    float m_Timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!endFadeIn)
        {
            FadeIn();
        }
    }
    void FadeIn()
    {
        m_Timer += Time.deltaTime;
        canvasGroup.alpha = 1 - (m_Timer / fadeDuration);
        if (m_Timer > fadeDuration)
        {
            endFadeIn = true;
        }
    }
}
