using System;
using UnityEngine;

public class InteractObject : MonoBehaviour
{

    private bool _isInteractable = false;

    private InteractObjectInteraction interaction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _isInteractable)
        {
            Debug.Log("Interact ");
            interaction.Interact();

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tag " + other.gameObject.tag);
        if (other.gameObject.CompareTag("Interactable"))
        {
            other.gameObject.GetComponent<Outline>().enabled = true;
            interaction = other.gameObject.GetComponent<InteractObjectInteraction>();
            Debug.Log("interaction" + interaction.ToString());
            _isInteractable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Tag " + other.gameObject.tag);
        if (other.gameObject.CompareTag("Interactable"))
        {
            other.gameObject.GetComponent<Outline>().enabled = false;
            interaction = null;
            _isInteractable = false;
        }
    }
}
