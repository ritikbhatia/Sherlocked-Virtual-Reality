using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class button4 : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Tobj;

    void Start()
    {
        Tobj = GameObject.Find("Poem");
        Tobj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void interact(){
        Tobj.SetActive(true);

        P1.problem=3;
    }
}
