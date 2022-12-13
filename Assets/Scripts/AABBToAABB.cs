using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AABBToAABB : MonoBehaviour
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
        checkAABBCollision2D(player, objects);
        //checkAABBCollision3D(player, objects);
    }
    void checkAABBCollision2D(GameObject A, GameObject B) // player is A, objects is B
    {
        // finding min and maximum value of axis point in a cube (e.g. finding different points/position per axis in each side of the cube)
        // equation to find the each points: position of the object along the axis +- (scale of the object along the axis/2)
        float aMinX = A.transform.position.x - (A.transform.localScale.x / 2);
        float aMaxX = A.transform.position.x + (A.transform.localScale.x / 2);
        float aMinY = A.transform.position.y - (A.transform.localScale.y / 2);
        float aMaxY = A.transform.position.y + (A.transform.localScale.y / 2);

        float bMinX = B.transform.position.x - (B.transform.localScale.x / 2);
        float bMaxX = B.transform.position.x + (B.transform.localScale.x / 2);
        float bMinY = B.transform.position.y - (B.transform.localScale.y / 2);
        float bMaxY = B.transform.position.y + (B.transform.localScale.y / 2);

        // comparing different points of both cubes to determine if the cube is intersecting along any of the axis
        // this can be also applied to check collision in 2D by ignoring the Z axis
        var AisToTheRightOfB = aMinX > bMaxX;
        var AisToTheLeftOfB = aMaxX < bMinX;
        var AisAboveB = aMinY > bMaxY;
        var AisBelowB = aMaxY < bMinY;

        if (!AisToTheRightOfB && !AisToTheLeftOfB && !AisAboveB && !AisBelowB)
        {
            // If the object A is not on the entire left, right, top, bottom, infront, behind of the object B, it means that the objects are colliding
            A.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            // the cube will remain as green color if the the cubes are not colliding with each other
            A.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
    void checkAABBCollision3D(GameObject A, GameObject B) // player is A, objects is B
    {
        // finding min and maximum value of axis point in a cube (e.g. finding different points/position per axis in each side of the cube)
        // equation to find the each points: position of the object along the axis +- (scale of the object along the axis/2)
        float aMinX = A.transform.position.x - (A.transform.localScale.x / 2);
        float aMaxX = A.transform.position.x + (A.transform.localScale.x / 2);
        float aMinY = A.transform.position.y - (A.transform.localScale.y / 2);
        float aMaxY = A.transform.position.y + (A.transform.localScale.y / 2);
        float aMinZ = A.transform.position.z - (A.transform.localScale.z / 2);
        float aMaxZ = A.transform.position.z + (A.transform.localScale.z / 2);

        float bMinX = B.transform.position.x - (B.transform.localScale.x / 2);
        float bMaxX = B.transform.position.x + (B.transform.localScale.x / 2);
        float bMinY = B.transform.position.y - (B.transform.localScale.y / 2);
        float bMaxY = B.transform.position.y + (B.transform.localScale.y / 2);
        float bMinZ = B.transform.position.z - (B.transform.localScale.z / 2);
        float bMaxZ = B.transform.position.z + (B.transform.localScale.z / 2);

        // comparing different points of both cubes to determine if the cube is intersecting along any of the axis
        // this can be also applied to check collision in 2D by ignoring the Z axis
        var AisToTheRightOfB = aMinX > bMaxX;
        var AisToTheLeftOfB = aMaxX < bMinX;
        var AisAboveB = aMinY > bMaxY;
        var AisBelowB = aMaxY < bMinY;
        var AisInfrontB = aMinZ > bMaxZ;
        var AisBehindB = aMaxZ < bMinZ;


        if (!AisToTheRightOfB && !AisToTheLeftOfB && !AisAboveB && !AisBelowB && !AisInfrontB && !AisBehindB)
        {
            // If the object A is not on the entire left, right, top, bottom, infront, behind of the object B, it means that the objects are colliding
            A.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            // the cube will remain as green color if the the cubes are not colliding with each other
            A.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
