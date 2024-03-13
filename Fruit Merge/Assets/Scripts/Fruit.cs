using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Fruit : MonoBehaviour
{
    public int points = 1;
    public bool isMerging;
    public GameObject nextFruit;
    public GameObject pointsText;
    public AudioClip mergeSound;
    public AudioSource source;

    void OnCollisionEnter2D(Collision2D other)
    {
        var source = GetComponent<AudioSource>();
        if (isMerging) return;
        if (!other.gameObject.CompareTag("Fruit")) return;
        if (points != other.gameObject.GetComponent<Fruit>().points) return;

        isMerging = true;
        source.clip = mergeSound;
        source.Play();
        other.gameObject.GetComponent<Fruit>().isMerging = true;

        if (!other.gameObject.CompareTag("Fruit")) return;

        var middlePos = (transform.position + other.transform.position) / 2;

        Destroy(gameObject);
        Destroy(other.gameObject);

        points += points;
        //pointsText = points.ToString();

        Instantiate(nextFruit, middlePos, Quaternion.identity);
    }
}
