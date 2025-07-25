using UnityEngine;
using System.Collections;

namespace Embers
{
	public class CameraController : MonoBehaviour
	{

		private GameObject player;
		private Vector3 offset;

		// Use this for initialization
		void Start()
		{
			//Calculate and store the offset value by getting the distance between the player's position and camera's position.
			player = GameObject.Find("Player");
			offset = transform.position - player.transform.position;
		}

		// LateUpdate is called after Update each frame
		void LateUpdate()
		{
			// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
			transform.position = player.transform.position + offset;
		}
	}
}