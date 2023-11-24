using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    Vector3 imlecdunya;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            imlecdunya = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 2));
        }

        transform.position = Vector3.MoveTowards(transform.position, imlecdunya, .2f);

    } 
    
    
    
}
