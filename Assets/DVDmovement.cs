using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DVDmovement : MonoBehaviour
{
    public int speed =1;
    int directionx = 1;
    int directiony = 1;
    private Rigidbody2D _rigidbody2d;
    private BoxCollider2D _boxcollider2d;
    private SpriteRenderer _spriterenderer;
    // Start is called before the first frame update
    void Start()
    {
        _spriterenderer = GetComponent<SpriteRenderer>();
        _rigidbody2d = GetComponent<Rigidbody2D>();
        _boxcollider2d = GetComponent<BoxCollider2D>();
        _boxcollider2d.isTrigger = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody2d.position = new Vector2(_rigidbody2d.position.x + speed * directionx * Time.deltaTime, _rigidbody2d.position.y + speed * directiony * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bloquederecha")
        {
            directionx = directionx * -1;
            _spriterenderer.flipX = !_spriterenderer.flipX;
        }
        if (collision.gameObject.tag == "bloquearriba")
        {
            directiony = directiony * -1;
            _spriterenderer.flipY = !_spriterenderer.flipY;
        }
    }
}
