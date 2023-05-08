using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Jugador : MonoBehaviour {
    private Rigidbody rb;
    private float velocidad = 4.0f;
    public GameObject pantallaFin;

    public TextMeshProUGUI tiempoTxt;
    private float tiempoInicio;
    private int tiempoEmpleado;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
        tiempoInicio = Time.time;
    }

    // Update is called once per frame
    void Update() {
        //Capturo el movimiento en horizontal y vertical de nuestro teclado
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        transform.position += new Vector3(movimientoH, 0, movimientoV) * velocidad * Time.deltaTime;

        // Actualizamos tiempo
        tiempoEmpleado = (int)Time.time - (int)tiempoInicio;
        SetTiempo(tiempoEmpleado);
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Enemigo")) {
            // Pausa
            Time.timeScale = 0;

            // Fin
            pantallaFin.SetActive(true);
            Debug.Log("Fin");
        }
    }

    public void SetTiempo(int tiempo) {
        int segundos = tiempo % 60;
        int minutos = tiempo / 60;
        tiempoTxt.text = minutos.ToString("00") + ":" + segundos.ToString("00");
    }
}
