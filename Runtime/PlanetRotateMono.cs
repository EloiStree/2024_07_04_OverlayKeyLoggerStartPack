using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotateMono : MonoBehaviour
{
    public float m_rotationSpeedInAngle = 180;
    public Transform m_whatToRotate;
    public Space m_space = Space.Self;
    void Update()
    {
        
        m_whatToRotate.Rotate(Vector3.up, m_rotationSpeedInAngle * Time.deltaTime, m_space);
    }
}
