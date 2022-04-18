using UnityEngine;

public class Gun : MonoBehaviour
{

	public float demage = 1f;
	public float range = 100f;

	public Camera fpsCam;
	
	void Update () {

		if (Input.GetButton("Fire1"))
		{
			RaycastHit hit;
			if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
			{
				Debug.Log(hit.transform.name);

				Target target = hit.transform.GetComponent<Target>();
				if(target != null)
                {
					target.TakeDemage(demage);
                }
			}
		}
		
	}
}
