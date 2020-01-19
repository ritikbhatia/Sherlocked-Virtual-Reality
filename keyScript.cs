using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class keyScript : MonoBehaviour
{
    GameObject obj;
    GameObject obj1;
    GameObject Tobj;

    bool flag= true;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("Key Cube");
        obj1 = GameObject.Find("key_gold");
        Tobj = GameObject.Find("Key text");
        Tobj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool getState(){
        return flag;
    }

    public void interact(){
        flag = false;
        obj.SetActive(false);
        obj1.SetActive(false);
        Tobj.SetActive(true);
        Tobj.GetComponent<TextMeshPro>().text = "Key picked up.";
    }
}

