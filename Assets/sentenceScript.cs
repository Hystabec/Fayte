using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class test : MonoBehaviour
{
    string[] nouns = { "actor", "gold", "painting", "advertisement", "grass", "parrot", "afternoon", "pencil", "airport", "guitar", "piano", "ambulance", "hair", "pillow", "animal", "hamburger", "pizza", "helicopter", "planet", "apple", "helmet", "plastic", "army", "holiday", "honey", "potato", "balloon", "horse", "queen", "banana", "hospital", "quill", "battery", "house", "rain", "beach", "rainbow", "beard", "ice", "raincoat", "bed", "insect", "refrigerator", "insurance", "restaurant", "boy", "iron", "river", "branch", "island", "rocket", "breakfast", "jackal", "room", "brother", "jelly", "rose", "camera", "jewellery", "candle", "sandwich", "car", "juice", "school", "caravan", "kangaroo", "scooter", "carpet", "king", "shampoo", "cartoon", "kitchen", "shoe", "kite", "soccer", "church", "knife", "spoon", "crayon", "lamp", "stone", "crowd", "lawyer", "sugar", "leather", "library", "teacher", "lighter", "diamond", "lion", "television", "dinner", "lizard", "tent", "lock", "doctor", "tomato", "dog", "lunch", "toothbrush", "dream", "machine", "traffic", "dress", "magazine", "train", "easter", "magician", "truck", "egg", "umbrella", "match", "van", "elephant", "microphone", "vase", "energy", "vegetable", "engine", "morning", "vulture", "motorcycle", "wall", "evening", "nail", "whale", "eye", "napkin", "window", "family", "needle", "wire", "nest", "xylophone", "fish", "yacht", "flag", "night", "yak", "flower", "notebook", "zebra", "football", "ocean", "zoo", "forest", "oil", "garden", "fountain", "orange", "oxygen", "girl", "furniture", "oyster", "glass", "garage", "ghost" };
    string[] verbs = { "acknowledging", "admiting", "answering", "arresting", "asking", "bashing", "bending", "bothering", "breaking", "brushing", "bumping", "calling", "cleaning", "closing", "collecting", "consuming", "covering", "dazing", "decieving", "denying", "digging", "disturbing", "dragging", "ejecting", "entertaining", "fighting", "filing", "fixing", "fliping", "freezing", "frying", "helping", "honouring", "hugging", "intimidating", "informing", "interrupting", "irritating", "jolting", "judging", "keeping", "kicking", "leaving", "lifting", "locking", "losing", "lowering", "marking", "melting", "mixing", "mocking", "moving", "numbering", "opening", "ordering", "packing", "paying", "picking", "placing", "protecting", "pulling", "questioning", "recognizing", "removing", "ringing", "saving", "scanning", "scaring", "shaking", "shifting", "slicing", "spliting", "startling", "steering", "stopping", "switching", "teaching", "telling", "testing", "thanking", "throwing", "tiring", "toasting", "tossing", "towing", "transforming", "trying", "turning", "twisting", "underestimating", "understanding", "upgrading", "vacating", "vilifying", "waking", "watching", "wrecking", "mocking", "walking", "leaving", "adjusting", "meeting", "utilising", "creating" };
    string[] adjectives = { "abrupt", "acidic", "adorable", "adventurous", "aggressive", "agitated", "alert", "aloof", "bored", "brave", "bright", "colossal", "condescending", "confused", "cooperative", "corny", "costly", "courageous", "cruel", "despicable", "determined", "dilapidated", "diminutive", "distressed", "disturbed", "dizzy", "exasperated", "excited", "exhilarated", "extensive", "exuberant", "frothy", "frustrating", "funny", "fuzzy", "gaudy", "greasy", "grieving", "gritty", "grotesque", "grubby", "grumpy", "handsome", "happy", "hollow", "hungry", "hurt", "icy", "ideal", "immense", "impressionable", "intrigued", "irate", "foolish", "frantic", "fresh", "friendly", "frightened", "frothy", "frustrating", "glorious", "gorgeous", "grubby", "happy", "harebrained", "healthy", "helpful", "helpless", "high", "hollow", "homely", "large", "lazy", "livid", "lonely", "loose", "lovely", "lucky", "mysterious", "narrow", "nasty", "outrageous", "panicky", "perfect", "perplexed", "quizzical", "teeny", "tender", "tense", "terrible", "tricky", "troubled", "unsightly", "upset", "wicked", "yummy", "zany", "zealous", "zippy" };

    private string stringToPrint;
    public TMP_Text TMP;

    // Start is called before the first frame update
    void Start()
    {
        stringToPrint = adjectives[Random.Range(0, adjectives.Length)] + " " + nouns[Random.Range(0, nouns.Length)] + " " + verbs[Random.Range(0, verbs.Length)] + " a " + adjectives[Random.Range(0, adjectives.Length)] + " " + nouns[Random.Range(0, nouns.Length)];

        TMP.text = stringToPrint;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
