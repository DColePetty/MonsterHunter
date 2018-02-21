using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Combat : MonoBehaviour {
    public float health = 100f;
    public Slider sliderV;

    private void Update()
    {
        IncrementHealth(3);
        UpdateSlider();
    }
    private void Start()
    {
        UpdateSlider();
        //sliderV.value = health;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision);
        //if (collision)
        health -= (50f * Time.deltaTime); Debug.Log(health);
        //sliderV.value = health;
        UpdateSlider();
        if (health < 0 ) Destroy(gameObject);
    }
    /*
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(collision);
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        demonHealth -= (10f * Time.deltaTime); Debug.Log(demonHealth); 
        if (demonHealth < 0) Destroy(gameObject);
    }
    */

    public void IncrementHealth(int n)
    {
        if(health < 250 && tag == "Player") health += n * Time.deltaTime;
    }
    private void UpdateSlider()
    {
        sliderV.value = health;
    }
}
