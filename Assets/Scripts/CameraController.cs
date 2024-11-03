using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 distancia;
    // Start is called before the first frame update
    void Start()
    {
        distancia = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = distancia + player.transform.position;
    }
}
