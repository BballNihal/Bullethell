using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot1 : MonoBehaviour
{
    [SerializeField]
    int numberOfProjectiles;

    [SerializeField]
    GameObject projectile;
    public Vector2 startPoint;
    public float radius;
    public float moveSpeed;
    public float Cooldown = 3f;
    public float CooldownCountdown = 0f;

    // Start is called before the first frame update
    void Start()
    {
      
    }
    void Update()
    {
        startPoint = new Vector2(transform.position.x, transform.position.y);
         if (CooldownCountdown < 0f)
        {
            CooldownCountdown = Cooldown;
            SpawnProjectiles (numberOfProjectiles);
        }
    else
        {
            //Countdown the timer with the time past in the last frame
            CooldownCountdown -= Time.deltaTime;
        }
    }

    // Update is called once per frame
   void SpawnProjectiles(int numberOfProjectiles)
	{
		float angleStep = 60f / numberOfProjectiles;
		float angle = -20f;

		for (int i = 0; i <= numberOfProjectiles - 1; i++) {
			
			float projectileDirXposition = startPoint.x + Mathf.Sin ((angle * Mathf.PI) / 180) * radius;
			float projectileDirYposition = startPoint.y + Mathf.Cos ((angle * Mathf.PI) / 180) * radius;

			Vector2 projectileVector = new Vector2 (projectileDirXposition, projectileDirYposition);
			Vector2 projectileMoveDirection = (projectileVector - startPoint).normalized * moveSpeed;

			var proj = Instantiate (projectile, startPoint, Quaternion.identity);
			proj.GetComponent<Rigidbody2D> ().velocity = 
				new Vector2 (projectileMoveDirection.x, projectileMoveDirection.y);

			angle += angleStep;
		}
    }
}
