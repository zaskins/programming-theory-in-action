using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape// INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        shape = "Sphere";
        color = "Blue";
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            HandleClick();// ABSTRACTION
        }   
    }

    public override void DisplayStats(){ // POLYMORPHISM
        Debug.Log("This "+color+" really suits this "+shape);
    }
}
