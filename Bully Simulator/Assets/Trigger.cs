using Unity.VisualScripting;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public void Start()
    {
        mugPrompt.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("You Mugged Them");
        }
    }
    public GameObject mugPrompt;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
        mugPrompt.SetActive(true);
            if (Input.GetKeyDown(KeyCode.M))
            {
                Debug.Log("You Mugged Them");
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mugPrompt.SetActive(false);
        }
    }
}


