using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack
{
    /// <summary>
    /// Represents a user in the FitTrack application.
    /// Stores username and provides workout suggestions and reward checks.
    /// </summary>
    public class SampleUser
    {
        // Username is set during object creation and cannot be changed later
        public string userName { get; }

        /// <summary>
        /// Constructor used to initialize the username.
        /// </summary>
        /// <param name="name">Name of the user</param>
        public SampleUser(string name)
        {
            userName = name;
        }

        /// <summary>
        /// Returns workout suggestion based on intensity level.
        /// </summary>
        /// <param name="intensity">Workout intensity level (1–3)</param>
        /// <returns>Suggested workout type</returns>
        public string Workout(int intensity)
        {
            string suggestion = "";

            // Select workout based on intensity level
            switch (intensity)
            {
                case 1:
                    suggestion = "Walk";
                    break;

                case 2:
                    suggestion = "Jog";
                    break;

                case 3:
                    suggestion = "Run";
                    break;

                default:
                    suggestion = "Invalid Intensity";
                    break;
            }

            return suggestion;
        }

        /// <summary>
        /// Checks if the user qualifies for the Pro Medal reward.
        /// </summary>
        /// <param name="stepsCount">Total number of steps</param>
        /// <param name="activeDay">Number of active days</param>
        /// <returns>Status message of reward eligibility</returns>
        public string Prize(int stepsCount, int activeDay)
        {
            try
            {
                // Condition to unlock Pro Medal
                if (stepsCount > 10000 && activeDay > 30)
                {
                    return "Pro Medal Unlocked!";
                }
                else
                {
                    return "Pro Medal is still locked!!!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}