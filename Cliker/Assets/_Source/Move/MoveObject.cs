using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveObject : MonoBehaviour
{
    [SerializeField] private Vector3 Left;
    [SerializeField] private Vector3 Right;
    [SerializeField] private float speed;
    [SerializeField] private HingeJoint HJ;
    private int index=1;
    private float defoltHJtargetV; 
    private void Start()
    {
        defoltHJtargetV = HJ.motor.targetVelocity;
    }
    void Update()
    {
        if(gameObject.transform.position.x > Right.x)
        {
            index = 1;
        }
        if (gameObject.transform.position.x < Left.x)
        {
            index = -1;
        }
        var motor = HJ.motor;
        motor.targetVelocity = defoltHJtargetV * index * speed; 
        HJ.motor = motor;
        //gameObject.transform.position += gameObject.transform.right * index * speed * Time.deltaTime;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Left, Right);
    }
}