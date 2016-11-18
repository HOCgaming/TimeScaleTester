using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.ImageEffects;

public class SpheresController : MonoBehaviour {

    public GameObject[] spheres;
    //public Camera firstPersonCamera;
    //public VignetteAndChromaticAberration vignette;
    public List<GameObject> bullets = new List<GameObject>();
    public Vector3 aimTowards = new Vector3(0, 1.8f, 0);
    public float slowTime = 0.1f, timeLimit = 0;
    public bool gameOver = false;

    private const int FORCE_MULTIPLIER = 100, FOV_TARGET = 110;
    
	void Start () {

        for (int i = 0; i < spheres.Length; i++)
        {
            GameObject bullet = Instantiate((GameObject)Resources.Load("Prefabs\\Bullet"));
            bullets.Add(bullet);

            bullet.transform.position = spheres[i].transform.position - ((spheres[i].transform.position / Vector3.Magnitude(spheres[i].transform.position)) * (spheres[i].transform.localScale.x));
            bullet.transform.forward = aimTowards - spheres[i].transform.position;

            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * FORCE_MULTIPLIER * bullet.GetComponent<Rigidbody>().mass);
            
        }
	    
	}
	
	void Update () {

        if(timeLimit >= 1)
        {
            gameOver = true;
        }

        if (Input.GetKeyDown(KeyCode.E) && !gameOver) {
            Time.timeScale = slowTime;
        }
        if (Input.GetKeyUp(KeyCode.E) && !gameOver) {
            Time.timeScale = 1;
        }

     /*   if (Input.GetKey(KeyCode.E) && !gameOver)
        {
            timeLimit += 0.5f * Time.deltaTime;
            vignette.intensity = Mathf.Lerp(0, 1, timeLimit);
            firstPersonCamera.fieldOfView = Mathf.Lerp(80, FOV_TARGET, timeLimit);
        }
        else if (timeLimit > 0 && !gameOver)
        {
            timeLimit -= Time.deltaTime;
            vignette.intensity = Mathf.Lerp(0, 1, timeLimit);
            firstPersonCamera.fieldOfView = Mathf.Lerp(80, FOV_TARGET, timeLimit);
        } */
	
	}
}

public class SpheresController : MonoBehaviour {

    public GameObject[] spheres;
    public Camera firstPersonCamera;
    public VignetteAndChromaticAberration vignette;
    public List<GameObject> bullets = new List<GameObject>();
    public Vector3 aimTowards = new Vector3(0, 1.8f, 0);
    public float slowTime = 0.1f, timeLimit = 0;
    public bool gameOver = false;

    private const int FORCE_MULTIPLIER = 100, FOV_TARGET = 110;
    
	void Start () {

        for (int i = 0; i < spheres.Length; i++)
        {
            GameObject bullet = Instantiate((GameObject)Resources.Load("Prefabs\\Bullet"));
            bullets.Add(bullet);

            bullet.transform.position = spheres[i].transform.position - ((spheres[i].transform.position / Vector3.Magnitude(spheres[i].transform.position)) * (spheres[i].transform.localScale.x));
            bullet.transform.forward = aimTowards - spheres[i].transform.position;

            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * FORCE_MULTIPLIER * bullet.GetComponent<Rigidbody>().mass);
            
        }
	    
	}
	
	void Update () {

        if(timeLimit >= 1)
        {
            gameOver = true;
        }

        if (Input.GetKeyDown(KeyCode.E) && !gameOver) {
            Time.timeScale = slowTime;
        }
        if (Input.GetKeyUp(KeyCode.E) && !gameOver) {
            Time.timeScale = 1;
        }

        if (Input.GetKey(KeyCode.E) && !gameOver)
        {
            timeLimit += 0.5f * Time.deltaTime;
            vignette.intensity = Mathf.Lerp(0, 1, timeLimit);
            firstPersonCamera.fieldOfView = Mathf.Lerp(80, FOV_TARGET, timeLimit);
        }
        else if (timeLimit > 0 && !gameOver)
        {
            timeLimit -= Time.deltaTime;
            vignette.intensity = Mathf.Lerp(0, 1, timeLimit);
            firstPersonCamera.fieldOfView = Mathf.Lerp(80, FOV_TARGET, timeLimit);
        }
	
	}


}
