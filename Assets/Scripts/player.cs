using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;

//using System.Numerics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerAction : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider mainSlider;
    public CharacterController controller;
    public GameObject bullet;
    public Rigidbody myRB;
    private Vector3 direction;
    public TextMeshProUGUI ammo;
    private int bulletshot = 0;
    private float movespeed = 100f;
    private float bulletspeed = 10f;
    private float rotatespeed = 10f;

    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        ammo.text = "";
    }
    // Update is called once per frame
    void Update()
    { 
        transform.Rotate(0, Input.GetAxis("Horizontal")*rotatespeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float currentspeed = movespeed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward*currentspeed);
        if(Input.GetButtonDown("Jump")){
          shoot();
        }
        Slidervalue();
        updateText();
        mainSlider.value -= 0.0005f;
    }

    void FixedUpdate(){
        if (direction != Vector3.zero){
            myRB.AddForce(direction * movespeed);
        }
    }

    void shoot(){
        if(mainSlider.value < 0.5){
        Vector3 bullposition = transform.position + new Vector3(0,2,0);
        GameObject newone =  Instantiate(bullet, bullposition, transform.rotation);
        Rigidbody newrb = newone.GetComponent<Rigidbody>();
        newrb.AddForce(transform.forward * bulletspeed, ForceMode.Impulse); 
        Destroy(newone, 5.0f);  
        //if(mainSlider.value < 0.5){
           // mainSlider.value = 0;
       // }
        //else{
             bulletshot++;
            mainSlider.value += 0.2f;
        }
        updateText();
    }

    void Slidervalue(){
        Debug.Log(mainSlider.value);
    }

    void updateText(){
        ammo.text = bulletshot.ToString();
    }
}
