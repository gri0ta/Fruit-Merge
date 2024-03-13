using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> fruitPrefabs;
    Rigidbody2D rb;
    public float minX = -3f;
    public float maxX = 3f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            SpawnFruit();
        }
        
    }

    void SpawnFruit()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 5f; 
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldPosition.y = 3f;
        worldPosition.x = Mathf.Clamp(worldPosition.x, minX, maxX);
        print(worldPosition);
        var randomFruitSpawn = Instantiate(fruitPrefabs[Random.Range(0, fruitPrefabs.Count)],worldPosition, Quaternion.identity);
            
    }
}
