using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NameSorter
{

    public class Sorter
    {
        public Sorter(IEnumerable<string> fileContent)
        {
            if (fileContent != null)
            {
                this.fileContent = fileContent;

                foreach (var item in fileContent)
                {
                    this.Original.Add(item);
                }
                var reArranged = FormatList(Original);
                var SortedReOrdered = SortList(reArranged);
                this.Sorted = FormatList(SortedReOrdered);
            }
        }

        public List<string> Original { get; } = new List<string>();
        public List<string> Sorted { get; } = new List<string>();
        private IEnumerable<string> fileContent { get; }

        
        private List<string> FormatList(List<string> list)
        {
            List<string> reOrdered = new List<string>();
            foreach (var item in list)
            {
                var temp = nameClean(item);
                reOrdered.Add(reOrder(temp));
            }
            return reOrdered;
        }


        //Rearrange the order of the given name from last to first. eg 'a b c d' => 'd c b a'
        public string reOrder(string name)
        {
            string[] arr = name.Trim().Split(" ");
            Array.Reverse(arr, 0, arr.Length);
            string reJoined = string.Join(" ", arr);
            return reJoined;
        }

        
        //Remove Unnecessary whitespace
        public string nameClean(string name){
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            return regex.Replace(name, " ").Trim();
        }


        //Sort the list alphabetically
        public List<string> SortList(List<string> list)
        {
            list.Sort();
            return list;
        }
    }
}