using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E4882.Models {
    public class DataEntry {
        public int ID { get; set; }
        public string Text { get; set; }
    }
    public static class DataRepository {
        public static IEnumerable GetData() {
            return Enumerable.Range(0, 100).Select(i => new DataEntry { ID = i, Text = "Text " + i });
        }
    }
}