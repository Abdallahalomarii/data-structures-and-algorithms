using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge28_SortingComparisons
{
    public class Movie
    {
        public string title { get; set; }
        public int year { get; set; }
        public List<string> genres { get; set; }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Movie other = (Movie)obj;
            return title == other.title && year == other.year;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(title, year);
        }


        public Movie[] SortArrayMoviesByYear(Movie[] unsorted)
        {
            if (unsorted.Length <= 1)
            {
                return unsorted;
            }

            int mid = unsorted.Length / 2;
            Movie[] left = new Movie[mid];
            Movie[] right = new Movie[unsorted.Length - mid];

            for (int i = 0; i < mid; i++)
                left[i] = unsorted[i];
            for (int i = 0; i < unsorted.Length - mid; i++)
            {
                right[i] = unsorted[i + mid];
            }

            left = SortArrayMoviesByYear(left);
            right = SortArrayMoviesByYear(right);
            Movie[] sorted = Merge(left, right, unsorted);

            return sorted;
        }

        private Movie[] Merge(Movie[] left, Movie[] right, Movie[] unsorted)
        {

            int leftIndex = 0, rightIndex = 0, resultIndex = 0;

            while (leftIndex < left.Length || rightIndex < right.Length)
            {
                if (leftIndex < left.Length && rightIndex < right.Length)
                {
                    if (left[leftIndex].year <= right[rightIndex].year)
                    {
                        unsorted[resultIndex++] = left[leftIndex++];
                    }

                    else
                    {
                        unsorted[resultIndex++] = right[rightIndex++];
                    }
                }

                else if (leftIndex < left.Length)
                {
                    unsorted[resultIndex++] = left[leftIndex++];
                }
                else if (rightIndex < right.Length)
                {
                    unsorted[resultIndex++] = right[rightIndex++];
                }
            }
            return unsorted;
        }

        public Movie[] SortArrayMoviesByTitle(Movie[] unsorted)
        {
            if (unsorted.Length <= 1)
            {
                return unsorted;
            }

            int mid = unsorted.Length / 2;
            Movie[] left = new Movie[mid];
            Movie[] right = new Movie[unsorted.Length - mid];

            for (int i = 0; i < mid; i++)
                left[i] = unsorted[i];
            for (int i = 0; i < unsorted.Length - mid; i++)
            {
                right[i] = unsorted[i + mid];
            }

            left = SortArrayMoviesByTitle(left);
            right = SortArrayMoviesByTitle(right);
            Movie[] sorted = MergeByTitle(left, right);

            return sorted;
        }

        private Movie[] MergeByTitle(Movie[] left, Movie[] right)
        {
            Movie[] result = new Movie[left.Length + right.Length];

            int leftIndex = 0, rightIndex = 0, resultIndex = 0;

            while (leftIndex < left.Length || rightIndex < right.Length)
            {
                if (leftIndex < left.Length && rightIndex < right.Length)
                {
                    string leftTitle = left[leftIndex].title.StartsWith("A ") ? left[leftIndex].title.Substring(2) :
                                       left[leftIndex].title.StartsWith("An ") ? left[leftIndex].title.Substring(3) :
                                       left[leftIndex].title.StartsWith("The ") ? left[leftIndex].title.Substring(4) :
                                       left[leftIndex].title;

                    string rightTitle = right[rightIndex].title.StartsWith("A ") ? right[rightIndex].title.Substring(2) :
                                        right[rightIndex].title.StartsWith("An ") ? right[rightIndex].title.Substring(3) :
                                        right[rightIndex].title.StartsWith("The ") ? right[rightIndex].title.Substring(4) :
                                        right[rightIndex].title;

                    if (leftTitle.CompareTo(rightTitle) <= 0)
                    {
                        result[resultIndex++] = left[leftIndex++];
                    }
                    else
                    {
                        result[resultIndex++] = right[rightIndex++];
                    }
                }
                else if (leftIndex < left.Length)
                {
                    result[resultIndex++] = left[leftIndex++];
                }
                else if (rightIndex < right.Length)
                {
                    result[resultIndex++] = right[rightIndex++];
                }
            }
            return result;
        }
    }
}
