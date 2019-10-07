using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    public GameObject ball;
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = ball.transform.position.x;
        y = ball.transform.position.y;

        gameObject.transform.position = new Vector3(x,y,0);

    }
}
