using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changeQn : MonoBehaviour
{

    GameObject qnobj;
    // Start is called before the first frame update
    void Start()
    {
        qnobj = GameObject.Find("Question");
    }

    // Update is called once per frame
    void Update()
    {
        if(P1.problem==2)
        {
            qnobj.GetComponent<TextMeshPro>().text = "The Second Problem: A picture Speaks a thousand words.";

        }
        if(P1.problem==3)
        {
            qnobj.GetComponent<TextMeshPro>().text = "WINners work hard for it.";

        }
        if(P1.problem==4)
        {
            qnobj.GetComponent<TextMeshPro>().text = "Congratulations, Holmes! You have entertained me today.";

        }
    }
}
