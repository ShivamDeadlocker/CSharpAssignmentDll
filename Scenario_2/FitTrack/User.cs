using System;

namespace FitTrack
{
    /// <summary>
    /// Represents a user in the FitTrack application.
    /// Handles age validation, membership calculation and fitness activities.
    /// </summary>
    public class User
    {
        // Stores validated age
        int validAge;

        // Message used to display validation result
        public string alert { get; set; }

        /// <summary>
        /// Property used to set and validate the user's age.
        /// </summary>
        public int age
        {
            get
            {
                return validAge;
            }
            set
            {
                // Validate age range
                if (value < 0 || value > 120)
                {
                    alert = Display("Age is invalid!!!!");
                }
                else
                {
                    validAge = value;
                    alert = Display("Age is valid!!!!");
                }
            }
        }

        /// <summary>
        /// Calculates gym membership fee based on user age.
        /// </summary>
        /// <returns>Membership amount</returns>
        public double GetAmount()
        {
            double amount = 50;

            // Discount for students or senior citizens
            if (validAge < 18 || validAge > 65)
            {
                return amount = 50 * 0.20;
            }
            else
            {
                return amount;
            }
        }

        /// <summary>
        /// Returns a string message.
        /// Used to display alerts in the UI.
        /// </summary>
        public static string Display(string msg)
        {
            return msg;
        }

        /// <summary>
        /// Simulates a plank challenge and shows milestone completion.
        /// </summary>
        /// <returns>Achievement messages</returns>
        public string PlankChallange()
        {
            try
            {
                string achieve = "";
                int timer = 0;

                // Loop increases timer in steps of 10 seconds
                while (timer <= 60)
                {
                    if (timer == 10)
                    {
                        achieve += "10 Second Completed<br/>";
                    }

                    if (timer == 20)
                    {
                        achieve += "20 Second Completed<br/>";
                    }

                    if (timer == 30)
                    {
                        achieve += "30 Second Completed<br/>";
                    }

                    if (timer == 60)
                    {
                        achieve += "60 Second Completed<br/>";
                    }

                    timer += 10;
                }

                return achieve;
            }
            catch (Exception ex)
            {
                return Display(ex.Message);
            }
        }

        /// <summary>
        /// Calculates BMI using height and weight.
        /// </summary>
        /// <param name="height">Height in meters</param>
        /// <param name="weight">Weight in kilograms</param>
        /// <returns>BMI value</returns>
        public static double Bmi(double height, double weight)
        {
            try
            {
                // Basic validation
                if (height <= 0 || weight <= 0)
                {
                    return 0;
                }
                else
                {
                    double bmi = weight / (height * height);
                    return Math.Round(bmi, 2);
                }
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Simulates running laps and gives a message at lap 3.
        /// </summary>
        /// <returns>Lap progress messages</returns>
        public string Running()
        {
            string Lap = "";

            // Loop for 5 laps
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                {
                    Lap += "Take a Drink break, Lap number: " + i + "<br/>";
                }
                else
                {
                    Lap += "You are on Lap number: " + i + "<br/>";
                }
            }

            return Lap;
        }
    }
}