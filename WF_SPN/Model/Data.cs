using Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Data
    {
        private Cypher cyfer;

        public Data() 
        {
            this.cyfer = new Cypher();
        }

        public Cypher Cyfer { get => cyfer; set => cyfer = value; }

        public DataTable ViewPBox()
        {
            DataTable dt = new DataTable();

            foreach (var k in this.cyfer.PBox)
            {
                dt.Columns.Add(k.Key.ToString(), typeof(int));
            }

            DataRow dr = dt.NewRow();

            for (int i = 0; i < this.cyfer.PBox.Count; i++)
            {
                dr[i] = cyfer.PBox[i];
            }

            dt.Rows.Add(dr);

            return dt;
        }


        public DataTable ViewSBox()
        {
            DataTable dt = new DataTable();

            foreach (var k in this.cyfer.SBox)
            {
                dt.Columns.Add(k.Key.ToString(), typeof(int));
            }

            DataRow dr = dt.NewRow();

            for (int i = 0; i < this.cyfer.SBox.Count; i++)
            {
                dr[i] = cyfer.SBox[i];
            }

            dt.Rows.Add(dr);

            return dt;
        }
    }
}
