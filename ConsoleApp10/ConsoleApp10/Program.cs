using System;

class Program
{







    static void Main()
    {
        Console.Title = "PS 1A";
    start:
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                          Press Enter to Start!");
        Console.ResetColor();
        string start = Console.ReadLine();
        Console.Clear();

        while (true)
        {
        back:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("             _________________________                                 ________________________                                 ________________________");
            Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
            Console.WriteLine("             |      ___________      |                                 |      _________       |                                 |      _________       |");
            Console.WriteLine("             |     |           |     |                                 |     |         |      |                                 |     |         |      |");
            Console.WriteLine("             |     |           |     |                                 |     |         |      |                                 |     |         |      |");
            Console.WriteLine("             |     |     1     |     |                                 |     |    2    |      |                                 |     |    3    |      |");
            Console.WriteLine("             |     |           |     |                                 |     |         |      |                                 |     |         |      |");
            Console.WriteLine("             |     |___________|     |                                 |     |_________|      |                                 |     |_________|      |");
            Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
            Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
            Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
            Console.WriteLine("            < >----------------------|                                ( )---------------------|                                { }---------------------|");
            Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
            Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
            Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
            Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
            Console.WriteLine("             |      FAMILY FEUD      |                                 |  ROCK PAPER SCISSOR  |                                 |      TIC TAC TOE     |");
            Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
            Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
            Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
            Console.WriteLine("             |_______________________|                                 |______________________|                                 |______________________|\n\n\n");
            Console.ResetColor();

            Console.WriteLine("                                                                             Select Door (1/2/3): ");
            Console.Write("                                                                                 Number: ");

            while (true)
            {
                try
                {
                    int select = Convert.ToInt32(Console.ReadLine());

                again:
                    if (select == 1)
                    {
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                         Select Level from 1-5: ");
                        Console.ResetColor();
                        Console.Write("                                                                                    ");
                        while (true)
                        {
                            try
                            {
                                int level = Convert.ToInt32(Console.ReadLine());

                                int error = 0;
                                Console.WriteLine("error" + error);

                                if (level == 1)
                                {

                                first:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                    Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);

                                    Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("                                                                             1. ");
                                    Console.WriteLine("                                                                             2. ");
                                    Console.WriteLine("                                                                             3. \n");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                    Console.WriteLine("                                                             Favorite place to spend leisure time inside LSPU-SPCC");
                                    Console.Write("                                                                             Answer: ");
                                    if (error == 3)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                        Console.Write("                                                                             Answer: ");
                                        string decide = Console.ReadLine().ToLower();
                                        if (decide == "y")
                                        {
                                            goto again;
                                        }
                                        else
                                        {
                                            goto start;
                                        }
                                    }
                                    string answer = Console.ReadLine().ToUpper();


                                    if (answer == "HANGOUT" || answer == "HANG OUT" || answer == "CCS HANG OUT" || answer == "CCS HANGOUT")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. HANGOUT ");
                                        Console.WriteLine("                                                                             2. ");
                                        Console.WriteLine("                                                                             3. \n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                             Favorite place to spend leisure time inside LSPU-SPCC");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else
                                            {
                                                goto start;
                                            }
                                        }
                                        string answer2 = Console.ReadLine().ToUpper();

                                        if (answer2 == "KUBO")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. HANGOUT");
                                            Console.WriteLine("                                                                             2. KUBO");
                                            Console.WriteLine("                                                                             3. \n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                             Favorite place to spend leisure time inside LSPU-SPCC");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();


                                            if (answer3 == "LIBRARY" || answer3 == "UNIVERSITY LIBRARY")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. HANGOUT");
                                                Console.WriteLine("                                                                             2. KUBO");
                                                Console.WriteLine("                                                                             3. LIBRARY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }

                                        else if (answer2 == "LIBRARY" || answer2 == "UNIVERSITY LIBRARY")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. HANGOUT");
                                            Console.WriteLine("                                                                             2. ");
                                            Console.WriteLine("                                                                             3. LIBRARY\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                             Favorite place to spend leisure time inside LSPU-SPCC");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }

                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "KUBO")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. HANGOUT");
                                                Console.WriteLine("                                                                             2. KUBO");
                                                Console.WriteLine("                                                                             3. LIBRARY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }

                                        else
                                        {
                                            error++;
                                            goto second;
                                        }

                                    }





                                    else if (answer == "KUBO")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. ");
                                        Console.WriteLine("                                                                             2. KUBO");
                                        Console.WriteLine("                                                                             3. \n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                             Favorite place to spend leisure time inside LSPU-SPCC");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }

                                        string answer21 = Console.ReadLine().ToUpper();

                                        if (answer21 == "HANG OUT" || answer21 == "HANGOUT" || answer21 == "CCS HANGOUT" || answer21 == "CCS HANG OUT")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. HANGOUT");
                                            Console.WriteLine("                                                                             2. KUBO");
                                            Console.WriteLine("                                                                             3. \n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                             Favorite place to spend leisure time inside LSPU-SPCC");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "LIBRARY" || answer3 == "UNIVERSITY LIBRARY")
                                            {

                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. HANGOUT");
                                                Console.WriteLine("                                                                             2. KUBO");
                                                Console.WriteLine("                                                                             3. LIBRARY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }

                                        else if (answer21 == "LIBRARY" || answer21 == "UNIVERSITY LIBRARY")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. ");
                                            Console.WriteLine("                                                                             2. KUBO");
                                            Console.WriteLine("                                                                             3. LIBRARY\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                             Favorite place to spend leisure time inside LSPU-SPCC");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "HANGOUT" || answer3 == "HANG OUT" || answer3 == "CCS HANGOUT" || answer3 == "CCS HANG OUT")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                          " +
                                                    "                                                   1. HANGOUT");
                                                Console.WriteLine("                                                                             2. KUBO");
                                                Console.WriteLine("                                                                             3. LIBRARY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }
                                        else
                                        {
                                            error++;
                                            goto second;
                                        }
                                    }






                                    else if (answer == "LIBRARY" || answer == "UNIVERSITY LIBRARY")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. ");
                                        Console.WriteLine("                                                                             2. ");
                                        Console.WriteLine("                                                                             3. LIBRARY\n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                             Favorite place to spend leisure time inside LSPU-SPCC");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }
                                        string answer22 = Console.ReadLine().ToUpper();

                                        if (answer22 == "HANG OUT" || answer22 == "HANGOUT" || answer22 == "CCS HANGOUT" || answer22 == "CCS HANG OUT")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. HANGOUT");
                                            Console.WriteLine("                                                                             2. ");
                                            Console.WriteLine("                                                                             3. LIBRARY\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                             Favorite place to spend leisure time inside LSPU-SPCC");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "KUBO")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. HANGOUT");
                                                Console.WriteLine("                                                                             2. KUBO");
                                                Console.WriteLine("                                                                             3. LIBRARY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }
                                        else if (answer22 == "KUBO")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. ");
                                            Console.WriteLine("                                                                             2. KUBO");
                                            Console.WriteLine("                                                                             3. LIBRARY\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                             Favorite place to spend leisure time inside LSPU-SPCC");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "HANGOUT" || answer3 == "HANG OUT" || answer3 == "CCS HANGOUT" || answer3 == "CCS HANG OUT")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. HANGOUT");
                                                Console.WriteLine("                                                                             2. KUBO");
                                                Console.WriteLine("                                                                             3. LIBRARY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }
                                        else
                                        {
                                            error++;
                                            goto second;
                                        }
                                    }
                                    else
                                    {
                                        error++;
                                        goto first;
                                    }
                                }

























                                if (level == 2)
                                {
                                first:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                    Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                    Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("                                                                             1. ");
                                    Console.WriteLine("                                                                             2. ");
                                    Console.WriteLine("                                                                             3. \n");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                    Console.WriteLine("                                                                  Most challenging subject this first semester");
                                    Console.Write("                                                                             Answer: ");
                                    if (error == 3)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                        Console.Write("                                                                             Answer: ");
                                        string decide = Console.ReadLine().ToLower();
                                        if (decide == "y")
                                        {
                                            goto again;
                                        }
                                        else

                                            goto start;
                                    }
                                    string answer = Console.ReadLine().ToUpper();

                                    if (answer == "FUNDAMENTALS OF PROGRAMMING" || answer == "ITEC 102" || answer == "FUNDAMENTAL OF PROGRAMMING")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. FUNDAMENTALS OF PROGRAMMING ");
                                        Console.WriteLine("                                                                             2. ");
                                        Console.WriteLine("                                                                             3. \n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                                  Most challenging subject this first semester");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }
                                        string answer2 = Console.ReadLine().ToUpper();

                                        if (answer2 == "KOMFIL" || answer2 == "KONTEKSTWALISADONG KOMUNIKASYON SA FILIPINO")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. FUNDAMENTALS OF PROGRAMMING");
                                            Console.WriteLine("                                                                             2. KOMFIL");
                                            Console.WriteLine("                                                                             3. \n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                  Most challenging subject this first semester");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();


                                            if (answer3 == "READINGS IN PHILIPPINE HISTORY" || answer3 == "RPH" || answer3 == "GEC 102")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. FUNDAMENTALS OF PROGRAMMING");
                                                Console.WriteLine("                                                                             2. KOMFIL");
                                                Console.WriteLine("                                                                             3. READINGS IN PHILIPPINE HISTORY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }

                                        else if (answer2 == "READINGS IN PHILIPPINE HISTORY" || answer2 == "RPH" || answer2 == "GEC 102")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. FUNDAMENTALS OF PROGRAMMING");
                                            Console.WriteLine("                                                                             2. ");
                                            Console.WriteLine("                                                                             3. READINGS IN PHILIPPINE HISTORY\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                  Most challenging subject this first semester");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "KOMFIL" || answer3 == "KONTEKSTWALISADONG KOMUNIKASYON SA FILIPINO")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. FUNDAMENTALS OF PROGRAMMINGCHURCH");
                                                Console.WriteLine("                                                                             2. KOMFIL");
                                                Console.WriteLine("                                                                             3. READINGS IN PHILIPPINE HISTORY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }

                                        else
                                        {
                                            error++;
                                            goto second;
                                        }

                                    }





                                    else if (answer == "KOMFIL" || answer == "KONTEKSTWALISADONG KOMUNIKASYON SA FILIPINO")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. ");
                                        Console.WriteLine("                                                                             2. KOMFIL");
                                        Console.WriteLine("                                                                             3. \n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                                  Most challenging subject this first semester");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }

                                        string answer21 = Console.ReadLine().ToUpper();

                                        if (answer21 == "ITEC 102" || answer21 == "FUNDAMENTALS OF PROGRAMMING" || answer21 == "FUNDAMENTAL OF PROGRAMMING")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. FUNDAMENTALS OF PROGRAMMING");
                                            Console.WriteLine("                                                                             2. KOMFIL");
                                            Console.WriteLine("                                                                             3. \n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                  Most challenging subject this first semester");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "RPH" || answer3 == "READINGS IN PHILIPPINE HISTORY" || answer3 == "GEC 102")
                                            {

                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. FUNDAMENTALS OF PROGRAMMING");
                                                Console.WriteLine("                                                                             2. KOMFIL");
                                                Console.WriteLine("                                                                             3. READINGS IN PHILIPPINE HISTORY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }

                                        else if (answer21 == "READINGS IN PHILIPPINE HISTORY" || answer21 == "RPH" || answer21 == "GEC 102")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. ");
                                            Console.WriteLine("                                                                             2. KOMFIL");
                                            Console.WriteLine("                                                                             3. READINGS IN PHILIPPINE HISTORY\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                  Most challenging subject this first semester");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "ITEC 102" || answer3 == "FUNDAMENTAL OF PROGRAMMING" || answer3 == "FUNDAMENTALS OF PROGRAMMING")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. FUNDAMENTALS OF PROGRAMMING");
                                                Console.WriteLine("                                                                             2. KOMFIL");
                                                Console.WriteLine("                                                                             3. READINGS IN PHILIPPINE HISTORY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }
                                        else
                                        {
                                            error++;
                                            goto second;
                                        }
                                    }






                                    else if (answer == "RPH" || answer == "READINGS IN PHILIPPINE HISTORY" || answer == "GEC 102")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. ");
                                        Console.WriteLine("                                                                             2. ");
                                        Console.WriteLine("                                                                             3. READINGS IN PHILIPPINE HISTORY\n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                                  Most challenging subject this first semester");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }
                                        string answer22 = Console.ReadLine().ToUpper();

                                        if (answer22 == "ITEC 102" || answer22 == "FUNDAMENTAL OF PROGRAMMING" || answer22 == "FUNDAMENTALS OF PROGRAMMING")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. FUNDAMENTALS OF PROGRAMMING");
                                            Console.WriteLine("                                                                             2. ");
                                            Console.WriteLine("                                                                             3. READINGS IN PHILIPPINE HISTORY\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                  Most challenging subject this first semester");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "KOMFIL" || answer3 == "KONTEKSTWALISADONG KOMUNIKASYON SA FILIPINO")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. FUNDAMENTALS OF PROGRAMMING");
                                                Console.WriteLine("                                                                             2. KOMFIL");
                                                Console.WriteLine("                                                                             3. READINGS IN PHILIPPINE HISTORY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }
                                        else if (answer22 == "KOMFIL" || answer22 == "KONTEKSTWALISADONG KOMUNIKASYON SA FILIPINO")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. ");
                                            Console.WriteLine("                                                                             2. KOMFIL");
                                            Console.WriteLine("                                                                             3. READINGS IN PHILIPPINE HISTORY\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                  Most challenging subject this first semester");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "ITEC 102" || answer3 == "FUNDAMENTAL OF PROGRAMMING" || answer3 == "FUNDAMENTALS OF PROGRAMMING")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. FUNDAMENTALS OF PROGRAMMING");
                                                Console.WriteLine("                                                                             2. KOMFIL");
                                                Console.WriteLine("                                                                             3. READINGS IN PHILIPPINE HISTORY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }
                                        else
                                        {
                                            error++;
                                            goto second;
                                        }
                                    }
                                    else
                                    {
                                        error++;
                                        goto first;
                                    }
                                }






























































                                if (level == 3)
                                {
                                first:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                    Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                    Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("                                                                             1. ");
                                    Console.WriteLine("                                                                             2. ");
                                    Console.WriteLine("                                                                             3. \n");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                    Console.WriteLine("                                                          Based on first semester's schedule, what is your hatest day?");
                                    Console.Write("                                                                             Answer: ");
                                    if (error == 3)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                        Console.Write("                                                                             Answer: ");
                                        string decide = Console.ReadLine().ToLower();
                                        if (decide == "y")
                                        {
                                            goto again;
                                        }
                                        else

                                            goto start;
                                    }
                                    string answer = Console.ReadLine().ToUpper();

                                    if (answer == "THURSDAY" || answer == "HUWEBES")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. THURSDAY ");
                                        Console.WriteLine("                                                                             2. ");
                                        Console.WriteLine("                                                                             3. \n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                          Based on first semester's schedule, what is your hatest day?");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }
                                        string answer2 = Console.ReadLine().ToUpper();

                                        if (answer2 == "MONDAY" || answer2 == "LUNES")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. THURSDAY");
                                            Console.WriteLine("                                                                             2. MONDAY");
                                            Console.WriteLine("                                                                             3. \n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                          Based on first semester's schedule, what is your hatest day?");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();


                                            if (answer3 == "FRIDAY" || answer3 == "BIYERNES" || answer3 == "BYERNES")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. THURSDAY");
                                                Console.WriteLine("                                                                             2. MONDAY");
                                                Console.WriteLine("                                                                             3. FRIDAY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }

                                        else if (answer2 == "FRIDAY" || answer2 == "BIYERNES" || answer2 == "BYERNES")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. THURSDAY");
                                            Console.WriteLine("                                                                             2. ");
                                            Console.WriteLine("                                                                             3. FRIDAY\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                          Based on first semester's schedule, what is your hatest day?");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "MONDAY" || answer3 == "LUNES")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. THURSDAY");
                                                Console.WriteLine("                                                                             2. MONDAY");
                                                Console.WriteLine("                                                                             3. FRIDAY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }

                                        else
                                        {
                                            error++;
                                            goto second;
                                        }

                                    }





                                    else if (answer == "MONDAY" || answer == "LUNES")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. ");
                                        Console.WriteLine("                                                                             2. MONDAY");
                                        Console.WriteLine("                                                                             3. \n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                          Based on first semester's schedule, what is your hatest day?");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }

                                        string answer21 = Console.ReadLine().ToUpper();

                                        if (answer21 == "THURSDAY" || answer21 == "HUWEBES")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. THURSDAY");
                                            Console.WriteLine("                                                                             2. MONDAY");
                                            Console.WriteLine("                                                                             3. \n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                          Based on first semester's schedule, what is your hatest day?");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "BYERNES" || answer3 == "BIYERNES" || answer3 == "FRIDAY")
                                            {

                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. THURSDAY");
                                                Console.WriteLine("                                                                             2. MONDAY");
                                                Console.WriteLine("                                                                             3. FRIDAY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }

                                        else if (answer21 == "FRIDAY" || answer21 == "BIYERNES" || answer21 == "BYERNES")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. ");
                                            Console.WriteLine("                                                                             2. MONDAY");
                                            Console.WriteLine("                                                                             3. FRIDAY\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                          Based on first semester's schedule, what is your hatest day?");
                                            Console.Write("                                                                             Answer: ");
                                            Console.ForegroundColor = ConsoleColor.Blue; if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "THURSDAY" || answer3 == "HUWEBES")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. THURSDAY");
                                                Console.WriteLine("                                                                             2. MONDAY");
                                                Console.WriteLine("                                                                             3. FRIDAY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }
                                        else
                                        {
                                            error++;
                                            goto second;
                                        }
                                    }






                                    else if (answer == "FRIDAY" || answer == "BYERNES" || answer == "BIYERNES")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. ");
                                        Console.WriteLine("                                                                             2. ");
                                        Console.WriteLine("                                                                             3. FRIDAY\n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                          Based on first semester's schedule, what is your hatest day?");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }
                                        string answer22 = Console.ReadLine().ToUpper();

                                        if (answer22 == "THURSDAY" || answer22 == "HUWEBES")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. THURSDAY");
                                            Console.WriteLine("                                                                             2. ");
                                            Console.WriteLine("                                                                             3. FRIDAY\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                          Based on first semester's schedule, what is your hatest day?");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "MONDAY" || answer3 == "LUNES")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. THURSDAY");
                                                Console.WriteLine("                                                                             2. MONDAY");
                                                Console.WriteLine("                                                                             3. FRIDAY\n");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }
                                        else if (answer22 == "MONDAY" || answer22 == "LUNES")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. ");
                                            Console.WriteLine("                                                                             2. MONDAY");
                                            Console.WriteLine("                                                                             3. FRIDAY\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                          Based on first semester's schedule, what is your hatest day?");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "THURSDAY" || answer3 == "HUWEBES")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. THURSDAY");
                                                Console.WriteLine("                                                                             2. MONDAY");
                                                Console.WriteLine("                                                                             3. FRIDAY\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }
                                        else
                                        {
                                            error++;
                                            goto second;
                                        }
                                    }
                                    else
                                    {
                                        error++;
                                        goto first;
                                    }
                                }



















































                                if (level == 4)
                                {
                                first:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                    Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                    Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("                                                                             1. ");
                                    Console.WriteLine("                                                                             2. ");
                                    Console.WriteLine("                                                                             3. \n");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                    Console.WriteLine("                                                                   Describe all of your teachers in one word");
                                    Console.Write("                                                                             Answer: ");
                                    if (error == 3)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                        Console.Write("                                                                             Answer: ");
                                        string decide = Console.ReadLine().ToLower();
                                        if (decide == "y")
                                        {
                                            goto again;
                                        }
                                        else

                                            goto start;
                                    }
                                    string answer = Console.ReadLine().ToUpper();

                                    if (answer == "KIND" || answer == "MABAIT")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. KIND");
                                        Console.WriteLine("                                                                             2. ");
                                        Console.WriteLine("                                                                             3. \n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                                   Describe all of your teachers in one word");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }
                                        string answer2 = Console.ReadLine().ToUpper();

                                        if (answer2 == "HARD WORKING" || answer2 == "HARDWORKING" || answer2 == "MASIPAG")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. KIND");
                                            Console.WriteLine("                                                                             2. HARDWORKING");
                                            Console.WriteLine("                                                                             3. \n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                   Describe all of your teachers in one word");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();


                                            if (answer3 == "EXCELLENT" || answer3 == "MAHUSAY")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. KIND");
                                                Console.WriteLine("                                                                             2. HARDWORKING");
                                                Console.WriteLine("                                                                             3. EXCELLENT\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }

                                        else if (answer2 == "EXCELLENT" || answer2 == "MAHUSAY")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. KIND");
                                            Console.WriteLine("                                                                             2. ");
                                            Console.WriteLine("                                                                             3. EXCELLENT\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                   Describe all of your teachers in one word");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "HARD WORKING" || answer3 == "HARDWORKING" || answer3 == "MASIPAG")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. KIND");
                                                Console.WriteLine("                                                                             2. HARDWORKING");
                                                Console.WriteLine("                                                                             3. EXCELLENT\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }

                                        else
                                        {
                                            error++;
                                            goto second;
                                        }

                                    }





                                    else if (answer == "HARD WORKING" || answer == "HARDWORKING" || answer == "MASIPAG")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. ");
                                        Console.WriteLine("                                                                             2. HARDWORKING");
                                        Console.WriteLine("                                                                             3. \n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                                   Describe all of your teachers in one word");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }

                                        string answer21 = Console.ReadLine().ToUpper();

                                        if (answer21 == "KIND" || answer21 == "MABAIT")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. KIND");
                                            Console.WriteLine("                                                                             2. HARDWORKING");
                                            Console.WriteLine("                                                                             3. \n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                   Describe all of your teachers in one word");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "MAHUSAY" || answer3 == "EXCELLENT")
                                            {

                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. KIND");
                                                Console.WriteLine("                                                                             2. HARDWORKING");
                                                Console.WriteLine("                                                                             3. EXCELLENT\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }

                                        else if (answer21 == "EXCELLENT" || answer21 == "MAHUSAY")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. ");
                                            Console.WriteLine("                                                                             2. HARDWORKING");
                                            Console.WriteLine("                                                                             3. EXCELLENT\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                   Describe all of your teachers in one word");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "KIND")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. KIND");
                                                Console.WriteLine("                                                                             2. HARDWORKING");
                                                Console.WriteLine("                                                                             3. EXCELLENT\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }
                                        else
                                        {
                                            error++;
                                            goto second;
                                        }
                                    }






                                    else if (answer == "EXCELLENT" || answer == "MAHUSAY")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. ");
                                        Console.WriteLine("                                                                             2. ");
                                        Console.WriteLine("                                                                             3. EXCELLENT\n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                                   Describe all of your teachers in one word");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }
                                        string answer22 = Console.ReadLine().ToUpper();

                                        if (answer22 == "KIND" || answer22 == "MABAIT")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. KIND");
                                            Console.WriteLine("                                                                             2. ");
                                            Console.WriteLine("                                                                             3. EXCELLENT\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                   Describe all of your teachers in one word");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "HARD WORKING" || answer3 == "HARDWORKING" || answer3 == "MASIPAG")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. KIND");
                                                Console.WriteLine("                                                                             2. HARDWORKING");
                                                Console.WriteLine("                                                                             3.  EXCELLENT\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }
                                        else if (answer22 == "HARD WORKING" || answer22 == "MASIPAG" || answer22 == "HARDWORKING")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. ");
                                            Console.WriteLine("                                                                             2. HARDWORKING");
                                            Console.WriteLine("                                                                             3. EXCELLENT\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                   Describe all of your teachers in one word");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "KIND" || answer3 == "MABAIT")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.ResetColor();
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. KIND");
                                                Console.WriteLine("                                                                             2. HARDWORKING");
                                                Console.WriteLine("                                                                             3. EXCELLENT\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }
                                        else
                                        {
                                            error++;
                                            goto second;
                                        }
                                    }
                                    else
                                    {
                                        error++;
                                        goto first;
                                    }
                                }




















































                                if (level == 5)
                                {
                                first:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                    Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                    Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("                                                                             1. ");
                                    Console.WriteLine("                                                                             2. ");
                                    Console.WriteLine("                                                                             3. \n");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                    Console.WriteLine("                                                                  On a scale of 1-10, rate the quality of LSPU");
                                    Console.Write("                                                                             Answer: ");
                                    if (error == 3)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                        Console.Write("                                                                             Answer: ");
                                        string decide = Console.ReadLine().ToLower();
                                        if (decide == "y")
                                        {
                                            goto again;
                                        }
                                        else

                                            goto start;
                                    }
                                    string answer = Console.ReadLine().ToUpper();

                                    if (answer == "9")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. 9 ");
                                        Console.WriteLine("                                                                             2. ");
                                        Console.WriteLine("                                                                             3. \n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                                  On a scale of 1-10, rate the quality of LSPU");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }
                                        string answer2 = Console.ReadLine().ToUpper();

                                        if (answer2 == "8")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. 9");
                                            Console.WriteLine("                                                                             2. 8");
                                            Console.WriteLine("                                                                             3. \n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                  On a scale of 1-10, rate the quality of LSPU");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();


                                            if (answer3 == "7")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. 9");
                                                Console.WriteLine("                                                                             2. 8");
                                                Console.WriteLine("                                                                             3. 7\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }

                                        else if (answer2 == "7")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. 9");
                                            Console.WriteLine("                                                                             2. ");
                                            Console.WriteLine("                                                                             3. 7\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                  On a scale of 1-10, rate the quality of LSPU");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "8")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. 9");
                                                Console.WriteLine("                                                                             2. 8");
                                                Console.WriteLine("                                                                             3. 7\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }

                                        else
                                        {
                                            error++;
                                            goto second;
                                        }

                                    }





                                    else if (answer == "8")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. ");
                                        Console.WriteLine("                                                                             2. 8");
                                        Console.WriteLine("                                                                             3. \n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                                  On a scale of 1-10, rate the quality of LSPU");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }

                                        string answer21 = Console.ReadLine().ToUpper();

                                        if (answer21 == "9")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. 9");
                                            Console.WriteLine("                                                                             2. 8");
                                            Console.WriteLine("                                                                             3. \n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                  On a scale of 1-10, rate the quality of LSPU");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "7")
                                            {

                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.ResetColor();
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. 9");
                                                Console.WriteLine("                                                                             2. 8");
                                                Console.WriteLine("                                                                             3. 7\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }

                                        else if (answer21 == "7")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. ");
                                            Console.WriteLine("                                                                             2. 8");
                                            Console.WriteLine("                                                                             3. 7\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                  On a scale of 1-10, rate the quality of LSPU");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "9")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.ResetColor();
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. 9");
                                                Console.WriteLine("                                                                             2. 8");
                                                Console.WriteLine("                                                                             3. 7\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }
                                        else
                                        {
                                            error++;
                                            goto second;
                                        }
                                    }






                                    else if (answer == "7")
                                    {
                                    second:
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                        Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                        Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("                                                                             1. ");
                                        Console.WriteLine("                                                                             2. ");
                                        Console.WriteLine("                                                                             3. 7\n");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                        Console.WriteLine("                                                                  On a scale of 1-10, rate the quality of LSPU");
                                        Console.Write("                                                                             Answer: ");
                                        if (error == 3)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                            Console.Write("                                                                             Answer: ");
                                            string decide = Console.ReadLine().ToLower();
                                            if (decide == "y")
                                            {
                                                goto again;
                                            }
                                            else

                                                goto start;
                                        }
                                        string answer22 = Console.ReadLine().ToUpper();

                                        if (answer22 == "9")
                                        {
                                        third:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.ResetColor();
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. 9");
                                            Console.WriteLine("                                                                             2. ");
                                            Console.WriteLine("                                                                             3. 7\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                  On a scale of 1-10, rate the quality of LSPU");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "8")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.ResetColor();
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. 9");
                                                Console.WriteLine("                                                                             2. 8");
                                                Console.WriteLine("                                                                             3. 7\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }

                                            else
                                            {
                                                error++;
                                                goto third;
                                            }
                                        }
                                        else if (answer22 == "8")
                                        {
                                        third2:
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                            Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                            Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("                                                                             1. ");
                                            Console.WriteLine("                                                                             2. 8");
                                            Console.WriteLine("                                                                             3. 7\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("                                                                     Nagsurvey kami ng 30 BSCS 1A students.");
                                            Console.WriteLine("                                                                  On a scale of 1-10, rate the quality of LSPU");
                                            Console.Write("                                                                             Answer: ");
                                            if (error == 3)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Game Over\n                                                           Type Y if want to play again and any key if no.");
                                                Console.Write("                                                                             Answer: ");
                                                string decide = Console.ReadLine().ToLower();
                                                if (decide == "y")
                                                {
                                                    goto again;
                                                }
                                                else

                                                    goto start;
                                            }
                                            string answer3 = Console.ReadLine().ToUpper();

                                            if (answer3 == "9")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("__________________________________________________________________________________________________________________________________________________________________________");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("                                                                                 FAMILY FEUD                                                                                            ");
                                                Console.WriteLine("                    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                             Error: " + error);
                                                Console.WriteLine("                                                                         Top 3 answers on the screen.");
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("                                                                             1. 9");
                                                Console.WriteLine("                                                                             2. 8");
                                                Console.WriteLine("                                                                             3. 7\n");
                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                Console.WriteLine("                                                              Play another? Press Y if yes and any key if no");
                                                Console.Write("                                                                             Answer: ");
                                                string decision = Console.ReadLine().ToLower();
                                                if (decision == "y")
                                                {
                                                    goto again;
                                                }
                                                else
                                                {
                                                    goto back;
                                                }
                                            }
                                            else
                                            {
                                                error++;
                                                goto third2;
                                            }
                                        }
                                        else
                                        {
                                            error++;
                                            goto second;
                                        }
                                    }
                                    else
                                    {
                                        error++;
                                        goto first;
                                    }
                                }
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                            Invalid input. Please select between number 1-5. ");
                                Console.ResetColor();
                                Console.Write("                                                                                    ");
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                            Invalid input. Please select between number 1-5. ");
                                Console.ResetColor();
                                Console.Write("                                                                                    ");
                            }
                        }

                    }





































































                    else if (select == 2)
                    {
                    back2:
                        Console.Clear();
                        Random random = new Random();
                        int playerScore = 0;
                        int computerScore = 0;
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("                                                             WELCOME TO ROCK, PAPER AND SCISSORS GAME!!!\n\n");
                        Console.ResetColor();
                        Console.Write("                                                                     Press any key to start....");
                        Console.ReadLine();
                        Console.Clear();

                        while (playerScore != 3 && computerScore != 3)
                        {



                            int computerChoice = random.Next(0, 3);

                            if (computerChoice == 0)
                            {
                                Console.WriteLine("\n\n");
                                Console.WriteLine("                                                          Player score = " + playerScore + "  ||  Computer score = " + computerScore);
                                Console.WriteLine("                                                          R (ROCK)");
                                Console.WriteLine("                                                          P (PAPER)");
                                Console.WriteLine("                                                          S (SCISSORS)");
                                Console.WriteLine("                                                          Press (X) if you don't want to continue and pick other game\n");
                                Console.Write("                                                              Your choice :       ");
                                string playerChoice = Console.ReadLine().ToLower();
                                Console.Clear();
                                Console.WriteLine("\n\n\n");
                                Console.WriteLine("                                                                   The computer chooses ROCK \n");
                                switch (playerChoice)
                                {

                                    case "r": Console.WriteLine("                                                                         TIE ROUND! "); break;
                                    case "p": Console.WriteLine("                                                                         PLAYER WON! "); playerScore++; break;
                                    case "s": Console.WriteLine("                                                                         COMPUTER WON! "); computerScore++; break;

                                    default:
                                        {
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("                                                Invalid Choice. ");
                                            Console.WriteLine("                                                Please enter 'r' for rock, enter 'p' for paper and enter 's' for scissors ");
                                            Console.ResetColor();
                                            Console.WriteLine("");
                                            break;
                                        }
                                }


                            }
                            else if (computerChoice == 1)
                            {

                                Console.WriteLine("\n\n");
                                Console.WriteLine("                                                          Player score = " + playerScore + "  ||  Computer score = " + computerScore);
                                Console.WriteLine("                                                          R (ROCK)");
                                Console.WriteLine("                                                          P (PAPER)");
                                Console.WriteLine("                                                          S (SCISSORS)");
                                Console.WriteLine("                                                          Press (X) if you don't want to continue and pick other game\n");
                                Console.Write("                                                              Your choice :       ");
                                string playerChoice = Console.ReadLine().ToLower();
                                Console.Clear();
                                Console.WriteLine("\n\n\n");
                                Console.WriteLine("                                                                   The computer chooses PAPER \n");
                                switch (playerChoice)
                                {
                                    case "r": Console.WriteLine("                                                                         COMPUTER WON! "); computerScore++; break;
                                    case "p": Console.WriteLine("                                                                         TIE ROUND! "); ; break;
                                    case "s": Console.WriteLine("                                                                         PLAYER WON! "); playerScore++; break;

                                    default:
                                        {
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("                                                Invalid Choice. ");
                                            Console.WriteLine("                                                Please enter 'r' for rock, enter 'p' for paper and enter 's' for scissors ");
                                            Console.ResetColor();
                                            Console.WriteLine("");
                                            break;
                                        }
                                }



                            }
                            else
                            {

                                Console.WriteLine("\n\n");
                                Console.WriteLine("                                                          Player score = " + playerScore + "  ||  Computer score = " + computerScore);
                                Console.WriteLine("                                                          R (ROCK)");
                                Console.WriteLine("                                                          P (PAPER)");
                                Console.WriteLine("                                                          S (SCISSORS)");
                                Console.WriteLine("                                                          Press (X) if you don't want to continue and pick other game\n");
                                Console.Write("                                                              Your choice :       ");
                                string playerChoice = Console.ReadLine().ToLower();
                                Console.Clear();
                                Console.WriteLine("\n\n\n");
                                Console.WriteLine("                                                                   The computer chooses SCISSORS \n");
                                switch (playerChoice)
                                {
                                    case "r": Console.WriteLine("                                                                         PLAYER WON! "); playerScore++; break;
                                    case "p": Console.WriteLine("                                                                         COMPUTER WON! "); computerScore++; break;
                                    case "s": Console.WriteLine("                                                                         TIE ROUND! "); break;

                                    default:
                                        {
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("                                                 Invalid Choice. ");
                                            Console.WriteLine("                                                Please enter 'r' for rock, enter 'p' for paper and enter 's' for scissors ");
                                            Console.ResetColor();
                                            Console.WriteLine("");
                                            break;
                                        }
                                }



                            }





                        }

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (playerScore == 3)
                        {
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                            Console.WriteLine("                                                                    Player is the Winner!!\n\n");
                            Console.WriteLine("                                                     Want to play again? Type 'Y' to play again and any key if no.");
                            string choose = Console.ReadLine().ToUpper();

                            if (choose == "Y")
                            {
                                goto back2;
                            }

                            else
                            {
                                goto start;
                            }
                        }

                        else
                        {
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                            Console.WriteLine("                                                                    Computer is the Winner!!\n\n");
                            Console.WriteLine("                                                     Want to play again? Type 'Y' to play again and any key if no.");
                            string choose = Console.ReadLine().ToUpper();

                            if (choose == "Y")
                            {
                                goto back2;
                            }

                            else
                            {
                                goto start;
                            }
                        }


                        Console.ReadKey();
                    }

































                    else if (select == 3)
                    {
                    again3:
                        Console.Clear();



                        bool gameRunning = true;

                        while (gameRunning)
                        {
                            Console.Clear();
                            DisplayBoard();
                            Console.WriteLine($"Player {currentPlayer}'s turn (X for Player 1, O for Player 2)");
                            Console.Write("Choose a position: ");
                            string input = Console.ReadLine();

                            if (!int.TryParse(input, out int position) || position < 1 || position > 9)
                            {
                                Console.WriteLine("Invalid input! Please enter a number between 1 and 9. Press any key to try again.");
                                Console.ReadKey();
                                continue;
                            }

                            if (PlaceMarker(position))
                            {
                                if (CheckWin())
                                {
                                    Console.Clear();
                                    DisplayBoard();
                                    Console.WriteLine($"Player {currentPlayer} wins!");
                                    Console.WriteLine("Want to play another game? Type 'Y' if yes and any key if no.");
                                    string choice = Console.ReadLine();
                                    if (choice == "y")
                                    {
                                        goto again3;
                                    }
                                    else
                                    {
                                        goto start;
                                    }
                                }
                                else if (CheckDraw())
                                {
                                    Console.Clear();
                                    DisplayBoard();
                                    Console.WriteLine("It's a draw!");
                                    Console.WriteLine("Want to play another game? Type 'Y' if yes and any key if no.");
                                    string choice = Console.ReadLine();
                                    if (choice == "y")
                                    {
                                        goto again3;
                                    }
                                    else
                                    {
                                        goto start;
                                    }
                                }
                                else
                                {
                                    currentPlayer = currentPlayer == 1 ? 2 : 1;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Position already taken. Press any key to try again.");
                                Console.ReadKey();
                            }
                        }










                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                        Console.WriteLine("             _________________________                                 ________________________                                 ________________________");
                        Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                        Console.WriteLine("             |      ___________      |                                 |      _________       |                                 |      _________       |");
                        Console.WriteLine("             |     |           |     |                                 |     |         |      |                                 |     |         |      |");
                        Console.WriteLine("             |     |           |     |                                 |     |         |      |                                 |     |         |      |");
                        Console.WriteLine("             |     |     1     |     |                                 |     |    2    |      |                                 |     |    3    |      |");
                        Console.WriteLine("             |     |           |     |                                 |     |         |      |                                 |     |         |      |");
                        Console.WriteLine("             |     |___________|     |                                 |     |_________|      |                                 |     |_________|      |");
                        Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                        Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                        Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                        Console.WriteLine("            < >----------------------|                                ( )---------------------|                                { }---------------------|");
                        Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                        Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                        Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                        Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                        Console.WriteLine("             |      FAMILY FEUD      |                                 |  ROCK PAPER SCISSOR  |                                 |      TIC TAC TOE     |");
                        Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                        Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                        Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                        Console.WriteLine("             |_______________________|                                 |______________________|                                 |______________________|\n\n\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("                                                                  Invalid input. Please select (1/2/3). ");
                        Console.ResetColor();
                        Console.Write("                                                                               Number: ");
                    }
                }

                catch (FormatException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("             _________________________                                 ________________________                                 ________________________");
                    Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                    Console.WriteLine("             |      ___________      |                                 |      _________       |                                 |      _________       |");
                    Console.WriteLine("             |     |           |     |                                 |     |         |      |                                 |     |         |      |");
                    Console.WriteLine("             |     |           |     |                                 |     |         |      |                                 |     |         |      |");
                    Console.WriteLine("             |     |     1     |     |                                 |     |    2    |      |                                 |     |    3    |      |");
                    Console.WriteLine("             |     |           |     |                                 |     |         |      |                                 |     |         |      |");
                    Console.WriteLine("             |     |___________|     |                                 |     |_________|      |                                 |     |_________|      |");
                    Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                    Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                    Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                    Console.WriteLine("            < >----------------------|                                ( )---------------------|                                { }---------------------|");
                    Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                    Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                    Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                    Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                    Console.WriteLine("             |      FAMILY FEUD      |                                 |  ROCK PAPER SCISSOR  |                                 |      TIC TAC TOE     |");
                    Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                    Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                    Console.WriteLine("             |                       |                                 |                      |                                 |                      |");
                    Console.WriteLine("             |_______________________|                                 |______________________|                                 |______________________|\n\n\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("                                                                  Invalid input. Please select (1/2/3). ");
                    Console.ResetColor();
                    Console.Write("                                                                               Number: ");
                }

            }
        }
    }
    static char[,] board = {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

    static int currentPlayer = 1;
    static void DisplayBoard()
    {
        Console.WriteLine("Tic Tac Toe Board:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($" {board[i, j]} ");
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("---|---|---");
        }
    }

    static bool PlaceMarker(int position)
    {
        int row = (position - 1) / 3;
        int col = (position - 1) % 3;

        if (board[row, col] != 'X' && board[row, col] != 'O')
        {
            board[row, col] = currentPlayer == 1 ? 'X' : 'O';
            return true;
        }
        return false;
    }

    static bool CheckWin()
    {
        char marker = currentPlayer == 1 ? 'X' : 'O';

        // Check rows and columns
        for (int i = 0; i < 3; i++)
        {
            if ((board[i, 0] == marker && board[i, 1] == marker && board[i, 2] == marker) ||
                (board[0, i] == marker && board[1, i] == marker && board[2, i] == marker))
                return true;
        }

        // Check diagonals
        if ((board[0, 0] == marker && board[1, 1] == marker && board[2, 2] == marker) ||
            (board[0, 2] == marker && board[1, 1] == marker && board[2, 0] == marker))
            return true;

        return false;
    }

    static bool CheckDraw()
    {
        foreach (var cell in board)
        {
            if (cell != 'X' && cell != 'O')
                return false;
        }
        return true;
    }
}










