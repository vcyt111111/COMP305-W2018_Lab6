using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Num1Press")]
public class Num1PressDecision : Decision
{
    public override bool Decide(EnemyStateController controller)
    {
        return Num1(controller);
    }

    private bool Num1(EnemyStateController controller)
    {
        if (Input.GetKey(KeyCode.Alpha1))
            return true;
        else return false;
 
    }
}
