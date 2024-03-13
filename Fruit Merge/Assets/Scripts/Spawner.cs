using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using TMPro;

public class Spawner : MonoBehaviour
{
    public List<GameObject> fruitPrefabs;
    Rigidbody2D rb;
    public float minX = -3f;
    public float maxX = 3f;
    public TMP_Text playText;
    public TMP_Text mergeFruitText;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
   
            SpawnFruit();
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                playText.text = " ";
                mergeFruitText.text = " ";
            }
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
