using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float speed = 2f;
    float initialYValue;

void Start()

{
    initialYValue = transform.position.y;
}
    void Update()
    {
       
        
        transform.Translate(0, -speed * Time.deltaTime, 0);

        
    }

    public void MoveBoxToRandomPosition()
    {
        Vector3 newPosition = transform.position;
        newPosition.y = initialYValue;
        transform.position = newPosition;

    }
}

