class ListingActivity : Activity
{
    private string _questionListing;
    private string _answerListing;

    private List<string> _answers;

    public ListingActivity(
        string activityName,
        string activityDescription,
        int activityDuration,
        string questionListing,
        string answerListing
    )
        : base(activityName, activityDescription, activityDuration)
    {
        _questionListing = questionListing;
        _answerListing = answerListing;
        //Console.WriteLine(_questionListing + _answerListing);
    }

    private List<string> _questions = new List<string>
    {
        "Who are people that you appreciate?",
        " What are personal strengths of yours?",
        " Who are people that you have helped this week?",
        " When have you felt the Holy Ghost this month?",
        " Who are some of your personal heroes?",
        " What are some accomplishments you are proud of?",
        " What challenges have you overcome recently?",
        " What acts of kindness have you received this week?",
        " What are some things that make you happy?",
        " What are your favorite memories?",
        " Who has had a positive impact on your life?",
        " What skills or talents do you have?",
        " What opportunities are you grateful for?",
        " What are your favorite qualities about yourself?",
        " How have you grown as a person this year?",
        " What lessons have you learned recently?",
        " What is something that made you smile today?",
        " What are some things you love about your family?",
        " What friendships are you grateful for?",
        " What hobbies bring you joy?",
        " What is something good that happened today?",
        " What motivates you to keep going?",
        " What is something beautiful you saw today?",
        " How have you helped someone recently?",
        " What are some positive habits you have developed?",
        " What are some things you love about your home?",
        " What experiences have made you stronger?",
        " What aspects of your health are you grateful for?",
        " What are some blessings in your life?",
        " What is a recent challenge that turned into a blessing?",
        " What are your favorite things about your job or studies?",
        " How have you shown kindness to yourself?",
        " What are some things you love about your culture?",
        " Who has inspired you lately?",
        " What are some things that make you feel at peace?",
        " What places hold special meaning for you?",
        " What are some things you love about nature?",
        " What songs or music uplift you?",
        " What are some of your happiest achievements?",
        " What are some traditions that bring you joy?",
        " What are your favorite ways to relax?",
        " What are some positive changes you have made recently?",
        " What aspects of your personality do you love?",
        " What are some things that make you laugh?",
        " What books",
        " movies",
        " or shows have inspired you?",
        " What are some things you love about your community?",
        " What are your favorite things about mornings?",
        " What is something you look forward to?",
        " How have you made a difference in someone’s life?",
        " What are some things that remind you of your worth?",
        " What are some things you appreciate about today?",
    };
    private List<string> answers = new List<string>{};
    public List<string> ListingQuestions(){
        return _questions;
    }
    public List<string> ListingAnswers(){
        return _answers;
    }
    public void AddListingAnswers(string element){
        _answers.Add(element);
    }
    public string getListElem(List<string> listing, int element){
        return listing[element];
    }
}
