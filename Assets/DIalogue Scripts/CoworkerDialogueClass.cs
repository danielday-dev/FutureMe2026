using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CoworkerDialogueClass
{
    public string[] CoworkerGreetings =
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

    public string[] CoworkerBabble =
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

    public string[] Nicknames = 
    {
        "brochacho",
        "coworker",
        "Lavelle",
        "buddy",
        "dudeman",
        "big guy",
        "fella",
        "brotato",
        "my man",
        "broseph"
    };

    public Dictionary<string, Answers> CoworkerQuestions = new Dictionary<string, Answers>
    {
        {
            "My kid, [n], performed [p] first solo at the school recital this weekend!-Choice=1",
            new Answers
            {
                GoodAnswer = "It was a real humdinger, that's for sure!",
                BadAnswer = "Maybe you'll understand when you have kids of your own..."
            }
        },
        {
            "The wife's really been getting at me to start helping more around the house...-Choice=2", 
            new Answers
            {
                GoodAnswer = "Ain't it so? After all, you know how hard I work here!",
                BadAnswer = "Now why would ya go and say something like that coworker?"
            }
        },
        {
            "I heard there's promise of a pizza party for the hardest worker this quarter!-Choice=3", 
            new Answers
            {
                GoodAnswer = "Too true! Sure, that'd be nice, no doubt about it. But folks like us don't need such culinary motives!",
                BadAnswer = "I think the promise of circular dough with cheese, tomatoes and various meats would entice anyone."
            }
        },
        {
            "Is there someone special in your life?-Choice=4", 
            new Answers
            {
                GoodAnswer = "Now you're just fishing for praise you mad dog! Hahahah!",
                BadAnswer = "Make sure to take time to clear that busy head of yours."
            }
        },
        {
            "What are your thoughts on the company's new 'Go Green!' initiative?-Choice=5", 
            new Answers
            {
                GoodAnswer = "We're all entitled to do our part! That's just the Humdrum way!",
                BadAnswer = "You're the type to put all your trash in one big black bag, ain'tcha?"
            }
        },
        {
            "I just copped the brand new H-Phone 21, what cellular device you rockin' these days?-Choice=6", 
            new Answers
            {
                GoodAnswer = "Technology is a cheeky lil maiden, isn't she just?",
                BadAnswer = "Sheesh, someone's not in the technological inner circles!"
            }
        },
        {
            "I'm thinking of taking a trip to Europe after this quarter, you ever been?-Choice=7", 
            new Answers
            {
                GoodAnswer = "Always pays to be worldly, como say alpaca and all that!",
                BadAnswer = "Geography hasn't ever really been my strong suit, but I guess YOU'RE a certified globetrotter!"
            }
        },
        {
            "I didn't see you on the town hall this morning, how come you missed that?-Choice=8", 
            new Answers
            {
                GoodAnswer = "Shame on me for expecting anything less of you!",
                BadAnswer = "We're all a family here at Humdrum, you wouldn't skip Thanksgiving or CHRISTMAS, would you??"
            }
        },
        {
            "That new song by The Herberts and Sherberts has been stuck in my head all day, whatcha been listening to recently?-Choice=9", 
            new Answers
            {
                GoodAnswer = "Add me on Musique friendo, we gotta swap playlists!",
                BadAnswer = "Guess we should all be grateful for the existence of earbuds, am I right?"
            }
        },
        {
            "You know my father was one of the first ever Humdrum employees? It's true!-Choice=10", 
            new Answers
            {
                GoodAnswer = "I like to think I'm honouring his legacy by being a helpful Humdrummer every darn day!",
                BadAnswer = "Well... at least we're all family here, right?"
            }
        }
    };
}
