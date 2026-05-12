using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDetection : MonoBehaviour
{
    public CajaMovement cajaMovementScript;
    public UITimer timerScript;

    void Start()
    {
        cajaMovementScript = GetComponent<CajaMovement>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            cajaMovementScript.speed += 1f;
            cajaMovementScript.MoveBoxToRandomPosition();
        }

        if (collision.gameObject.CompareTag("Caja"))
        {
            timerScript.juegoTerminado = true;
        }
    }
}