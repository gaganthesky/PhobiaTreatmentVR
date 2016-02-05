using UnityEngine;
using System.Collections;
namespace CompleteProject
{
    public class OutlineEnemySnake : MonoBehaviour
    {

        GameObject Test_Obj;
        Component ObjMoveComp;
        RaycastHit hit;

        void Awake()
        {
            //Test_Obj = GameObject.FindGameObjectWithTag("Enemy");
            //ObjMoveComp = Test_Obj.GetComponent<EnemyMovementSnake>();
        }

        void Update()
        {
            var fwd = transform.TransformDirection(Vector3.forward);
            Ray temp = new Ray(transform.position, fwd);
            if (Physics.Raycast(temp, out hit))
            {
                if (hit.collider.gameObject.tag == "Enemy")
                {



                    hit.transform.GetComponent<EnemyMovementSnake>().isHighlighted = true;
                    //SkinnedMeshRenderer temp2 = hit.collider.gameObject.GetComponentInChildren<SkinnedMeshRenderer> ();
                    //temp2.material = highlightMat;

                }

                //else
                //{
                //    if (!Test_Obj)
                //        print("enemy tagged object not found");
                //    if (!ObjMoveComp)
                //        print("EnemyMovementSnake not found");
                //    //GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyMovementSnake>().isHighlighted = false;
                //    //GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
                //    //for (int i = 0; i < enemies.Length; i++)
                //    //{
                //    //    enemies[i].GetComponent<EnemyMovementSnake>().isHighlighted = false;
                //    //}
                //    //hit.collider.gameObject.renderer.material.shader = Shader.Find("Diffuse");
                //}
            }
        }


    }
}