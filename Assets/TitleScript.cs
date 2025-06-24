using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    bool toStage = false;
    [SerializeField] float fadeDuration = 1f;
    [SerializeField] float displayImageDuration=1f;
    [SerializeField] CanvasGroup canvasGroup;
    float m_Timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toStage)
        {
            FadeOut();
        }
    }
    void FadeOut()
    {
        m_Timer += Time.deltaTime;
        canvasGroup.alpha = m_Timer / fadeDuration;
        if (m_Timer > fadeDuration + displayImageDuration)
        {
            SceneManager.LoadScene("Stage");
        }
    }
}
