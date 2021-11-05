using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DynamicBox.EventManagement;
using System;

public class AreaController : MonoBehaviour
{
    [SerializeField] private Renderer renderer;
    [SerializeField] private Color greenColor;
    [SerializeField] private Color redColor;

    public static event Action evnt;



    private void OnEnable()
    {
        EventManager.Instance.AddListener<PlayerIsInsideEvent>(PlayerIsInsideEventHandler);
    }

    private void OnDisable()
    {
        EventManager.Instance.RemoveListener<PlayerIsInsideEvent>(PlayerIsInsideEventHandler);
    }

    private void Start()
    {
        renderer = GetComponent<Renderer>();

        evnt.Invoke();
    }

    private void PlayerIsInsideEventHandler(PlayerIsInsideEvent eventDetails)
    {
        if(eventDetails .IsPlayerInside)
        {
            renderer.material.SetColor("_Color", greenColor);
        }
        else
        {
            renderer.material.SetColor("_Color", redColor);
        }
    }
}
