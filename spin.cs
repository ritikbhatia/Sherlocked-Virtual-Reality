using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    // Start is called before the first frame update
    public float spinVal = 90;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*spinVal*Time.deltaTime);
    }
    public void flipSpin()
    {
        spinVal = -spinVal;
    }
}
