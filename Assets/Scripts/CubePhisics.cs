using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;


public class CubePhisics : MonoBehaviour

{
    public Transform EndPoint;
    private Transform transform;
    public Vector3 speed;
    public Vector3 acceleration;
    private Vector3 previousSpeed;
    private float Kff = 0;
    private float l= 0;
    private float lk = 0;
    public float mass;
    private float G = 0.0000000000667f;
    void Awake()
    {
    }
    void Start()
    {
        previousSpeed = Vector3.zero;
        acceleration = Vector3.zero;
        //speed = Vector3.zero;
        Debug.Log("I start fallihg");
        transform = GetComponent<Transform>();
    }
    void Update()
    {
        //Debug.Log("L: " + l.ToString());
        //Debug.Log("X: " + transform.position.x.ToString());
        //Debug.Log("SPEED_X: " + speed.x.ToString());
    }
    void FixedUpdate()
    {
        l = Mathf.Sqrt((EndPoint.position.x - transform.position.x) * (EndPoint.position.x - transform.position.x)
            + (EndPoint.position.y - transform.position.y) * (EndPoint.position.y - transform.position.y)
            + (EndPoint.position.z - transform.position.z) * (EndPoint.position.z - transform.position.z));

        lk = l * l * l;
        Kff = G * mass/lk;

        acceleration.x = (Kff * (EndPoint.position.x - transform.position.x));
        acceleration.y = (Kff * (EndPoint.position.y - transform.position.y));
        acceleration.z = (Kff * (EndPoint.position.z - transform.position.z));

        previousSpeed.x = speed.x;
        previousSpeed.y = speed.y;
        previousSpeed.z = speed.z;

        speed.x += acceleration.x * Time.deltaTime;
        speed.y += acceleration.y * Time.deltaTime;
        speed.z += acceleration.z * Time.deltaTime;

        transform.position = transform.position + new Vector3((speed.x+previousSpeed.x)/2 , (speed.y+previousSpeed.y)/2, (speed.z+previousSpeed.z)/2) * Time.deltaTime;

    }
}
