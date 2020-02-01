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

            private SpriteRenderer spriteRenderer;
            private Sprite collectedSprite;

            private const string SPRITE_DIRECTORY = "Sprites/body parts/";

            private const string HEAD_TAG = "UI-Head";
            private const string TORSO_TAG = "UI-Torso";
            private const string LEFT_ARM_TAG = "UI-Left-Arm";
            private const string RIGHT_ARM_TAG = "UI-Right-Arm";
            private const string LEFT_LEG_TAG = "UI-Left-Leg";
            private const string RIGHT_LEG_TAG = "UI-Right-Leg";

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
                this.spriteRenderer = GetComponent<SpriteRenderer>();
                //this.collectedSprite = Resources.Load<Sprite>("Sprites/body parts/head-collected");
            }

            // Update is called once per frame
            void Update()
            {
                //print(this.collectedSprite);
                Collect();
            }

            public void Collect()
            {
                isCollected = true;

                print(this.tag);
                if (this.tag == HEAD_TAG)
                {
                    print(SPRITE_DIRECTORY + HEAD_COLLECTED_SPRITE);
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + HEAD_COLLECTED_SPRITE);
                }
                else if (this.tag == TORSO_TAG)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + TORSO_COLLECTED_SPRITE);
                }
                else if (this.tag == LEFT_ARM_TAG)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + LEFT_ARM_COLLECTED_SPRITE);
                }
                else if (this.tag == RIGHT_ARM_TAG)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + RIGHT_ARM_COLLECTED_SPRITE);
                }
                else if (this.tag == LEFT_LEG_TAG)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + LEFT_LEG_COLLECTED_SPRITE);
                }
                else if (this.tag == RIGHT_LEG_TAG)
                {
                    this.spriteRenderer.sprite = Resources.Load<Sprite>(SPRITE_DIRECTORY + RIGHT_LEG_COLLECTED_SPRITE);
                }
            }
        }
    }
}
