using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Num2")]
public class Num2Action : Action {
    private AudioSource audioSource;
    public override void Act(EnemyStateController controller)
    {
        Num2(controller);
    }

    private void Num2(EnemyStateController controller)
    {
        audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        audioSource.pitch = 4;
    }
}
