using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Num3Press")]
public class Num3PressDecision : Decision
{
    public override bool Decide(EnemyStateController controller)
    {
        return Num3(controller);
    }

    private bool Num3(EnemyStateController controller)
    {
        if (Input.GetKey(KeyCode.Alpha3))
            return true;
        else return false;
 
    }
}
