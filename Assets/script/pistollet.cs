using System.Reflection;
using UnityEngine;

public class pistollet : MonoBehaviour
{
    public Camera cam;
    public Transform boule;
    

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

        Transform bullet = boule;
        Quaternion rndRotation = Random.rotation;
        Vector3 pointeur = hit.point;

        Transform gO = Instantiate(bullet, pointeur, rndRotation);
        //Destroy(gO.gameObject,1F);
        Destroy(gO.gameObject, 0.12f);
    }
}
