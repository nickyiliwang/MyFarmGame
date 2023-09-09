using UnityEngine;

public class Player : SingletonMonoBehaviour<Player>
{
    private AnimationSettings playerSettings = new AnimationSettings
    {
        isCarrying = false,
        toolEffect = ToolEffect.none
    };

    private Rigidbody2D rigidBody;
    private Direction playerDirection;
    private float movementSpeed;

    private bool _isPlayerInputDisabled = false;

    public bool IsPlayerInputDisabled
    {
        get => _isPlayerInputDisabled;
        set => _isPlayerInputDisabled = value;
    }

    protected override void Awake()
    {
        base.Awake(); //add some additional functionality to the Awake() method of the base class without completely overriding it

        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ResetAnimationTriggers();

        PlayerMovementInput();

        PlayerWalkInput();

        EventHandler.CallMovementEvent(playerSettings);
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        var s = playerSettings;
        Vector2 move = new Vector2(
            s.xInput * movementSpeed * Time.deltaTime,
            s.yInput * movementSpeed * Time.deltaTime
        );

        rigidBody.MovePosition(rigidBody.position + move);
    }

    private void ResetAnimationTriggers()
    {
        playerSettings.isUsingToolRight = false;
        playerSettings.isUsingToolLeft = false;
        playerSettings.isUsingToolUp = false;
        playerSettings.isUsingToolDown = false;
        playerSettings.isLiftingToolRight = false;
        playerSettings.isLiftingToolLeft = false;
        playerSettings.isLiftingToolUp = false;
        playerSettings.isLiftingToolDown = false;
        playerSettings.isPickingLeft = false;
        playerSettings.isPickingRight = false;
        playerSettings.isPickingUp = false;
        playerSettings.isPickingDown = false;
        playerSettings.isSwingingToolLeft = false;
        playerSettings.isSwingingToolRight = false;
        playerSettings.isSwingingToolUp = false;
        playerSettings.isSwingingToolDown = false;
        playerSettings.toolEffect = ToolEffect.none;
    }

    private void PlayerMovementInput()
    {
        var s = playerSettings;
        s.xInput = (int)Input.GetAxisRaw("Horizontal");
        s.yInput = (int)Input.GetAxisRaw("Vertical");

        if (s.xInput != 0 && s.yInput != 0)
        {
            s.xInput *= (int)0.71f;
            s.yInput *= (int)0.71f;
        }

        if (s.xInput != 0 || s.yInput != 0)
        {
            s.isRunning = true;
            s.isWalking = false;
            s.isIdle = false;

            IsPlayerInputDisabled = false;
            movementSpeed = Settings.runningSpeed;

            // Capture Player direction for save game
            if (s.xInput < 0)
            {
                playerDirection = Direction.left;
            }
            else if (s.xInput > 0)
            {
                playerDirection = Direction.right;
            }
            else if (s.yInput > 0)
            {
                playerDirection = Direction.up;
            }
            else
            {
                playerDirection = Direction.down;
            }
        }
        else if (s.xInput == 0 && s.yInput == 0)
        {
            s.isRunning = false;
            s.isWalking = false;
            s.isIdle = true;
        }
    }

    private void PlayerWalkInput()
    {
        var s = playerSettings;
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            s.isRunning = false;
            s.isWalking = true;
            s.isIdle = false;
            movementSpeed = Settings.walkingSpeed;
        }
        else
        {
            s.isRunning = true;
            s.isWalking = false;
            s.isIdle = false;
            movementSpeed = Settings.runningSpeed;
        }
    }
}
