using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereToSphere : MonoBehaviour
{
    public GameObject player;
    public GameObject objects;

    // Update is called once per frame
    void Update()
    {
        checkCircleCollision(player, objects);
        //heckSphereCollision(player, objects);
    }
    void checkCircleCollision(GameObject A, GameObject B)   
    {
        // finding the distance between two circle by using the math equation
        // distance between two circles = square root((a.x - b.x)^2 + (a.y - b.y)^2)
        float distance = Mathf.Sqrt(
            (A.transform.position.x - B.transform.position.x) * (A.transform.position.x - B.transform.position.x) +
            (A.transform.position.y - B.transform.position.y) * (A.transform.position.y - B.transform.position.y)
            );

        // if the distance between both sphere is smaller than the addition of radius of both circles, it means two circles are overlapping
        // this is possible as circle will have same radius within the object
        if (distance <= ((A.transform.localScale.y / 2) + (B.transform.localScale.y / 2)))
        {
            A.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            A.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    void checkSphereCollision(GameObject A, GameObject B)
    {
        // finding the distance between two spheres by using the math equation
        // distance between two spheres = square root((a.x - b.x)^2 + (a.y - b.y)^2 + (a.z - b.z)^2)
        float distance = Mathf.Sqrt(
            (A.transform.position.x - B.transform.position.x) * (A.transform.position.x - B.transform.position.x) +
            (A.transform.position.y - B.transform.position.y) * (A.transform.position.y - B.transform.position.y) +
            (A.transform.position.z - B.transform.position.z) * (A.transform.position.z - B.transform.position.z)
            );

        // if the distance between both sphere is smaller than the addition of radius of both spheres, it means two spheres are overlapping
        // this is possible as sphere have same raidus around the object
        if (distance <= ((A.transform.localScale.y / 2) + (B.transform.localScale.y / 2)))
        {
            A.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            A.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
