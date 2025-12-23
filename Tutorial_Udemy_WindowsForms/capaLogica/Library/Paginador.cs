using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy_WindowsForms
{
    public class Paginador<T>
    {
        private List<T> dataList;
        private Label label;
        private int maxReg, reg_por_pagina, pageCount, numPagi = 1;

        public Paginador(List<T> dataList, Label label, int reg_por_pagina)
        {   
            this.dataList = dataList;
            this.label = label;
            this.reg_por_pagina = reg_por_pagina;
            cargarDatos();
        }
        public void cargarDatos()
        {
            numPagi = 1;
            maxReg = dataList.Count;
            pageCount = (maxReg / reg_por_pagina);
            if (maxReg % reg_por_pagina > 0)
            {
                pageCount++;
            }
            label.Text = $"paginas 1 / {pageCount}";
        }
        public int Primero()
        {
            numPagi = 1;
            label.Text = $"Paginas {numPagi}/{pageCount}";
            return numPagi;
        }
        public int Anterior()
        {
            if(numPagi > 1)
            {
                numPagi--;
                label.Text = $"Paginas {numPagi}/{pageCount}";
            }
            return numPagi;
        }
        public int Sigueinte()
        {
            if (numPagi == pageCount)
                numPagi--;
            if(numPagi < pageCount)
            {
                numPagi++;
                label.Text = $"Paginas {numPagi}/{pageCount}";
            }
            return numPagi;
        }
        public int Ultimo()
        {
            numPagi = pageCount;
            label.Text = $"Paginas {numPagi}/{pageCount}";
            return numPagi;
        }
    }
}
