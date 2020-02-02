﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DespairRepair
{
    public class BodyPartInventoryManager : MonoBehaviour
    {
        public const string HEAD_TAG = "UI-Head";
        public const string TORSO_TAG = "UI-Torso";
        public const string LEFT_ARM_TAG = "UI-Left-Arm";
        public const string RIGHT_ARM_TAG = "UI-Right-Arm";
        public const string LEFT_LEG_TAG = "UI-Left-Leg";
        public const string RIGHT_LEG_TAG = "UI-Right-Leg";

        private const int TOTAL_BODY_PART_COUNT = 6;

        private ArrayList collectedParts;
        private int correctPartCount;


        private int test = 0;

        // Start is called before the first frame update
        void Start()
        {
            this.collectedParts = new ArrayList();
            this.correctPartCount = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (test == 0) 
            { 
                this.CollectBodyPart(BodyPartTypes.torso, true);
                this.CollectBodyPart(BodyPartTypes.leftArm, false);
                this.CollectBodyPart(BodyPartTypes.rightLeg, true);
                this.CollectBodyPart(BodyPartTypes.head, false);
                this.RemoveBodyPart(BodyPartTypes.head);
                this.RemoveBodyPart(BodyPartTypes.torso);
                this.RemoveLastBodyPart();
                this.RemoveLastBodyPart();

                print(this.AreAllBodyPartsCollected());
                print(this.GetNumberOfCorrectBodyPartsCollected());
                
                test++;
            }
        }

        public void CollectBodyPart(BodyPartTypes bodyPartType, bool isCorrectPart)
        {
            UIBodyPart part = this.GetBodyPart(bodyPartType);
            
            if (part != null && !part.IsCollected())
            {
                part.Collect(isCorrectPart);
                this.collectedParts.Add(part);

                if (isCorrectPart)
                {
                    this.correctPartCount++;
                }
            }
        }

        public UIBodyPart RemoveLastBodyPart()
        {
            if (this.collectedParts.Count > 0)
            {
                UIBodyPart lastBodyPart = (UIBodyPart)this.collectedParts[this.collectedParts.Count-1];   //this.collectedParts[this.collectedPartCount - 1];
                if (lastBodyPart != null)
                {
                    if (lastBodyPart.IsCorrect())
                    {
                        this.correctPartCount--;
                    }

                    lastBodyPart.Uncollect();
                    this.collectedParts.RemoveAt(this.collectedParts.Count - 1);

                    return lastBodyPart;
                }
                
                return null;
            }

            return null;
        }

        public UIBodyPart RemoveBodyPart(BodyPartTypes bodyPartType)
        {
            foreach (UIBodyPart bodyPart in this.collectedParts)
            {
                if (bodyPart.partType == bodyPartType)
                {
                    this.collectedParts.Remove(bodyPart);
                    if (bodyPart.IsCorrect())
                    {
                        this.correctPartCount--;
                        print(this.correctPartCount);
                    }
                    bodyPart.Uncollect();

                    return bodyPart;
                }
            }

            return null;
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
              
            foreach (UIBodyPart bodyPart in partList)
            {
                if (bodyPart.partType == partType)
                {
                    part = bodyPart;
                }
            }

            return part;
        }

        public bool AreAllBodyPartsCollected()
        {
            return this.collectedParts.Count == TOTAL_BODY_PART_COUNT;
        }

        public int GetNumberOfCorrectBodyPartsCollected()
        {
            return this.correctPartCount;
        }
    }
}
