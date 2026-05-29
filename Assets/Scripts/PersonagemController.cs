using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemController : MonoBehaviour
{
    public Rigidbody2D rb2d;



    // Start is called before the first frame update
    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity += new Vector2(1, 0);

    }
}
