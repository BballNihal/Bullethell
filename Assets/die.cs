using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{   
    public float speed;
    [SerializeField]
    int numberOfProjectiles;
    [SerializeField]
    GameObject projectile;
    public Vector2 startPoint;
    public float radius;
    public float moveSpeed;

    IEnumerator fryCoroutine;
    // Start is called before the first frame update
    void Start()
    {
      
        Destroy(gameObject,1.5f);
        fryCoroutine = fry();
        StartCoroutine(fryCoroutine);
    }

    IEnumerator fry()
    {
        yield return new WaitForSeconds(1.4f);
                    GetComponent<Rigidbody2D>().velocity = transform.right * speed * 0f;
                    float angleStep = 360f / numberOfProjectiles;
		            float angle = 0f;

	                for (int i = 0; i <= numberOfProjectiles - 1; i++) 
                        {	
			                float projectileDirXposition = startPoint.x + Mathf.Sin ((angle * Mathf.PI) / 180) * radius;
                            float projectileDirYposition = startPoint.y + Mathf.Cos ((angle * Mathf.PI) / 180) * radius;

                            Vector2 projectileVector = new Vector2 (projectileDirXposition, projectileDirYposition);
                            Vector2 projectileMoveDirection = (projectileVector - startPoint).normalized * moveSpeed;

                            var proj = Instantiate (projectile, transform.position, Quaternion.identity);
                            proj.GetComponent<Rigidbody2D> ().velocity = new Vector2 (projectileMoveDirection.x, projectileMoveDirection.y);

                            angle += angleStep;
                        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
