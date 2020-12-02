using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWalk : StateMachineBehaviour
{
    public float speed = 2f;
    Transform player;
    Rigidbody2D rb;
    BossFlip bossflip;
    public float range = 2f;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Pepsi").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        bossflip = animator.GetComponent<BossFlip>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        bossflip.FollowPlayer();

        Vector2 target = new Vector2(player.position.x, rb.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
        rb.MovePosition(newPos);

        if (Vector2.Distance(player.position, rb.position) <= 6f)
        {
            animator.SetTrigger("Attack");
            Vector2 newPos1 = Vector2.MoveTowards(rb.position, target, 6 * Time.fixedDeltaTime);
            rb.MovePosition(newPos1);
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
    }
}
