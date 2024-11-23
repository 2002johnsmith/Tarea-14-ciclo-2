using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float xMinPosition;
    public float xMaxPosition;
    public float Yposition;
    public float Time;
    // Start is called before the first frame update
    void Start()
    {
        CreateEnemy();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateEnemy()
    {
        float XPosition = Random.Range(xMinPosition,xMaxPosition);
        Vector2 positiontoCreate = new Vector2(XPosition, Yposition);
        Instantiate(EnemyPrefab, positiontoCreate, transform.rotation);
        Invoke("CreateEnemy", Time);
    }
}
