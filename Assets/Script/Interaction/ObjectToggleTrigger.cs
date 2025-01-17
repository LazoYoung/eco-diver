using UnityEngine;
namespace Script.Interaction
{
    public class ObjectToggleTrigger : MonoBehaviour
    {
        [SerializeField] [Header("Debug")] private bool debugMode;

        [SerializeField]
        [Tooltip("Default state(No Enter)'s Object's mode. If true, the object will be enable by default.")]
        private bool isDefaultDisabled = true;

        [SerializeField] [Tooltip("ObjectDisabler script to disable objects.")]
        private Disabler disabler;

        private void Start()
        {
            Reset();
        }

        private void OnDisable()
        {
            Reset();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (debugMode)
            {
                Debug.Log("Enter Object: " + other.tag);
            }
            if (!other.CompareTag("Player"))
            {
                return;
            }
            Enter();
        }

        private void OnTriggerExit(Collider other)
        {
            if (debugMode)
            {
                Debug.Log("Exit Object: " + other.tag);
            }
            // Check if the exiting object has the tag "Player"
            if (other.CompareTag("Player"))
            {
                Reset();
            }
        }

        private void Enter()
        {
            if (debugMode)
            {
                Debug.Log("ObjectToggleTrigger: Enter");
            }
            if (isDefaultDisabled)
            {
                enableObjects();
            }
            else
            {
                disableObjects();
            }
        }

        private void Reset()
        {
            if (isDefaultDisabled)
            {
                disableObjects();
            }
            else
            {
                enableObjects();
            }
        }

        private void enableObjects()
        {
            disabler.Enable(debugMode);
        }

        private void disableObjects()
        {
            disabler.Disable(debugMode);
        }
    }
}
