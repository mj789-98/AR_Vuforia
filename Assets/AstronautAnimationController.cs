using UnityEngine;

public class AstronautAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        // Assuming your idle animation state has an Exit Time condition, or alternatively:
        // You can use an Animation Event at the end of your idle animation to call TriggerWave.
    }

    void Update()
    {
        // Check if the Idle state animation is about to finish
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (stateInfo.IsName("astronaut-idle") && stateInfo.normalizedTime >= 0.99f)
        {
            TriggerWave();
        }
    }

    void TriggerWave()
    {
        animator.SetBool("isWaving", true);
    }
}
