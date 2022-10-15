using UnityEngine;
using UnityEngine.UI;
public class pauseButton : MonoBehaviour
{
    [SerializeField] private GameObject pausebutton;
    [SerializeField] private GameObject resumebutton;
    public void _pauseButton()
    {
        Time.timeScale = 0f;
        pausebutton.SetActive(false);
        resumebutton.SetActive(true);
    }
    public void _resumeButton()
    {
        Time.timeScale = 1.0f;
        pausebutton.SetActive(true);
        resumebutton.SetActive(false);
    }
}