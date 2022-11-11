using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AABBToSphere : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkAABBtoSphereCollision(cube, sphere);
    }
    void checkAABBtoSphereCollision(GameObject A, GameObject B)
    {
        float aMinX = A.transform.position.x - (A.transform.localScale.x / 2);
        float aMaxX = A.transform.position.x + (A.transform.localScale.x / 2);
        float aMinY = A.transform.position.y - (A.transform.localScale.y / 2);
        float aMaxY = A.transform.position.y + (A.transform.localScale.y / 2);
        float aMinZ = A.transform.position.z - (A.transform.localScale.z / 2);
        float aMaxZ = A.transform.position.z + (A.transform.localScale.z / 2);

        // get box closest point to sphere center by clamping
        var x = Mathf.Max(aMinX, Mathf.Min(B.transform.position.x, aMaxX));
        var y = Mathf.Max(aMinY, Mathf.Min(B.transform.position.y, aMaxY));
        var z = Mathf.Max(aMinZ, Mathf.Min(B.transform.position.z, aMaxZ));

        var distance = Mathf.Sqrt(
            (x - B.transform.position.x) * (x - B.transform.position.x) +
            (y - B.transform.position.y) * (y - B.transform.position.y) +
            (z - B.transform.position.z) * (z - B.transform.position.z)
           );

        if (distance < (B.transform.localScale.x / 2))
        {
            A.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            A.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
