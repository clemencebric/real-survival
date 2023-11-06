using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perso_mouv : MonoBehaviour
{
    public float vitesse;
    public float hauteur_saut;
    private Vector3 velocity;
    public Rigidbody rigi;

    public float RaycastUpOffset;
    public float RaycastDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        float saut = Input.GetAxisRaw("Jump");
        velocity = Vector3.right * horizontal + Vector3.forward * vertical + Vector3.up * saut * hauteur_saut;
        velocity = velocity.normalized;
        //rigi.velocity = velocity * vitesse;
    }
    private void FixedUpdate()
    {
        if (IsOnTheGround())
            rigi.velocity = velocity * vitesse;
    }
    public bool IsOnTheGround()
    {
        return (Physics.Raycast(transform.position + Vector3.up * RaycastUpOffset, Vector3.down, RaycastDistance));
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position + Vector3.up * RaycastUpOffset, Vector3.down * RaycastDistance);
    }
}
