using System.IO;
using UnityEngine;
using UnityEngine.UI;


public class DataEndGameP2 : MonoBehaviour
{
    private Player2Data SecondPlayerData;
    
    private string player2TimeAmount;
    private string path = "";
    private string persistentPath = "";
    private float PlayerData;
    private string Player2Name;
    private string Player2SchoolName;
    private string Player2ClassName;
    private static string separator = ";";

    private string Player2StarString;
    private string Player2StarInt;

    [SerializeField] private Text p2DataText;
    // Start is called before the first frame update
    void Start()
    {
        PrefsData();
        SetPaths();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetPaths()
    {
        path = Application.dataPath + Path.AltDirectorySeparatorChar + "/SaveData2.csv";//Used to test in Unity
        persistentPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "SaveData.csv";//ACtually location the data will be saved after publishing
    }
    private void PrefsData()
    {
        Player2Name = PlayerPrefs.GetString("player2Name");
        Player2SchoolName = PlayerPrefs.GetString("player2SchoolName");
        Player2ClassName = PlayerPrefs.GetString("player2ClassName");
        player2TimeAmount = PlayerPrefs.GetString("player2Time");
        Player2StarString = PlayerPrefs.GetString("player2StarString");
        Player2StarInt = PlayerPrefs.GetString("player2StarInteger");

    }
    public void clickSaveButton()
    {
        // SaveData();
        CreatePlayer2Data();
        SaveDataExcel();
    }
    private void CreatePlayer2Data()
    {
        SecondPlayerData = new Player2Data(Player2Name, player2TimeAmount,Player2SchoolName, Player2ClassName);
    }
    public void SaveDataExcel()
    {
        
        string savePath = persistentPath;
        Debug.Log("Saving data at " + savePath);
        
        
        
        TextWriter tw = new StreamWriter(savePath, true);
        //tw.WriteLine("sep=.");
        //tw.WriteLine("Name; School; Class; Time");//Headings

        //tw.Close();

        //tw = new StreamWriter(savePath, true);
        tw.WriteLine(Player2Name + separator + Player2SchoolName + separator + player2TimeAmount + separator + Player2ClassName+ separator +Player2StarString+ separator+ Player2StarInt );
        tw.Close();
    }
    public void onclick()
    {
        p2DataText.text = "Saving data at " + persistentPath;

    }

}

