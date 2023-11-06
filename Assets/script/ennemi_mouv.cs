using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemi_mouv : MonoBehaviour
{
    public Rigidbody rigi_ennemi;
    public Transform rigi_perso;
    public float vitesse_ennemi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigi_ennemi.transform.LookAt(rigi_perso);
        rigi_ennemi.velocity = transform.forward * vitesse_ennemi;

    }
}
