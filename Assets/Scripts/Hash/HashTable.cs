using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DSA.Scripts.Hash
{
    public class HashTable
    {
        #region Entry Helper Class

        private class Entry
        {
            #region Fields

            internal int Key;
            internal string Value;

            #endregion

            #region Constructor

            public Entry(int key, string value)
            {
                Key = key;
                Value = value;
            }

            #endregion
        }

        #endregion
        

        #region Fields

        private LinkedList<Entry>[] _entries;

        #endregion

        #region Constructor

        public HashTable(int capacity)
        {
            _entries = new LinkedList<Entry>[capacity];
        }

        #endregion

        #region Add

        public void Add(int key, string value)
        {
            Entry entry = GetEntry(key);
            if (entry is not null)
            {
                entry.Value = value;
                return;
            }

            GetOrCreateBucket(key).AddLast(new Entry(key, value));
        }

        #endregion

        #region GetValue

        public string GetValue(int key)
        {
            Entry entry = GetEntry(key);

            return (entry is null) ? null : entry.Value;
        }

        #endregion

        #region Remove

        public void Remove(int key)
        {
            Entry entry = GetEntry(key);

            if (entry is null)
            {
                throw new Exception("Illegal State Exception");
            }

            GetBucket(key).Remove(entry);
        }

        #endregion
        

        #region Hash

        private int Hash(int key)
        {
            return key % _entries.Length;
        }

        #endregion

        #region GetEntry

        private Entry GetEntry(int key)
        {
            LinkedList<Entry> bucket = GetBucket(key);

            if (bucket is not null)
            {
                foreach (Entry entry in bucket)
                {
                    if (entry.Key == key)
                    {
                        return entry;
                    }
                }
            }

            return null;
        }

        #endregion

        #region GetBucket

        private LinkedList<Entry> GetBucket(int key)
        {
            return _entries[Hash(key)];
        }

        #endregion

        #region GetOrCreateBucket

        private LinkedList<Entry> GetOrCreateBucket(int key)
        {
            int index = Hash(key);
            LinkedList<Entry> bucket = _entries[index];

            if (bucket is null)
            {
                _entries[index] = new LinkedList<Entry>();
            }

            return bucket;
        }

        #endregion
    }
}
