using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoosterPositions : MonoBehaviour
{
    public List<Vector3> positions;
    public List<Vector3> rotations;

    private int currentPos = 0;

    private Animator animator;
    private CapsuleCollider capsuleCollider;

    private bool gotHit;
    private double gotHitTimer;

    void Start()
    {
        animator = GetComponent<Animator>();
        capsuleCollider = GetComponent<CapsuleCollider>();


        //initial position
        ChangePosition(currentPos);

        //set Score 0;
        ScoreSystem.Instance.ResetScore();
    }

    private void Update()
    {
        if(gotHit)
        {
            if(gotHitTimer > 0.5) //cooldown to go back to normal
            {
                SetGotHit(false);
            }
            gotHitTimer += Time.deltaTime;
        }    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hit")
        {
            currentPos++;
            if(currentPos <= positions.Count - 1) //not gameOver
            {
                ChangePosition(currentPos);
                SoundManager.Instance.PlaySFX("getHit");

                //can't collide for a few seconds and get hit animation
                SetGotHit(true);

                //disable score collision box for that obstacle and collision in general.
                other.gameObject.transform.Find("CollisionBox").GetComponent<BoxCollider>().enabled = false;
                other.GetComponent<BoxCollider>().enabled = false;
            }
            else
            {
                //game Over
                SceneManager.LoadScene(2);//restart scene.
            }

        }
        if (other.tag == "Score")
        {
            ScoreSystem.Instance.Score();
        }
    }
 
    private void ChangePosition(int index)
    {
        transform.position = positions[index];
        transform.eulerAngles = rotations[index];
    }

    private void SetGotHit(bool status)
    {
        animator.SetBool("gotHit", status);
        gotHit = status;
        gotHitTimer = 0;
        capsuleCollider.isTrigger = !status;
    }
}
