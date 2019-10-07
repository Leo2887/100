using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb2d;//Rigid body 2D
    public float speed = 5f;
    public float scale = 0.1f;
    public CircleCollider2D myCollider; //to detect collision
    public string Tag = "ball";
    // Start is called before the first frame update
    void Start()
    {
        var force = (transform.forward + transform.up) * speed;// initial move
        //var force =(transform.forward + transform.right) * speed;  you can change the intial move like this

        rb2d = GetComponent<Rigidbody2D>();
        
        rb2d.AddForce(force, ForceMode2D.Impulse);//initial move
        myCollider = GetComponent<CircleCollider2D>();//collision detection
        rb2d.transform.localScale = new Vector3(1.0f,1.0f, 0);//set the initial size of the ball
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))//detect mouse clic
        {
            //detect the position of the input weather it's match to the position of object
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit)//if the input and position of ball matches...
            {
                scale += 0.1f;//the amount of increse in size each time you hit object
                rb2d.transform.localScale = new Vector3(1.0f + scale, 1.0f + scale, 0);
                Debug.Log("Touched");
            }

            
        }

    }
}
    
