using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthComponent : HealthComponent
{
    [SerializeField] private PlayerHealthUI ui;
    private void Start()
    {
        ui.UpdateUI(currenthealth);
    }
    protected override void Death()
    {
        base.Death();
        print("Loading Level");
    }
    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();
        //update levens
        ui.UpdateUI(currenthealth);
    }
}