using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBola : MonoBehaviour
{

    public Rigidbody rb;
    public float vel;
    public float forcaPulo;
    public bool noChao;
    public float raio;
    public LayerMask layer;
    public ConstantForce2D constantForce2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      noChao = Physics2D.OverlapCircle(transform.position,raio,layer);

      if(noChao && Input.GetKeyDown(KeyCode.Space))
      {
          rb.velocity = new Vector2(rb.velocity.x,(rb.velocity.y + 1) * forcaPulo);
      }  
    }

    void FixedUpate()
    {
        if(rb != null)
        {
            //chamando metodo
        }
    }

    public void AplicaForca()
    {
        float yVel = rb.velocity.y;
        float xInput = Input.GetAxis("Horizontal");
        float XForca = xInput * vel * Time.deltaTime;

        Vector2 forca = new Vector2(XForca,0);

        rb.velocity = new Vector2(XForca,rb.velocity.y);
    }
}
