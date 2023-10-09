using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public string type = "basic";
    public int level = 1;
    public float power = 1.0f;
    public float speed = 1.0f;

    private Vector3 direction = Vector3.zero;

    public void SetDirection(Vector3 newDirection){
        direction = newDirection.normalized;
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision){
        Destroy(gameObject);
    }
}
