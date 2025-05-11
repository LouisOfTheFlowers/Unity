using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public Projectile laserPrefab;
    private bool laserActive;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            shoot();
        }

    }
    private void shoot()
    {
        if (!laserActive)
        {
           Projectile projectile =  Instantiate(this.laserPrefab, this.transform.position, Quaternion.identity);
            projectile.destroyed += laserDestroyed;
            laserActive = true;
        }
        
    }
    private void laserDestroyed()
    {
        laserActive = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Invader") || other.gameObject.layer == LayerMask.NameToLayer("Missile"))
        {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}