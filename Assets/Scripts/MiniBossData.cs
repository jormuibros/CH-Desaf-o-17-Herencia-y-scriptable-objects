using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="MiniBossData", menuName="MiniBoss Data")]
public class MiniBossData : ScriptableObject
{
[SerializeField] private string minibossName;
    [SerializeField] private int hp;
    [SerializeField] private float distanceRay;
    [SerializeField] private int damage;

    [SerializeField] private float Speed;

    [SerializeField] private float RangeOfView =10f;

    [SerializeField] private float minmunDistance;

    [SerializeField] private float rotationSpeed;

    [SerializeField] private float shield;

    
   public string miniBossName { 
        get
        {
            return minibossName;
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

       public float Shield
    {
        get
        {
            return shield;
        }
    }

}
