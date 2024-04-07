using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    //The Speed of which our object moves
    public float Speed;

    //Positon in which we want to teleport our objects
    public float DespawnPosition;
    public float SpawnPosition;

    //Random range in which we will position our object in Y-Axis
    public float MinY;
    public float MaxY;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(MinY, MaxY), transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);

        if(transform.position.x < DespawnPosition)
        {
            transform.position = new Vector3(SpawnPosition, Random.Range(MinY, MaxY), transform.position.z);
        }
    }
}
