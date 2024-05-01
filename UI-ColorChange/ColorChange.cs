//Suryakumar P 21MIS1146
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    SpriteRenderer sprite;
    public Color newColor;
    public Button B1,B2,B3;
    // Start is called before the first frame update
    void Start()
    {
        Button btn1 = B1.GetComponent<Button>();
        btn1.onClick.AddListener(B1Click);
        Button btn2 = B2.GetComponent<Button>();
        btn2.onClick.AddListener(B2Click);
        Button btn3 = B3.GetComponent<Button>();
        btn3.onClick.AddListener(B3Click);
    }

    public void B1Click()
    {
        Debug.Log("Red Color");
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = Color.red;
    }

    public void B2Click()
    {
        Debug.Log("Blue Color");
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = Color.blue;
    }

    public void B3Click()
    {
        Debug.Log("Green Color");
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
