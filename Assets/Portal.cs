using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    //public Scene sceneName;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            SceneManager.LoadScene("SceneTwo", LoadSceneMode.Single);
        }
    }
}
//sceneName.ToString()
