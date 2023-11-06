using System.Reflection;
using UnityEditor;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Camera cam;
    public Transform boulet;
    public Rigidbody rigi;
    public Transform luncher;
    private Vector3 velocity;
    public float vitesse_bullet;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 positionSouris = Input.mousePosition;
        positionSouris.z = 5;
        positionSouris = cam.ScreenToWorldPoint(positionSouris);

        Vector3 direction = positionSouris - cam.transform.position;
        Physics.Raycast(cam.transform.position, direction, out hit);

      
        Vector3 pointeur = hit.point;

        Vector3 direction_boulet = pointeur - boulet.transform.position; 
        //direction_boulet = direction_boulet.normalized;
        
        if (Input.GetMouseButtonDown(0))
        {
            //Vector3 position_tir = Vector3 


            Transform missile = Instantiate(boulet);

            missile.position = luncher.transform.position;
            missile.forward = direction_boulet;

            

            Destroy(missile.gameObject, 2);
            
        }
        rigi.velocity = velocity * vitesse_bullet;
    }
}