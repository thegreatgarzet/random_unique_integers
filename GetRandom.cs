using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class GetRandom{
    public static int[] RandomNumInRange(int int_array_size, int random_range){
        List<int> number_list = new List<int>();
        number_list.AddRange(Enumerable.Range(0,random_range));
        
        List<int> int_list = new List<int>();
        for (int x = 0; x < int_array_size; x++)
        {
            int remove_at = Random.Range(0, number_list.Count);
            int_list.Add(number_list[remove_at]);
            number_list.RemoveAt(remove_at);
        }
        return int_list.ToArray();
    }
}
