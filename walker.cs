using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walker : MonoBehaviour
{
    public float speed = 3.5f;
    private float gravity = 10f;
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1" ))
        {
        Vector3 direction = new Vector3(0,0,1);
        Vector3 velocity = direction*speed;
        velocity = Camera.main.transform.TransformDirection(velocity);
        velocity.y-=gravity;
        controller.Move(velocity*Time.deltaTime);
        }
    }

}
