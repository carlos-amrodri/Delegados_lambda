using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados_lambda
{
    public class CalculadoQ
    {
        private List<int> _lista;

        public CalculadoQ(List<int> lista)
        {
            _lista = lista;
        }

        public int suma()
        {
            int result = 0;
            foreach(int num in _lista)
            {
                result += num;
            }
            return result;
        }

        public List<int> pares()
        {
            var par = new List<int>();
            foreach(int num in _lista)
            {
                if(num % 2 == 0)
                {
                    par.Add(num);
                }
            }
            return par;
        }


        //Lo mismo pero con linQ
        public int sumaQ()
        {
            return _lista.Sum();
        }

        public List<int> paesQ()
        {
            var pares = _lista.Where(x => x % 2 == 0).ToList();
            return pares;
        }

    }
}
