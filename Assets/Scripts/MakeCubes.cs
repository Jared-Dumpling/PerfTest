using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCubes : MonoBehaviour
{
    public CollidingCube collidingCube;

    public int cubeAmount = 100;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < cubeAmount; i++)
		{
            CollidingCube newCube = Instantiate(collidingCube);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
