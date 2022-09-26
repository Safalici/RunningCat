
using UnityEngine.SceneManagement;
using UnityEngine;


public class EndLevelscene : MonoBehaviour
{
    
    public void onClickNextStage()
    {
        SceneManager.LoadScene("AfterGameEnds");
        
    }

}
