using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {
    private Rigidbody rb;
    private float velocidad = 4.0f;
    public GameObject pantallaFin;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        //Capturo el movimiento en horizontal y vertical de nuestro teclado
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        transform.position += new Vector3(movimientoH, 0, movimientoV) * velocidad * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Enemigo")) {
            Time.timeScale = 0;
            pantallaFin.SetActive(true);
            Debug.Log("Fin");
        }
    }
}
