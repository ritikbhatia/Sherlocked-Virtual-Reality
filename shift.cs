using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shift : MonoBehaviour
{
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("picture Cube");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void moveBy(){
        if (P1.problem==2){
        transform.position+= new Vector3(0,0,10);
        obj.SetActive(false);
    }
    }
}
