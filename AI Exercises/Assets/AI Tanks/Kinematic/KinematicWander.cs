using UnityEngine;
using System.Collections;

public class KinematicWander : MonoBehaviour {

	public float max_angle = 0.5f;
    public float timer_factor = 2.0f;
    private float timer;
    private float angle;


    Move move;

	// Use this for initialization
	void Start () {
		move = GetComponent<Move>();
        timer = RandomBinominal() * timer_factor;
        angle = RandomBinominal() * max_angle;

    }

	// number [-1,1] values around 0 more likely
	float RandomBinominal()
	{
        return Random.value * Random.value;
	}
	
	// Update is called once per frame
	void Update () 
	{
        // TODO 9: Generate a velocity vector in a random rotation (use RandomBinominal) and some attenuation factor
       
        Vector3 velocity = Quaternion.AngleAxis(Mathf.Rad2Deg * angle, Vector3.up) * Vector3.forward;
        velocity *= move.max_mov_velocity;

        move.SetMovementVelocity(velocity);

        if (timer <= 0)
        {
            angle = RandomBinominal() * max_angle;
            timer = RandomBinominal() * timer_factor;

        }

        timer -= Time.deltaTime;
    }
}
