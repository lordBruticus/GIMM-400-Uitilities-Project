// --> Branches and Loops

//Page 1

int a = 5;
int b = 6;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10.");
    
int b = 3;

//Page 2

int a = 5;
int b = 3;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10");
else
    Console.WriteLine("The answer is not greater than 10");

int a = 5;
int b = 3;
if (a + b > 10)
{
    Console.WriteLine("The answer is greater than 10");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
}

int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) || (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}

//Page 3

int counter = 0;
while (counter < 10)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
}

int counter = 0;
do
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
} while (counter < 10);

//Page 4

for(int counter = 0; counter < 10; counter++)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
}

// --> Converting a String to a Number

// 1

using System;

public class StringConversion
{
    public static void Main()
    {
       string input = String.Empty;
       try
       {
           int result = Int32.Parse(input);
           Console.WriteLine(result);
       }
       catch (FormatException)
       {
           Console.WriteLine($"Unable to parse '{input}'");
       }
       // Output: Unable to parse ''

       try
       {
            int numVal = Int32.Parse("-105");
            Console.WriteLine(numVal);
       }
       catch (FormatException e)
       {
           Console.WriteLine(e.Message);
       }
       // Output: -105

        if (Int32.TryParse("-105", out int j))
            Console.WriteLine(j);
        else
            Console.WriteLine("String could not be parsed.");
        // Output: -105

        try
        {
            int m = Int32.Parse("abc");
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        // Output: Input string was not in a correct format.

        string inputString = "abc";
        if (Int32.TryParse(inputString, out int numValue))
            Console.WriteLine(inputString);
        else
            Console.WriteLine($"Int32.TryParse could not parse '{inputString}' to an int.");
        // Output: Int32.TryParse could not parse 'abc' to an int.
     }
}

// 2

using System;

public class StringConversion
{
    public static void Main()
    {
        var str = "  10FFxxx";
        string numericString = String.Empty;
        foreach (var c in str) 
        {
            // Check for numeric characters (hex in this case) or leading or trailing spaces.
            if ((c >= '0' && c <= '9') || (Char.ToUpperInvariant(c) >= 'A' && Char.ToUpperInvariant(c) <= 'F') || c == ' ') {
                numericString = String.Concat(numericString, c.ToString());
            }
            else
            {
                break;
            }
        }
        if (int.TryParse(numericString, System.Globalization.NumberStyles.HexNumber, null, out int i))
            Console.WriteLine($"'{str}' --> '{numericString}' --> {i}");
            // Output: '  10FFxxx' --> '  10FF' --> 4351

        str = "   -10FFXXX";
        numericString = "";
        foreach (char c in str) {
            // Check for numeric characters (0-9), a negative sign, or leading or trailing spaces.
            if ((c >= '0' && c <= '9') || c == ' ' || c == '-') 
            {
                numericString = String.Concat(numericString, c);
            } else
                break;
        }
        if (int.TryParse(numericString, out int j))
            Console.WriteLine($"'{str}' --> '{numericString}' --> {j}");
            // Output: '   -10FFXXX' --> '   -10' --> -10
    }
}

// 3

using System;

public class ConvertStringExample1
{
    static void Main(string[] args)
    {
        int numVal = -1;
        bool repeat = true;

        while (repeat)
        {
            Console.Write("Enter a number between −2,147,483,648 and +2,147,483,647 (inclusive): ");

            string input = Console.ReadLine();

            // ToInt32 can throw FormatException or OverflowException.
            try
            {
                numVal = Convert.ToInt32(input);
                if (numVal < Int32.MaxValue)
                {
                    Console.WriteLine("The new value is {0}", ++numVal);
                }
                else
                {
                    Console.WriteLine("numVal cannot be incremented beyond its current value");
                }
           }
            catch (FormatException)
            {
                Console.WriteLine("Input string is not a sequence of digits.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number cannot fit in an Int32.");
            }

            Console.Write("Go again? Y/N: ");
            string go = Console.ReadLine();
            if (go.ToUpper() != "Y")
            {
                repeat = false;
            }
        }
    }
}

// --> Parsing Strings Using String.Split method

//1

string phrase = "The quick brown fox jumps over the lazy dog.";
string[] words = phrase.Split(' ');

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}

//2

string phrase = "The quick brown    fox     jumps over the lazy dog.";
string[] words = phrase.Split(' ');

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}

//3

char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

string text = "one\ttwo three:four,five six seven";
System.Console.WriteLine($"Original text: '{text}'");

string[] words = text.Split(delimiterChars);
System.Console.WriteLine($"{words.Length} words in text:");

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}

//4

char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

string text = "one\ttwo :,five six seven";
System.Console.WriteLine($"Original text: '{text}'");

string[] words = text.Split(delimiterChars);
System.Console.WriteLine($"{words.Length} words in text:");

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}


//5

string[] separatingStrings = { "<<", "..." };

string text = "one<<two......three<four";
System.Console.WriteLine($"Original text: '{text}'");

string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
System.Console.WriteLine($"{words.Length} substrings in text:");

foreach (var word in words)
{
    System.Console.WriteLine(word);
}

//  --> List collection and storage

// 1

var names = new List<string> { "<name>", "Ana", "Felipe" };
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

// 2

Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

Console.WriteLine($"The list has {names.Count} people in it");

// 3

var index = names.IndexOf("Felipe");
if (index != -1)
  Console.WriteLine($"The name {names[index]} is at index {index}");

var notFound = names.IndexOf("Not Found");
  Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
  
  names.Sort();
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

// 4

var fibonacciNumbers = new List<int> {1, 1};

var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

fibonacciNumbers.Add(previous + previous2);

foreach(var item in fibonacciNumbers)
    Console.WriteLine(item);
    
 // 5
 
 var fibonacciNumbers = new List<int> {1, 1};

while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}
foreach(var item in fibonacciNumbers)
    Console.WriteLine(item);

// --> Numbers in C#

//Page 1

int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

int c = a - b;
int c = a * b;
int c = a / b;

//Page 2

int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);

int a = 5;
int b = 4;
int c = 2;
int d = (a + b) * c;
Console.WriteLine(d);

int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;

int a = 7;
int b = 4;
int c = 3;
int d = (a  + b) / c;
Console.WriteLine(d);

//Page 3

int a = 7;
int b = 4;
int c = 3;
int d = (a  + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

// Page 4

double a = 5;
double b = 4;
double c = 2;
double d = (a  + b) / c;
Console.WriteLine(d);

double a = 19;
double b = 23;
double c = 8;
double d = (a  + b) / c;
Console.WriteLine(d);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);

//Page 5

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

//Page 6

double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);

// --> Parsing Numeric Strings in NET

//Parsing and Format Providers

using System;
using System.Globalization;

public class Example
{
   public static void Main()
   {
      string[] values = { "1,304.16", "$1,456.78", "1,094", "152", 
                          "123,45 €", "1 304,16", "Ae9f" };
      double number;
      CultureInfo culture = null;
      
      foreach (string value in values) {
         try {
            culture = CultureInfo.CreateSpecificCulture("en-US");
            number = Double.Parse(value, culture);
            Console.WriteLine("{0}: {1} --> {2}", culture.Name, value, number);
         }   
         catch (FormatException) {
            Console.WriteLine("{0}: Unable to parse '{1}'.", 
                              culture.Name, value);
            culture = CultureInfo.CreateSpecificCulture("fr-FR");
            try {
               number = Double.Parse(value, culture);
               Console.WriteLine("{0}: {1} --> {2}", culture.Name, value, number);
            }
            catch (FormatException) {
               Console.WriteLine("{0}: Unable to parse '{1}'.", 
                                 culture.Name, value);
            }
         }
         Console.WriteLine();
      }   
   }
}
// The example displays the following output:
//    en-US: 1,304.16 --> 1304.16
//    
//    en-US: Unable to parse '$1,456.78'.
//    fr-FR: Unable to parse '$1,456.78'.
//    
//    en-US: 1,094 --> 1094
//    
//    en-US: 152 --> 152
//    
//    en-US: Unable to parse '123,45 €'.
//    fr-FR: Unable to parse '123,45 €'.
//    
//    en-US: Unable to parse '1 304,16'.
//    fr-FR: 1 304,16 --> 1304.16
//    
//    en-US: Unable to parse 'Ae9f'.
//    fr-FR: Unable to parse 'Ae9f'.

// Parsing and NumberStyles Values

using System;
using System.Globalization;

public class Example
{
   public static void Main()
   {
      string value = "1,304";
      int number;
      IFormatProvider provider = CultureInfo.CreateSpecificCulture("en-US");
      if (Int32.TryParse(value, out number))
         Console.WriteLine("{0} --> {1}", value, number);
      else
         Console.WriteLine("Unable to convert '{0}'", value);
            
      if (Int32.TryParse(value, NumberStyles.Integer | NumberStyles.AllowThousands, 
                        provider, out number))
         Console.WriteLine("{0} --> {1}", value, number);
      else
         Console.WriteLine("Unable to convert '{0}'", value);
   }
}
// The example displays the following output:
//       Unable to convert '1,304'
//       1,304 --> 1304

//Parsing and Unicode Digits

using System;

public class Example
{
   public static void Main()
   {
      string value;
      // Define a string of basic Latin digits 1-5.
      value = "\u0031\u0032\u0033\u0034\u0035";
      ParseDigits(value);

      // Define a string of Fullwidth digits 1-5.
      value = "\uFF11\uFF12\uFF13\uFF14\uFF15";
      ParseDigits(value);
      
      // Define a string of Arabic-Indic digits 1-5.
      value = "\u0661\u0662\u0663\u0664\u0665";
      ParseDigits(value);
      
      // Define a string of Bangla digits 1-5.
      value = "\u09e7\u09e8\u09e9\u09ea\u09eb";
      ParseDigits(value);
   }

   static void ParseDigits(string value)
   {
      try {
         int number = Int32.Parse(value);
         Console.WriteLine("'{0}' --> {1}", value, number);
      }   
      catch (FormatException) {
         Console.WriteLine("Unable to parse '{0}'.", value);      
      }     
   }
}
// The example displays the following output:
//       '12345' --> 12345
//       Unable to parse '１２３４５'.
//       Unable to parse '١٢٣٤٥'.
//       Unable to parse '১২৩৪৫'.

// --> Player Controller

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 50.0f;
    public Rigidbody head;
    public LayerMask layerMask;
    public Animator bodyAnimator;
    public float[] hitForce;
    public float timeBetweenHits = 2.5f;
    public Rigidbody marineBody;
    private bool isDead = false;
    private bool isHit = false;
    private float timeSinceHit = 0;
    private int hitNumber = -1;
    private Vector3 currentLookTarget = Vector3.zero;
    //private CharacterController characterController;
    private DeathParticles deathParticles;

    private CharacterController characterController;

    // Use this for initialization
    void Start ()
    {
        characterController = GetComponent<CharacterController>();
        deathParticles = gameObject.GetComponentInChildren<DeathParticles>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"),
        //0, Input.GetAxis("Vertical"));
        //characterController.SimpleMove(moveDirection * moveSpeed);

        if (isHit)
        {
            timeSinceHit += Time.deltaTime;
            if (timeSinceHit > timeBetweenHits)
            {
                isHit = false;
                timeSinceHit = 0;
            }
        }
    }

    void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime * moveSpeed, 0, Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed);
        
        if (moveDirection == Vector3.zero)
        {
            bodyAnimator.SetBool("IsMoving", false);
        }
        else
        {
            head.AddForce(transform.right * 150, ForceMode.Acceleration);
            bodyAnimator.SetBool("IsMoving", true);
        }
        
        transform.position += new Vector3(moveDirection.x, 0, moveDirection.z);
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 1000, Color.green);

        if (Physics.Raycast(ray, out hit, 1000, layerMask, QueryTriggerInteraction.Ignore))
        {
            if (hit.point != currentLookTarget)
            {
                currentLookTarget = hit.point;
            }
        }
        Vector3 targetPosition = new Vector3(hit.point.x, transform.position.y, hit.point.z);
        Quaternion rotation = Quaternion.LookRotation(targetPosition - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * 10.0f);
    }

    void OnTriggerEnter(Collider other)
    {
        Alien alien = other.gameObject.GetComponent<Alien>();
        if (alien != null)
        { // 1
            if (!isHit)
            {
                hitNumber += 1; // 2
                CameraShake cameraShake =
                    Camera.main.GetComponent<CameraShake>();
                if (hitNumber < hitForce.Length) // 3 
                {
                    cameraShake.intensity = hitForce[hitNumber];
                    cameraShake.Shake();
                }
                else
                {
                    Die();
                }
                isHit = true; // 4
                SoundManager.Instance
                    .PlayOneShot(SoundManager.Instance.hurt);
            }
            alien.Die();
        }
    }

    public void Die()
    {
        bodyAnimator.SetBool("IsMoving", false);
        marineBody.transform.parent = null;
        marineBody.isKinematic = false;
        marineBody.useGravity = true;
        marineBody.gameObject.GetComponent<CapsuleCollider>().enabled = true;
        marineBody.gameObject.GetComponent<Gun>().enabled = false;
        Destroy(head.gameObject.GetComponent<HingeJoint>());
        head.transform.parent = null;
        head.useGravity = true;
        SoundManager.Instance.PlayOneShot(SoundManager.Instance.marineDeath);
        deathParticles.Activate();
        Destroy(gameObject);
    }
}

// --> ML Agents agent code

using System.Collections.Generic;
using UnityEngine;
using Barracuda;
using MLAgents.Sensor;



namespace MLAgents
{
    /// <summary>
    /// Struct that contains all the information for an Agent, including its
    /// observations, actions and current status, that is sent to the Brain.
    /// </summary>
    public struct AgentInfo
    {
        /// <summary>
        /// Most recent agent vector (i.e. numeric) observation.
        /// </summary>
        public List<float> vectorObservation;

        /// <summary>
        /// The previous agent vector observations, stacked. The length of the
        /// history (i.e. number of vector observations to stack) is specified
        /// in the Brain parameters.
        /// </summary>
        public List<float> stackedVectorObservation;

        /// <summary>
        /// Most recent compressed observations.
        /// </summary>
        public List<CompressedObservation> compressedObservations;

        /// <summary>
        /// Most recent text observation.
        /// </summary>
        public string textObservation;

        /// <summary>
        /// Keeps track of the last vector action taken by the Brain.
        /// </summary>
        public float[] storedVectorActions;

        /// <summary>
        /// Keeps track of the last text action taken by the Brain.
        /// </summary>
        public string storedTextActions;

        /// <summary>
        /// For discrete control, specifies the actions that the agent cannot take. Is true if
        /// the action is masked.
        /// </summary>
        public bool[] actionMasks;

        /// <summary>
        /// Used by the Trainer to store information about the agent. This data
        /// structure is not consumed or modified by the agent directly, they are
        /// just the owners of their trainier's memory. Currently, however, the
        /// size of the memory is in the Brain properties.
        /// </summary>
        public List<float> memories;

        /// <summary>
        /// Current agent reward.
        /// </summary>
        public float reward;

        /// <summary>
        /// Whether the agent is done or not.
        /// </summary>
        public bool done;

        /// <summary>
        /// Whether the agent has reached its max step count for this episode.
        /// </summary>
        public bool maxStepReached;

        /// <summary>
        /// Unique identifier each agent receives at initialization. It is used
        /// to separate between different agents in the environment.
        /// </summary>
        public int id;

        /// <summary>
        /// User-customizable object for sending structured output from Unity to Python in response
        /// to an action in addition to a scalar reward.
        /// TODO(cgoy): All references to protobuf objects should be removed.
        /// </summary>
        public CommunicatorObjects.CustomObservationProto customObservation;
    }

    /// <summary>
    /// Struct that contains the action information sent from the Brain to the
    /// Agent.
    /// </summary>
    public struct AgentAction
    {
        public float[] vectorActions;
        public string textActions;
        public List<float> memories;
        public float value;
        /// TODO(cgoy): All references to protobuf objects should be removed.
        public CommunicatorObjects.CustomActionProto customAction;
    }

    /// <summary>
    /// Struct that contains all the Agent-specific parameters provided in the
    /// Editor. This excludes the Brain linked to the Agent since it can be
    /// modified programmatically.
    /// </summary>
    [System.Serializable]
    public class AgentParameters
    {
        /// <summary>
        /// The maximum number of steps the agent takes before being done.
        /// </summary>
        /// <remarks>
        /// If set to 0, the agent can only be set to done programmatically (or
        /// when the Academy is done).
        /// If set to any positive integer, the agent will be set to done after
        /// that many steps. Note that setting the max step to a value greater
        /// than the academy max step value renders it useless.
        /// </remarks>
        public int maxStep;

        /// <summary>
        /// Determines the behaviour of the agent when done.
        /// </summary>
        /// <remarks>
        /// If true, the agent will reset when done and start a new episode.
        /// Otherwise, the agent will remain done and its behavior will be
        /// dictated by the AgentOnDone method.
        /// </remarks>
        public bool resetOnDone = true;

        /// <summary>
        /// Whether to enable On Demand Decisions or make a decision at
        /// every step.
        /// </summary>
        public bool onDemandDecision;

        /// <summary>
        /// Number of actions between decisions (used when On Demand Decisions
        /// is turned off).
        /// </summary>
        public int numberOfActionsBetweenDecisions;
    }


    /// <summary>
    /// Agent Monobehavior class that is attached to a Unity GameObject, making it
    /// an Agent. An agent produces observations and takes actions in the
    /// environment. Observations are determined by the cameras attached
    /// to the agent in addition to the vector observations implemented by the
    /// user in <see cref="CollectObservations"/>. On the other hand, actions
    /// are determined by decisions produced by a Policy. Currently, this
    /// class is expected to be extended to implement the desired agent behavior.
    /// </summary>
    /// <remarks>
    /// Simply speaking, an agent roams through an environment and at each step
    /// of the environment extracts its current observation, sends them to its
    /// policy and in return receives an action. In practice,
    /// however, an agent need not send its observation at every step since very
    /// little may have changed between successive steps.
    ///
    /// At any step, an agent may be considered <see cref="m_Done"/>.
    /// This could occur due to a variety of reasons:
    ///     - The agent reached an end state within its environment.
    ///     - The agent reached the maximum # of steps (i.e. timed out).
    ///     - The academy reached the maximum # of steps (forced agent to be done).
    ///
    /// Here, an agent reaches an end state if it completes its task successfully
    /// or somehow fails along the way. In the case where an agent is done before
    /// the academy, it either resets and restarts, or just lingers until the
    /// academy is done.
    ///
    /// An important note regarding steps and episodes is due. Here, an agent step
    /// corresponds to an academy step, which also corresponds to Unity
    /// environment step (i.e. each FixedUpdate call). This is not the case for
    /// episodes. The academy controls the global episode count and each agent
    /// controls its own local episode count and can reset and start a new local
    /// episode independently (based on its own experience). Thus an academy
    /// (global) episode can be viewed as the upper-bound on an agents episode
    /// length and that within a single global episode, an agent may have completed
    /// multiple local episodes. Consequently, if an agent max step is
    /// set to a value larger than the academy max steps value, then the academy
    /// value takes precedence (since the agent max step will never be reached).
    ///
    /// Lastly, note that at any step the policy to the agent is allowed to
    /// change model with <see cref="GiveModel"/>.
    ///
    /// Implementation-wise, it is required that this class is extended and the
    /// virtual methods overridden. For sample implementations of agent behavior,
    /// see the Examples/ directory within this Unity project.
    /// </remarks>
    [HelpURL("https://github.com/Unity-Technologies/ml-agents/blob/master/" +
        "docs/Learning-Environment-Design-Agents.md")]
    [System.Serializable]
    [RequireComponent(typeof(BehaviorParameters))]
    public abstract class Agent : MonoBehaviour
    {
        private IPolicy m_Brain;
        private BehaviorParameters m_PolicyFactory;

        /// <summary>
        /// Agent parameters specified within the Editor via AgentEditor.
        /// </summary>
        [HideInInspector] public AgentParameters agentParameters;

        /// Current Agent information (message sent to Brain).
        AgentInfo m_Info;
        public AgentInfo Info
        {
            get { return m_Info; }
            set { m_Info = value; }
        }

        /// Current Agent action (message sent from Brain).
        AgentAction m_Action;

        /// Represents the reward the agent accumulated during the current step.
        /// It is reset to 0 at the beginning of every step.
        /// Should be set to a positive value when the agent performs a "good"
        /// action that we wish to reinforce/reward, and set to a negative value
        /// when the agent performs a "bad" action that we wish to punish/deter.
        /// Additionally, the magnitude of the reward should not exceed 1.0
        float m_Reward;

        /// Keeps track of the cumulative reward in this episode.
        float m_CumulativeReward;

        /// Whether or not the agent requests an action.
        bool m_RequestAction;

        /// Whether or not the agent requests a decision.
        bool m_RequestDecision;

        /// Whether or not the agent has completed the episode. This may be due
        /// to either reaching a success or fail state, or reaching the maximum
        /// number of steps (i.e. timing out).
        bool m_Done;

        /// Whether or not the agent reached the maximum number of steps.
        bool m_MaxStepReached;

        /// Keeps track of the number of steps taken by the agent in this episode.
        /// Note that this value is different for each agent, and may not overlap
        /// with the step counter in the Academy, since agents reset based on
        /// their own experience.
        int m_StepCount;

        /// Flag to signify that an agent has been reset but the fact that it is
        /// done has not been communicated (required for On Demand Decisions).
        bool m_HasAlreadyReset;

        /// Flag to signify that an agent is done and should not reset until
        /// the fact that it is done has been communicated.
        bool m_Terminate;

        /// Unique identifier each agent receives at initialization. It is used
        /// to separate between different agents in the environment.
        int m_Id;

        /// Keeps track of the actions that are masked at each step.
        private ActionMasker m_ActionMasker;

        /// <summary>
        /// Demonstration recorder.
        /// </summary>
        private DemonstrationRecorder m_Recorder;

        public List<ISensor> m_Sensors;

        /// Monobehavior function that is called when the attached GameObject
        /// becomes enabled or active.
        void OnEnable()
        {
            m_Id = gameObject.GetInstanceID();
            var academy = FindObjectOfType<Academy>();
            academy.LazyInitialization();
            OnEnableHelper(academy);

            m_Recorder = GetComponent<DemonstrationRecorder>();
        }

        /// Helper method for the <see cref="OnEnable"/> event, created to
        /// facilitate testing.
        void OnEnableHelper(Academy academy)
        {
            m_Info = new AgentInfo();
            m_Action = new AgentAction();
            m_Sensors = new List<ISensor>();

            if (academy == null)
            {
                throw new UnityAgentsException(
                    "No Academy Component could be found in the scene.");
            }

            academy.AgentSetStatus += SetStatus;
            academy.AgentResetIfDone += ResetIfDone;
            academy.AgentSendState += SendInfo;
            academy.DecideAction += DecideAction;
            academy.AgentAct += AgentStep;
            academy.AgentForceReset += _AgentReset;
            m_PolicyFactory = GetComponent<BehaviorParameters>();
            m_Brain = m_PolicyFactory.GeneratePolicy(Heuristic);
            ResetData();
            InitializeAgent();
            InitializeSensors();
        }

        /// Monobehavior function that is called when the attached GameObject
        /// becomes disabled or inactive.
        void OnDisable()
        {
            var academy = FindObjectOfType<Academy>();
            if (academy != null)
            {
                academy.AgentSetStatus -= SetStatus;
                academy.AgentResetIfDone -= ResetIfDone;
                academy.AgentSendState -= SendInfo;
                academy.DecideAction -= DecideAction;
                academy.AgentAct -= AgentStep;
                academy.AgentForceReset -= ForceReset;
            }
            m_Brain?.Dispose();
        }

        /// <summary>
        /// Updates the Model for the agent. Any model currently assigned to the
        /// agent will be replaced with the provided one. If the arguments are
        /// identical to the current parameters of the agent, the model will
        /// remain unchanged.
        /// </summary>
        /// <param name="behaviorName"> The identifier of the behavior. This
        /// will categorize the agent when training.
        /// </param>
        /// <param name="model"> The model to use for inference.</param>
        /// <param name = "inferenceDevide"> Define on what device the model
        /// will be run.</param>
        public void GiveModel(
            string behaviorName,
            NNModel model,
            InferenceDevice inferenceDevice = InferenceDevice.CPU)
        {
            m_PolicyFactory.GiveModel(behaviorName, model, inferenceDevice);
            m_Brain?.Dispose();
            m_Brain = m_PolicyFactory.GeneratePolicy(Heuristic);
        }

        /// <summary>
        /// Returns the current step counter (within the current epside).
        /// </summary>
        /// <returns>
        /// Current episode number.
        /// </returns>
        public int GetStepCount()
        {
            return m_StepCount;
        }

        /// <summary>
        /// Resets the step reward and possibly the episode reward for the agent.
        /// </summary>
        public void ResetReward()
        {
            m_Reward = 0f;
            if (m_Done)
            {
                m_CumulativeReward = 0f;
            }
        }

        /// <summary>
        /// Overrides the current step reward of the agent and updates the episode
        /// reward accordingly.
        /// </summary>
        /// <param name="reward">The new value of the reward.</param>
        public void SetReward(float reward)
        {
            m_CumulativeReward += (reward - m_Reward);
            m_Reward = reward;
        }

        /// <summary>
        /// Increments the step and episode rewards by the provided value.
        /// </summary>
        /// <param name="increment">Incremental reward value.</param>
        public void AddReward(float increment)
        {
            m_Reward += increment;
            m_CumulativeReward += increment;
        }

        /// <summary>
        /// Retrieves the step reward for the Agent.
        /// </summary>
        /// <returns>The step reward.</returns>
        public float GetReward()
        {
            return m_Reward;
        }

        /// <summary>
        /// Retrieves the episode reward for the Agent.
        /// </summary>
        /// <returns>The episode reward.</returns>
        public float GetCumulativeReward()
        {
            return m_CumulativeReward;
        }

        /// <summary>
        /// Sets the done flag to true.
        /// </summary>
        public void Done()
        {
            m_Done = true;
        }

        /// <summary>
        /// Is called when the agent must request the brain for a new decision.
        /// </summary>
        public void RequestDecision()
        {
            m_RequestDecision = true;
            RequestAction();
        }

        /// <summary>
        /// Is called then the agent must perform a new action.
        /// </summary>
        public void RequestAction()
        {
            m_RequestAction = true;
        }

        /// <summary>
        /// Indicates if the agent has reached his maximum number of steps.
        /// </summary>
        /// <returns>
        /// <c>true</c>, if max step reached was reached, <c>false</c> otherwise.
        /// </returns>
        public bool IsMaxStepReached()
        {
            return m_MaxStepReached;
        }

        /// <summary>
        /// Indicates if the agent is done
        /// </summary>
        /// <returns>
        /// <c>true</c>, if the agent is done, <c>false</c> otherwise.
        /// </returns>
        public bool IsDone()
        {
            return m_Done;
        }

        /// Helper function that resets all the data structures associated with
        /// the agent. Typically used when the agent is being initialized or reset
        /// at the end of an episode.
        void ResetData()
        {
            var param = m_PolicyFactory.brainParameters;
            m_ActionMasker = new ActionMasker(param);
            // If we haven't initialized vectorActions, initialize to 0. This should only
            // happen during the creation of the Agent. In subsequent episodes, vectorAction
            // should stay the previous action before the Done(), so that it is properly recorded.
            if (m_Action.vectorActions == null)
            {
                if (param.vectorActionSpaceType == SpaceType.Continuous)
                {
                    m_Action.vectorActions = new float[param.vectorActionSize[0]];
                    m_Info.storedVectorActions = new float[param.vectorActionSize[0]];
                }
                else
                {
                    m_Action.vectorActions = new float[param.vectorActionSize.Length];
                    m_Info.storedVectorActions = new float[param.vectorActionSize.Length];
                }
            }

            if (m_Info.textObservation == null)
                m_Info.textObservation = "";
            m_Action.textActions = "";
            m_Info.memories = new List<float>();
            m_Action.memories = new List<float>();
            m_Info.vectorObservation =
                new List<float>(param.vectorObservationSize);
            m_Info.stackedVectorObservation =
                new List<float>(param.vectorObservationSize
                    * param.numStackedVectorObservations);
            m_Info.stackedVectorObservation.AddRange(
                new float[param.vectorObservationSize
                          * param.numStackedVectorObservations]);

            m_Info.compressedObservations = new List<CompressedObservation>();
            m_Info.customObservation = null;
        }

        /// <summary>
        /// Initializes the agent, called once when the agent is enabled. Can be
        /// left empty if there is no special, unique set-up behavior for the
        /// agent.
        /// </summary>
        /// <remarks>
        /// One sample use is to store local references to other objects in the
        /// scene which would facilitate computing this agents observation.
        /// </remarks>
        public virtual void InitializeAgent()
        {
        }


        /// <summary>
        /// When the Agent uses Heuristics, it will call this method every time it
        /// needs an action. This can be used for debugging or controlling the agent
        /// with keyboard.
        /// </summary>
        /// <returns> A float array corresponding to the next action of the Agent
        /// </returns>
        public virtual float[] Heuristic()
        {
            throw new UnityAgentsException(string.Format(
                    "The Heuristic method was not implemented for the Agent on the " +
                    "{0} GameObject.",
                    gameObject.name));
        }

        /// <summary>
        /// Set up the list of ISensors on the Agent. By default, this will select any
        /// SensorBase's attached to the Agent.
        /// </summary>
        public void InitializeSensors()
        {
            var attachedSensorComponents = GetComponents<SensorComponent>();
            m_Sensors.Capacity += attachedSensorComponents.Length;
            foreach (var component in attachedSensorComponents)
            {
                m_Sensors.Add(component.CreateSensor());
            }

            // Sort the sensors by name to ensure determinism
            m_Sensors.Sort((x, y) => x.GetName().CompareTo(y.GetName()));

#if DEBUG
            // Make sure the names are actually unique
            for (var i = 0; i < m_Sensors.Count - 1; i++)
            {
                Debug.Assert(!m_Sensors[i].GetName().Equals(m_Sensors[i + 1].GetName()), "Sensor names must be unique.");
            }
#endif
        }

        /// <summary>
        /// Sends the Agent info to the linked Brain.
        /// </summary>
        void SendInfoToBrain()
        {
            if (m_Brain == null)
            {
                return;
            }

            m_Info.memories = m_Action.memories;
            m_Info.storedVectorActions = m_Action.vectorActions;
            m_Info.storedTextActions = m_Action.textActions;
            m_Info.vectorObservation.Clear();
            m_Info.compressedObservations.Clear();
            m_ActionMasker.ResetMask();
            using (TimerStack.Instance.Scoped("CollectObservations"))
            {
                CollectObservations();
            }
            m_Info.actionMasks = m_ActionMasker.GetMask();

            var param = m_PolicyFactory.brainParameters;
            if (m_Info.vectorObservation.Count != param.vectorObservationSize)
            {
                throw new UnityAgentsException(string.Format(
                    "Vector Observation size mismatch in continuous " +
                    "agent {0}. " +
                    "Was Expecting {1} but received {2}. ",
                    gameObject.name,
                    param.vectorObservationSize,
                    m_Info.vectorObservation.Count));
            }

            Utilities.ShiftLeft(m_Info.stackedVectorObservation, param.vectorObservationSize);
            Utilities.ReplaceRange(m_Info.stackedVectorObservation, m_Info.vectorObservation,
                m_Info.stackedVectorObservation.Count - m_Info.vectorObservation.Count);

            m_Info.reward = m_Reward;
            m_Info.done = m_Done;
            m_Info.maxStepReached = m_MaxStepReached;
            m_Info.id = m_Id;

            m_Brain.RequestDecision(this);

            if (m_Recorder != null && m_Recorder.record && Application.isEditor)
            {
                // This is a bit of a hack - if we're in inference mode, compressed observations won't be generated
                // But we need these to be generated for the recorder. So generate them here.
                if (m_Info.compressedObservations.Count == 0)
                {
                    GenerateSensorData();
                }

                m_Recorder.WriteExperience(m_Info);
            }

            m_Info.textObservation = "";
        }

        /// <summary>
        /// Generate data for each sensor and store it on the Agent's AgentInfo.
        /// NOTE: At the moment, this is only called during training or when using a DemonstrationRecorder;
        /// during inference the sensors are used to write directly to the Tensor data. This will likely change in the
        /// future to be controlled by the type of brain being used.
        /// </summary>
        public void GenerateSensorData()
        {
            // Generate data for all sensors
            // TODO add bool argument indicating when to compress? For now, we always will compress.
            for (var i = 0; i < m_Sensors.Count; i++)
            {
                var sensor = m_Sensors[i];
                var compressedObs = new CompressedObservation
                {
                    Data = sensor.GetCompressedObservation(),
                    Shape = sensor.GetFloatObservationShape(),
                    CompressionType = sensor.GetCompressionType()
                };
                m_Info.compressedObservations.Add(compressedObs);
            }
        }

        /// <summary>
        /// Collects the (vector, visual, text) observations of the agent.
        /// The agent observation describes the current environment from the
        /// perspective of the agent.
        /// </summary>
        /// <remarks>
        /// Simply, an agents observation is any environment information that helps
        /// the Agent acheive its goal. For example, for a fighting Agent, its
        /// observation could include distances to friends or enemies, or the
        /// current level of ammunition at its disposal.
        /// Recall that an Agent may attach vector, visual or textual observations.
        /// Vector observations are added by calling the provided helper methods:
        ///     - <see cref="AddVectorObs(int)"/>
        ///     - <see cref="AddVectorObs(float)"/>
        ///     - <see cref="AddVectorObs(Vector3)"/>
        ///     - <see cref="AddVectorObs(Vector2)"/>
        ///     - <see>
        ///         <cref>AddVectorObs(float[])</cref>
        ///       </see>
        ///     - <see>
        ///         <cref>AddVectorObs(List{float})</cref>
        ///      </see>
        ///     - <see cref="AddVectorObs(Quaternion)"/>
        ///     - <see cref="AddVectorObs(bool)"/>
        ///     - <see cref="AddVectorObs(int, int)"/>
        /// Depending on your environment, any combination of these helpers can
        /// be used. They just need to be used in the exact same order each time
        /// this method is called and the resulting size of the vector observation
        /// needs to match the vectorObservationSize attribute of the linked Brain.
        /// Visual observations are implicitly added from the cameras attached to
        /// the Agent.
        /// Lastly, textual observations are added using
        /// <see cref="SetTextObs(string)"/>.
        /// </remarks>
        public virtual void CollectObservations()
        {
        }

        /// <summary>
        /// Sets an action mask for discrete control agents. When used, the agent will not be
        /// able to perform the action passed as argument at the next decision. If no branch is
        /// specified, the default branch will be 0. The actionIndex or actionIndices correspond
        /// to the action the agent will be unable to perform.
        /// </summary>
        /// <param name="actionIndices">The indices of the masked actions on branch 0</param>
        protected void SetActionMask(IEnumerable<int> actionIndices)
        {
            m_ActionMasker.SetActionMask(0, actionIndices);
        }

        /// <summary>
        /// Sets an action mask for discrete control agents. When used, the agent will not be
        /// able to perform the action passed as argument at the next decision. If no branch is
        /// specified, the default branch will be 0. The actionIndex or actionIndices correspond
        /// to the action the agent will be unable to perform.
        /// </summary>
        /// <param name="actionIndex">The index of the masked action on branch 0</param>
        protected void SetActionMask(int actionIndex)
        {
            m_ActionMasker.SetActionMask(0, new[] { actionIndex });
        }

        /// <summary>
        /// Sets an action mask for discrete control agents. When used, the agent will not be
        /// able to perform the action passed as argument at the next decision. If no branch is
        /// specified, the default branch will be 0. The actionIndex or actionIndices correspond
        /// to the action the agent will be unable to perform.
        /// </summary>
        /// <param name="branch">The branch for which the actions will be masked</param>
        /// <param name="actionIndex">The index of the masked action</param>
        protected void SetActionMask(int branch, int actionIndex)
        {
            m_ActionMasker.SetActionMask(branch, new[] { actionIndex });
        }

        /// <summary>
        /// Modifies an action mask for discrete control agents. When used, the agent will not be
        /// able to perform the action passed as argument at the next decision. If no branch is
        /// specified, the default branch will be 0. The actionIndex or actionIndices correspond
        /// to the action the agent will be unable to perform.
        /// </summary>
        /// <param name="branch">The branch for which the actions will be masked</param>
        /// <param name="actionIndices">The indices of the masked actions</param>
        protected void SetActionMask(int branch, IEnumerable<int> actionIndices)
        {
            m_ActionMasker.SetActionMask(branch, actionIndices);
        }

        /// <summary>
        /// Adds a float observation to the vector observations of the agent.
        /// Increases the size of the agents vector observation by 1.
        /// </summary>
        /// <param name="observation">Observation.</param>
        protected void AddVectorObs(float observation)
        {
            m_Info.vectorObservation.Add(observation);
        }

        /// <summary>
        /// Adds an integer observation to the vector observations of the agent.
        /// Increases the size of the agents vector observation by 1.
        /// </summary>
        /// <param name="observation">Observation.</param>
        protected void AddVectorObs(int observation)
        {
            m_Info.vectorObservation.Add(observation);
        }

        /// <summary>
        /// Adds an Vector3 observation to the vector observations of the agent.
        /// Increases the size of the agents vector observation by 3.
        /// </summary>
        /// <param name="observation">Observation.</param>
        protected void AddVectorObs(Vector3 observation)
        {
            m_Info.vectorObservation.Add(observation.x);
            m_Info.vectorObservation.Add(observation.y);
            m_Info.vectorObservation.Add(observation.z);
        }

        /// <summary>
        /// Adds an Vector2 observation to the vector observations of the agent.
        /// Increases the size of the agents vector observation by 2.
        /// </summary>
        /// <param name="observation">Observation.</param>
        protected void AddVectorObs(Vector2 observation)
        {
            m_Info.vectorObservation.Add(observation.x);
            m_Info.vectorObservation.Add(observation.y);
        }

        /// <summary>
        /// Adds a collection of float observations to the vector observations of the agent.
        /// Increases the size of the agents vector observation by size of the collection.
        /// </summary>
        /// <param name="observation">Observation.</param>
        protected void AddVectorObs(IEnumerable<float> observation)
        {
            m_Info.vectorObservation.AddRange(observation);
        }

        /// <summary>
        /// Adds a quaternion observation to the vector observations of the agent.
        /// Increases the size of the agents vector observation by 4.
        /// </summary>
        /// <param name="observation">Observation.</param>
        protected void AddVectorObs(Quaternion observation)
        {
            m_Info.vectorObservation.Add(observation.x);
            m_Info.vectorObservation.Add(observation.y);
            m_Info.vectorObservation.Add(observation.z);
            m_Info.vectorObservation.Add(observation.w);
        }

        /// <summary>
        /// Adds a boolean observation to the vector observation of the agent.
        /// Increases the size of the agent's vector observation by 1.
        /// </summary>
        /// <param name="observation"></param>
        protected void AddVectorObs(bool observation)
        {
            m_Info.vectorObservation.Add(observation ? 1f : 0f);
        }

        protected void AddVectorObs(int observation, int range)
        {
            var oneHotVector = new float[range];
            oneHotVector[observation] = 1;
            m_Info.vectorObservation.AddRange(oneHotVector);
        }

        /// <summary>
        /// Sets the text observation.
        /// </summary>
        /// <param name="textObservation">The text observation.</param>
        public void SetTextObs(string textObservation)
        {
            m_Info.textObservation = textObservation;
        }

        /// <summary>
        /// Specifies the agent behavior at every step based on the provided
        /// action.
        /// </summary>
        /// <param name="vectorAction">
        /// Vector action. Note that for discrete actions, the provided array
        /// will be of length 1.
        /// </param>
        /// <param name="textAction">Text action.</param>
        public virtual void AgentAction(float[] vectorAction, string textAction)
        {
        }

        /// <summary>
        /// Specifies the agent behavior at every step based on the provided
        /// action.
        /// </summary>
        /// <param name="vectorAction">
        /// Vector action. Note that for discrete actions, the provided array
        /// will be of length 1.
        /// </param>
        /// <param name="textAction">Text action.</param>
        /// <param name="customAction">
        /// A custom action, defined by the user as custom protobuf message. Useful if the action is hard to encode
        /// as either a flat vector or a single string.
        /// </param>
        public virtual void AgentAction(float[] vectorAction, string textAction, CommunicatorObjects.CustomActionProto customAction)
        {
            // We fall back to not using the custom action if the subclassed Agent doesn't override this method.
            AgentAction(vectorAction, textAction);
        }

        /// <summary>
        /// Specifies the agent behavior when done and
        /// <see cref="AgentParameters.resetOnDone"/> is false. This method can be
        /// used to remove the agent from the scene.
        /// </summary>
        public virtual void AgentOnDone()
        {
        }

        /// <summary>
        /// Specifies the agent behavior when being reset, which can be due to
        /// the agent or Academy being done (i.e. completion of local or global
        /// episode).
        /// </summary>
        public virtual void AgentReset()
        {
        }

        /// <summary>
        /// This method will forcefully reset the agent and will also reset the hasAlreadyReset flag.
        /// This way, even if the agent was already in the process of reseting, it will be reset again
        /// and will not send a Done flag at the next step.
        /// </summary>
        void ForceReset()
        {
            m_HasAlreadyReset = false;
            _AgentReset();
        }

        /// <summary>
        /// An internal reset method that updates internal data structures in
        /// addition to calling <see cref="AgentReset"/>.
        /// </summary>
        void _AgentReset()
        {
            ResetData();
            m_StepCount = 0;
            AgentReset();
        }

        public void UpdateAgentAction(AgentAction action)
        {
            m_Action = action;
        }

        /// <summary>
        /// Updates the vector action.
        /// </summary>
        /// <param name="vectorActions">Vector actions.</param>
        public void UpdateVectorAction(float[] vectorActions)
        {
            m_Action.vectorActions = vectorActions;
        }

        /// <summary>
        /// Updates the memories action.
        /// </summary>
        /// <param name="memories">Memories.</param>
        public void UpdateMemoriesAction(List<float> memories)
        {
            m_Action.memories = memories;
        }

        public void AppendMemoriesAction(List<float> memories)
        {
            m_Action.memories.AddRange(memories);
        }

        public List<float> GetMemoriesAction()
        {
            return m_Action.memories;
        }

        /// <summary>
        /// Updates the value of the agent.
        /// </summary>
        public void UpdateValueAction(float value)
        {
            m_Action.value = value;
        }

        protected float GetValueEstimate()
        {
            return m_Action.value;
        }

        /// <summary>
        /// Scales continuous action from [-1, 1] to arbitrary range.
        /// </summary>
        /// <param name="rawAction"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        protected float ScaleAction(float rawAction, float min, float max)
        {
            var middle = (min + max) / 2;
            var range = (max - min) / 2;
            return rawAction * range + middle;
        }

        /// <summary>
        /// Sets the status of the agent. Will request decisions or actions according
        /// to the Academy's stepcount.
        /// </summary>
        /// <param name="academyStepCounter">Number of current steps in episode</param>
        void SetStatus(int academyStepCounter)
        {
            MakeRequests(academyStepCounter);
        }

        /// Signals the agent that it must reset if its done flag is set to true.
        void ResetIfDone()
        {
            // If an agent is done, then it will also
            // request for a decision and an action
            if (IsDone())
            {
                if (agentParameters.resetOnDone)
                {
                    if (agentParameters.onDemandDecision)
                    {
                        if (!m_HasAlreadyReset)
                        {
                            // If event based, the agent can reset as soon
                            // as it is done
                            _AgentReset();
                            m_HasAlreadyReset = true;
                        }
                    }
                    else if (m_RequestDecision)
                    {
                        // If not event based, the agent must wait to request a
                        // decision before resetting to keep multiple agents in sync.
                        _AgentReset();
                    }
                }
                else
                {
                    m_Terminate = true;
                    RequestDecision();
                }
            }
        }

        /// <summary>
        /// Signals the agent that it must sent its decision to the brain.
        /// </summary>
        void SendInfo()
        {
            if (m_RequestDecision)
            {
                SendInfoToBrain();
                ResetReward();
                m_Done = false;
                m_MaxStepReached = false;
                m_RequestDecision = false;

                m_HasAlreadyReset = false;
            }
        }

        /// Used by the brain to make the agent perform a step.
        void AgentStep()
        {
            if (m_Terminate)
            {
                m_Terminate = false;
                ResetReward();
                m_Done = false;
                m_MaxStepReached = false;
                m_RequestDecision = false;
                m_RequestAction = false;

                m_HasAlreadyReset = false;
                OnDisable();
                AgentOnDone();
            }

            if ((m_RequestAction) && (m_Brain != null))
            {
                m_RequestAction = false;
                AgentAction(m_Action.vectorActions, m_Action.textActions, m_Action.customAction);
            }

            if ((m_StepCount >= agentParameters.maxStep)
                && (agentParameters.maxStep > 0))
            {
                m_MaxStepReached = true;
                Done();
            }

            m_StepCount += 1;
        }

        /// <summary>
        /// Is called after every step, contains the logic to decide if the agent
        /// will request a decision at the next step.
        /// </summary>
        void MakeRequests(int academyStepCounter)
        {
            agentParameters.numberOfActionsBetweenDecisions =
                Mathf.Max(agentParameters.numberOfActionsBetweenDecisions, 1);
            if (!agentParameters.onDemandDecision)
            {
                RequestAction();
                if (academyStepCounter %
                    agentParameters.numberOfActionsBetweenDecisions == 0)
                {
                    RequestDecision();
                }
            }
        }

        void DecideAction()
        {
            m_Brain?.DecideAction();
        }

        /// <summary>
        /// Sets the custom observation for the agent for this episode.
        /// </summary>
        /// <param name="customObservation">New value of the agent's custom observation.</param>
        public void SetCustomObservation(CommunicatorObjects.CustomObservationProto customObservation)
        {
            m_Info.customObservation = customObservation;
        }
    }
}

// --> ML Agents utilities code

using UnityEngine;
using System.Collections.Generic;
using MLAgents.InferenceBrain;

namespace MLAgents
{
    public static class Utilities
    {
        /// <summary>
        /// Converts a list of Texture2D into a TensorProxy.
        /// </summary>
        /// <param name="textures">
        /// The list of textures to be put into the tensor.
        /// Note that the textures must have same width and height.
        /// </param>
        /// <param name="tensorProxy">
        /// TensorProxy to fill with Texture data.
        /// </param>
        /// <param name="grayScale">
        /// If set to <c>true</c> the textures will be converted to grayscale before
        /// being stored in the tensor.
        /// </param>
        public static void TextureToTensorProxy(
            List<Texture2D> textures,
            TensorProxy tensorProxy,
            bool grayScale)
        {
            var numTextures = textures.Count;
            var width = textures[0].width;
            var height = textures[0].height;

            for (var t = 0; t < numTextures; t++)
            {
                var texture = textures[t];
                Debug.Assert(width == texture.width, "All Textures must have the same dimension");
                Debug.Assert(height == texture.height, "All Textures must have the same dimension");
                TextureToTensorProxy(texture, tensorProxy, grayScale, t);
            }
        }

        /// <summary>
        /// Puts a Texture2D into a TensorProxy.
        /// </summary>
        /// <param name="texture">
        /// The texture to be put into the tensor.
        /// </param>
        /// <param name="tensorProxy">
        /// TensorProxy to fill with Texture data.
        /// </param>
        /// <param name="grayScale">
        /// If set to <c>true</c> the textures will be converted to grayscale before
        /// being stored in the tensor.
        /// </param>
        /// <param name="textureOffset">
        /// Index of the texture being written.
        /// </param>
        public static void TextureToTensorProxy(
            Texture2D texture,
            TensorProxy tensorProxy,
            bool grayScale,
            int textureOffset = 0)
        {
            var width = texture.width;
            var height = texture.height;
            var data = tensorProxy.data;

            var t = textureOffset;
            var texturePixels = texture.GetPixels32();
            // During training, we convert from Texture to PNG before sending to the trainer, which has the
            // effect of flipping the image. We need another flip here at inference time to match this.
            for (var h = height - 1; h >= 0; h--)
            {
                for (var w = 0; w < width; w++)
                {
                    var currentPixel = texturePixels[(height - h - 1) * width + w];
                    if (grayScale)
                    {
                        data[t, h, w, 0] =
                            (currentPixel.r + currentPixel.g + currentPixel.b) / 3f / 255.0f;
                    }
                    else
                    {
                        // For Color32, the r, g and b values are between 0 and 255.
                        data[t, h, w, 0] = currentPixel.r / 255.0f;
                        data[t, h, w, 1] = currentPixel.g / 255.0f;
                        data[t, h, w, 2] = currentPixel.b / 255.0f;
                    }
                }
            }

        }

        /// <summary>
        /// Calculates the cumulative sum of an integer array. The result array will be one element
        /// larger than the input array since it has a padded 0 at the beginning.
        /// If the input is [a, b, c], the result will be [0, a, a+b, a+b+c]
        /// </summary>
        /// <param name="input">
        /// Input array whose elements will be cumulatively added
        /// </param>
        /// <returns> The cumulative sum of the input array.</returns>
        public static int[] CumSum(int[] input)
        {
            var runningSum = 0;
            var result = new int[input.Length + 1];
            for (var actionIndex = 0; actionIndex < input.Length; actionIndex++)
            {
                runningSum += input[actionIndex];
                result[actionIndex + 1] = runningSum;
            }
            return result;
        }

        /// <summary>
        /// Shifts list elements to the left by the specified amount (in-place).
        /// <param name="list">
        /// List whose elements will be shifted
        /// </param>
        /// <param name="shiftAmount">
        /// Amount to shift the elements to the left by
        /// </param>
        /// </summary>
        public static void ShiftLeft<T>(List<T> list, int shiftAmount)
        {
            for (var i = shiftAmount; i < list.Count; i++)
            {
                list[i - shiftAmount] = list[i];
            }
        }

        /// <summary>
        /// Replaces target list elements with source list elements starting at specified position
        /// in target list.
        /// <param name="dst">
        /// Target list, where the elements are added to
        /// </param>
        /// <param name="src">
        /// Source array, where the elements are copied from
        /// </param>
        /// <param name="start">
        /// Starting position in target list to copy elements to
        /// </param>
        /// </summary>
        public static void ReplaceRange<T>(List<T> dst, List<T> src, int start)
        {
            for (var i = 0; i < src.Count; i++)
            {
                dst[i + start] = src[i];
            }
        }

        /// <summary>
        /// Adds elements to list without extra temp allocations (assuming it fits pre-allocated
        /// capacity of the list). The built-in List/<T/>.AddRange() unfortunately allocates
        /// a temporary list to add items (even if the original array has sufficient capacity):
        /// https://stackoverflow.com/questions/2123161/listt-addrange-implementation-suboptimal
        /// Note: this implementation might be slow with a large source array.
        /// <param name="dst">
        /// Target list, where the elements are added to
        /// </param>
        /// <param name="src">
        /// Source array, where the elements are copied from
        /// </param>
        /// </summary>
        // ReSharper disable once ParameterTypeCanBeEnumerable.Global
        public static void AddRangeNoAlloc<T>(List<T> dst, T[] src)
        {
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var item in src)
            {
                dst.Add(item);
            }
        }
    }
}

// --> Saving data locally

// Save game session function
public void SaveGame()
    {
        // 1
        Save save = CreateSaveGameObject();

        // 2
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();

        // 3
        hits = 0;
        shots = 0;
        shotsText.text = "Shots: " + shots;
        hitsText.text = "Hits: " + hits;

        ClearRobots();
        ClearBullets();
        Debug.Log("Game Saved");
    }
    
    // Creating save file
    private Save CreateSaveGameObject()
    {
        Save save = new Save();
        int i = 0;
        foreach (GameObject targetGameObject in targets)
        {
            Target target = targetGameObject.GetComponent<Target>();
            if (target.activeRobot != null)
            {
                save.livingTargetPositions.Add(target.position);
                save.livingTargetsTypes.Add((int)target.activeRobot.GetComponent<Robot>().type);
                i++;
            }
        }

        save.hits = hits;
        save.shots = shots;

        return save;
    }
    
    // Load saved game session
    public void LoadGame()
    {
        // 1
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {
            ClearBullets();
            ClearRobots();
            RefreshRobots();

            // 2
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            // 3
            for (int i = 0; i < save.livingTargetPositions.Count; i++)
            {
                int position = save.livingTargetPositions[i];
                Target target = targets[position].GetComponent<Target>();
                target.ActivateRobot((RobotTypes)save.livingTargetsTypes[i]);
                target.GetComponent<Target>().ResetDeathTimer();
            }

            // 4
            shotsText.text = "Shots: " + save.shots;
            hitsText.text = "Hits: " + save.hits;
            shots = save.shots;
            hits = save.hits;

            Debug.Log("Game Loaded");

            Unpause();
        }
        else
        {
            Debug.Log("No game saved!");
        }
    }
    
    //Saving game session as a JSON file
    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
    }
    
// --> Player death and respawning
    
    // 1
	public void GameOver()
	{
		isGameOver = true;
		Time.timeScale = 0;
		player.GetComponent<FirstPersonController>().enabled = false;
		player.GetComponent<CharacterController>().enabled = false;
		gameOverPanel.SetActive(true);
	}

	// 2
	public void RestartGame()
	{
		SceneManager.LoadScene(Constants.SceneBattle);
		gameOverPanel.SetActive(true);
	}
