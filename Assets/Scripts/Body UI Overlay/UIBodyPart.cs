using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DespairRepair
{
    namespace BodyOverlayUI
    {
        public class UIBodyPart : MonoBehaviour
        {
            private bool isCollected;
            private bool isCorrectPart;
            public BodyPartTypes partType;

            private SpriteRenderer spriteRenderer;
            private Sprite collectedSprite;

            private const string SPRITE_DIRECTORY = "Sprites/body parts/";

            private const string HEAD_COLLECTED_SPRITE = "head-collected";
            private const string TORSO_COLLECTED_SPRITE = "torso-collected";
            private const string LEFT_ARM_COLLECTED_SPRITE = "left-arm-collected";
            private const string RIGHT_ARM_COLLECTED_SPRITE = "right-arm-collected";
            private const string LEFT_LEG_COLLECTED_SPRITE = "left-leg-collected";
            private const string RIGHT_LEG_COLLECTED_SPRITE = "right-leg-collected";

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
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + HEAD_COLLECTED_SPRITE + incorrectSuffix);
                }
                else if (this.partType == BodyPartTypes.torso)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + TORSO_COLLECTED_SPRITE + incorrectSuffix);
                }
                else if (this.partType == BodyPartTypes.leftArm)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + LEFT_ARM_COLLECTED_SPRITE + incorrectSuffix);
                }
                else if (this.partType == BodyPartTypes.rightArm)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + RIGHT_ARM_COLLECTED_SPRITE + incorrectSuffix);
                }
                else if (this.partType == BodyPartTypes.leftLeg)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + LEFT_LEG_COLLECTED_SPRITE + incorrectSuffix);
                }
                else if (this.partType == BodyPartTypes.rightLeg)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + RIGHT_LEG_COLLECTED_SPRITE + incorrectSuffix);
                }

                //this.spriteRenderer.color = Color.red;//211,29,0
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
}
