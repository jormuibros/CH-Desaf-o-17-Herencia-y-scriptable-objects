using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="SkeletonData", menuName="Skeleton Data")]
public class SkeletonData : ScriptableObject
{
    [SerializeField] private string skeletonName;
    [SerializeField] private int hp;
    [SerializeField] private float distanceRay;
    [SerializeField] private int damage;

    [SerializeField] private float Speed;

    [SerializeField] private float RangeOfView =10f;

    [SerializeField] private float minmunDistance;

    [SerializeField] private float rotationSpeed;
   public string skeletoName { 
        get
        {
            return skeletonName;
        } 
    }

    public int HP
    {
        get
        {
            return hp;
        }
    }

    public float SpeeD
    {
        get
        {
            return Speed;
        }
    }

    public float RangeofView
    {
        get
        {
            return RangeOfView;
        }
    }
      public float minimunDistance
    {
        get
        {
            return minmunDistance;
        }
    }

      public float rotatioNSpeed
    {
        get
        {
            return rotationSpeed;
        }
    }

}
