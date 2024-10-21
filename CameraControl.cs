/*
 * script that controls the camera
 * 
 * 
 */
using UnityEngine;

public class CameraControl : MonoBehaviour 
{
    [SerializeField] private bool m_rolling;
    //int working = 0;

    // Start is called before the first frame update
    void Start()
    {
          

    }

    // Update is called once per frame
    void Update()
    {
        Camera camera = Camera.main;
        
        if (camera != null)
        {
            camera.backgroundColor = Color.white;
          
            Kecode_(camera);
      
        }

        
       
    }
    

   void Kecode_(Camera camera)

    {

 
        
        if (Input.GetKey(KeyCode.UpArrow))
        {

            camera.transform.Translate(Vector3.forward, Space.Self);


        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {

            camera.transform.Translate(Vector3.back, Space.Self);

        }

        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.B))
        {

            camera.transform.Translate(Vector3.left, Space.Self);

        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.C))
        {

            camera.transform.Translate(Vector3.right, Space.Self);

        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.C))
        {

            camera.transform.Translate(Vector3.up, Space.Self);

        }
        else if (Input.GetKey(KeyCode.V) || Input.GetKey(KeyCode.C))
        {

            camera.transform.Translate(Vector3.down, Space.Self);

        }
    }
}
