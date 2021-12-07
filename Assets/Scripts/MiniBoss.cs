using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBoss : Patrol
{
    [SerializeField] protected MiniBossData myData;

    [SerializeField] private GameObject player;

  private Vector3 GetPlayerDirection()
    {
        return player.transform.position - transform.position;
    }

      public override void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
        Debug.Log("I'M GOIN TO EAT YOU!");
        }

    }

    public override void OnDrawGizmos()
    {
        if(IseeYou == true)
        {
        Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.yellow;
        }

        Gizmos.DrawWireSphere(transform.position, myData.RangeofView);
    }

}
