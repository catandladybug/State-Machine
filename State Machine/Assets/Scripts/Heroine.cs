/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Heroine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

void Heroine(Input input)
{
    switch (state_)
    {
        case STATE_STANDING:
            if (input == PRESS_B)
            {
                state_ = STATE_JUMPING;
                yVelocity_ = JUMP_VELOCITY;
                setGraphics(IMAGE_JUMP);
            }
            else if (input == PRESS_DOWN)
            {
                state_ = STATE_DUCKING;
                setGraphics(IMAGE_DUCK);
            }
            break;

        case STATE_JUMPING:
            if (input == PRESS_DOWN)
            {
                state_ = STATE_DIVING;
                setGraphics(IMAGE_DIVE);
            }
            break;

        case STATE_DUCKING:
            if (input == RELEASE_DOWN)
            {
                state_ = STATE_STANDING;
                setGraphics(IMAGE_STAND);
            }
            break;
    }
}

void Update()
{
    if (state_ == STATE_DUCKING)
    {
        chargeTime_++;
        if (chargeTime_ > MAX_CHARGE)
        {
            superBomb();
        }
    }
}

void handleInput(Input input)
{
    switch (state_)
    {
        case STATE_STANDING:
            if (input == PRESS_DOWN)
            {
                state_ = STATE_DUCKING;
                chargeTime_ = 0;
                setGraphics(IMAGE_DUCK);
            }
            // Handle other inputs...
            break;

            // Other states...
    }
}

public abstract class HeroineState
{
    public abstract void HandleInput(Heroine heroine, Input input);
    public abstract void Update(Heroine heroine);

};

public class DuckingState : HeroineState
{
    private int chargeTime_;

    public DuckingState()
    {
        chargeTime_ = 0;
    }

    public override void handleInput(Heroine heroine, Input input)
    {
        if (input == Input.RELEASE_DOWN)
        {
            heroine.setGraphics(IMAGE_STAND);
        }
    }

    public override void update(Heroine heroine)
    {
        chargeTime_++;
        if (chargeTime_ > MAX_CHARGE)
        {
            heroine.superBomb();
        }
    }
}

public abstract class Heroine
{
    public abstract void HandleInput(Input input);
    public abstract void Update();

    protected HeroineState state;
}

public class ConcreteHeroine : Heroine
{
    public override void HandleInput(Input input)
    {
        state.HandleInput(this, input);
    }

    public override void Update()
    {
        state.Update(this);
    }
}

public class ConcreteHeroineState : HeroineState
{
    public override void HandleInput(Heroine heroine, Input input)
    {
        // Implement handle input logic
    }

    public override void Update(Heroine heroine)
    {
        // Implement update logic
    }
}

class HeroineState
{
    public:
  static StandingState standing;
    static DuckingState ducking;
    static JumpingState jumping;
    static DivingState diving;

    // Other code...
};

enum State
{
    STATE_STANDING,
    STATE_JUMPING,
    STATE_DUCKING,
    STATE_DIVING
}; */
