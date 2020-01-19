using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerSwitch : MonoBehaviour
{
    public bool state = true;
    GameObject obj;
    // Start is called before the first frame update

    void Start()
    {
        obj = GameObject.Find("Directional Light");

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void flipSw(){
        obj.GetComponent<Light>().enabled = !state;
        state = !state;
    }
}
