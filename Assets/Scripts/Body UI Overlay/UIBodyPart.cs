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

        private const string OUTLINE = " Outline";
        private const string FOUND = " Found";

        private BodyPartObject bodyPart;
        
        // Start is called before the first frame update
        void Start()
        {
            this.isCollected = false;
            this.isCorrectPart = false;
            this.bodyPart = null;

            this.DisableRenderers(GameObject.Find(this.name + FOUND));
            this.EnableRenderers(GameObject.Find(this.name + OUTLINE));
        }

        public void Collect(bool isCorrectPart)
        {
            this.isCollected = true;
            this.isCorrectPart = isCorrectPart;

            this.DisableRenderers(GameObject.Find(this.name + OUTLINE));
            this.EnableRenderers(GameObject.Find(this.name + FOUND));
        }



        public void Uncollect()
        {
            this.isCollected = false;

            this.DisableRenderers(GameObject.Find(this.name + FOUND));
            this.EnableRenderers(GameObject.Find(this.name + OUTLINE));
        }

            private void DisableRenderers(GameObject gameObject)
        {
            SpriteRenderer[] renderers = gameObject.GetComponents<SpriteRenderer>();

            //If no renderers are found, we need to check if there are child game objects that have renderers. Some of the body parts are composites of multiple sprites
            //that need multiple sprite renderers enabled/disabled.
            if (renderers == null || renderers.Length == 0)
            {
                int i = 0;
                List<SpriteRenderer> renderersList = new List<SpriteRenderer>();

                //Child objects should be named like "Torso Found0", "Torso Found1", and so on. So long as we find children with this naming convention, add their renderers to the list.
                while (GameObject.Find(gameObject.name + i) != null)
                {
                    GameObject gameObj = GameObject.Find(gameObject.name + i);

                    if (gameObj != null)
                    {
                        renderers = gameObj.GetComponents<SpriteRenderer>();

                        foreach (SpriteRenderer renderer in renderers)
                        {
                            renderersList.Add(renderer);
                        }
                    }
                    
                    i++;
                }
                renderers = renderersList.ToArray();
            }

            //Disable the renderers.
            foreach (SpriteRenderer renderer in renderers)
            {
                renderer.enabled = false;
            }
        }
        private void EnableRenderers(GameObject gameObject)
        {
            SpriteRenderer[] renderers = gameObject.GetComponents<SpriteRenderer>();

            //If no renderers are found, we need to check if there are child game objects that have renderers. Some of the body parts are composites of multiple sprites
            //that need multiple sprite renderers enabled/disabled.
            if (renderers == null || renderers.Length == 0)
            {
                int i = 0;
                List<SpriteRenderer> renderersList = new List<SpriteRenderer>();

                //Child objects should be named like "Torso Found0", "Torso Found1", and so on. So long as we find children with this naming convention, add their renderers to the list.
                while (GameObject.Find(gameObject.name + i) != null)
                {
                    GameObject gameObj = GameObject.Find(gameObject.name + i);

                    if (gameObj != null)
                    {
                        renderers = gameObj.GetComponents<SpriteRenderer>();

                        foreach (SpriteRenderer renderer in renderers)
                        {
                            renderersList.Add(renderer);
                        }
                    }

                    i++;
                }
                renderers = renderersList.ToArray();
            }

            //Enable the renderers.
            foreach (SpriteRenderer renderer in renderers)
            {
                renderer.enabled = true;
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
