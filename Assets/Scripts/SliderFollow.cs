using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderFollow : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = Camera.main.WorldToScreenPoint(player.transform.position);
        Vector3 offset= new Vector3(30, 0, 0);
        GetComponent<RectTransform>().position = pos - offset;
            }
}
