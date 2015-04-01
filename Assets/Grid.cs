using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {
	public Color[] Col = new Color[3];
	int k;
	public GameObject Cube;
	int xP = 0;
	int yP = 0;
	int zP = 0;
	static public GameObject [,,] cub = new GameObject[3,3,3];
	// Use this for initialization
	void Start () {

	for (int i = 0; i < 3; i++) {
			yP = 0;
			for (int q = 0; q < 3; q++) {
				zP = 0;
				for (int j = 0; j < 3; j++) {
					GameObject Cub = (GameObject)Instantiate(Cube);
					Cub.transform.position = new Vector3(Cub.transform.position.x + xP, Cub.transform.position.y + yP, Cub.transform.position.z + zP);
					//Cub.GetComponent<MeshRenderer>().material.color = new Color (Random.Range (0, 0.255f), Random.Range (0, 0.255f), Random.Range (0, 0.255f));
					cub [i, q, j] = Cub;
					zP++;
				}
				yP++;
			}
			xP++;
		}

			/*for (int q = 0; q < 5; q++) {
				zP = 0;
				for (int j = 0; j < 5; j++) {
				k = Random.Range(0, 3);
					GameObject Cub = (GameObject)Instantiate(Cube);
					Cub.transform.position = new Vector3(Cub.transform.position.x + zP, Cub.transform.position.y + yP, Cub.transform.position.z);
					Cub.GetComponent<MeshRenderer>().material.color = Col[k];
                    Cub.transform.name = "square" + string.Format("{0:D2}", q) + " " + string.Format("{0:D2}", j);
					cub [q, j] = Cub;
					zP++;
				}
				yP++;

		}*/

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
