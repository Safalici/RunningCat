using UnityEngine.UI;
using UnityEngine;

public class CloseDemo : MonoBehaviour
{
    public Text thanksText;
    // Start is called before the first frame update
    void Start()
    {
        thanksText.text = "Oynad���n�z i�in te�ekk�rler " + PlayerPrefs.GetString("player1Name") + " ve " + PlayerPrefs.GetString("player2Name");
    }

    

   
}
