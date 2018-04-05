using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Num1")]
public class Num1Action : Action {
    private AudioSource audioSource;
    public override void Act(EnemyStateController controller)
    {
        Num1(controller);
    }

    private void Num1(EnemyStateController controller)
    {
        audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        audioSource.pitch = 2;
    }
}
