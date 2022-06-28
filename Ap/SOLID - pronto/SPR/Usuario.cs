using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPR
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public bool EValido { get { return UsuarioValidacao.Validar(); } }
    }

    public static class ValidaCpf
    {
        public bool Validar(Usuario usuario)
        {
            if(CPF < 11)
                return false;
            else
                return true;
        }
    }
}