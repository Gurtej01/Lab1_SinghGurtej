using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchRadius : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public float threshold;
    public float distance;

    private void Start()
    {
        threshold = 1;
    }
    void Update()
    {
        distance = Vector2.Distance(obj1.transform.position, obj2.transform.position);
             
        if (distance <= threshold)
         {
          SceneManager.LoadScene("EndScene");
         }
    }
}
