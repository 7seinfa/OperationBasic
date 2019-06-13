using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	//Speed at which camera moves
	public float speed;
	public float speed_increase;
	public int Increase;
	public Ball ball;

	int oldPoints;

	void Start(){
		oldPoints = 0;
	}

	//Every frame, move camera up by speed
	void FixedUpdate(){
		transform.position += new Vector3(0, speed, 0);
		if (ball.points % Increase == 0 && ball.points > oldPoints) {
			speed += speed_increase;
			oldPoints = ball.points;
		}
	}
}
