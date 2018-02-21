using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    private float moveSpeed = 5f;
    // Use this for initialization
    //void Start () {	
    //}

    // Update is called once per frame
    void Update()
    {
        //Input.GetKeyDown is on the down press 
        //up arrow
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
            transform.eulerAngles = new Vector3(0, 0, -90);
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
        //diagonal top left
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 225);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyUp(KeyCode.UpArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, -90);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 180);
        }
        //diagonal top right
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 135);
        }
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKeyUp(KeyCode.UpArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 180);
        }
        //diagonal bottom right
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 45);
        }
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        //diagonal bottom left
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, -45);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, -90);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

    }
}
    
    // add in scirpt for diagonal movement if both say left and up are pressed at the same time 

