using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Num2Press")]
public class Num2PressDecision : Decision
{
    public override bool Decide(EnemyStateController controller)
    {
        return Num2(controller);
    }

    private bool Num2(EnemyStateController controller)
    {
        if (Input.GetKey(KeyCode.Alpha2))
            return true;
        else return false;
 
    }
}
