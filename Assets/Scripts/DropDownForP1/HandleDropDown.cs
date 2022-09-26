using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using System.Linq;

//Handle Names
public class HandleDropDown : MonoBehaviour
{
    public TextAsset textAssetData;
    
    
    public Dropdown schoolDropdawn;
    public Dropdown classDropdawn;

   // private static string dataCSVPath = "/ExData.csv";

    
    public SortedSet<string> splitDataSchoolNames = new SortedSet<string>();
    public SortedSet<string> splitDataClassNames = new SortedSet<string>();
   

    void Start()
    {
        GetData();

        //SchoolName
        foreach (string data in splitDataSchoolNames)
        {
            schoolDropdawn.options.Add(new Dropdown.OptionData() { text = data });
        }

        //Class Name
        foreach(string data in splitDataClassNames)
        {
            classDropdawn.options.Add(new Dropdown.OptionData() { text = data });
        }
        //School Name
        DropDownDataSelectedSchool(schoolDropdawn);
        schoolDropdawn.onValueChanged.AddListener(delegate { DropDownDataSelectedSchool(schoolDropdawn); });


      
        
        //Class Name
        DropDownDataSelectedClass(classDropdawn);
        classDropdawn.onValueChanged.AddListener(delegate { DropDownDataSelectedClass(classDropdawn); });
    }
    
    void DropDownDataSelectedSchool(Dropdown schoolDropdawn)
    {
        
        int index = schoolDropdawn.value;

        PlayerPrefs.SetString("player1SchoolName", schoolDropdawn.options[index].text);
        Debug.Log("Player 1 School name : " + PlayerPrefs.GetString("player1SchoolName"));
    }
    void DropDownDataSelectedClass(Dropdown classDropdawn)
    {
        int index = classDropdawn.value;

        PlayerPrefs.SetString("player1ClassName", classDropdawn.options[index].text);
        Debug.Log("Player 1 Class name : " + PlayerPrefs.GetString("player1ClassName"));
    }
    public void GetData()
    {
        string[] allLines = textAssetData.text.Split(new string[] { ";","\n"},StringSplitOptions.None);//File.ReadAllLines(Application.persistentDataPath + Path.AltDirectorySeparatorChar + dataCSVPath);

        //Debug.Log(Application.dataPath);
       
        foreach (string s in allLines)
        {


            for (int i = 0; i < allLines.Length; i++)
            {
                //allLines = s.Split(';');

                    if (i % 2 == 0)
                    {
                       
                        splitDataSchoolNames.Add(allLines[i]);    
                    }
                    
                    else if (i % 2 == 1)
                    {

                        splitDataClassNames.Add(allLines[i]);
                    }
            }
        }
    }
    

}
