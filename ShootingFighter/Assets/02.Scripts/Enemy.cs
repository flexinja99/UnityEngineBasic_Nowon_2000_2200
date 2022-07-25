using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    private float _hp;
    public float hp
    {
        set
        {
            if (value < 0)
                value = 0;

            _hp = value;
            if (_hp <= 0)
            {
                Destroy(gameObject);
            }     
        }
        get
        {
            return _hp;
        }
    }

    public float hpMax;
    public Slider hpbar;

    public float score;
    [SerializeField] private float moveSpeed;

    private void Awake()
    {
        hp = hpMax;
    }

    private void FixedUpdate()
    {
        Vector3 deltaMove = Vector3.back * moveSpeed * Time.deltaTime;
        transform.Translate(deltaMove);
    }
}
