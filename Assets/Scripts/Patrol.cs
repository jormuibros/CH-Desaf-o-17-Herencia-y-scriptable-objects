using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    [SerializeField] GameObject Hero;
    [SerializeField] private Animator animEnemy;

    [SerializeField] protected SkeletonData patrolData;
    
    public bool IseeYou = false;
    private bool goBack = false;
    private int currentIndex;

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Vector3.Distance(transform.position, Hero.transform.position) <= patrolData.RangeofView)
        {
            IseeYou = true;                              
        }
        else
        {
            IseeYou = false;
        }

        if(IseeYou)
        {
            ChaseCharacter();
            animEnemy.SetBool("isRun", true);

        }
        else
        {
            MovementPatrol();   
            animEnemy.SetBool("isRun", false);

        }            
    }
    public void  MovementPatrol()
    {
        Vector3 deltaVector = waypoints[currentIndex].position - transform.position;
        Vector3 direction = deltaVector.normalized;
        transform.forward = Vector3.Lerp(transform.forward, direction, patrolData.rotatioNSpeed * Time.deltaTime);
        transform.position += transform.forward * patrolData.SpeeD * Time.deltaTime;
        float distance = deltaVector.magnitude;
        if(distance < patrolData.minimunDistance )
        {
          if(currentIndex >= waypoints.Length -1)
            {
                goBack = true;
            }
            else if( currentIndex <= 0)
            {
                goBack = false;
            }
            if(!goBack)
            {
                currentIndex++;
            }
            else currentIndex--;
        }
        
    }

 
    public virtual void ChaseCharacter()
    {
       // Debug.Log("ENTRO EN AREA");
        Vector3 direction =(Hero.transform.position - transform.position).normalized;
        transform.forward = Vector3.Lerp(transform.forward, direction, patrolData.rotatioNSpeed * Time.deltaTime);
        transform.position += transform.forward * patrolData.SpeeD * Time.deltaTime;
        
    }
    
    public virtual void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
        Debug.Log("Jugador Herido");
        //GameManager.instance.addScore();
        //Debug.Log(GameManager.instance.getScore());
        //Destroy(gameObject);
        }

    }
    public virtual void OnDrawGizmos()
    {
        if(IseeYou == true)
        {
        Gizmos.color = Color.magenta;
        }
        else
        {
            Gizmos.color = Color.cyan;
        }

        Gizmos.DrawWireSphere(transform.position, patrolData.RangeofView);
    }
}
