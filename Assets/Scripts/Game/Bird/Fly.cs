using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField]
    private float _velocity;

    [SerializeField]
    private GameManager _gameManager;

    private new Rigidbody2D rigidbody2D;

    public Fly(Rigidbody2D rigidbody2D)
    {
        this.rigidbody2D = rigidbody2D;
    }

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody2D.velocity = Vector2.up * _velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _gameManager.GameOver();
    }
}
