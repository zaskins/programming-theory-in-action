using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        shape = "Cylinder";
        color = "Green";
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            HandleClick();
        }   
    }

    public override void DisplayStats(){
        Debug.Log("This "+color+" "+shape+" is really cool");
    }
}
