using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public HingeJoint2D links;
    public HingeJoint2D rechts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        JointMotor2D motorL = links.motor;
        JointMotor2D motorR = rechts.motor;

        if (Input.GetKey("v"))
        {
            motorL.motorSpeed = Mathf.Abs(links.motor.motorSpeed) * -1;
            links.motor = motorL;
        }
        else
        {
            motorL.motorSpeed = Mathf.Abs(links.motor.motorSpeed);
            links.motor = motorL;
        }
        if (Input.GetKey("b"))
        {
            motorR.motorSpeed = Mathf.Abs(rechts.motor.motorSpeed);
            rechts.motor = motorR;
        }
        else
        {
            motorR.motorSpeed = Mathf.Abs(rechts.motor.motorSpeed) * -1;
            rechts.motor = motorR;
        }
    }
}
