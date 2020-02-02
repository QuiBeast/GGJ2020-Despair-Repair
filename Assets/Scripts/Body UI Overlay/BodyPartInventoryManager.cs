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

            public enum BodyParts
            {
                head,
                torso,
                leftArm,
                rightArm,
                leftLeg,
                rightLeg
            }

            // Start is called before the first frame update
            void Start()
            {
                
            }

            // Update is called once per frame
            void Update()
            {
                this.CollectBodyPart(BodyParts.torso, false);
                print(GetNumberOfCorrectBodyPartsCollected());
            }

            public void CollectBodyPart(BodyParts bodyPart, bool isCorrectPart)
            {
                UIBodyPart part = this.GetBodyPart(bodyPart);

                if (part != null && !part.IsCollected())
                {
                    part.Collect(isCorrectPart);
                }
            }

            public bool IsBodyPartCollected(BodyParts bodyPart)
            {
                UIBodyPart part = this.GetBodyPart(bodyPart);

                if (part != null)
                {
                    return part.IsCollected();
                }

                return false;
            }

            private UIBodyPart GetBodyPart(BodyParts bodyPart)
            {
                UIBodyPart part = null;

                switch (bodyPart)
                {
                    case BodyParts.head:
                        part = GameObject.FindGameObjectWithTag(HEAD_TAG).GetComponent<UIBodyPart>();
                        break;
                    case BodyParts.torso:
                        part = GameObject.FindGameObjectWithTag(TORSO_TAG).GetComponent<UIBodyPart>();
                        break;
                    case BodyParts.leftArm:
                        part = GameObject.FindGameObjectWithTag(LEFT_ARM_TAG).GetComponent<UIBodyPart>();
                        break;
                    case BodyParts.rightArm:
                        part = GameObject.FindGameObjectWithTag(RIGHT_ARM_TAG).GetComponent<UIBodyPart>();
                        break;
                    case BodyParts.leftLeg:
                        part = GameObject.FindGameObjectWithTag(LEFT_LEG_TAG).GetComponent<UIBodyPart>();
                        break;
                    case BodyParts.rightLeg:
                        part = GameObject.FindGameObjectWithTag(RIGHT_LEG_TAG).GetComponent<UIBodyPart>();
                        break;
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
