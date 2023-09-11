using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.State
{
    public class ClientState : MonoBehaviour
    {
        private BikeController _bikeController;

        int stand = 0;
        int jump = 0;
        bool duck = false;
        int dive = 0;

        void Start()
        {
            _bikeController = (BikeController)FindObjectOfType(typeof(BikeController));
        }
        void Update()
        {

            if (Input.GetKeyDown("w"))
            {
                _bikeController.Standing();
            }

            if (Input.GetKey("a"))
            {
                _bikeController.Stupid();
            }

            if (Input.GetKeyDown("s"))
            {
                _bikeController.Ducking();
            }
           
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _bikeController.Jumping();

                _bikeController.Standing();
            }


            if (Input.GetKeyDown("e"))
            {
                _bikeController.Diving();
            }

            //super jump
            if(Input.GetKeyDown("q"))
            {
                _bikeController.Color();

                _bikeController.Standing();
            }

            if(Input.GetKey("d"))
            {
                _bikeController.Gone();
            }
        }
    }
}
