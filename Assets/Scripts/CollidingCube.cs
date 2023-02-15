using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidingCube : MonoBehaviour
{
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = Random.insideUnitSphere * 10.0f;

        direction = Random.insideUnitSphere.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = this.transform.position + direction * 0.05f;

        if (newPosition.x > 10.0f || newPosition.x < -10.0f)
            direction.x = -direction.x;
        if (newPosition.y > 10.0f || newPosition.y < -10.0f)
            direction.y = -direction.y;
        if (newPosition.z > 10.0f || newPosition.z < -10.0f)
            direction.z = -direction.z;

        this.transform.position = newPosition;

        CollidingCube[] cubes = FindObjectsOfType<CollidingCube>();

        foreach (CollidingCube cube in cubes)
        {
            if (cube != this)
            {

                Collider thisCube = GetComponent<Collider>();
                Collider otherCube = cube.GetComponent<Collider>();

                Renderer cubeRenderer = GetComponent<Renderer>();

                if (thisCube.bounds.Intersects(otherCube.bounds))
                {
                    cubeRenderer.material.color = Color.red;
                    continue;
                }
                else
                {
                    cubeRenderer.material.color = Color.white;
                }
            }
        }
    }
}
