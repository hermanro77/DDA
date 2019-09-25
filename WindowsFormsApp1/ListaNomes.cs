using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    class ListaNomes : IListaNomes {
        private ArrayList names = new ArrayList();


        public void AddName(string name, object sender, EventArgs e) {
            if (!names.Contains(name)) {
                names.Add(name);
            }
        }

        public void EraseAll(object sender, EventArgs e) {
            names.Clear();
        }

        public string GetAllNames() {
            return string.Join(", ", names.ToArray());
        }
    }

    interface IListaNomes {
        void AddName(string name, object sender, EventArgs e);
        String GetAllNames();
        void EraseAll(object sender, EventArgs e);
    }
}
