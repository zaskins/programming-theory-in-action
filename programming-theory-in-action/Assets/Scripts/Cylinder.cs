using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape// INHERITANCE
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
            HandleClick();// ABSTRACTION
        }   
    }

    public override void DisplayStats(){ // POLYMORPHISM
        Debug.Log("This "+color+" "+shape+" is really cool");
    }
}
