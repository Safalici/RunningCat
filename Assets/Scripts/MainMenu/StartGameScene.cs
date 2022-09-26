using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGameScene : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene("TakeName");
    }

}
