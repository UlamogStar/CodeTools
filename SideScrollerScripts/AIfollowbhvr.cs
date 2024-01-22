using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIfollowbhvr : MonoBehaviour
    {
        public Transform target; // The target to follow
        private NavMeshAgent agent; // Reference to the NavMeshAgent component

        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        void Update()
        {
            if (target != null)
            {
                agent.SetDestination(target.position);
            }
        }
    }



