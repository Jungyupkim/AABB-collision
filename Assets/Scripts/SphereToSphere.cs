using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereToSphere : MonoBehaviour
{
    public GameObject player;
    public GameObject objects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkSphereCollision(player, objects);
    }
    void checkSphereCollision(GameObject A, GameObject B)
    {
        // finding the distance between two spheres by using the math equation
        // distance between two spheres = ?((a.x - b.x)^2 + (a.y - b.y)^2 + (a.z - b.z)^2)
        float distance = Mathf.Sqrt(
            (A.transform.position.x - B.transform.position.x) * (A.transform.position.x - B.transform.position.x) +
            (A.transform.position.y - B.transform.position.y) * (A.transform.position.y - B.transform.position.y) +
            (A.transform.position.z - B.transform.position.z) * (A.transform.position.z - B.transform.position.z)
            );

        // if the distance between both sphere is smaller than the addition of radius of both spheres, it means two spheres are overlapping
        if (distance < ((A.transform.localScale.y / 2) + (B.transform.localScale.y / 2)))
        {
            A.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            A.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    void checkCIrcleCollision(GameObject A, GameObject B)
    {
        // finding the distance between two spheres by using the math equation
        // distance between two spheres = ?((a.x - b.x)^2 + (a.y - b.y)^2 + (a.z - b.z)^2)
        float distance = Mathf.Sqrt(
            (A.transform.position.x - B.transform.position.x) * (A.transform.position.x - B.transform.position.x) +
            (A.transform.position.y - B.transform.position.y) * (A.transform.position.y - B.transform.position.y) +
            (A.transform.position.z - B.transform.position.z) * (A.transform.position.z - B.transform.position.z)
            );

        // if the distance between both sphere is smaller than the addition of radius of both spheres, it means two spheres are overlapping
        if (distance < ((A.transform.localScale.y / 2) + (B.transform.localScale.y / 2)))
        {
            A.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            A.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
