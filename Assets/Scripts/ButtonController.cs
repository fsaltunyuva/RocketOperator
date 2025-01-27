using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

    private void Start()
    {
        Time.timeScale = 0;
        
        if(Singleton.Instance.isTutorialShown)
        {
            canvas.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            canvas.SetActive(true);
        }
    }

    public void Continue()
    {
        canvas.SetActive(false);
        Time.timeScale = 1;
        Singleton.Instance.isTutorialShown = true;
    }
    
}
