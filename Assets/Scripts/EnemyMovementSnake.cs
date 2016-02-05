using UnityEngine;
using System.Collections;
namespace CompleteProject
{
    public class EnemyMovementSnake : MonoBehaviour
    {
        Transform player;               // Reference to the player's position.
        //PlayerHealth playerHealth;      // Reference to the player's health.
        EnemyHealthSnake enemyHealth;        // Reference to this enemy's health.
        NavMeshAgent nav;               // Reference to the nav mesh agent.
        SkinnedMeshRenderer rend;
        public Material highlightMat;
        Material orig;
        public bool isHighlighted = false;

        void Awake()
        {
            // Set up the references.
            player = GameObject.FindGameObjectWithTag("Player").transform;
            //playerHealth = player.GetComponent<PlayerHealth>();
            enemyHealth = GetComponent<EnemyHealthSnake>();
            nav = GetComponent<NavMeshAgent>();
            rend = GetComponentInChildren<SkinnedMeshRenderer>();
            orig = GetComponentInChildren<SkinnedMeshRenderer>().material;
        }


        void Update()
        {
            // If the enemy and the player have health left...
            if (enemyHealth.currentHealth > 0 )//&& playerHealth.currentHealth > 0)
             {
            // ... set the destination of the nav mesh agent to the player.
            nav.SetDestination(player.position);
             }
            // Otherwise...
            else
            {
                // ... disable the nav mesh agent.
                //nav.enabled = false;
                nav.SetDestination(-player.position);
                //nav.SetDestination(-Vector3.up);
            }

            Pick();
        }

        public void Pick()
        {
            if (isHighlighted && !enemyHealth.isDead)
            {
                print("saw enemy!!");
                rend.material = highlightMat;
                isHighlighted = false;
            }
            else
            {
                print("original material" + orig.name);
                rend.material = orig;
            }
        }
    }
}