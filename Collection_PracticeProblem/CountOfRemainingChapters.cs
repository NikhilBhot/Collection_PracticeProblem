using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_PracticeProblem
{
/*Count Of Remaining Chapters

1) Amelas reading a book of 'N' chapters. Each chapter contains at east 2 pages.
While she is reading the Kth page, her friend asked Amelia, how many chapters
she has yet to read including chapter she is currently reading.
Your task is to help Amelia find the number of chapters she has yet to read.
Given a number 'N' representing the number of chapters in a book, X,Y
representing the start and end pages of each chapter, K representing the current
reading page, and prints a single integer representing the number of chapters
Amelia has yet to read.
Note:
1) There might be empty pages before and after each chapter in the book.
2) The number of chapters yet to be read should include the chapter that is
currently reading.
For example, if the total chapters are 5, current reading chapters 2, then the
number of chapters yet to read is 4 (Chapter 2, Chapter 3, Chapter 4, Chapter 5.
Explanation
Input:
For example if N=4,
The Start and end page of each chapter is,
1 4
5 7
9 16
17 26
The current reading pages is K=7,
output:
3
     */
    public class CountOfRemainingChapters
    {
        public static void DemoMethod()
        {
            int N = 4; // Total number of chapters
            List<int[]> chapters = new List<int[]>
        {
            new int[] { 1, 4 },   // Chapter 1 start and end pages
            new int[] { 5, 7 },   // Chapter 2 start and end pages
            new int[] { 9, 16 },  // Chapter 3 start and end pages
            new int[] { 17, 26 }  // Chapter 4 start and end pages
        };
            int K = 7; // Current reading page

            int chaptersRemaining = CountRemainingChapters(N, chapters, K);
            Console.WriteLine("Chapters remaining: " + chaptersRemaining);
        }

        static int CountRemainingChapters(int N, List<int[]> chapters, int K)
        {
            int chaptersRemaining = 0;

            foreach (int[] chapter in chapters)
            {
                int startPage = chapter[0];
                int endPage = chapter[1];

                if (K >= startPage && K <= endPage)
                {
                    chaptersRemaining = N - chaptersRemaining;
                    break;
                }

                chaptersRemaining++;
            }

            return chaptersRemaining;
        }
    }
}
