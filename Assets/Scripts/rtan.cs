using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class rtan : MonoBehaviour
{
    [SerializeField]
    float direction = 0.01f;

    [SerializeField]
    float toward = 1f;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 2.4){
            direction = -0.05f;
            toward = -1f;

        }

        if(transform.position.x < -2.3){
            direction = 0.05f;
            toward = 1f;
        }
        
        if(Input.GetMouseButtonDown(0)){
        
                direction *= -1;
                toward *= -1;
            
        }
        transform.localScale = new Vector3(toward, 1, 1);
        
    }

    void FixedUpdate() {
        transform.position += new Vector3(direction, 0, 0);
    }
}
