using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NewBehaviourScript : MonoBehaviour
{
    public Transform    Objetivo;
    public float Velocidad;
    public NavMeshAgent IA;


       void Update()
    {
      IA.speed = Velocidad;
      IA.SetDestination(Objetivo.position);
      

    }
}
