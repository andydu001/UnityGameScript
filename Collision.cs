 /*
  * 
  * This program control keyboard event input 
  * 
  */
using UnityEngine;

public class Collision : MonoBehaviour
{
    private JumpByAndyD byAndyD;
    private GameObject game;
    private CharacterController character;
    // Start is called before the first frame update
    void Start()
    {
        //here we creating an object of type JumpByAndyD and we're getting our references.
         byAndyD = new JumpByAndyD();
         game = GameObject.Find("cube");
         character = game.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //in this section we make a call to MakeControl(character, game, vector3)
        if (game != null)
        {

             if (Input.GetKey(KeyCode.M))
            {

                game.transform.Translate(Vector3.down, Space.Self);

            }

            
            else if (Input.GetKey(KeyCode.E))
            {

                game.transform.Translate(Vector3.right, Space.Self);

            }

            else if (Input.GetKey(KeyCode.J))
            {
     
                if (character  != null)
                {
                    
                    byAndyD.MakeControl(character, game, new Vector3(0,0,-1));
                    
                        

                }
            }


            else if (Input.GetKey(KeyCode.G))
            {

                if (character != null)
                {

                    byAndyD.MakeControl(character, game, Vector3.forward);

                   

                }
            }

            else if (Input.GetKey(KeyCode.H))
            {

                if (character != null)
                {

                    byAndyD.MakeControl(character, game, Vector3.left);



                }
            }
            else if (Input.GetKey(KeyCode.K))
            {

                if (character != null)
                {

                    byAndyD.MakeControl(character, game, Vector3.right);



                }
            }
        }
    }
}
