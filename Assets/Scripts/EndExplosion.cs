using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndExplosion : MonoBehaviour
{
    public Animator ExplosionAnimator;
    private void Update()
    {
        if (ExplosionAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !ExplosionAnimator.IsInTransition(0))
        {
            Destroy(gameObject);
        }
    }
}
