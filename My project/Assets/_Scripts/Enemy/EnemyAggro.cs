using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAggro : MonoBehaviour
{
<<<<<<< HEAD
    public bool isAggro;
    public float distanceToAggro;
    [HideInInspector] public Transform playerTransform;
=======

    public bool isAggro;

    public float distanceToAggro;

    [HideInInspector] public Transform playerTransform;

>>>>>>> d61501eb9f13a49e72f606c921b5c9cf4f4cc923
    private EnemyAttack enemyAttack;
    // Start is called before the first frame update
    void Start()
    {
        if (playerTransform == null)
        {
            playerTransform = FindAnyObjectByType<PlayerMovement>().transform;
<<<<<<< HEAD
            enemyAttack = GetComponentInChildren<EnemyAttack>();
            isAggro = false;
        }
=======

            enemyAttack = GetComponentInChildren<EnemyAttack>();

            isAggro = false;
        }

>>>>>>> d61501eb9f13a49e72f606c921b5c9cf4f4cc923
    }

    // Update is called once per frame
    void Update()
    {
        CheckEnemyAggro();
    }
<<<<<<< HEAD
    public void CheckEnemyAggro()
    {
        var dis = Vector3.Distance(transform.position,playerTransform.position);
        if (dis > distanceToAggro)
=======

    public void CheckEnemyAggro()
    {
        var dis = Vector3.Distance(transform.position,playerTransform.position);

        if ( dis < distanceToAggro)
>>>>>>> d61501eb9f13a49e72f606c921b5c9cf4f4cc923
        {
            isAggro = false;
        }
        else
        {
            isAggro = true;
        }
    }
<<<<<<< HEAD
=======

>>>>>>> d61501eb9f13a49e72f606c921b5c9cf4f4cc923
    public void EnemyDamage()
    {
        if (enemyAttack.isAttacking)
        {
            playerTransform.GetComponent<PlayerStats>().PlayerDamage();
        }
    }
}
