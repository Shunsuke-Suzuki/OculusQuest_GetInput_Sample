using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetInputs : MonoBehaviour
{
    public GameObject cube;
    GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        // GameObject obj = Instantiate(cube);
        this.text = GameObject.Find("TestMessage");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A)) {
            //Aボタンを押した際の処理
            text.GetComponent<Text>().text = "ButtonA";
            cube.GetComponent<Renderer>().material.color = Color.red;
        }
        if (OVRInput.GetDown(OVRInput.RawButton.B)) {
            //Bボタンを押した際の処理
            text.GetComponent<Text>().text = "ButtonB";
            cube.GetComponent<Renderer>().material.color = Color.black;

        }
        if(OVRInput.GetDown(OVRInput.RawButton.X)) {
            //Xボタンを押した際の処理
            text.GetComponent<Text>().text = "ButtonX";
            cube.GetComponent<Renderer>().material.color = Color.blue;

        }
        if (OVRInput.GetDown(OVRInput.RawButton.Y)) {
            //Yボタンを押した際の処理
            text.GetComponent<Text>().text = "ButtonY";
            cube.GetComponent<Renderer>().material.color = Color.cyan;

        }
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)) {
            //右人差し指トリガーを押した際の処理
            text.GetComponent<Text>().text = "RightIndexTrigger";
            cube.GetComponent<Renderer>().material.color = Color.gray;

        }
        if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger)) {
                //右中指トリガーを押した際の処理
            text.GetComponent<Text>().text = "RightHandTrigger";
            cube.GetComponent<Renderer>().material.color = Color.green;


        }
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger)) {
            //左人差し指トリガーを押した際の処理
            text.GetComponent<Text>().text = "LeftIndexTrigger";
            cube.GetComponent<Renderer>().material.color = Color.magenta;


        }
        if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger)) {
            //左中指トリガーを押した際の処理
            text.GetComponent<Text>().text = "LeftHandTrigger";
            cube.GetComponent<Renderer>().material.color = Color.white;


        }
        if (OVRInput.Get(OVRInput.RawTouch.A))
        {
            //Aボタンをタッチした際の処理         
            text.GetComponent<Text>().text = "TouchedButtonA";
            cube.GetComponent<Renderer>().material.color = Color.yellow;

        }
        if (OVRInput.Get(OVRInput.RawTouch.B))
        {
            //Bボタンをタッチした際の処理         
            text.GetComponent<Text>().text = "TouchedButtonB";
            cube.GetComponent<Renderer>().material.color = Color.red;

        }
        if (OVRInput.Get(OVRInput.RawTouch.X))
        {
            //Xボタンをタッチした際の処理         
            text.GetComponent<Text>().text = "TouchedButtonX";
            cube.GetComponent<Renderer>().material.color = Color.black;

        }
        if (OVRInput.Get(OVRInput.RawTouch.Y))
        {
            //Yボタンをタッチした際の処理         
            text.GetComponent<Text>().text = "TouchedButtonY";
            cube.GetComponent<Renderer>().material.color = Color.green;

        }
    }
    

    public void ButtonTest()
    {
        text.GetComponent<Text>().text = "テスト成功";
        cube.GetComponent<Renderer>().material.color = Color.green;
        // cube.GetComponent<Renderer>().material.SetColor("_Color", Color.red);


    }


}
