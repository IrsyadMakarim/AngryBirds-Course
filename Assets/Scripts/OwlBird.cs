using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlBird : Bird
{
    public GameObject Explosion;
    private bool _hasExploded = false;
    private void Update()
    {
        if(_hasExploded == true)
        {
            Destroy(gameObject);
        }
    }

    public void Explode()
    {
        if (State == BirdState.Thrown && !_hasExploded)
        {
            Instantiate(Explosion, transform.position, Quaternion.identity);
            _hasExploded = true;
        }
    }

    public override void OnTap()
    {
        Explode();
    }
}
