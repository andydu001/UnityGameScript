/*
 * 
 * This program control a first person characrter including its speed,
 * smoothness,direction,and velocity.
 * 
 */
using System;
using UnityEditor;
using UnityEngine;

public class JumpByAndyD
{
    private float max_speed = 1500.9f;
    private Vector3 m_vector;
    private float smooth_time;
    private Vector3 current_velocity; 
    private bool smooth = true;
     

    public void MakeControl(CharacterController character, GameObject gameObject, Vector3 vector3)
    {
        if (smooth)
        {
 
            current_velocity = character.velocity;

            smooth_time = (Time.deltaTime * Time.maximumDeltaTime);
           
            m_vector = Vector3.SmoothDamp(new Vector3(gameObject.transform.position.x / 10000, 0 , gameObject.transform.position.z / 10050),
            vector3, ref (current_velocity), smooth_time, max_speed);
 
            character.Move(m_vector);
            //let the camera follow the game object by giving it the same vector move
         
            Camera_move(m_vector); 
          
        }
   }

    /*
     * a camera to move
     * 
     */
    public void Camera_move(Vector3 vect)
    {

        Camera camera = Camera.main;

        if (camera != null)
        {
            
            camera.transform.Translate(vect, Space.Self);

        }

    }


}
