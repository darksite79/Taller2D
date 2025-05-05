using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SueloInfinito : MonoBehaviour
{
    private float size;
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D groundCollider = GetComponent<BoxCollider2D>();
        size = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -size)
        {
            transform.Translate(Vector2.right *2f * size);

        }
    }
}
