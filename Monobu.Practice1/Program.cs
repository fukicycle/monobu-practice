// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 * 変数
 */
int number = 1; //数字
bool condition = false; //2値
bool condition1 = number == 1; //比較結果を入れることもできる
string str = "Today is sunny."; //文字列
//変数の上書き
number = 2;

/*
 * 配列、リスト
 */
//初期化
int[] numberArray0 = new int[6];//配列のサイズは後で変更できない。
List<int> numberList0 = new List<int>();//リストはサイズを指定しない。

//初期化と同時に値を入れる。
int[] numberArray = [0, 1, 3, 4, 6];
List<int> numberList = new List<int>
{
    0,1, 3, 4,6
};

/*
 * IF文
 */
Console.WriteLine("------------------------------------");
if (condition)
{
    //Trueの時の処理
    Console.WriteLine("True");
}
else
{
    //Falseの時の処理
    Console.WriteLine("False");
}

//直接値の比較をすることもできる
Console.WriteLine("------------------------------------");
if (number == 2)
{
    Console.WriteLine("number is 2.");
}
else
{
    Console.WriteLine("number is not 2.");
}

/*
 * For文
 */
//基本形１
Console.WriteLine("------------------------------------");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
//基本形２
Console.WriteLine("------------------------------------");
foreach (int i in numberArray)
{
    Console.WriteLine(i);
}