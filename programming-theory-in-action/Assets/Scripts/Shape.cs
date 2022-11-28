using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public string color {get; set;}
    public string shape {get; set;}
    // Start is called before the first frame update
    void Start()
    {
        color = "gray";
        shape = "Shape";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            HandleClick();
        }   
    }

    public void HandleClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            if(hit.transform.name==shape){
                DisplayStats();
            }
        }
    }

    public virtual void DisplayStats()
    {
        Debug.Log("Color: "+color+" Shape: "+shape);
    }
}
