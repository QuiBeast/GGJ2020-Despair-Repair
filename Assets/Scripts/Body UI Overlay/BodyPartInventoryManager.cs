using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DespairRepair
{
    namespace BodyOverlayUI
    {
        public class BodyPartInventoryManager : MonoBehaviour
        {
            public const string HEAD_TAG = "UI-Head";
            public const string TORSO_TAG = "UI-Torso";
            public const string LEFT_ARM_TAG = "UI-Left-Arm";
            public const string RIGHT_ARM_TAG = "UI-Right-Arm";
            public const string LEFT_LEG_TAG = "UI-Left-Leg";
            public const string RIGHT_LEG_TAG = "UI-Right-Leg";

            // Start is called before the first frame update
            void Start()
            {
                
            }

            // Update is called once per frame
            void Update()
            {
                this.CollectBodyPart(BodyPartTypes.torso, true);
            }

            public void CollectBodyPart(BodyPartTypes bodyPartType, bool isCorrectPart)
            {
                UIBodyPart part = this.GetBodyPart(bodyPartType);
                print(part);

                if (part != null && !part.IsCollected())
                {
                    part.Collect(isCorrectPart);
                }
            }

            public bool IsBodyPartCollected(BodyPartTypes bodyPartType)
            {
                UIBodyPart part = this.GetBodyPart(bodyPartType);

                if (part != null)
                {
                    return part.IsCollected();
                }

                return false;
            }

            private UIBodyPart GetBodyPart(BodyPartTypes partType)
            {
                UIBodyPart part = null;
                UIBodyPart[] partList = GameObject.FindObjectsOfType<UIBodyPart>();
                print(this.GetComponentsInChildren<UIBodyPart>().Length);
                foreach (UIBodyPart bodyPart in partList)
                {
                    print(bodyPart.partType);
                    if (bodyPart.partType == partType)
                    {
                        part = bodyPart;
                    }
                }

                return part;
            }

            public bool AreAllBodyPartsCollected()
            {
                foreach(UIBodyPart bodyPart in this.GetComponentsInChildren<UIBodyPart>())
                {
                    if (!bodyPart.IsCollected())
                    {
                        return false;
                    }
                }

                return true;
            }

            public int GetNumberOfCorrectBodyPartsCollected()
            {
                int count = 0;

                foreach (UIBodyPart bodyPart in this.GetComponentsInChildren<UIBodyPart>())
                {
                    if (bodyPart.IsCorrect())
                    {
                        count++;
                    }
                }

                return count;
            }
        }
    }
}
