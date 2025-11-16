using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Accesses Rigidbody component
    private Rigidbody playerRb;
    private Animator playerAnim;
    private AudioSource playerAudio;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public float jumpForce = 10.0f;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        //Physics.gravity *= gravityModifier;
        Physics.gravity = new Vector3(0, -9.81f * gravityModifier, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Triggers when spacebar is pressed and the player is on the ground
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            // Player jumps and is no longer on the ground
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Sets player status to back on the ground via colliders 
            isOnGround = true;
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            explosionParticle.Play();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            dirtParticle.Stop();
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }

    }
}
