using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DespairRepair
{
    public class TestUIBodyPart : UIBodyPart
    {
        private bool isCollected;
        private bool isCorrectPart;
        //public BodyPartTypes partType;

        //private SpriteRenderer spriteRenderer;
        //private Sprite collectedSprite;

        private const string SPRITE_DIRECTORY = "Sprites/body parts/";

        private const string HEAD_SPRITE = "head";
        private const string TORSO_SPRITE = "torso";
        private const string LEFT_ARM_SPRITE = "left-arm";
        private const string RIGHT_ARM_SPRITE = "right-arm";
        private const string LEFT_LEG_SPRITE = "left-leg";
        private const string RIGHT_LEG_SPRITE = "right-leg";

        private const string COLLECTED = "-collected";
        private const string INCORRECT_SUFFIX = "-incorrect";

        private const string OUTLINE = " Outline";
        private const string FOUND = " Found";


        // Start is called before the first frame update
        void Start()
        {
            this.isCollected = false;
            this.isCorrectPart = false;
            //this.spriteRenderer = GetComponent<SpriteRenderer>();

            /*GameObject.Find("Head").GetComponent<SpriteRenderer>().enabled = false;
            SpriteRenderer[] renderers = this.GetComponentsInChildren<SpriteRenderer>();
            
            foreach(SpriteRenderer renderer in renderers)
            {
                
            }
            this.gameObject.name*/

            this.DisableRenderers(GameObject.Find(this.name + FOUND));
            this.EnableRenderers(GameObject.Find(this.name + OUTLINE));
        }

        public new void Collect(bool isCorrectPart)
        {
            print("collecting");

            this.isCollected = true;
            this.isCorrectPart = isCorrectPart;

            //if (this.partType == BodyPartTypes.head)
            //{
            print(this.name + OUTLINE);
            print(this.name + FOUND);
            this.DisableRenderers(GameObject.Find(this.name + OUTLINE));
                this.EnableRenderers(GameObject.Find(this.name + FOUND));
            //}
        }

        private void DisableRenderers(GameObject gameObject)
        {
            if (gameObject == null)
            {
                print(this.name);
            }
            SpriteRenderer[] renderers = gameObject.GetComponents<SpriteRenderer>();

            if (renderers == null || renderers.Length == 0)
            {
                int i = 0;

                while (GameObject.Find(gameObject.name + i) != null)
                {
                    List<SpriteRenderer> renderersList = new List<SpriteRenderer>();
                    GameObject gameObj = GameObject.Find(gameObject.name + i);

                    if (gameObj != null)
                    {
                        renderers = gameObj.GetComponents<SpriteRenderer>();

                        foreach (SpriteRenderer renderer in renderers)
                        {
                            renderersList.Add(renderer);
                        }
                    }

                    renderers = renderersList.ToArray();
                    i++;
                }
            }

            foreach (SpriteRenderer renderer in renderers)
            {
                renderer.enabled = false;
            }
        }
        private void EnableRenderers(GameObject gameObject)
        {
            SpriteRenderer[] renderers = gameObject.GetComponents<SpriteRenderer>();

            if (renderers == null || renderers.Length == 0)
            {
                int i = 0;

                while (GameObject.Find(gameObject.name + i) != null)
                {
                    List<SpriteRenderer> renderersList = new List<SpriteRenderer>();
                    GameObject gameObj = GameObject.Find(gameObject.name + i);

                    if (gameObj != null)
                    {
                        renderers = gameObj.GetComponents<SpriteRenderer>();

                        foreach (SpriteRenderer renderer in renderers)
                        {
                            renderersList.Add(renderer);
                        }
                    }

                    renderers = renderersList.ToArray();
                    i++;
                }
            }

            foreach (SpriteRenderer renderer in renderers)
            {
                renderer.enabled = true;
            }
        }

        /*
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
        }*/
    }
}
