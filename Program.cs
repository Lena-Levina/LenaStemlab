// //  //  //  Все задачи для сеньеров.cs
//﻿using System;

//namespace lesson_C
//{
    //class MainClass
    //{
        //public static void Main(string[] args)
        //{







//////////////////////////
//////////////////////////                                          перевод с арабских чисел в римские числа
///////// http://graecolatini.bsu.by/htm-different/num-converter-roman.htm


//int[] arabic = { 1000, 900,  500, 400,  100,  90,  50,  40,   10,   9,    5,    4,   1 };
//string[] rome = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
//Console.WriteLine("перевод с арабских чисел на римские числа");
//string str = "";
//int num = 0;
//str = Console.ReadLine();
//num = Int32.Parse(str);
//int i = 0;
//str = "";

//while (num > 0)
//{
//    if (num >= arabic[i])
//    {
//        num = num - arabic[i];
//        str = str + rome[i];
//    }
//    else
//    {
//        i++;
//    }

//}
//Console.WriteLine(str);
//        }
//    }
//}







//////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////       ЗМЕЙКА
//using System;
//using System.Threading;

//namespace lesson_4_fri_snake
//{
//    class MainClass
//    {
//        enum directions
//        {
//            Up,
//            Down,
//            Left,
//            Right
//        }

//        static int[] packman = { 5, 5 };
//        static directions direction = directions.Up;
//        static int[,] field = new int[15, 15];
//        static int score = 0;

//        public static void Main(string[] args)
//        {
//            TimerCallback tm = new TimerCallback(Move);
//            Timer timer = new Timer(tm, null, 0, 500);

//            while (true)
//            {
//                if (Console.KeyAvailable)
//                {
//                    ConsoleKeyInfo button = Console.ReadKey();

//                    if (button.Key == ConsoleKey.UpArrow)
//                        direction = directions.Up;
//                    if (button.Key == ConsoleKey.DownArrow)
//                        direction = directions.Down;
//                    if (button.Key == ConsoleKey.RightArrow)
//                        direction = directions.Right;
//                    if (button.Key == ConsoleKey.LeftArrow)
//                        direction = directions.Left;
//                }
//            }
//        }

//        public static void Tank()
//        {

//        }

//        public static void Move(object obj)
//        {
//            field[packman[0], packman[1]] = 0;
//            if (direction == directions.Right)
//            {
//                packman[0] = packman[0] + 1;
//            }

//            if (direction == directions.Left)
//            {
//                packman[0] = packman[0] - 1;
//            }

//            if (direction == directions.Up)
//            {
//                packman[1] = packman[1] - 1;
//            }

//            if (direction == directions.Down)
//            {
//                packman[1] = packman[1] + 1;
//            }
//            field[packman[0], packman[1]] = 1;
//            //Snake();
//            Graphics();
//        }

//        public static void Graphics()
//        {
//            //Tank();
//            string current_string = "";

//            Console.Clear();
//            Console.Write("Score: " + score);
//            Console.WriteLine("\n");

//            for (int i = 0; i < 17; i++)
//            {
//                for (int j = 0; j < 17; j++)
//                {
//                    if (i == 0 || i == 16)
//                    {
//                        if (j == 0 || j == 16)
//                            current_string = current_string + "+";
//                        else
//                            current_string = current_string + "-";
//                    }
//                    else
//                    {
//                        if (j == 0 || j == 16)
//                        {
//                            current_string = current_string + "|";
//                        }
//                        else
//                        {
//                            if (field[j - 1, i - 1] == 0)
//                                current_string = current_string + " ";
//                            if (field[j - 1, i - 1] == 1)
//                                current_string = current_string + "@";
//                        }
//                    }
//                }
//                Console.WriteLine(current_string);
//                current_string = "";
//            }
//        }
//    }
//}








///////////////////////////////////////
/// ////////////////////////// Куб числа

//using System;

//namespace Lena
//{
//class MainClass
//{
//public static void Main(string[] args)
//{

/*
for (int i = 0; i < 9; i++)
{
    Console.WriteLine($"Куб числа {i} равен {i * i *i }");
}

*/





/////////////////////// 
/// //////////////////////////ввод C КЛАВИАТУРЫ


//Console.Write("Введите имя: ");
//string name = Console.ReadLine();

//Console.Write("Введите возраст: ");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите рост: ");
//double height = Convert.ToDouble(Console.ReadLine());

//Console.Write("Введите размер зарплаты: ");
//decimal salary = Convert.ToDecimal(Console.ReadLine());

//Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");








////////////////////////////
/// //////////////////////////ПОИСК МАКСИМАЛЬНОГО ИЗ ТРЕХ ЧИСЕЛ
//Random x = new Random();
//int a = x.Next(10);
//int b = x.Next(10);
//int c = x.Next(10);
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//int max;
//max = a;
//if (b > max)
//    max = b;
//if (c > max)
//    max = c;
//Console.WriteLine(max);






//////////////////////////
/// //////////////////////////  ССЫЛКИ
//      https://patorjk.com/software/taag/#p=display&f=Ogre&t=ABC

//       https://www.cyberforum.ru/csharp-beginners/thread1520866.html

// https://habr.com/ru/post/585948/





////////////////////////////
/// //////////////////////////прямоугольник

// https://habr.com/ru/post/585948/

//  CTRL + ALT + C - закомментировать и раскомментировать выделенный блок

//    for (int i = 0; i < 10; i++)
//    {
//        Console.Write('*');
//    }
//    for (int i = 0; i < 10; i++)
//    {
//        Console.SetCursorPosition(10, i);
//        Console.Write('*');
//    }
//    for (int i = 10; i >= 0; i--)
//    {
//        Console.SetCursorPosition(i, 10);
//        Console.Write('*');
//    }
//    for (int i = 10; i >= 0; i--)
//    {
//        Console.SetCursorPosition(0, i);
//        Console.Write('*');
//    }

//////ЧТОБ НЕ ВЫВОДИЛСЯ ТЕКСТ ЗАВЕРШЕНИЯ ПРОГРАММЫ
//Console.ReadLine();






//     // квадрат 

//  for (int i = 0; i < 10; ++i)
//  {
//      Console.Write(". ");
//  }
//  for (int i = 0; i < 10; ++i)
//  {
//      Console.SetCursorPosition(20, i);
//      Console.Write(".");
//  }
//  for (int i = 20; i >= 0; i = i - 2)
//  {
//      Console.SetCursorPosition(i, 10);
//      Console.Write(". ");
//  }
//  for (int i = 10; i >= 0; --i)
//  {
//      Console.SetCursorPosition(0, i);
//      Console.Write(".");
//  }

////  ЧТОБ НЕ ВЫВОДИЛСЯ ТЕКСТ ЗАВЕРШЕНИЯ ПРОГРАММЫ
//Console.ReadLine();




//  // овал

//   int r = 10;
//    int x = 0;
//    for (int y = 0; y <= r; ++y)
//    {
//        x = (int)Math.Round(Math.Sqrt((Math.Pow(r, 2) - Math.Pow(y, 2))));
//       // Console.WriteLine(x);
//        //Console.WriteLine(x + r);
//        //Console.WriteLine(y + r);
//        Console.SetCursorPosition(x + r, y + r);
//        Console.Write('.');

//        //Console.WriteLine(x + r);
//        //Console.WriteLine(-y + r);
//        Console.SetCursorPosition(x + r, -y + r);
//        Console.Write('.');

//        //Console.WriteLine(-x + r);
//        //Console.WriteLine(y + r);
//        Console.SetCursorPosition(-x + r, -y + r);
//        Console.Write('.');

//        //Console.WriteLine(x + r);
//        //Console.WriteLine(y + r);
//        Console.SetCursorPosition(-x + r, y + r);
//        Console.Write('.');
//    }

////    ЧТОБ НЕ ВЫВОДИЛСЯ ТЕКСТ ЗАВЕРШЕНИЯ ПРОГРАММЫ
//Console.ReadLine();





//  круг

//        // Console.WindowHeight = 70;
//        // Console.WindowWidth = 110;
//int r = 5;
//int x = 0;
//int k = 3;
//for (int y = 0; y < r; ++y)
//{
//    x = (int)Math.Round(k * Math.Sqrt((Math.Pow(r, 2) - Math.Pow(y, 2))));

//    Console.SetCursorPosition(x + r, y + r);
//    Console.Write('.');
//    Console.SetCursorPosition(x + r, -y + r);
//    Console.Write('.');
//    Console.SetCursorPosition(-x + k * r, -y + r);
//    Console.Write('.');
//    Console.SetCursorPosition(-x + k * r, y + r);
//    Console.Write('.');
//}

//     Console.SetCursorPosition(0, r * k + 2);

////ЧТОБ НЕ ВЫВОДИЛСЯ ТЕКСТ ЗАВЕРШЕНИЯ ПРОГРАММЫ
//Console.ReadLine();









////   //    рисование символами построчно - 1 вариант
//string str = "+---+\n|   |\n|   |\n|   |\n+---+";
//Console.WriteLine(str);
//Console.WriteLine();

//                // рисование символами построчно - 2 вариант
//string top_bottom = "+---+";
//string middle = "|   |";
//string out_str = top_bottom + "\n" + middle + "\n" +  middle + "\n" + middle + "\n" + top_bottom;
//Console.WriteLine(out_str);








////  АЛФАВИТ

//string strT = "+---+\n  |\n  | \n  | \n  | \n";
//Console.WriteLine(strT);


//string strA = "  +\n + +\n+   +\n+++++\n+   +\n";
// Console.WriteLine(strA);

//string strB = "+--+\n+   +\n++++\n+   +\n+---+\n";
// Console.WriteLine(strB);

//string strC = "+---+\n+   \n+   \n+   \n+---+\n";
//   Console.WriteLine(strC);

//string strD = "+--+\n+   +\n+   +\n+   +\n+--+\n";
// Console.WriteLine(strD);

//string strE = "+---+\n|   \n|+++\n|   \n+---+\n";
//  Console.WriteLine(strE);

//string strF = "+---+\n|   \n|+++\n|   \n+\n";
// Console.WriteLine(strF);

//string strK = "+   +\n+  +\n++  \n+  +\n+   +\n";
//   Console.WriteLine(strK);

//string strL = "+ \n+   \n+  \n+\n+---+\n";
//  Console.WriteLine(strL);

//string strM = "+   +\n++ ++\n+ + +\n+   +\n+   +\n";
//  Console.WriteLine(strM);

//string strN = "+   +\n++  +\n+ + +\n+  ++\n+   +\n";
// Console.WriteLine(strN);

//string strO = "+---+\n+   +\n+   +\n+   +\n+---+\n";
//   Console.WriteLine(strO);

//string strP = "+++++\n+   +\n+++++ \n+\n+\n";
//Console.WriteLine(strP);

//string strR = "*****\n*   *\n***** \n* *  \n*   *\n";
//   Console.WriteLine(strR);

//string strS = "+---+\n+   \n+++++\n    +\n+---+\n";
//    Console.WriteLine(strS);


////  // цифры
//string str0 = "  ++\n |  |\n|    |\n |  |\n  ++\n";
////  Console.WriteLine(str0);


//string str1 = "  +\n+ +\n  +\n  +\n +++\n";
////    Console.WriteLine(str1);


//// рисование символами построчно - 1 вариант
//string str2 = "+---+\n+   +\n   +\n +  \n+---+\n";
////Console.WriteLine(str2);

//Console.WriteLine(strS);
//Console.WriteLine(strO);
//Console.WriteLine(strS);
//Console.WriteLine();
//Console.WriteLine(str1);
//Console.WriteLine(str0);
//Console.WriteLine(str2);











///////////////////////////////////////////////////////////////////////        Таблица сложения до 15
//Console.WriteLine("Таблица сложения до 15");
//for (int i = 0; i < 16; ++i)
//{
//    for (int j = 0; j < 16; j++)
//    {
//        Console.Write($"{i + j,-3} ");
//    }
//    Console.WriteLine();
//    Console.WriteLine();
//}

//            //////////////////////////////////////////////////////            Таблица умножения до 15
//            Console.WriteLine("Таблица умножения до 15");
//            for (int i = 1; i < 16; ++i)
//                Console.Write($"{i,-3} ");
//            Console.WriteLine();
//            Console.WriteLine();

//            for (int i = 1; i < 16; ++i)
//            {
//                //Console.Write($"{i,-3} ");
//                for (int j = 1; j < 16; j++)
//                {
//                    Console.Write($"{i * j,-3} ");
//                }
//                Console.WriteLine();
//                Console.WriteLine();
//            }


//        }
//    }
//}


//// квадратное уравнение
//Random q = new Random();
//double a = q.Next(19) - 9;
//double b = q.Next(19) - 9;
//double c = q.Next(19) - 9;
///*double a = 2;
//double b = 7;
//double c = -4;*/
//Console.WriteLine($"a = {a}");
//Console.WriteLine($"b = {b}");
//Console.WriteLine($"c = {c}");
//double d = Math.Pow(b, 2) - 4 * a * c;
//Console.WriteLine($"дискриминант d = {d}");
//if (d > 0)
//{
//    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
//    Console.WriteLine($"x1 = {x1}");
//    Console.WriteLine($"x2 = {x2}");
//}
//if (d == 0)
//{
//    double x = -b / (2 * a);
//    Console.WriteLine($"x = {x}");
//}

//else

//if (d < 0)

//Console.WriteLine($"Корней нет");







////Подсчет кол-во цифр в числе
//Console.WriteLine("Введите число :");
//int y = -495;
//Console.WriteLine(y);
//int x = 0;
//int z = 0;
//int a = 0;
//int f = 0;
//y = Math.Abs(y);

//z = y % 10;
//x = y / 10 % 10;
//a = y / 100 % 10;

//if (y == 0)
//    Console.WriteLine("Количество цифр 1");
//else
//{
//    while (y > 0)
//    {
//        y = y / 10;
//        f++;
//    }
//    Console.WriteLine($"Количество цифр {f}");
//}










//        }
//    }
//}








///////
///// 
///// крестики нолики
//using System;
//using System.Linq;

//namespace lesson_3_fri
//{
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {
//            //string bottom_info = "Стрелочки - выбор позиции\nEnter - сделать ход\nESC - выход";
//            int move = 1;
//            int win_1 = 0;
//            int win_2 = 0;
//            int game = 0;
//            bool turn = true;
//            //string turn_sign = "";
//            int[] field = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
//            //string vertical_line = "|";
//            //string horizontal_line = "---+---+---";
//            //string empty_slot = "   ";
//            //string x_slot = " X ";
//            //string o_slot = " O ";
//            //string field_out = "";
//            bool run = true;
//            int cursor_X = 1;
//            int cursor_Y = 2;
//            //int turn_num = 0;
//            int[] temp_field = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
//            int win_result = 0;
//            bool new_game = true;
//            bool computer_play = false;

//            //Test values
//            //int[] field = { 1, 2, 0, 1, 2, 0, 1, 2, 0};
//            //End test values

//            Graphics(field, turn, move, win_1, win_2, game);
//            Console.SetCursorPosition(cursor_X, cursor_Y);

//            while (run)
//            {
//                if (new_game)
//                {
//                    computer_play = Computer();
//                    Console.CursorVisible = true;

//                    for (int i = 0; i < 9; i++)
//                        field[i] = 0;
//                    move = 1;
//                    turn = true;
//                    new_game = false;
//                    Console.Clear();
//                    cursor_X = 1;
//                    cursor_Y = 2;
//                    Graphics(field, turn, move, win_1, win_2, game);
//                    Console.SetCursorPosition(cursor_X, cursor_Y);
//                }

//                if (computer_play == false || turn == true)
//                {

//                    ConsoleKeyInfo button;
//                    button = Console.ReadKey();
//                    Graphics(field, turn, move, win_1, win_2, game);
//                    /*
//                    Console.Clear();

//                    field_out = "";

//                    for (int i = 0; i < 9; i++)
//                    {
//                        if (field[i] == 0)
//                            field_out = field_out + empty_slot;
//                        else if (field[i] == 1)
//                            field_out = field_out + x_slot;
//                        else
//                            field_out = field_out + o_slot;

//                        if (i == 2 || i == 5)
//                            field_out = field_out + "\n" + horizontal_line + "\n";
//                        else if (i == 8)
//                            field_out = field_out + "";
//                        else
//                            field_out = field_out + vertical_line;
//                    }

//                    if (turn)
//                        turn_sign = "X";
//                    else
//                        turn_sign = "O";

//                    string top_info = $"Номер хода: {move} | Игрок 1: {win_1} | Игрок 2: {win_2} | Партия: {game} | Ход делают: {turn_sign}";

//                    Console.WriteLine(top_info);
//                    Console.WriteLine();
//                    Console.WriteLine(field_out);
//                    Console.WriteLine();
//                    Console.WriteLine(bottom_info);
//                    */
//                    Console.SetCursorPosition(0, 11);
//                    if (button.Key == ConsoleKey.DownArrow)
//                    {
//                        Console.WriteLine("Down");
//                        //Console.SetCursorPosition(2, 3);
//                        if (cursor_Y < 6)
//                        {
//                            cursor_Y = cursor_Y + 2;
//                        }
//                    }
//                    if (button.Key == ConsoleKey.UpArrow)
//                    {
//                        Console.WriteLine("Up");
//                        //Console.SetCursorPosition(2, 1);
//                        if (cursor_Y > 3)
//                        {
//                            cursor_Y = cursor_Y - 2;
//                        }
//                    }
//                    if (button.Key == ConsoleKey.LeftArrow)
//                    {
//                        Console.WriteLine("Left");
//                        //Console.SetCursorPosition(1, 2);
//                        if (cursor_X > 1)
//                        {
//                            cursor_X = cursor_X - 4;
//                        }
//                    }
//                    if (button.Key == ConsoleKey.RightArrow)
//                    {
//                        Console.WriteLine("Right");
//                        //Console.SetCursorPosition(3, 2);
//                        if (cursor_X < 9)
//                        {
//                            cursor_X = cursor_X + 4;
//                        }
//                    }

//                    if (button.Key == ConsoleKey.Enter)
//                    {
//                        for (int i = 0; i < 9; i++)
//                            temp_field[i] = field[i];

//                        Console.WriteLine("Enter");

//                        /*if (turn)
//                            turn_num = 1;
//                        else
//                            turn_num = 2;*/

//                        if (cursor_Y == 2)
//                        {
//                            if (cursor_X == 1)
//                                field[0] = LegalTurn(0, field, cursor_X, cursor_Y, turn);
//                            else
//                            {
//                                if (cursor_X == 5)
//                                    field[1] = LegalTurn(1, field, cursor_X, cursor_Y, turn);
//                                else
//                                    field[2] = LegalTurn(2, field, cursor_X, cursor_Y, turn);
//                            }
//                        }
//                        else
//                        {
//                            if (cursor_Y == 4)
//                            {
//                                if (cursor_X == 1)
//                                    field[3] = LegalTurn(3, field, cursor_X, cursor_Y, turn);
//                                else
//                                {
//                                    if (cursor_X == 5)
//                                        field[4] = LegalTurn(4, field, cursor_X, cursor_Y, turn);
//                                    else
//                                        field[5] = LegalTurn(5, field, cursor_X, cursor_Y, turn);
//                                }
//                            }
//                            else
//                            {
//                                if (cursor_X == 1)
//                                    field[6] = LegalTurn(6, field, cursor_X, cursor_Y, turn);
//                                else
//                                {
//                                    if (cursor_X == 5)
//                                        field[7] = LegalTurn(7, field, cursor_X, cursor_Y, turn);
//                                    else
//                                        field[8] = LegalTurn(8, field, cursor_X, cursor_Y, turn);
//                                }
//                            }
//                        }

//                        if (!temp_field.SequenceEqual(field))
//                        {
//                            win_result = Winner(field, turn, move);
//                            move++;
//                            turn = !turn;
//                        }
//                        Graphics(field, turn, move, win_1, win_2, game);

//                        if (win_result == 0)
//                        {
//                            //Nothing to do here
//                        }
//                        else if (win_result == 1)
//                        {
//                            Console.SetCursorPosition(0, 11);
//                            Console.WriteLine("Победили крестики");
//                            run = Continue();
//                            cursor_X = 0;
//                            cursor_Y = 12;
//                            win_1++;
//                            game++;
//                            new_game = true;
//                        }
//                        else if (win_result == 2)
//                        {
//                            Console.SetCursorPosition(0, 11);
//                            Console.WriteLine("Победили нолики");
//                            run = Continue();
//                            cursor_X = 0;
//                            cursor_Y = 12;
//                            win_2++;
//                            game++;
//                            new_game = true;
//                        }
//                        else if (win_result == 3)
//                        {
//                            Console.SetCursorPosition(0, 11);
//                            Console.WriteLine("Ничья");
//                            run = Continue();
//                            cursor_X = 0;
//                            cursor_Y = 12;
//                            game++;
//                            new_game = true;
//                        }
//                        else
//                        {
//                            Console.Clear();
//                            Console.WriteLine("Ошибка!");
//                        }

//                    }
//                    if (button.Key == ConsoleKey.Escape)
//                    {
//                        Console.WriteLine("ESC");
//                        run = false;
//                        cursor_X = 0;
//                        cursor_Y = 11;
//                    }
//                    Console.SetCursorPosition(cursor_X, cursor_Y);
//                }

//                else
//                {
//                    int field_num = Computer_move(field);
//                    if (field_num != -1)
//                    {
//                        field[field_num] = 2;
//                        move++;
//                        turn = !turn;
//                        Graphics(field, turn, move, win_1, win_2, game);
//                    }
//                    else
//                    {
//                        Console.Clear();
//                        Console.WriteLine("Ошибка программы! Перезапустите приложение!");
//                        Environment.Exit(0);
//                    }
//                }
//            }
//        }
//        public static int LegalTurn(int position, int[] field, int cursor_x, int cursor_y, bool turn)
//        {
//            int turn_num = 0;

//            if (turn)
//                turn_num = 1;
//            else
//                turn_num = 2;

//            if (field[position] == 0)
//            {
//                return turn_num;
//            }
//            else
//            {
//                Console.SetCursorPosition(0, 11);
//                Console.WriteLine("Недопустимый ход! Выберите другую ячейку");
//                Console.SetCursorPosition(cursor_x, cursor_y);
//                return field[position];
//            }
//        }

//        public static void Graphics(int[] field, bool turn, int move, int win_1, int win_2, int game)
//        {
//            Console.Clear();

//            string field_out = "";
//            string turn_sign = "";
//            string vertical_line = "|";
//            string horizontal_line = "---+---+---";
//            string empty_slot = "   ";
//            string x_slot = " X ";
//            string o_slot = " O ";
//            string bottom_info = "Стрелочки - выбор позиции\nEnter - сделать ход\nESC - выход";

//            for (int i = 0; i < 9; i++)
//            {
//                if (field[i] == 0)
//                    field_out = field_out + empty_slot;
//                else if (field[i] == 1)
//                    field_out = field_out + x_slot;
//                else
//                    field_out = field_out + o_slot;

//                if (i == 2 || i == 5)
//                    field_out = field_out + "\n" + horizontal_line + "\n";
//                else if (i == 8)
//                    field_out = field_out + "";
//                else
//                    field_out = field_out + vertical_line;
//            }

//            if (turn)
//                turn_sign = "X";
//            else
//                turn_sign = "O";

//            string top_info = $"Номер хода: {move} | Игрок 1: {win_1} | Игрок 2: {win_2} | Партия: {game} | Ход делают: {turn_sign}";

//            Console.WriteLine(top_info);
//            Console.WriteLine();
//            Console.WriteLine(field_out);
//            Console.WriteLine();
//            Console.WriteLine(bottom_info);
//            ///Console.SetCursorPosition(cursor_x, cursor_y);
//        }

//        public static int Winner(int[] field, bool turn, int move)
//        {
//            int[,] winning_rows = { { 0, 1, 2 },
//                                    { 0, 3, 6 },
//                                    { 0, 4, 8 },
//                                    { 3, 4, 5 },
//                                    { 6, 7, 8 },
//                                    { 2, 4, 6 },
//                                    { 2, 5, 8 },
//                                    { 1, 4, 7 } };
//            bool found = false;
//            //bool tie = false;

//            for (int i = 0; i < 8; i++)
//            {
//                if ((field[winning_rows[i, 0]] == field[winning_rows[i, 1]]) && (field[winning_rows[i, 1]] == field[winning_rows[i, 2]]) &&
//                    (field[winning_rows[i, 2]] != 0))
//                {
//                    if (field[winning_rows[i, 0]] == 1)
//                        return 1;
//                    else
//                        return 2;
//                    /*found = true;
//                    if (turn)
//                        return 1;
//                    else
//                        return 2;*/
//                }
//            }
//            if ((move == 9) && !found)
//            {
//                //tie = true;
//                return 3;
//            }
//            return 0;
//            /*if (found)
//            {
//                Console.SetCursorPosition(0, 11);
//                if (turn)
//                    Console.WriteLine("Крестики победили!");
//                else
//                    Console.WriteLine("Нолики победили!");
//            }
//            if (tie)
//            {
//                Console.SetCursorPosition(0, 11);
//                Console.WriteLine("Ничья");
//            }*/
//        }

//        public static bool Continue()
//        {
//            Console.SetCursorPosition(0, 13);
//            Console.WriteLine("Хотите продолжить?\nДля продолжения нажмите Enter\nДля выхода ESC");

//            ConsoleKeyInfo button;

//            while (true)
//            {
//                button = Console.ReadKey();

//                if (button.Key == ConsoleKey.Enter)
//                    return true;

//                if (button.Key == ConsoleKey.Escape)
//                    return false;
//            }
//        }

//        public static bool Computer()
//        {

//            bool first = true;
//            Console.CursorVisible = false;

//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("Выберите соперника:");

//                if (first)
//                {
//                    Console.WriteLine("> Человек");
//                    Console.WriteLine("  Компьютер");
//                }
//                else
//                {
//                    Console.WriteLine("  Человек");
//                    Console.WriteLine("> Компьютер");
//                }
//                ConsoleKeyInfo button;
//                button = Console.ReadKey();

//                if (button.Key == ConsoleKey.UpArrow)
//                    first = true;
//                if (button.Key == ConsoleKey.DownArrow)
//                    first = false;
//                if (button.Key == ConsoleKey.Enter)
//                {
//                    if (first)
//                        return false;
//                    else
//                        return true;
//                }
//            }
//        }

//        public static int Computer_move(int[] field)
//        {
//            int winnner_code = 0;
//            int[] optimal_move = { 4, 0, 2, 6, 8, 1, 3, 5, 7 };

//            for (int i = 0; i < 9; i++)
//            {
//                if (field[i] == 0)
//                {
//                    field[i] = 2;
//                    winnner_code = Winner(field, false, 0);
//                    if (winnner_code == 2)
//                    {
//                        return i;
//                    }
//                    field[i] = 0;
//                }
//            }
//            for (int i = 0; i < 9; i++)
//            {
//                if (field[i] == 0)
//                {
//                    field[i] = 1;
//                    winnner_code = Winner(field, false, 0);
//                    if (winnner_code == 1)
//                    {
//                        return i;
//                    }
//                    field[i] = 0;
//                }
//            }
//            for (int i = 0; i < 9; i++)
//            {
//                if (field[optimal_move[i]] == 0)
//                {
//                    return optimal_move[i];
//                }
//            }
//            return -1;
//        }
//    }
//}













  //// УГАДАЙ ЧИСЛО

using System;

namespace lesson_1_fri
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int value = 0;
            int num = 0;
            string input_string = "";
            int i = 0;
            bool run = true;

            Console.WriteLine("<<< Guess my number / Угадай число>>>");
            Console.WriteLine("I choose number - you guess! Я загадал число - а ты отгадай!");
            //Получение случайного числа

            while (run)
            {

                Random rnd = new Random();
                value = rnd.Next(0, 20);
                // value - хранит случайное число
                Console.WriteLine("I choose number form 0 to 10, Your turn! / Я загадал число от 0 до 10. Твой ход ");
                Console.WriteLine("Print number: / Напиши число: ");
                //Получение ввода пользователя
                //string input_string = "";
                for (i = 0; i < 10 && num != value; i++)
                {
                    Console.WriteLine("turn / ход #" + i);
                    input_string = Console.ReadLine();
                    // input_string - хранит ввод пользователя
                    //Перевод из строки в число
                    num = Int32.Parse(input_string);
                    // num - хранит число    
                    if (value != num)
                    {
                        Console.WriteLine("You Wrong! / Неправильно");
                        if (num > value)
                        {
                            Console.WriteLine("Less / Меньше");
                        }
                        else
                        {
                            Console.WriteLine("More / Больше");
                        }
                    }
                }
                if (num == value)
                {
                    Console.WriteLine("You Win / Победа");
                }
                else
                {
                    Console.WriteLine("YOU LOOSE / Проигрыш");
                }
                Console.WriteLine("Do you want to continue? / Хочешь еще поиграть ? Нажми y/n ");
                while (input_string != "y" & input_string != "n")
                {
                    input_string = Console.ReadLine();
                    if (input_string == "y")
                    { }
                    else
                    {
                        if (input_string == "n")
                        {
                            run = false;
                        }
                        else
                        { 
                            Console.WriteLine("не понял, введите ответ");
                        }
                    }
               }
            }
        }
    }
}








//        }
//    }
//}