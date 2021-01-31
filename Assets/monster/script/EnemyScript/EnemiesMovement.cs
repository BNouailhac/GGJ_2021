using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMovement : MonoBehaviour
{
    public float speed;
    public Vector2 direction;
    public GameObject player;

    void Start()
    {
        speed = 0.005f;
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        direction = Vector2.zero;
        Vector2 myPos = transform.position;
        Vector2 targetPog = player.transform.position;
        direction += (targetPog - myPos).normalized;
        transform.Translate(direction * speed);
    }
}
