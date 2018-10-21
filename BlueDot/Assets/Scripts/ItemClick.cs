using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemClick : MonoBehaviour {


	public GameObject bufferfield ;


	void Start()
    {
    	Button b = GetComponent<Button>();
    	bufferfield = GameObject.Find("Buffer");
        b.onClick.AddListener(onClick);
    }


    void onClick()
    {
        string keytext = gameObject.GetComponentInChildren<Text>().text;
        Text bufferfield = GameObject.Find("Buffer").GetComponentInChildren<Text>();
        bufferfield.text = bufferfield.text + keytext;
    }

    void onSpace()
    {
        Text bufferfield = GameObject.Find("Buffer").GetComponentInChildren<Text>();
        bufferfield.text = bufferfield.text + " ";
    }

    void onClear()
    {
        Text bufferfield = GameObject.Find("Buffer").GetComponentInChildren<Text>();
        bufferfield.text = "";
    }

    void onBackspace()
    {
        Text bufferfield = GameObject.Find("Buffer").GetComponentInChildren<Text>();
        bufferfield.text = bufferfield.text.Substring(0, bufferfield.text.Length-1);
    }

    void onSubmit(string text = "#BUF")
    {
        bool success;
        Text bufferfield;

        if ("#BUF".Equals(text))
        {
            bufferfield = GameObject.Find("Buffer").GetComponentInChildren<Text>();
            text = bufferfield.text;

        }
         

        //send text varible to text to speech use success to determine if the text is processed


    }

    void onMacro()
    {
        Text bufferfield = GameObject.Find("Buffer").GetComponentInChildren<Text>();
        onSubmit(bufferfield.text);

    }



}
