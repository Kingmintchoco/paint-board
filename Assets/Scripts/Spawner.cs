using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject weapon;
    public GameObject item;

    private void Start(){
        
    }
    
    private void Update(){

    }

    public Vector3 GetRandomEnemyPosition(){
        float radius = 3f;
        Vector3 playerPosition = transform.position;
        
        float a = playerPosition.x;
        float b = playerPosition.y;

        float x = Random.Range(-radius + a, radius + a);
        float yy = Mathf.Sqrt(Mathf.Pow(radius, 2) - Mathf.Pow(x - a, 2));
        yy *= Random.Range(0, 2) == 0 ? -1 : 1;
        float y = yy + b;

        Vector3 randomPosition = new Vector3(x, y, 0);

        return randomPosition;
    }
}
