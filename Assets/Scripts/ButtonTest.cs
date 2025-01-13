using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    public Button nextButton;
    public Button prevButton;
    
    void Start()
    {
        nextButton.onClick.AddListener(NextButton);
        prevButton.onClick.AddListener(PrevButton);
    }
    public void NextButton()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    public void PrevButton()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }
}
