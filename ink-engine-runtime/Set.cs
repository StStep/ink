﻿using System.Collections.Generic;

namespace Ink.Runtime
{
    internal class Set
    {
        public string name { get { return _name; } }

        public Dictionary<string, int> items {
            get {
                return _items;
            }
        }

        public int ValueForItem (string itemName)
        {
            int intVal;
            if (_items.TryGetValue (itemName, out intVal))
                return intVal;
            else
                return 0;
        }

        public bool TryGetValueForItem (string itemName, out int val)
        {
            return _items.TryGetValue (itemName, out val);
        }

        public bool TryGetItemWithValue (int val, out string itemName)
        {
            itemName = null;

            foreach (var namedItem in _items) {
                if (namedItem.Value == val) {
                    itemName = namedItem.Key;
                    return true;
                }
            }

            return false;
        }

        public Set (string name, Dictionary<string, int> items)
        {
            _name = name;
            _items = items;
        }

        string _name;
        Dictionary<string, int> _items;
    }
}