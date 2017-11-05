using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tower_of_Hanoi
{
    
   
    public sealed partial class MainPage : Page
    {
        private int num = 7;

        int[] ar = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        
        int count1 = 0;
        char[] a = { 'E', 'L', 'E', 'P', 'H', 'A', 'N', 'T' };
        string b;
        int flag1 = 0;
        static string[] array1 = { "PAPAYA","APPLE","BANANA","STRAWBERRY","PEAR","GRAPE","PEACH","CHERRY","MANGO","PINEAPPLE","ORANGE","GRAPEFRUIT","LEMON","WATERMELON","APRICOT","AVOCADO","BLACKBERRY","COCONUT","LYCHEE","OLIVE" };
        static string[] array2 = { "RED","ORANGE","WHITE","BLACK","PINK","YELLOW","GREEN","PURPLE","BLUE","VIOLET","BROWN","INDIGO","MAGENTA","MAROON","GOLD" };
        static string[] array = { "ELEPHANT", "DOG", "COW", "DEER", "MONKEY","CAT","LION","BEAR","LEOPARD","SQUIRREL","TIGER","HORSE","PIG","TURTLE","RACOON","CROCODILE","SNAKE","LIZARD","OWL","GORILLA","DONKEY","HYENA","WEASEL","CAMEL","GOOSE","FERRET","CHEETAH","GOAT","HARE","FROG","ALIGATOR","HEDGEHOG","OSTRICH","CHIMPANZE","REINDEER","ANTELOPE","LEMUR" };
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length!=count1)
            {
                flag1 = 1;
                textBlock7.Text = "";
                Random r = new Random();
                int result = r.Next(0, array.Length - 1);
                a = array[result].ToCharArray();
                
                b = array[result];
                initial_value();
                textBlock6.Text = "    No. of letters : " + a.Length;
            }
            
        }

        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length!=count1)
            {
                flag1 = 1;
                textBlock7.Text = "";
                Random r = new Random();
                int result = r.Next(0, array1.Length - 1);
                a = array1[result].ToCharArray();
               
                b = array1[result];
                initial_value();
                textBlock6.Text = "     No. of letters : " + a.Length;
            }
        }

        private void ButtonClick2(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length!=count1)
            {
                flag1 = 1;
                textBlock7.Text = "";
                Random r = new Random();
                int result = r.Next(0, array2.Length - 1);
                a = array2[result].ToCharArray();
               
                b = array2[result];
                initial_value();
                textBlock6.Text = "     No. of letters : " + a.Length;
            }
        }
       
        
        public MainPage()
        {
            this.InitializeComponent();
           
           
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            // textBox1.Text = temp;
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'A' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'a';
                        flag = 1;

                    }
                    else if(a[i]=='a')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[0]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }

                }
                if (flag == 0 && num > 0)
                {
                    if (ar[0] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[0]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }

                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if(flag1==0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'B' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'b';
                        flag = 1;
                    }
                    else if (a[i] == 'b')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[1]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[1] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[1]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (ar[i] == 'C' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        ar[i] = 'c';
                        flag = 1;
                    }
                    else if (a[i] == 'c')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[2]++;
                        break;
                    }
                    else
                    {
                        //textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[2] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[2]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'D' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'd';
                        flag = 1;
                    }
                    else if (a[i] == 'd')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[3]++;
                        break;
                    }
                    else
                    {
                        //textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[3] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[3]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'E' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'e';
                        flag = 1;
                    }
                    else if (a[i] == 'e')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[4]++;
                        break;
                    }
                    else
                    {
                        //textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[4] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[4]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'F' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'f';
                        flag = 1;
                    }
                    else if (a[i] == 'f')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[5]++;
                        break;
                    }
                    else
                    {
                        //textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[5] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[5]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'G' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'g';
                        flag = 1;
                    }
                    else if (a[i] == 'g')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[6]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[6] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[6]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'H' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'h';
                        flag = 1;
                    }
                    else if (a[i] == 'h')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[7]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        //  ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[7] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[7]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'I' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'i';
                        flag = 1;
                    }
                    else if (a[i] == 'i')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[8]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[8] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[8]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'J' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'j';
                        flag = 1;
                    }
                    else if (a[i] == 'j')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[9]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[9] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[9]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'K' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'k';
                        flag = 1;
                    }
                    else if (a[i] == 'k')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[10]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[10] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[10]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'L' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'l';
                        flag = 1;
                    }
                    else if (a[i] == 'l')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[11]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[11] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[11]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'M' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'm';
                        flag = 1;
                    }
                    else if (a[i] == 'm')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[12]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[12] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[12]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    //  ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'N' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'n';
                        flag = 1;
                    }
                    else if (a[i] == 'n')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[13]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[13] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[13]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click14(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'O' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'o';
                        flag = 1;
                    }
                    else if (a[i] == 'o')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[14]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[14] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[14]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click15(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'P' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'p';
                        flag = 1;
                    }
                    else if (a[i] == 'p')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[15]++;
                        break;
                    }
                    else
                    {
                        //textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        //  ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[15] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[15]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click16(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'Q' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'q';
                        flag = 1;
                    }
                    else if (a[i] == 'q')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[16]++;
                        break;
                    }
                    else
                    {
                        //textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[16] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[16]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click17(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'R' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'r';
                        flag = 1;
                    }
                    else if (a[i] == 'r')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[17]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[17] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[17]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click18(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'S' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 's';
                        flag = 1;
                    }
                    else if (a[i] == 's')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[18]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[18] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[18]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click19(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'T' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 't';
                        flag = 1;
                    }
                    else if (a[i] == 't')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[19]++;
                        break;
                    }
                    else
                    {
                        //textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                        {
                            // ButtonShowMessageDialog_Click();
                            textBlock4.Text = "You Won!";
                        }
                    

                }
                if (flag == 0 && num > 0)
                {
                    if (ar[19] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[19]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click20(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'U' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i]='u';
                        flag = 1;
                    }
                    else if (a[i] == 'u')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[20]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        //  ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[20] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[20]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click21(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'V' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'v';
                        flag = 1;
                    }
                    else if (a[i] == 'v')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[21]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[21] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[21]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click22(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'W' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'w';
                        flag = 1;
                    }
                    else if (a[i] == 'w')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[22]++;
                        break;
                    }
                    else
                    {
                       // textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[22] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[22]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click23(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'X' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'x';
                        flag = 1;
                    }
                    else if (a[i] == 'x')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[23]++;
                        break;
                    }
                    else
                    {
                        //textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[23] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[23]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click24(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'Y' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'y';
                        flag = 1;
                    }
                    else if (a[i] == 'y')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[24]++;
                        break;
                    }
                    else
                    {
                        //textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[24] == 0)
                    {
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[24]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    // ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_Click25(object sender, RoutedEventArgs e)
        {
            if (num > 0 && a.Length != count1 && flag1==1)
            {
                int flag = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'Z' && num > 0)
                    {
                        textBlock7.Text = "Right guess";
                        count1++;
                        Button_click(i);
                        a[i] = 'z';
                        flag = 1;
                    }
                    else if (a[i] == 'z')
                    {
                        textBlock7.Text = "Already guessed that letter";
                        ar[25]++;
                        break;
                    }
                    else
                    {
                        //textBlock7.Text = "";
                    }
                    if (count1 == a.Length)
                    {
                        // ButtonShowMessageDialog_Click();
                        textBlock4.Text = "You Won!";
                    }
                }
                if (flag == 0 && num > 0)
                {
                    if (ar[25] == 0)
                    {
                        
                        textBlock7.Text = "Wrong guess";
                        num--;
                        ar[25]++;
                    }
                    else
                    {
                        textBlock7.Text = "Already guessed that letter";
                    }
                }
                if (num < 1)
                {
                    //  ButtonShowMessageDialog_Click1();
                    textBlock4.Text = "You Lose!";
                    textBlock5.Text = "Answer: " + b;
                }
                textBlock.Text = "No of trials remaining: " + num;
                textBlock2.Text = "No of correct letters: " + count1;
            }
            else if (flag1 == 0)
            {
                textBlock7.Text = "Select the category first.";
            }
        }
        private void Button_click(int i)
        {
            switch (i)
            {
                case 0:
                    textBlock1.Text = a[i].ToString();
                    break;
                case 1:
                    textBlock1_Copy.Text = a[i].ToString();
                    break;
                case 2:
                    textBlock1_Copy1.Text = a[i].ToString();
                    break;
                case 3:
                    textBlock1_Copy2.Text = a[i].ToString();
                    break;
                case 4:
                    textBlock1_Copy3.Text = a[i].ToString();
                    break;
                case 5:
                    textBlock1_Copy5.Text = a[i].ToString();
                    break;
                case 6:
                    textBlock1_Copy4.Text = a[i].ToString();
                    break;
                case 7:
                    textBlock1_Copy6.Text = a[i].ToString();
                    break;
                case 8:
                    textBlock1_Copy7.Text = a[i].ToString();
                    break;
                case 9:
                    textBlock1_Copy8.Text = a[i].ToString();
                    break;
            }
        }
        private void initial_value()
        {
            switch(a.Length)
            {
                case 10:
                    textBlock1_Copy8.Text = "  _";
                    goto case 9;
                case 9:
                    textBlock1_Copy7.Text = "  _";
                    goto case 8;
                case 8:
                    textBlock1_Copy6.Text = "  _";
                    goto case 7;
                case 7:
                    textBlock1_Copy4.Text = "  _";
                    goto case 6;
                case 6:
                    textBlock1_Copy5.Text = "  _";
                    goto case 5;
                case 5:
                    textBlock1_Copy3.Text = "  _";
                    goto case 4;
                case 4:
                    textBlock1_Copy2.Text = "  _";
                    goto case 3;
                case 3:
                    textBlock1_Copy1.Text = "  _";
                    goto case 2;
                case 2:
                    textBlock1_Copy.Text = "  _";
                    goto case 1;
                case 1:
                    textBlock1.Text = "  _";
                    break;

            }
        }
        private async void ButtonShowMessageDialog_Click()
        {

            var dialog = new Windows.UI.Popups.MessageDialog(
                        "Congatulations! " +
                        "You have won.\n" +
                         "Want to play again? "
                        );

            dialog.Commands.Add(new Windows.UI.Popups.UICommand("Yes") { Id = 0 });
            dialog.Commands.Add(new Windows.UI.Popups.UICommand("No") { Id = 1 });



            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;

            var result = await dialog.ShowAsync();



        }
        private async void ButtonShowMessageDialog_Click1()
        {

            var dialog = new Windows.UI.Popups.MessageDialog(
                        "Sorry," +
                        "You have lost.\n" +
                         "Want to play again? "
                        );
            
            dialog.Commands.Add(new Windows.UI.Popups.UICommand("Yes") { Id = 0 });
            dialog.Commands.Add(new Windows.UI.Popups.UICommand("No") { Id = 1 });



            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;

           

            var result = await dialog.ShowAsync();

           
           
        }
       
        private void button10_Copy4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void textBlock1_Copy3_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock1_Copy5_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock5_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void button_navigate(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
   


}


