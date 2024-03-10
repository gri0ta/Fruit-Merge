using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> fruitPrefabs;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Input.mousePosition;
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        SpawnFruit();
    }

    void SpawnFruit()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            var randomFruitSpawn = Instantiate(fruitPrefabs[Random.Range(0, fruitPrefabs.Count)],transform.position, Quaternion.identity);
            

        }
    }
}
