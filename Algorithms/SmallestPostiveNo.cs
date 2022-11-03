using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SmallestPostiveNo
    {
        int a = 0;
        int[] arr = new int[2];
        List<int> lst = new();
        TimeSpan startime;
        TimeSpan endime;
        public SmallestPostiveNo()
        {
            Console.WriteLine("Program is starting");
            startime = new TimeSpan();
            endime = new TimeSpan();
            //string s = "race car";
            //string s2 = "formular one";
            //string s3 = "";
            //string s1 = "";
            //Palindro(s, s1);
            //Palindro(s2, s1);
            //Palindro(s3, s1);
            //int[] nums = new int[] { 1, 2, 3 , 5, 7};
            //int target = 9;
            //AddToSortedTarget(nums, target);
            //int[] nums1 = new int[] { 1, 5, 7, 2, 3 };
            //int target1 = 8;
            //AddToTarget(nums1, target1);
            //int[] nums2 = new int[] { 1, 4, 7, 2, 3 };
            //int target2 = 6;
            //AddToTarget(nums2, target2);
            //int[] nums = new int[] { -1, -3 };
            //PositiveInt(nums);
            //int[] nums1 = new int[] { 1, 2, 3};
            //PositiveInt(nums1);
            //int[] nums2 = new int[] { -1, 0, 1, 3, 5, 4};
            //PositiveInt(nums2);
            //int[] nums3 = new int[] { 2, 0, 4, 5, 2, -9};
            ////PositiveInt(nums3);
            //string ori = "the sky is blue";
            //string reverse = "";
            //ReverseStr(ori, reverse);
            //int k = 3;
            //int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            //RotateArray(array, k);
            //string str = "sweater";
            //string cstr = "eat";
            //FindStrings(str, cstr);
            //string s = "{()}";
            //FindBrackets(s);
            //int[] bs = new int[] { 1, 4, 3, 8, 5, 7, -1, 6 };
            //int target = 8;
            //Bsearcher(bs, target);
            //int[] un = new int[] { 1, 3, 3, 6, 6, 7, 5, 7, 5, 7 };
            ////uniQueInt(un);
            //string vno = "001";
            //IsaNumber(vno);
            //string vno1 = "001b";
            //IsaNumber(vno1);
            //string vno2 = "abc";
            //IsaNumber(vno2);
            string lon = "aaabbbcccdddddssszzzzzzzeee";
            FindLongestSub(lon);
        }

        private void FindLongestSub(string lon)
        {
            char[] chars = lon.ToArray();
            int count = 0;
            int nwCount = 0;
            char c = 'a';
            for(int i = 0; i < chars.Length; i++)
            {
                if(chars[i] == c)
                {
                    count++;
                }
                else
                {
                    count = 0;
                    c = chars[i];
                    count++;
                }
                if(count > nwCount)
                {
                    Console.Clear();
                    nwCount = count;
                    Console.WriteLine(nwCount);
                }
            }
        }

        private bool IsaNumber(string vno)
        {
            
            
            return true;
        }

        private int uniQueInt(int[] un)
        {
            for (int i = 0; i <= un.Length -2; i++)
            {
                for (int j = un.Length - 1; j > 0; j--)
                {
                    if (un[i + 1] == un[j])
                    {
                        Console.WriteLine(un[i]);

                        return un[i];
                    }
                }
            }
            return -1;
        }

        private bool Bsearcher(int[] bs, int target)
        {
            int Left = 0;
            int Right = bs.Length;
            int mid = 0;
            while(Left < Right)
            {
                mid = (Left + Right) / 2;
                if (target > bs[mid - 1])
                    Left = mid + 1;
                else if(target < bs[mid-1])
                    Right = mid - 1;

                if (target == bs[mid-1])
                {
                    Console.WriteLine("true " + bs[mid - 1]);
                    return true;
                }
            }
            return false;
        }

        private bool FindBrackets(string s)
        {
            char[] chars = s.ToCharArray();
            if(chars.Length%2 != 0)
                return false;
            bool Istrue = false;
            for (int i = 0; i < chars.GetUpperBound(0); i++)
            {
                for (int j = chars.GetUpperBound(0); j > 0 ; j--)
                {
                    if (chars[i] == '[' && chars[j] == ']' && i + 1 == j)
                        Istrue = true;
                    if (chars[i] == '{' && chars[j] == '}' && i + 1 == j)
                        Istrue = true;
                    if (chars[i] == '(' && chars[j] == ')' && i + 1 == j)
                        Istrue = true;
                    if(chars.Length > 3)
                    {
                        if (chars[i] == '[' && chars[j] == ']' && i + 2 == j)
                            Istrue = true;
                        if (chars[i] == '{' && chars[j] == '}' && i + 2 == j)
                            Istrue = true;
                        if (chars[i] == '(' && chars[j] == ')' && i + 2 == j)
                            Istrue = true;
                    }
                    Console.WriteLine(Istrue);
                }
            }
            return Istrue;
        }

        private int[] FindStrings(string str, string cstr)
        {
            char[] chars = str.ToCharArray();
            char[] chars1 = cstr.ToCharArray();
            for (int i = 0; i <= chars.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= chars1.GetUpperBound(0); j++)
                {
                    if (chars[i + j] != chars1[j]) break;
                    if (chars[i + j] == chars1[j] && arr[0] == 0) arr[0] = i;
                    if (j == chars1.GetUpperBound(0))
                    {
                        arr[1] = i+j;
                        for (int x = 0; x <= arr.GetUpperBound(0); x++)
                        {
                            Console.WriteLine(arr[x]);
                        }
                        return arr;
                    }
                        
                }
            }
            return arr;
        }

        private int[] RotateArray(int[] array, int k)
        {
            int temp = 0;
            while(k > 0)
            {
                temp=array[array.GetUpperBound(0)];
                for (int i = array.GetUpperBound(0); i > 0; i--)
                {
                    array[i] = array[i-1];
                }
                array[0] = temp;
                k--;
            }
            for (int i = 0; i <= array.GetUpperBound(0); i++)
                Console.WriteLine(array[i]);
            return array;
        }

        private string ReverseStr(string ori, string reverse)
        {
            string nw = "";
            if (ori.Length == 0)
                return " ";
            char[] chars = ori.ToCharArray();
            int y = chars.GetUpperBound(0);
            for (int i = y; i >= 0; i--)
            {
                if (chars[i] == ' ')
                {
                    char[] chars1 = nw.ToCharArray();
                    //int a = 0;
                    int b = chars1.GetUpperBound(0);
                    while( b >= 0)
                    {
                        reverse += chars1[b];
                        b--;
                        Console.WriteLine(reverse);
                        if (reverse.Length == ori.Length)
                            break;
                    }
                    reverse += " ";
                    nw = "";
                }
                if(chars[i] != ' ')
                {
                    nw += chars[i];
                }
            }
            char[] chars2 = nw.ToCharArray();
            //int a = 0;
            int c = chars2.GetUpperBound(0);
            while (c >= 0)
            {
                reverse += chars2[c];
                c--;
                Console.WriteLine(reverse);
            }
            Console.WriteLine(reverse);
            return reverse;
        }

        private bool Palindro(string s, string s1)
        {
            s.ToLower();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("true");
                return true;
            }
            char[] chars = s.ToCharArray();
            char i = chars[0];
            char j = chars[chars.GetUpperBound(0)];
            if(i == j)
            {
                Console.WriteLine("true");
                return true;
            }
            Console.WriteLine("false");
            return false;
        }

        private int[] AddToSortedTarget(int[] nums, int target)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            startime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
            int x = 0;
            int y = nums.GetUpperBound(0);
            int sum = 0;
            while (x < y)
            {
                sum = nums[x] + nums[y];
                if (sum > target)
                    y--;
                else if (sum < target)
                    x++;
                else
                {
                    arr[0] = nums[x];
                    arr[1] = nums[y];
                    endime = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startime);
                    Console.WriteLine($"{arr[0]}, {arr[1]}, start time: {endime}");
                    return arr;
                }
            }
            //for (int i = 0; i < nums.GetUpperBound(0); i++)
            //{
            //    int j = Bsearch(nums, target - nums[i], i+1, target);
            //    if (j != -1)
            //    {
            //        arr[0] = nums[i];
            //        arr[1] = nums[j];
            //        Console.WriteLine($"{arr[0]}, {arr[1]}");
            //        return arr;
            //    }
            //}

            return arr;
        }

        private int Bsearch(int[] nums, int v, int i, int target)
        {
            int L = i; 
            int R = nums.GetUpperBound(0);
            int M = 0;
            while (L < R)
            {
                M = (L + R) / 2;
                if (nums[M] < v)
                    L = M + 1;
                else
                    R = M;
            }
            return M;
        }

        private int[] AddToTarget(int[] nums, int target)
        {
            Hashtable values = new();
            for (int i = 0; i < nums.GetUpperBound(0); i++)
            {
                int x = nums[i];
                if (values.ContainsKey(target - i))
                {
                    return new int[] { target - x, i + 1 };
                }
                values.Add(x, i);
                Console.WriteLine($"{values.Values}");
            }
            return arr;
            //for (int i = 0; i < nums.GetUpperBound(0) - 1; i++)
            //{
            //    for (int j = i + 1; j < nums.GetUpperBound(0); j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            arr[0] = nums[i];
            //            arr[1] = nums[j];
            //            Console.WriteLine($"{arr[0]}, {arr[1]}");
            //            return arr;
            //        }
            //    }
            //}
            //Console.WriteLine($"{arr[0]}, {arr[1]}");
            //return arr;
        }

        public int PositiveInt(int[] nums)
        {
            for (int i = 0; i < nums.GetUpperBound(0); i++)
            {
                if (nums[i] >= 0)
                {
                    lst.Add(nums[i]);
                }
            }
            lst.Sort();
            if (lst.Count == 0)
            {
                Console.WriteLine(1);
                return 1;
            }
                
            foreach (int item in lst)
            {
                if (a + 1 < item)
                {
                    int b = a + 1;
                    Console.WriteLine(b);
                    return b;
                }
                a = item;
            }
            return 1;
        }
    }
}
