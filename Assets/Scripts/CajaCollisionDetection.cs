using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDetection : MonoBehaviour
{
    public CajaMovement cajaMovementScript;
    
    // Start is called before the first frame update
    void Start()
    {
        cajaMovementScript = GetComponent<CajaMovement>();
        
    }


      void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            cajaMovementScript.MoveBoxToRandomPosition();
        }
    }
}
