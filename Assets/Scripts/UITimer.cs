using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITimer : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo;
    private float tiempo = 0f;
    public bool juegoTerminado = false;

    void Update()
    {
        if (!juegoTerminado)
        {
            tiempo += Time.deltaTime;
            textoTiempo.text = tiempo.ToString("F2");
        }
    }
}