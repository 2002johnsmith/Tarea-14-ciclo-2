using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycode : MonoBehaviour
{
    public float movimientoy;
    public float VelocidadY;
    public GameObject Explosion;
    private Transform _componentTransform;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
        _componentTransform = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        _componentTransform.position = new Vector2(_componentTransform.position.x,
            _componentTransform.position.y + VelocidadY * -movimientoy * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball"||collision.gameObject.tag=="player")
        {
            GameObject explosiondestroy = Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
            Destroy(explosiondestroy, 0.5f);
        }
        else if (collision.gameObject.tag == "wall")
        {
            Destroy(this.gameObject);
        }
    }
}