using UnityEngine;

public class EnemyMovementNew : MonoBehaviour
{
	public float speed = 2f;            // The speed that the player will move at.

	Vector3 movement;                   // The vector to store the direction of the player's movement.
	Animator anim;                      // Reference to the animator component.
	Rigidbody playerRigidbody;          // Reference to the player's rigidbody.
	Transform handsLocation;
	public bool isHighlighted;
	void Awake()
	{

		// Set up references.
		handsLocation = GameObject.FindGameObjectWithTag("Player").transform;
		anim = GetComponent<Animator>();
		playerRigidbody = GetComponent<Rigidbody>();
	}


	void FixedUpdate()
	{
		// Store the input axes.
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");

		// Move the player around the scene.
		Move(h, v);
		Pick();
	}

	void Move(float h, float v)
	{
		// Set the movement vector based on the axis input.
		//movement.Set(h, 0f, v);
		movement.Set(handsLocation.position.x,0,handsLocation.position.z);
		// Normalise the movement vector and make it proportional to the speed per second.
		movement = movement.normalized * speed * Time.deltaTime;

		// Move the player to it's current position plus the movement.
		playerRigidbody.MovePosition(transform.position + movement);
	}
	public void Pick()
	{
		if (isHighlighted)
		{
			print("pick highlighted");
			//rend.material = highlightMat;
		}
		else
		{
			print("not highlighted");
			//rend.material = orig;
		}
	}


}