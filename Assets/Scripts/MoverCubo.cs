using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCubo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        move();
    }

    public void move()
    {
        gameObject.transform.position = new Vector3(Random.Range(-5,5), Random.Range(-5, 5), Random.Range(-5, 5));
    }

    public void reset()
    {
        gameObject.transform.position = new Vector3(0,0,0);
    }
}
