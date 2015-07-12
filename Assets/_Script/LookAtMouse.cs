using UnityEngine;
using System.Collections;

public class LookAtMouse : MonoBehaviour {

	Animator animator;
	public Transform butterFly;


	void Start () {
		animator = GetComponent<Animator>();
		animator.SetLookAtWeight(1, 0.1f, 0.8f, 0.9f);
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit)) {
			print (hit.point);
            butterFly.position = hit.point;
			animator.SetLookAtWeight(1, 0.1f, 0.8f, 0.9f);
            animator.SetLookAtPosition(hit.point);
		}
        butterFly.LookAt(transform);
	}
}
