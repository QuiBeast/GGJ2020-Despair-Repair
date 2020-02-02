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

            private SpriteRenderer spriteRenderer;
            private Sprite collectedSprite;

            private const string SPRITE_DIRECTORY = "Sprites/body parts/";

            private const string HEAD_COLLECTED_SPRITE = "head-collected";
            private const string TORSO_COLLECTED_SPRITE = "torso-collected";
            private const string LEFT_ARM_COLLECTED_SPRITE = "left-arm-collected";
            private const string RIGHT_ARM_COLLECTED_SPRITE = "right-arm-collected";
            private const string LEFT_LEG_COLLECTED_SPRITE = "left-leg-collected";
            private const string RIGHT_LEG_COLLECTED_SPRITE = "right-leg-collected";

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

                if (this.tag == BodyPartInventoryManager.HEAD_TAG)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + HEAD_COLLECTED_SPRITE);
                }
                else if (this.tag == BodyPartInventoryManager.TORSO_TAG)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + TORSO_COLLECTED_SPRITE);
                }
                else if (this.tag == BodyPartInventoryManager.LEFT_ARM_TAG)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + LEFT_ARM_COLLECTED_SPRITE);
                }
                else if (this.tag == BodyPartInventoryManager.RIGHT_ARM_TAG)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + RIGHT_ARM_COLLECTED_SPRITE);
                }
                else if (this.tag == BodyPartInventoryManager.LEFT_LEG_TAG)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + LEFT_LEG_COLLECTED_SPRITE);
                }
                else if (this.tag == BodyPartInventoryManager.RIGHT_LEG_TAG)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + RIGHT_LEG_COLLECTED_SPRITE);
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
