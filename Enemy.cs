using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float rangoAlert;
    public LayerMask capaPlayer;

    bool stayAlert;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       stayAlert = Physics.CheckSphere(transform.position, rangoAlert, capaPlayer);
    }

    private void DrawGizmos(){
        Gizmos.DrawSphere(transform.position, rangoAlert);
    }
}
