using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Conversations
{
    string[] CoworkerGreetings =
    {
        "Hey [n]!",
        "Greetings, [n]!",
        "Hey howdy hey [n]!",
        "Companyyy Salute! General [n], sir!",
        "The winter wind blew me to you [n]",
        "Surprise, [n]!",
        "Bing bing wahoo!",
        "Beauteous morning to you, [n]!",
        "Smells like hard work in here! Eh, [n]?",
        "Yankee doodle hi, [n]!",
        "Ex-squeeze me, [n]"
    };

    string[] CoworkerBabble =
    {
        "So, get this",
        "Anywho~",
        "Working hard or hardly working, am I right?",
        "God bless the company!",
        "Corporate called: you're looking at a bonus if we can make it to next quarter! Mum's the word!",
        "Don't tell anyone, but I had my fingers crossed when I promised the wife not to work too hard today!",
        "The weather's getting nicer!",
        "Beers after work? 0.0% for me, naturally!",
        "Tried going vegan today, but I simply HAD to have a burger for lunch!",
        "Putting on a few pounds I see! Bulking season, am I right?",
        "You ever tried the coffee here?",
        "The new menu in the cafeteria is superb!",
        "Wonder if they'll ever fix the second elevator..."
    };

    Answers KidRecital = new Answers
    {
        GoodAnswer = "It was a real humdinger, that's for sure!",
        BadAnswer = "Maybe you'll understand when you have kids of your own..."
    }
    
    public Dictionary<string, Answers> CoworkerQuestions = new Dictionary<string, Answers>
    {
        {"My kid, [n], performed [p] first solo at the school recital this weekend!", KidRecital}
    }
}
