﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour, IObserver
{
    public Image healthBar;
    
    public void onNotify(MyEvent _event)
    {
        switch(_event.myType)
        {
            case MyEvent.EventType.damageDone:
                ProcessDamage(_event.sender);
                break;
        }
    }

    private void ProcessDamage(Subject player)
    {
        float maxHealth = player.GetComponent<PlayerController>().MaxHealth;
        float currentHealth = player.GetComponent<PlayerController>().CurrentHealth;
        healthBar.fillAmount = currentHealth / maxHealth;
    }
}