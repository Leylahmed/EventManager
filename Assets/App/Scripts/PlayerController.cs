using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DynamicBox.EventManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private AreaController areaController;

    private void Start()
    {
        AreaController.evnt += Test;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        EventManager.Instance.Raise(new PlayerIsInsideEvent(true));
    }

    private void OnTriggerExit(Collider other)
    {
        EventManager.Instance.Raise(new PlayerIsInsideEvent(false));

    }

    private void Test()
    {

    }
}
