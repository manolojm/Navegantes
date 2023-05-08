using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    public Transform ruta;
    public Transform jugador;
    int indiceHijos;
    Vector3 destino;

    public NavMeshAgent agent;

    private void Start() {
        //destino = ruta.GetChild(indiceHijos).position;
        //GetComponent<NavMeshAgent>().SetDestination(destino);
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        destino = jugador.position;
        GetComponent<NavMeshAgent>().SetDestination(destino);

        /*if (Vector3.Distance(transform.position, destino) < 2.0f) {
            indiceHijos++;
            indiceHijos = indiceHijos % ruta.childCount;
            destino = ruta.GetChild(indiceHijos).position;
        }*/

        /*if (Input.GetButtonDown("Fire1")) {
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(rayo, out hit, 1000)) {
                GetComponent<NavMeshAgent>().SetDestination(hit.point);
            }
        }*/
    }
}
