using System.Reflection;
using UnityEditor;
using UnityEngine;

public class pistollet : MonoBehaviour
{
    public Camera cam;
    public Transform lazer;
    //public Transform boulet;
   // public Transform luncher;
    

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

        Transform bullet = lazer;
        Quaternion rndRotation = Random.rotation;
       
        Vector3 pointeur = hit.point;
        //Vector3 direction_boulet = bullet.transform.position - pointeur;
        //direction_boulet = direction_boulet.normalized;
        Transform gO = Instantiate(bullet, pointeur, rndRotation);
        Destroy(gO.gameObject, 0.12f);
/*
        if (Input.GetMouseButtonDown(0))
        {
            //Vector3 position_tir = Vector3 
            

            Transform g1 = Instantiate(boulet, direction_boulet, rndRotation);
            
            if (Input.GetMouseButtonUp(0)) 
            {
                Destroy(g1.gameObject, 0.1f);
            }
        }*/
    }
}
