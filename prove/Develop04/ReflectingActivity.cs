class ReflectingActivity : Activity
{
    public ReflectingActivity(string activityName, string activityDescription, int activityDuration)
        : base(activityName, activityDescription, activityDuration) { }

    private List<string> _phrases = new List<string>
    {
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless",
        "Think of a moment when you overcame a major obstacle",
        "Think of a time when you made a tough decision that benefited others",
        "Think of a situation where you had to be brave",
        "Think of a time when you put someone else’s needs before your own",
        "Think of a time when you stayed strong despite difficulties",
        "Think of a time when you encouraged someone to keep going",
        "Think of a time when you achieved something you never thought possible",
        "Think of a time when you forgave someone who hurt you",
        "Think of a time when you took responsibility for a mistake",
        "Think of a time when you inspired someone",
        "Think of a time when you refused to give up",
        "Think of a time when you pushed past your fears",
        "Think of a time when you handled a stressful situation calmly",
        "Think of a time when you had to trust yourself",
        "Think of a time when you stood by your values",
        "Think of a time when you learned an important lesson through failure",
        "Think of a time when you solved a difficult problem",
        "Think of a time when you supported a friend in need",
        "Think of a time when you turned a negative experience into a positive one",
        "Think of a time when you challenged yourself to grow",
        "Think of a time when you faced rejection but kept going",
        "Think of a time when you made a difference in someone’s life",
        "Think of a time when you handled criticism constructively",
        "Think of a time when you took a risk and it paid off",
        "Think of a time when you stayed optimistic in a tough situation",
        "Think of a time when you let go of something holding you back",
        "Think of a time when you found strength in a difficult moment",
        "Think of a time when you showed patience when it was hard",
        "Think of a time when you made a sacrifice for someone else",
        "Think of a time when you stood up for yourself",
        "Think of a time when you embraced change",
        "Think of a time when you asked for help and grew because of it",
        "Think of a time when you turned a failure into motivation",
        "Think of a time when you adapted to an unexpected challenge",
        "Think of a time when you remained kind despite frustration",
        "Think of a time when you helped a stranger",
        "Think of a time when you showed resilience after a setback",
        "Think of a time when you believed in yourself",
        "Think of a time when you mentored or guided someone",
        "Think of a time when you faced your fears head-on",
        "Think of a time when you chose gratitude over resentment",
        "Think of a time when you worked hard to achieve a goal",
        "Think of a time when you helped resolve a conflict",
        "Think of a time when you showed true perseverance",
        "Think of a time when you chose peace over anger",
        "Think of a time when you stayed hopeful in uncertainty",
        "Think of a time when you let go of self-doubt.",
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        " Have you ever done anything like this before?",
        " How did you get started?",
        " How did you feel when it was complete?",
        " What made this time different than other times when you were not as successful?",
        " What is your favorite thing about this experience?",
        " What could you learn from this experience that applies to other situations?",
        " What did you learn about yourself through this experience?",
        " How can you keep this experience in mind in the future?",
        " What emotions did you feel during this moment?",
        " What inspired you to take action?",
        " How did this experience change you?",
        " What was the biggest challenge you faced?",
        " How did you handle any setbacks?",
        " What surprised you about this experience?",
        " What strengths did you discover in yourself?",
        " How did this experience impact your confidence?",
        " How did others respond to your actions?",
        " How did this situation shape your perspective?",
        " What would you do differently if you faced this situation again?",
        " What advice would you give to someone going through a similar experience?",
        " How did you stay motivated?",
        " What skills did you use to navigate this moment?",
        " How did this experience align with your personal values?",
        " How did you know you were making the right choice?",
        " What external factors influenced your decision?",
        " What did you learn about resilience from this experience?",
        " How can you apply this lesson in other areas of your life?",
        " What was the hardest part of this experience?",
        " How did you measure your success?",
        " What sacrifices did you make?",
        " How did you maintain a positive mindset?",
        " What role did patience play in this experience?",
        " How did this experience shape your relationships?",
        " What would have happened if you had not taken action?",
        " How did you overcome fear in this situation?",
        " What did you learn about perseverance?",
        " How did this experience make you feel about your abilities?",
        " What encouragement did you give yourself along the way?",
        " How did you celebrate your success?",
        " How did this experience compare to your expectations?",
        " What lessons did you take from this into your daily life?",
        " How did your perspective shift as a result of this experience?",
        " How did this moment reveal your character?",
        " What would you tell your past self about this experience?",
        " How did this experience shape your goals?",
        " What did you learn about trust?",
        " How did you practice self-compassion in this moment?",
        " What strengths did others see in you during this experience?",
        " How did you balance logic and emotion in your decision?",
        " What did this moment teach you about growth?",
    };

    public List<string> reflectionMessage()
    {
        return _phrases;
    }

    public List<string> reflectionQuestion()
    {
        return _questions;
    }

    public string getListElem(List<string> reflect, int element)
    {
        return reflect[element];
    }
}
