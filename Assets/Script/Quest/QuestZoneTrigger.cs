using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Quest
{
    public class QuestZoneTrigger : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Enter By: " + other.tag);
            Debug.Log("Enter By: " + other);

        }

        private void OnTriggerExit(Collider other)
        {
            Debug.Log("Exit By: " + other.tag);
        }
    }
}
