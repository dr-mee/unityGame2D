
using System;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed = 1;
    private Enemy enemy;
    // Update is called once per frame

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed, Space.World);

        if(transform.position.x <= -11)
        {
            transform.position += new Vector3(22,0,0);
            spawnChildRandomly();
            enemy?.Alive();

        }
    }

    private void spawnChildRandomly()
    {
        int totalChildren = transform.childCount;
        int randomIndexOfChild = UnityEngine.Random.Range(0, totalChildren);

        for(int i=0; i<totalChildren; i++)
        {
            Transform child = transform.GetChild(i);
            child.gameObject.SetActive(randomIndexOfChild == i);

            
        }
    }

    private void OnEnable()
    {
        spawnChildRandomly();
    }
}
