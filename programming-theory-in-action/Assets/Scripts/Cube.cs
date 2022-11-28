using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        shape = "Cube";
        color = "Red";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            HandleClick();
        }   
    }

    public override void DisplayStats(){
        Debug.Log("This is a "+shape+" that is "+color);
    }
}
