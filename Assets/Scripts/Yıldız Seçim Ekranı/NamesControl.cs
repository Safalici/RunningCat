using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamesControl : MonoBehaviour
{
    private bool Name1Entred;
    private bool Name2Entred;
    public GameObject okbtn;

    // Start is called before the first frame update
    void Start()
    {
        Name1Entred = false;
        Name2Entred = false;
        okbtn.SetActive(false);
    }
    public void Name1Entreded()
    {
        Name1Entred = true;
    }
    public void Name2Entreded()
    {
        Name2Entred = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Name1Entred && Name2Entred)
        {
            okbtn.SetActive(true);
        }
    }
}
