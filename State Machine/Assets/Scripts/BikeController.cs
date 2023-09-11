using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.State
{
    public interface HeroineState
    {
        void Handle(BikeController controller);
    }


    public class BikeStateContext
    {
        public HeroineState CurrentState
        {
            get; set;
        }
        private readonly BikeController _bikeController;
        public BikeStateContext(BikeController bikeController)
        {
            _bikeController = bikeController;
        }
        public void Transition()
        {
            CurrentState.Handle(_bikeController);
        }
        public void Transition(HeroineState state)
        {
            CurrentState = state;
            CurrentState.Handle(_bikeController);
        }
    }

    public class BikeController : MonoBehaviour
    {

        private HeroineState
            _standingState, _duckingState, _jumpingState, _divingState, _goneState, _colorState, _stupidState;
        private BikeStateContext _bikeStateContext;
        private void Start()
        {
            _bikeStateContext = new BikeStateContext(this);
            _standingState = gameObject.AddComponent<StandingState>();
            _duckingState = gameObject.AddComponent<DuckingState>();
            _jumpingState = gameObject.AddComponent<JumpingState>();
            _divingState = gameObject.AddComponent<DivingState>();
            _goneState = gameObject.AddComponent<GoneState>();
            _colorState = gameObject.AddComponent<ColorState>();
            _stupidState = gameObject.AddComponent<StupidState>();
            _bikeStateContext.Transition(_standingState);

        }
        public void Standing()
        {
            _bikeStateContext.Transition(_standingState);
        }
        public void Ducking()
        {
            _bikeStateContext.Transition(_duckingState);
        }
        public void Jumping()
        {
            _bikeStateContext.Transition(_jumpingState);
        }
        public void Diving()
        {
            _bikeStateContext.Transition(_divingState);
        }
        public void Color()
        {
            _bikeStateContext.Transition(_colorState);
        }
        public void Gone()
        {
            _bikeStateContext.Transition(_goneState);
        }
        public void Stupid()
        {
            _bikeStateContext.Transition(_stupidState);
        }
    }

    public class DuckingState : MonoBehaviour, HeroineState
    {
        private BikeController _bikeController;
        public void Handle(BikeController bikeController)
        {
            if (!_bikeController)
                _bikeController = bikeController;

            gameObject.transform.localScale = new Vector3(2, 1, 2);
        }
    }
    public class StupidState : MonoBehaviour, HeroineState
    {
        private BikeController _bikeController;
        public void Handle(BikeController bikeController)
        {
            if (!_bikeController)
                _bikeController = bikeController;

            gameObject.transform.localScale = new Vector3(6, 0, 0);
        }
    }
    public class StandingState : MonoBehaviour, HeroineState
    {
        private BikeController _bikeController;
        public void Handle(BikeController bikeController)
        {
            if (!_bikeController)
                _bikeController = bikeController;

            gameObject.transform.localScale = new Vector3(2, 2, 2);

        }

    }

    public class JumpingState : MonoBehaviour, HeroineState
    {
        public Vector3 jump;
        public float jumpForce = 2.0f;
        public bool isGrounded;
        Rigidbody rb;

        private BikeController _bikeController;

        public void Handle(BikeController bikeController)
        {
            if (!_bikeController)
                _bikeController = bikeController;

            rb = GetComponent<Rigidbody>();
            jump = new Vector3(0.0f, 5.0f, 0.0f);

            void OnCollisionStay()
            {
                isGrounded = true;
            }

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;

        }
    }

        public class DivingState : MonoBehaviour, HeroineState
        {
            public Vector3 jump;
            public float jumpForce = 2.0f;
            Rigidbody rb;

        private BikeController _bikeController;

            public void Handle(BikeController bikeController)
            {
                if (!_bikeController)
                    _bikeController = bikeController;

                rb = GetComponent<Rigidbody>();
                jump = new Vector3(0.0f, -10.0f, 0.0f);

                rb.AddForce(jump * jumpForce, ForceMode.Impulse);
           
            }
        }
        public class ColorState : MonoBehaviour, HeroineState
        {
            public Vector3 jump;
            public float jumpForce = 2.0f;
            Rigidbody rb;

            private BikeController _bikeController;
            public void Handle(BikeController bikeController)
            {
                if (!_bikeController)
                    _bikeController = bikeController;
                rb = GetComponent<Rigidbody>();
                jump = new Vector3(0.0f, 10.0f, 0.0f);

                rb.AddForce(jump * jumpForce, ForceMode.Impulse);

            }

        }
        public class GoneState : MonoBehaviour, HeroineState
        {
            private BikeController _bikeController;
            public void Handle(BikeController bikeController)
            {
                if (!_bikeController)
                    _bikeController = bikeController;

                gameObject.transform.Translate(-100,-100,-100);

            }

        }

}