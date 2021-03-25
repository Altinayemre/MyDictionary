using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;
        K[] tempArrayk;
        V[] tempArrayv;
        

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];          
        }
        
        public void Add(K key, V value)
        {           
            tempArrayk = keys;
            keys = new K[keys.Length + 1];

            for (int i = 0; i < tempArrayk.Length; i++)
            {
                keys[i] = tempArrayk[i];
            }

            tempArrayv = values;
            values = new V[values.Length + 1];

            for (int i = 0; i < tempArrayv.Length; i++)
            {
                values[i] = tempArrayv[i];
            }

            values[values.Length - 1] = value;
            keys[keys.Length - 1] = key;
        }

        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Plaka No: "+keys[i]+" -- "+"Şehir: "+values[i]);
            }
        }

        public int Count
        {
            get { return keys.Length; } 
        }
    }
}
