using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Num3")]
public class Num3Action : Action {
    private AudioSource audioSource;
    public override void Act(EnemyStateController controller)
    {
        Num3(controller);
    }

    private void Num3(EnemyStateController controller)
    {
        audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        audioSource.PlayDelayed(1f);
    }
}
