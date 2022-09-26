
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DataEndGame : MonoBehaviour
{
    //Player1
    private Player1Data FirstPlayerData;

    private string player1TimeAmount;
    private string path = "";
    private string persistentPath = "";
    private float PlayerData;
    private string Player1Name;
    private string player1SchoolName;
    private string player1ClassName;
    private static string separator = ";";

    private string starStringP1;
    private string starIntP1;

    private timeController timerLeft;
    private float timerLeftFloat;

    //Player2
    private Player2Data SecondPlayerData;

    private string player2TimeAmount;
    private string Player2Name;
    private string Player2SchoolName;
    private string Player2ClassName;

    private string csv= "/SaveData.csv";

    // Start is called before the first frame update
    void Start()
    {
        
        PrefsData();
        SetPaths();
        // timerLeft = GetComponent<timeController>();
        //timerLeftFloat = timerLeft.TimeLeft;
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetPaths()
    {
        path = Application.dataPath + Path.AltDirectorySeparatorChar + "/SaveData1.csv";//Used to test in Unity
        persistentPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + csv;//ACtually location the data will be saved after publishing
        PlayerPrefs.SetString("path", persistentPath);
    }
    private void PrefsData()
    {
        Player1Name = PlayerPrefs.GetString("player1Name");
        player1SchoolName = PlayerPrefs.GetString("player1SchoolName");
        player1ClassName = PlayerPrefs.GetString("player1ClassName");
        player1TimeAmount = PlayerPrefs.GetString("player1Time");
        starStringP1 = PlayerPrefs.GetString("player1StarString");
        starIntP1 = PlayerPrefs.GetString("player1StarInteger");

        Player2Name = PlayerPrefs.GetString("player2Name");
        
        player2TimeAmount = PlayerPrefs.GetString("player2Time");
       


    }
    public void clickSaveButton()//When time ends this function is called
    {

        PrefsData();
        SetPaths();


        CreatePlayer1Data();
        CreatePlayer2Data();
        SaveDataExcel();


        

    }
    private void CreatePlayer1Data()
    {

        FirstPlayerData = new Player1Data(Player1Name, player1TimeAmount, player1SchoolName, player1ClassName, starStringP1, starIntP1);
       
    }
    private void CreatePlayer2Data()
    {
        SecondPlayerData = new Player2Data(Player2Name, player2TimeAmount, Player2SchoolName, Player2ClassName);
    }
    /* public void SaveData()
     {
         string savePath = persistentPath;

         Debug.Log("Saving data at " + savePath);

         string json = JsonUtility.ToJson(FirstPlayerData);
         Debug.Log(json);

         using StreamWriter writer = new StreamWriter(savePath);
         writer.Write(json);

     }
    */
    public void SaveDataExcel()
    {
        string savePath = path;
        Debug.Log("Saving data at " + savePath);
        TextWriter tw = new StreamWriter(savePath, true);
        //tw.WriteLine("sep=.");
        //tw.WriteLine("Player 1 Time; Player 1 School; Player 1 Class; Player 1 Name; Player2 Name; Player2 School name; Player 2 Class Name; Player 2 Time omunt");//Headings

        //tw.Close();

        //tw = new StreamWriter(savePath, true);                                                                                                                                                                                                
        tw.WriteLine(player1SchoolName + separator+Player1Name+separator+ player2TimeAmount + separator/*+player1ClassName+separator*/+ Player1Name+" "+ PlayerPrefs.GetInt("Player2PressedPlayAmount") + " kez tusa basti." +
            separator+Player2Name+ separator+ player1TimeAmount + separator + Player2Name+" " + PlayerPrefs.GetInt("Player1PressedPlayAmountInt") + " kez tusa basti." + separator+GetTimeStamp()+ separator + player1ClassName);
        tw.Close();
    }

    static string GetTimeStamp()
    {
        return System.DateTime.Now.ToString();
    }
}
