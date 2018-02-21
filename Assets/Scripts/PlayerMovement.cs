using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

   
    private float moveSpeed = 5f;
    // Use this for initialization
    //void Start () {	
    //}

    // Update is called once per frame
    void Update () {
        //Input.GetKeyDown is on the down press ..up arrow
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 180);
        }
        //left arrow
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0,0,-90);
        }
        //right arrow
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
         {
           transform.eulerAngles = new Vector3(0, 0, 90);
         }
        // down arrow
            if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 360);
        }
        
    }
    // add in scirpt for diagonal movement if both say left and up are pressed at the same time 
}
