using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ParticleSystem snakeSpell, aoeSnakeSpell;
    public Transform singleParticlePos, aoeParticlePos;

    Animator animController;
    private void Start()
    {
        animController = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
            animController.SetTrigger("SingleSpell");
        if (Input.GetKeyDown(KeyCode.Q))
            animController.SetTrigger("AOESpell");
    }

    public void SingleSnakeSpell()
    {
        Destroy(Instantiate(snakeSpell.gameObject, singleParticlePos.position, singleParticlePos.rotation).GetComponent<ParticleSystem>(), 8);
    }

    public void AOESnakeSpell()
    {
        Destroy(Instantiate(aoeSnakeSpell.gameObject, aoeParticlePos.position, aoeParticlePos.rotation).GetComponent<ParticleSystem>(), 8);
    }

}
