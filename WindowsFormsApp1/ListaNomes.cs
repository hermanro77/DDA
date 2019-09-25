using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    class ListaNomes : IListaNomes {
        private ArrayList names = new ArrayList();


        public void AddName(string name) {
            if (!names.Contains(name)) {
                names.Add(name);
            }
        }

        public void EraseAll() {
            names.Clear();
        }

        public string GetAllNames() {
            return string.Join(", ", names.ToArray());
        }
    }

    interface IListaNomes {
        void AddName(string name);
        String GetAllNames();
        void EraseAll();
    }
}
