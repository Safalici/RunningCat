using UnityEngine;
using UnityEngine.UI;
public class P1DataRead : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    private void Start()
    {
        PlayerPrefs.SetString("player1Name",theName);
    }
 
    public void StoreName()
    {

        theName = inputField.GetComponent<Text>().text;
        PlayerPrefs.SetString("player1Name", theName);
        textDisplay.GetComponent<Text>().text = theName;
        Debug.Log(PlayerPrefs.GetString("player1Name"));

    }

}
