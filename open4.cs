using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class open4 : MonoBehaviour
{
    GameObject obj;
    GameObject obj1;
    GameObject Tobj;
    bool showText1 = false;
    bool showText = false;
    bool opened = false;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("Key Cube");
        obj1 = GameObject.Find("key_gold");
        Tobj = GameObject.Find("Text Variable 4");
        Tobj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tryOpen(){
        if (opened ||(!obj.activeSelf && !USED.used)){
            showText = true;
            USED.used = true;
            opened = true;
            Tobj.SetActive(true);
            Tobj.GetComponent<TextMeshPro>().text = "Unlocked. \n You're getting old, Sherlock. Try Harder in the next problem.";
            P1.problem=2;
            //add code here to show message??
        }else{
            // if (!showText1)
            // showText1 = true;
            Tobj.SetActive(true);
            Tobj.GetComponent<TextMeshPro>().text = "Locked.";
        // If you clicked the object, set showText to true
            //add code here to show locked
        }
    }

}
