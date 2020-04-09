using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeographyQuiz2
{
  public partial class Form1 : Form
  {
    private DateTime startTime = DateTime.Now;

    // the questions and answers
    private readonly SortedList<string, string> Questions = new SortedList<string, string>()
    {
      { "What is the state capital of California?", "Sacramento" },
      { "What is the tallest mountain in the world?", "Mauna Kea" },
      { "Which country has the furthest south extent", "Chile" }
    };
    // a place to store the questions answered incorrectally so that they might be displayed at the end.
    private readonly SortedList<string, string> WrongAnswers = new SortedList<string, string>()
    { };
    private int currentQuestion = 0;

    public Form1()
    {
      InitializeComponent();
      getQuestion();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      // The timer. Works by subtracting the current time from the time the app was opened once a second. 
      DateTime currentTime = DateTime.Now;
      TimeSpan timeTaken = currentTime.Subtract(startTime);

      lblTime.Text = timeTaken.ToString(@"mm\:ss");
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
      checkAnswer();
      getQuestion();
    }

    private void btnCheat_Click(object sender, EventArgs e)
    {
      KeyValuePair<string, string> question = Questions.ElementAt(currentQuestion);
      Cheat cheatForm = new Cheat();
      cheatForm.Tag = question.Value;
      DialogResult isLazy = cheatForm.ShowDialog();
      if (isLazy == DialogResult.OK)
      {
        txtAnswer.Text = question.Value;
      }
    }

    private void checkAnswer()
    {
      if (currentQuestion < 2)
      {
        KeyValuePair<string, string> question = Questions.ElementAt(currentQuestion);
        string answer = txtAnswer.Text.ToLower();

        // I decided to be nice and take any answer that contains the correct answer BUT I also made a character limit of 15 for the answer text box so you can't just type nine million things in there.
        if (!answer.Contains(question.Value.ToLower()))
        {
          WrongAnswers.Add(question.Key, question.Value);
        }
        txtAnswer.Text = "";
        currentQuestion++;
      }
      else
      {
        endQuiz();
      }
    }

    private void getQuestion()
    {
      if (currentQuestion < 3)
      {
        KeyValuePair<string, string> question = Questions.ElementAt(currentQuestion);
        lblQuestion.Text = question.Key;
      }
    }
    
    private void endQuiz()
    {
      string corrections ="";
      foreach(KeyValuePair<string, string> question in WrongAnswers)
      {
        corrections += ($"The correct answer to \"{question.Key}\" is \"{question.Value}\"\n");
      }
      int score = Questions.Count - WrongAnswers.Count;
      MessageBox.Show($"Your score is {score}!\n{corrections}\nFinal Time: {lblTime.Text}");
      timer1.Stop();
    }
  }
}
