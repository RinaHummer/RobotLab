using System;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Commands: START, EXIT");
            if (Console.ReadLine().ToLower() == "start")
            {
                Game game = new Game();
                

                do
                {
                    Console.WriteLine("Enter player name, must be less than 10 characters long");
                    game.SetPlayerName(Console.ReadLine());
                } while (game.player == null);
                game.SetRobot();
                GameHistory history = new GameHistory();
                
                Console.WriteLine($"Player created. Your robot is {game.GetRobotInfo()}. Commands: MOVE, TAKE, ROBOTSTATE, UNDO");
                Cargo c = null;
                while (!game.IsOver())
                {
                    string answer = Console.ReadLine();
                    
                    switch (answer.ToLower())
                    {
                        case "move":
                            history.History.Push(game.robot.SaveState());
                            c = null;
                            game.robot.Move();
                            if (game.FindCargo())
                            {
                                c = game.CreateCargo();
                                Console.WriteLine($"You`ve found cargo. Weight: {c.weight}, cost: {c.cost}");
                                
                            } else
                            {
                                Console.WriteLine("Nothing`s here");
                                
                            }
                            
                            break;
                        case "take":
                            
                            if (c == null)
                            {
                                Console.WriteLine("There`s nothing to take");
                            } else
                            {
                                
                                if (game.TakeCargo(c))
                                {
                                    
                                    Console.WriteLine("Success");
                                    
                                } else
                                {
                                    Console.WriteLine("Encoding failed");
                                    
                                }
                                c = null;
                            }
                            
                            break;
                        case "robotstate":
                            Console.WriteLine(game.GetbatteryState());
                            break;
                        case "undo":
                            game.robot.RestoreState(history.History.Pop());
                            Console.WriteLine("Undo!");
                            Console.WriteLine($"{game.GetbatteryState()}, cargo count {game.robot.backpack.backpackList.Count}");
                            break;
                        default:
                            Console.WriteLine("Incorrect command");
                            break;
                    }
                }
                Console.WriteLine($"Game is over. Your score: {game.robot.backpack.currCost}");
                Console.ReadLine();
                
                
            } else
            {
                Environment.Exit(0);
            } 
        }    
    }
}

