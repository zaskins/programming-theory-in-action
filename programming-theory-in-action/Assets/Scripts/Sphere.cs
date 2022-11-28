using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
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
            HandleClick();
        }   
    }

    public override void DisplayStats(){
        Debug.Log("This "+color+" really suits this "+shape);
    }
}
