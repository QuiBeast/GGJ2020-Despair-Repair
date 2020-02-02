using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DespairRepair
{
    public class UIBodyPart : MonoBehaviour
    {
        private bool isCollected;
        private bool isCorrectPart;
        public BodyPartTypes partType;

        private SpriteRenderer spriteRenderer;
        private Sprite collectedSprite;

        private const string SPRITE_DIRECTORY = "Sprites/body parts/";

        private const string HEAD_SPRITE = "head";
        private const string TORSO_SPRITE = "torso";
        private const string LEFT_ARM_SPRITE = "left-arm";
        private const string RIGHT_ARM_SPRITE = "right-arm";
        private const string LEFT_LEG_SPRITE = "left-leg";
        private const string RIGHT_LEG_SPRITE = "right-leg";
        
        private const string COLLECTED = "-collected";
        private const string INCORRECT_SUFFIX = "-incorrect";


        // Start is called before the first frame update
        void Start()
        {
            this.isCollected = false;
            this.isCorrectPart = false;
            this.spriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            //Collect();
        }

        public void Collect(bool isCorrectPart)
        {
            this.isCollected = true;
            this.isCorrectPart = isCorrectPart;

            string incorrectSuffix = "";
            if (!isCorrectPart)
            {
                incorrectSuffix = INCORRECT_SUFFIX;
            }

            if (this.partType == BodyPartTypes.head)
            {
                this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + HEAD_SPRITE + COLLECTED + incorrectSuffix);
            }
            else if (this.partType == BodyPartTypes.torso)
            {
                this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + TORSO_SPRITE + COLLECTED + incorrectSuffix);
            }
            else if (this.partType == BodyPartTypes.leftArm)
            {
                this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + LEFT_ARM_SPRITE + COLLECTED + incorrectSuffix);
            }
            else if (this.partType == BodyPartTypes.rightArm)
            {
                this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + RIGHT_ARM_SPRITE + COLLECTED + incorrectSuffix);
            }
            else if (this.partType == BodyPartTypes.leftLeg)
            {
                this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + LEFT_LEG_SPRITE + COLLECTED + incorrectSuffix);
            }
            else if (this.partType == BodyPartTypes.rightLeg)
            {
               this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + RIGHT_LEG_SPRITE + COLLECTED + incorrectSuffix);
            }

            //this.spriteRenderer.color = Color.red;//211,29,0
        }

        public void Uncollect()
        {
            if (this.isCollected)
            {
                this.isCollected = false;
                
                if (this.partType == BodyPartTypes.head)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + HEAD_SPRITE);
                }
                else if (this.partType == BodyPartTypes.torso)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + TORSO_SPRITE);
                }
                else if (this.partType == BodyPartTypes.leftArm)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + LEFT_ARM_SPRITE);
                }
                else if (this.partType == BodyPartTypes.rightArm)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + RIGHT_ARM_SPRITE);
                }
                else if (this.partType == BodyPartTypes.leftLeg)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + LEFT_LEG_SPRITE);
                }
                else if (this.partType == BodyPartTypes.rightLeg)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + RIGHT_LEG_SPRITE);
                }
            }
        }

        public bool IsCollected()
        {
            return this.isCollected;
        }

        public bool IsCorrect()
        {
            return this.isCorrectPart;
        }
    }
}
