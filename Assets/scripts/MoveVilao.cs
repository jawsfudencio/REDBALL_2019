using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVilao : MonoBehaviour
{

    public float periodoRotacao;
    public float compLateral = 1f;
    private bool estaRotacionando = false;
    private float direcaoX = 0;

    private Vector3 inicioPos;
    private float tempoRotacao = 0;
    private float raio;
    private Quaternion fRotacao;
    private Quaternion tRotacao;

    private float x,y;



    // Start is called before the first frame update
    void Start()
    {
        raio = compLateral * Mathf.Sqrt(2f)/2;
    }

    // Update is called once per frame
    void Update()
    {
        x = 0;
        y = 0;

        x = Input.GetAxisRaw("Horizontal");
        if(x == 0)
        {
            y = Input.GetAxisRaw("Vertical");
        }

        if((x !=0 || y != 0) && !estaRotacionando)
        {
            direcaoX = y;
            inicioPos = transform.position;
            fRotacao = transform.rotation;
            transform.Rotate(0,0,direcaoX * 90,Space.World);
            tRotacao = transform.rotation;
            transform.rotation = fRotacao;
            tempoRotacao = 0;
            estaRotacionando = true;

        }
    }


    void FixedUpdate()
    {

    }
}
