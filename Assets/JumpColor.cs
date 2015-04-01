using UnityEngine;
using System.Collections;

public class JumpColor : MonoBehaviour
{
    Color one;
    Color two;
   
    int rand;
    int xP = 1;
    int yP = 1;
    int zP = 1;
    //float count = 0;
    // Use this for initialization
    void Start()
    {
        /*for (int i = 1; i < 11; i++) {
            if (i % 2 != 0) {
				
                iTween.MoveAdd (gameObject, iTween.Hash ("x", -1, "y",5, "time", 2, "easetype", iTween.EaseType.linear, "delay", count));
                iTween.ScaleTo (gameObject, iTween.Hash ("x", 1.5, "y", 1.5, "z", 1.5, "easetype", iTween.EaseType.easeInOutBounce, "delay", count));

            }
            else {
                iTween.MoveAdd (gameObject, iTween.Hash ("x", -1, "y", -5, "time", 2, "easetype", iTween.EaseType.linear, "delay", count));
                iTween.ScaleTo (gameObject, iTween.Hash ("x", 0.5, "y", 0.5, "z", 0.5, "easetype", iTween.EaseType.easeInOutBounce, "delay", count));
            }
            iTween.ColorTo (gameObject, iTween.Hash ("r", Random.Range (0, 0.255f), "g", Random.Range (0, 0.255f), "b", Random.Range (0, 0.255f), "time", 2, "easetype", iTween.EaseType.linear, "delay", count));
            count += 2;
        }*/
    }
    void OnMouseDown()
    {
        /*if (Input.GetMouseButton(0))
        {
            string s = gameObject.name;
            int x = int.Parse(s.Substring(6, 2));
            int y = int.Parse(s.Substring(9, 2));

            one = Grid.cub[x, y].GetComponent<MeshRenderer>().material.color;
            Debug.Log(x + " " + y + " one");
            if (Input.GetMouseButton(0))
            {
                string m = gameObject.name;
                int a = int.Parse(m.Substring(6, 2));
                int b = int.Parse(m.Substring(9, 2));
                two = Grid.cub[a, b].GetComponent<MeshRenderer>().material.color;
                Debug.Log(x + " " + y + " two");
                Grid.cub[x, y].GetComponent<MeshRenderer>().material.color = two;
                Grid.cub[a, b].GetComponent<MeshRenderer>().material.color = one;
            }
        }*/

        /*int k = Random.Range (1, 4);
        for (int i = 0; i < k; i++) {		
            GameObject first = (GameObject)Instantiate (gameObject);
            iTween.MoveAdd (first, iTween.Hash ("x", Random.Range(0, 3), "y", Random.Range(0, 3), "z", Random.Range(0, 3), "time", 2, "easetype", iTween.EaseType.linear));
            rand = Random.Range(1, 4);
            switch (rand) {
            case 1:
                iTween.ScaleTo (first, iTween.Hash ("x", 1.5, "y", 1.5, "z", 1.5, "easetype", iTween.EaseType.easeInOutBounce));
                break;
            case 2:
                iTween.ColorTo (first, iTween.Hash ("r", Random.Range (0, 0.255f), "g", Random.Range (0, 0.255f), "b", Random.Range (0, 0.255f), "time", 2, "easetype", iTween.EaseType.linear));
                break;
            case 3:
                iTween.RotateTo (first, iTween.Hash ("x", 180, "y", 180, "time", 2, "easetype", iTween.EaseType.linear));
                break;
            }
	
        }*/

        for (int i = 0; i < 3; i++) {
            yP = 1;
            for (int q = 0; q < 3; q++) {
                zP = 1;
                for (int j = 0; j < 3; j++) {
                    iTween.MoveAdd (Grid.cub[i, q, j], iTween.Hash ("x", Random.Range(-100, 100), "y", Random.Range(0, 100), "z", Random.Range(-100, 100), "time", 10, "easetype", iTween.EaseType.linear));
                    //iTween.ColorTo (Grid.cub[i, q, j], iTween.Hash ("r", Random.Range (0, 0.255f), "g", Random.Range (0, 0.255f), "b", Random.Range (0, 0.255f), "time", 2, "easetype", iTween.EaseType.easeInOutBounce));
                }
                yP++;
            }
            xP++;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
